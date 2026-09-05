# Dominio de votación genérica — Democratic

Modelo conceptual y esquema físico **genérico** para procesos de votación configurables. La aplicación WinForms y MySQL usan tablas `tb_*` con nombres de dominio actuales.

---

## Visión general

1. **Organización** (`tb_organizacion`) — contexto del evento.
2. **Grupos de opciones** (`tb_grupo_opciones`) — agrupación de alternativas.
3. **Opciones** (`tb_opcion`) — ítems votables.
4. **Participantes** (`tb_participante`) — padrón asignado a sedes y mesas.
5. **Boletas** (`tb_boleta`) y **votos** (`tb_voto`) — emisión y registro.
6. **Escrutinio** (`tb_registro_escrutinio`, `tb_detalle_escrutinio`) — cierre por mesa.

```
tb_organizacion
    └── tb_sede
            └── tb_mesa
                    ├── tb_boleta → tb_voto → tb_grupo_opciones
                    └── tb_registro_escrutinio → tb_detalle_escrutinio

tb_grupo_opciones
    └── tb_opcion
```

---

## Tablas principales

| Concepto | Tabla | PK |
|----------|-------|-----|
| Organización | `tb_organizacion` | `id_organizacion` |
| Grupo de opciones | `tb_grupo_opciones` | `id_grupo_opciones` |
| Opción | `tb_opcion` | `id_opcion` |
| Boleta | `tb_boleta` | `id_boleta` |
| Voto | `tb_voto` | `id_voto` |
| Mesa | `tb_mesa` | `id_mesa` |
| Sede | `tb_sede` | `id_sede` |
| Registro escrutinio | `tb_registro_escrutinio` | `id_registro_escrutinio` |
| Detalle escrutinio | `tb_detalle_escrutinio` | `id_detalle_escrutinio` |
| Participante | `tb_participante` | `id_participante` |
| Usuario | `tb_usuario` | `id_usuario` |
| Rol | `tb_rol` | `id_rol` |

### Catálogos

`tb_estado_grupo`, `tb_estado_opcion`, `tb_estado_sede`, `tb_estado_mesa`, `tb_estado_boleta`, `tb_estado_voto`, `tb_estado_participante`, `tb_estado_usuario`, `tb_municipio`, `tb_detalle_participante`.

---

## Columnas clave

### `tb_organizacion`

| Columna | Descripción |
|---------|-------------|
| `fecha_fundacion` | Texto libre |
| `descripcion` | Composición / descripción |
| `imagen` | Logo (Base64) |
| `tipo_organizacion`, `jurisdiccion`, `sede_principal` | Metadatos |
| `correo`, `contrasena_contacto` | Contacto |

### `tb_grupo_opciones`

| Columna | Descripción |
|---------|-------------|
| `nombre_grupo` | Nombre del grupo |
| `total_votos` | Contador |
| `id_estado_grupo` | FK estado |

### `tb_opcion`

| Columna | Descripción |
|---------|-------------|
| `nombre`, `apellido`, `genero` | Datos de la opción |
| `id_grupo_opciones` | FK grupo |
| `id_estado_opcion` | FK estado |

### `tb_voto`

| Columna | Descripción |
|---------|-------------|
| `id_grupo_opciones` | Grupo elegido |
| `id_boleta` | Boleta asociada |
| `fecha_votacion`, `hora_votacion` | Registro temporal |

---

## Roles (`tb_rol`)

| id_rol | Rol |
|--------|-----|
| 1 | Superadministrador |
| 2 | Votante |
| 3 | Supervisor |
| 4 | Auditor |
| 5 | Representante de grupo |
| 6 | Operador de mesa |
| 7 | Administrador |

Sesión: `VarSession.Roles` y `VarSession.nivelU` en `FrmContenedor`.

---

## Flujo de voto

1. Votante elige **opción** (`tb_opcion`).
2. Se crea **boleta** en su **mesa** (`tb_boleta`).
3. Se registra **voto** con el **grupo** de la opción (`tb_voto.id_grupo_opciones`).
4. **Gráficas** (`ModelResultados`) agregan por `nombre_grupo`.

---

## Instalación de la base de datos

MySQL 8.x, utf8mb4:

```bash
mysql -u root -p < sql/schema_generico_mysql8.sql
```

Consultas de ejemplo:

```sql
SELECT o.id_opcion, o.nombre, g.nombre_grupo
FROM tb_opcion o
JOIN tb_grupo_opciones g ON g.id_grupo_opciones = o.id_grupo_opciones;

SELECT g.nombre_grupo, COUNT(v.id_voto) AS total
FROM tb_voto v
JOIN tb_grupo_opciones g ON g.id_grupo_opciones = v.id_grupo_opciones
GROUP BY g.id_grupo_opciones, g.nombre_grupo;
```

---

## Referencias en código

| Área | Ubicación |
|------|-----------|
| Conexión | `Modelo/Conexion.cs` |
| Voto / boleta | `Modelo/ModelVoto.cs` |
| Resultados | `Modelo/ModelResultados.cs`, `FrmGraficos.cs` |
| Opciones | `Modelo/ModelCandidato.cs` |
| Grupos | `Modelo/ModelPartido.cs` |
| Organización | `Modelo/ModelTribunal.cs` |
| Escrutinio | `Modelo/ModelActas.cs`, `Modelo/ModelDetalleActa.cs` |
| Sedes / mesas | `Modelo/ModelCV.cs`, `Modelo/ModelJRV.cs` |
| Roles / sesión | `FrmLogin.cs`, `FrmContenedor.cs`, `Controlador/VarSession.cs` |
