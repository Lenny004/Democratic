# Democratic — Plantilla genérica de votación

Aplicación de escritorio **WinForms (.NET Framework 4.5.2)** con base de datos **MySQL** para gestionar procesos de votación configurables: organización del evento, sedes, mesas, grupos de opciones, emisión de votos, escrutinio y **gráficas de resultados**.

> **No es una plantilla fija de elección presidencial.** El esquema conserva nombres legacy (`tbcandidato`, `tbpartido_politico`, `tbjrv`, etc.) por compatibilidad, pero el dominio actual es genérico: organización, grupos, opciones, mesas y sedes. Ver [docs/DOMINIO-VOTACION.md](docs/DOMINIO-VOTACION.md).

---

## Características

- **Votación configurable:** grupos de opciones y opciones ilimitadas (personas, listas, propuestas).
- **Padrón de participantes** con autenticación por usuario/contraseña o DUI + OCR.
- **Roles y permisos:** superadministrador, administrador, operador de mesa, representante de grupo, votante.
- **Escrutinio:** registros por mesa y detalle por grupo.
- **Gráficas en tiempo real:** barras y tortas con `System.Windows.Forms.DataVisualization.Charting` (`FrmGraficos`).
- **Modo oscuro** e idiomas español / inglés.
- **Sitio web complementario:** carpeta hermana `Pagina Democratic 2020 Full/` (HTML/CSS/JS estático).

---

## Arquitectura

Solución en tres capas (`Democratic.sln`):

| Proyecto | Carpeta | Responsabilidad |
|----------|---------|-----------------|
| **Vista** | `Democratic/` | Formularios WinForms, recursos, idiomas |
| **Controlador** | `Controlador/` | Lógica de presentación y coordinación |
| **Modelo** | `Modelo/` | Acceso a datos MySQL (`MySql.Data`) |

```
Vista (Frm*)  →  Controlador (*Controller)  →  Modelo (Model*)  →  MySQL (dbdemocratic)
```

### Formularios principales

| Formulario | Función |
|------------|---------|
| `FrmLogin` / `FrmLogin2` | Autenticación |
| `FrmContenedor` | Menú según rol |
| `FrmVotar` | Emisión de voto |
| `FrmGraficos` | Gráficas de resultados por grupo |
| `FrmPartidos` / `FrmVerCandidatos` | Grupos y opciones |
| `FrmCV` / `FrmJRV` | Sedes y mesas |
| `FrmActas` / `FrmDetalleActa` | Escrutinio |
| `FrmMiembros` / `FrmUsuarios` | Padrón y cuentas |

---

## Requisitos

- Windows con **.NET Framework 4.5.2** o superior
- **Visual Studio 2015+** (recomendado para compilar)
- **MySQL 5.7+** o **MariaDB 10.x**
- Base de datos: `dbdemocratic` (ver `Modelo/Conexion.cs`)

### Conexión por defecto

```csharp
server   = 127.0.0.1
database = dbdemocratic
user     = root
password = (vacío)
```

Ajustar en `Modelo/Conexion.cs` según el entorno local.

---

## Base de datos

### Tablas legacy (sin renombrar)

El código C# consulta directamente tablas como `tbcandidato`, `tbpartido_politico`, `tbvoto`, `tbboleta`, `tbjrv`, `tbcentro_de_votación`, `tbacta`, `tbtribunal`.

### Vistas genéricas opcionales

Para reportes SQL, BI o documentación sin tocar el esquema físico:

```bash
mysql -u root -p dbdemocratic < sql/compat_vistas_genericas.sql
```

Crea vistas como `vw_opciones`, `vw_grupos_opciones`, `vw_votos`, `vw_mesas`, `vw_sedes`, `vw_resultados_por_grupo`, etc.

Documentación del mapeo completo: **[docs/DOMINIO-VOTACION.md](docs/DOMINIO-VOTACION.md)**

---

## Compilación y ejecución

1. Clonar o abrir la carpeta `Democratic/`.
2. Restaurar paquetes NuGet si aplica (`MySql.Data` en el proyecto Modelo).
3. Abrir `Democratic.sln` en Visual Studio.
4. Establecer proyecto de inicio: **Vista** (`Democratic`).
5. Compilar (F6) y ejecutar (F5).
6. En el primer arranque, registrar la **organización** (`FrmPrimerUso`) y el **usuario root** (`FrmPrimerUsuario`) si la base está vacía.

---

## Gráficas de resultados

`FrmGraficos` y `ModelResultados` agregan votos por **grupo de opciones**:

```sql
SELECT nombre_grupo, COUNT(*) AS total
FROM vw_resultados_por_grupo;
```

La UI muestra tres controles `Chart` con la misma agregación (variantes visuales). Los datos provienen de `tbvoto` unido a `tbpartido_politico`.

---

## Roles (resumen)

| Nivel | Rol genérico | Capacidades típicas |
|-------|--------------|---------------------|
| 1 | Superadministrador | Todo el sistema |
| 7 | Administrador | Usuarios, grupos, opciones |
| 6 | Operador de mesa | Actas, mesas, votos |
| 5 | Representante de grupo | Estadísticas de su grupo |
| 2–4 | Votante / opción | Votar y ver resultados |

Detalle en [docs/DOMINIO-VOTACION.md#roles-genéricos](docs/DOMINIO-VOTACION.md#roles-genéricos).

---

## Estructura del repositorio

```
Democratic/
├── Democratic/          # Vista (WinForms)
├── Controlador/         # Controladores
├── Modelo/              # Acceso a datos
├── docs/
│   └── DOMINIO-VOTACION.md
├── sql/
│   └── compat_vistas_genericas.sql
├── Democratic.sln
└── README.md
```

---

## Licencia y origen

Proyecto académico / demo evolucionado a plantilla reutilizable. Los nombres de tablas reflejan el dominio electoral original; la documentación y vistas SQL expresan el **modelo genérico** actual sin exigir migración de datos.
