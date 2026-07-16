# Dominio de votación genérica — Democratic

Este documento describe el **modelo conceptual** del sistema Democratic como **plantilla genérica de votación**, independiente de elecciones presidenciales o de partidos políticos. Las tablas físicas en MySQL conservan nombres **legacy** por compatibilidad con la aplicación WinForms existente; el significado actual se interpreta mediante el mapeo siguiente.

> **Principio:** no renombrar tablas ni columnas en producción. La capa de compatibilidad SQL (`sql/compat_vistas_genericas.sql`) expone vistas con nombres genéricos sin alterar el esquema legacy.

---

## Visión general

Democratic gestiona un proceso electoral configurable:

1. Una **Organización** define el contexto del evento (nombre, sede, jurisdicción, imagen).
2. Los **Grupos de opciones** agrupan candidaturas o alternativas (equipos, listas, bloques).
3. Las **Opciones** son las elecciones concretas que el votante puede elegir.
4. Los **Participantes** (padrón) se asignan a **Sedes** y **Mesas**.
5. Cada emisión genera una **Boleta** en una **Mesa** y uno o más **Votos** asociados a un grupo.
6. El **Escrutinio** consolida resultados por mesa en **Registros de escrutinio** y su detalle.

```
Organización (tbtribunal)
    └── Sedes (tbcentro_de_votación)
            └── Mesas (tbjrv)
                    ├── Boletas (tbboleta)
                    │       └── Votos (tbvoto) → Grupo de opciones
                    └── Registros de escrutinio (tbacta)
                            └── Detalle por grupo (tbdetalle_acta)

Grupos de opciones (tbpartido_politico)
    └── Opciones (tbcandidato)
```

---

## Mapeo tabla legacy → concepto genérico

| Concepto genérico | Tabla legacy | Descripción |
|-------------------|--------------|-------------|
| **Organización** | `tbtribunal` | Entidad que organiza el proceso de votación (antes “tribunal electoral”). Almacena datos institucionales: fundación, composición, país, tipo, jurisdicción, sede, contacto e imagen. |
| **Grupo de opciones** | `tbpartido_politico` | Conjunto al que pertenecen una o más opciones (antes “partido político”). Incluye nombre, imagen, contador de votos y estado. |
| **Opción** | `tbcandidato` | Alternativa votable concreta (antes “candidato”). Pertenece a un grupo (`id_Partido`). Puede representar persona, propuesta, lista o cualquier ítem de balota. |
| **Boleta** | `tbboleta` | Registro de una emisión de voto en una mesa: fecha, estado y mesa (`id_JRV`). |
| **Voto** | `tbvoto` | Selección registrada, ligada a boleta, grupo (`id_Partido`), estado, fecha y hora. La app puede resolver el grupo a partir de la opción elegida (`tbcandidato`). |
| **Mesa** | `tbjrv` | Punto de recepción de votos (antes “JRV”). Identificada por correlativo y asociada a una sede. |
| **Sede** | `tbcentro_de_votación` | Lugar físico o lógico del proceso (antes “centro de votación”). Agrupa mesas y participantes. |
| **Registro de escrutinio** | `tbacta` | Acta de cierre de mesa: cantidad de boletas y mesa asociada. |
| **Detalle de escrutinio** | `tbdetalle_acta` | Desglose de votos por grupo dentro de un registro de escrutinio. |

### Tablas de soporte (sin cambio de nombre)

| Concepto | Tabla legacy | Uso |
|----------|--------------|-----|
| Participante / padrón | `tbmiembros` | Personas habilitadas para votar (DUI, OCR, sede, mesa). |
| Usuario del sistema | `tbusuario` | Cuentas de acceso vinculadas a un participante y un rol. |
| Rol | `tbtipo_usuario` | Tipo de usuario y nivel de permisos (`id_Tipo_Usuario`). |
| Estado de usuario | `tbestado_usuario` | Activo, bloqueado, etc. |
| Municipio | `tbmunicipio` | Ubicación geográfica de sedes. |
| Estados (catálogos) | `tbestado_*` | Estados de opción, grupo, mesa, sede, boleta, voto, miembro. |

---

## Columnas clave y alias genéricos

### Organización — `tbtribunal`

| Columna legacy | Alias genérico | Notas |
|----------------|----------------|-------|
| `id_Tribunal` | `id_organizacion` | PK |
| `Fundación` | `fecha_fundacion` | Texto libre |
| `Composición` | `descripcion` | |
| `Imagen_Tribunal` | `imagen` | Base64 |
| `Pais` | `pais` | |
| `Tipo` | `tipo_organizacion` | |
| `Jurisdicción` | `jurisdiccion` | |
| `Sede` | `sede_principal` | |
| `Correo_electronicoTribunal` | `correo` | |
| `Contra_Tribunal` | `contrasena_contacto` | |

### Grupo de opciones — `tbpartido_politico`

| Columna legacy | Alias genérico |
|----------------|----------------|
| `id_Partido` | `id_grupo_opciones` |
| `Nombre_Partido` | `nombre_grupo` |
| `Imagen_Partido` | `imagen` |
| `Cantidad_Votos` | `total_votos` |
| `id_Estado_Partido` | `id_estado_grupo` |

### Opción — `tbcandidato`

| Columna legacy | Alias genérico |
|----------------|----------------|
| `id_Candidato` | `id_opcion` |
| `Nombre_Candidato` | `nombre` |
| `Apellido_Candidato` | `apellido` |
| `Género` | `genero` |
| `Imagen_Candidato` | `imagen` |
| `id_Partido` | `id_grupo_opciones` |
| `id_Estado_Candidato` | `id_estado_opcion` |

### Boleta — `tbboleta`

| Columna legacy | Alias genérico |
|----------------|----------------|
| `id_Boleta` | `id_boleta` |
| `Fecha_Votación` | `fecha_votacion` |
| `id_Estado_Boleta` | `id_estado_boleta` |
| `id_JRV` | `id_mesa` |

### Voto — `tbvoto`

| Columna legacy | Alias genérico |
|----------------|----------------|
| `id_Voto` | `id_voto` |
| `id_Partido` | `id_grupo_opciones` |
| `id_Boleta` | `id_boleta` |
| `id_Estado_Voto` | `id_estado_voto` |
| `Fecha_Votación` | `fecha_votacion` |
| `Hora_Votacion` | `hora_votacion` |

> En el dominio genérico, `id_Partido` en `tbvoto` significa **grupo de opciones elegido**, no partido político obligatoriamente.

### Mesa — `tbjrv`

| Columna legacy | Alias genérico |
|----------------|----------------|
| `id_JRV` | `id_mesa` |
| `Correlativo_JRV` | `codigo_mesa` |
| `id_Centro_Votación` | `id_sede` |
| `id_Estado_JRV` | `id_estado_mesa` |

### Sede — `tbcentro_de_votación`

| Columna legacy | Alias genérico |
|----------------|----------------|
| `id_Centro_Votación` | `id_sede` |
| `Nombre_Centro_Votación` | `nombre_sede` |
| `id_Acta` | `id_registro_escrutinio` |
| `Cantidad_de_JRV` | `cantidad_mesas` |
| `id_Estado_CentroVotación` | `id_estado_sede` |
| `id_Municipio` | `id_municipio` |
| `id_Tribunal` | `id_organizacion` |

### Registro de escrutinio — `tbacta`

| Columna legacy | Alias genérico |
|----------------|----------------|
| `id_Acta` | `id_registro_escrutinio` |
| `Cantidad_Boletas` | `cantidad_boletas` |
| `id_JRV` | `id_mesa` |

### Detalle de escrutinio — `tbdetalle_acta`

| Columna legacy | Alias genérico |
|----------------|----------------|
| `id_Detalle_Acta` | `id_detalle_escrutinio` |
| `Cantidad_Votos` | `cantidad_votos` |
| `id_Acta` | `id_registro_escrutinio` |
| `id_Partido` | `id_grupo_opciones` |

---

## Roles genéricos

Los permisos se definen en `tbtipo_usuario`. El campo `id_Tipo_Usuario` se usa en la sesión como **nivel** (`VarSession.nivelU`) para mostrar u ocultar menús en `FrmContenedor`.

| Nivel (`id_Tipo_Usuario`) | Rol legacy (UI) | Rol genérico | Acceso resumido |
|---------------------------|-----------------|--------------|-----------------|
| 1 | Root | **Superadministrador** | Configuración completa: organización, sedes, mesas, grupos, opciones, usuarios, escrutinio, reportes. |
| 2 | Votante | **Votante** | Ver opciones, emitir voto, ver estadísticas/gráficas. |
| 3 | Candidato a Presidencia | **Opción principal** | Igual que votante; rol asociado a una opción destacada del proceso. |
| 4 | Candidato a VicePresidencia | **Opción secundaria** | Igual que votante; segunda categoría de opción. |
| 5 | Partido | **Representante de grupo** | Ver opciones y estadísticas de su grupo; sin emitir voto. |
| 6 | Miembro de JRV | **Operador de mesa** | Gestión de actas, sedes/mesas asignadas, registro de votos en mesa. |
| 7 | Administrador | **Administrador** | Usuarios, grupos, opciones, estructura; sin todos los módulos de Root. |

Los textos de bienvenida en la UI pueden seguir mostrando etiquetas legacy (“Candidato a Presidencia”, “Partido”, etc.) hasta que se actualicen los recursos de idioma. **Semánticamente**, el sistema ya no asume elección presidencial: esos roles son plantillas de permisos reutilizables.

### Autenticación

- **Usuario/contraseña:** `tbusuario` + `tbmiembros` + `tbtipo_usuario`.
- **DUI + OCR:** acceso directo del participante desde el padrón (`tbmiembros`), sin rol administrativo.

---

## Flujo de voto (dominio genérico)

1. El votante autenticado elige una **Opción** (`tbcandidato`).
2. Se registra una **Boleta** en su **Mesa** (`tbboleta` + `id_JRV`).
3. Se registra el **Voto** resolviendo el **Grupo de opciones** de la opción (`tbvoto.id_Partido` ← `tbcandidato.id_Partido`).
4. Las **gráficas** (`FrmGraficos`, `ModelResultados`) agregan votos por grupo (`Nombre_Partido` / `nombre_grupo`).

---

## Ya no es plantilla de presidentes

El sistema nació como demo de elecciones presidenciales (9 candidatos fijos, partidos políticos, JRV, tribunal). La evolución a **plantilla genérica** implica:

| Antes (legacy) | Ahora (genérico) |
|----------------|------------------|
| Tribunal electoral | Organización |
| Partido político | Grupo de opciones |
| Candidato presidencial / vicepresidencial | Opción (cualquier categoría) |
| Centro de votación | Sede |
| JRV | Mesa |
| Acta electoral | Registro de escrutinio |
| Roles “Presidente / Vice / Partido” | Roles configurables por `tbtipo_usuario` |

**Qué permanece igual:** nombres de tablas y columnas en MySQL, formularios WinForms y consultas SQL del código C# existente.

**Qué cambia conceptualmente:** la interpretación de datos y la documentación; las vistas SQL opcionales; y la capacidad de reutilizar el mismo esquema para encuestas, elecciones internas, referéndums o simulacros sin migrar la base.

---

## Uso de las vistas de compatibilidad

Ejecutar en MySQL (base `dbdemocratic`):

```bash
mysql -u root -p dbdemocratic < sql/compat_vistas_genericas.sql
```

Consultas de ejemplo:

```sql
-- Opciones activas con su grupo
SELECT o.id_opcion, o.nombre, o.apellido, g.nombre_grupo
FROM vw_opciones o
JOIN vw_grupos_opciones g ON g.id_grupo_opciones = o.id_grupo_opciones;

-- Resultados por grupo (equivalente a gráficas)
SELECT nombre_grupo, COUNT(*) AS total
FROM vw_votos v
JOIN vw_grupos_opciones g ON g.id_grupo_opciones = v.id_grupo_opciones
GROUP BY nombre_grupo;
```

La aplicación WinForms **sigue usando las tablas legacy** directamente. Las vistas sirven para reportes externos, BI, migraciones futuras y documentación viva del dominio.

---

## Referencias en código

| Área | Ubicación |
|------|-----------|
| Conexión MySQL | `Modelo/Conexion.cs` → `dbdemocratic` |
| Voto y boleta | `Modelo/ModelVoto.cs` |
| Resultados / gráficas | `Modelo/ModelResultados.cs`, `Democratic/FrmGraficos.cs` |
| Opciones | `Modelo/ModelCandidato.cs`, `Modelo/ModelVer.cs` |
| Grupos | `Modelo/ModelPartido.cs` |
| Escrutinio | `Modelo/ModelActas.cs`, `Modelo/ModelDetalleActa.cs` |
| Sedes y mesas | `Modelo/ModelCV.cs`, `Modelo/ModelJRV.cs` |
| Roles y sesión | `Democratic/FrmLogin.cs`, `Democratic/FrmContenedor.cs` |
