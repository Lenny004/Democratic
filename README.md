# Democratic — Plantilla genérica de votación

Aplicación de escritorio **WinForms (.NET Framework 4.5.2)** con base de datos **MySQL 8** para gestionar procesos de votación configurables: organización del evento, sedes, mesas, grupos de opciones, emisión de votos, escrutinio y **gráficas de resultados**.

> Plantilla genérica reutilizable. El esquema físico usa tablas `tb_*` con nombres de dominio actual (organización, grupo, opción, sede, mesa, etc.).

---

## Características

- **Votación configurable:** grupos de opciones y opciones ilimitadas.
- **Padrón de participantes** con autenticación por usuario/contraseña o DUI + OCR.
- **Roles y permisos:** superadministrador, administrador, operador de mesa, representante de grupo, votante.
- **Escrutinio:** registros por mesa y detalle por grupo.
- **Gráficas en tiempo real** (`FrmGraficos`).
- **Modo oscuro** e idiomas español / inglés (paleta centralizada en `Democratic/UiTheme.cs`).
- **Configuración inicial** sin correo SMTP: organización + superadministrador local.
- **Sitio web complementario:** `Pagina Democratic 2020 Full/`.

---

## Arquitectura

| Proyecto | Carpeta | Responsabilidad |
|----------|---------|-----------------|
| **Vista** | `Democratic/` | Formularios WinForms |
| **Controlador** | `Controlador/` | Lógica de presentación |
| **Modelo** | `Modelo/` | Acceso a datos MySQL |

```
Vista → Controlador → Modelo → MySQL (dbdemocratic)
```

---

## Requisitos

- Windows con **.NET Framework 4.5.2+**
- **Visual Studio 2015+**
- **MySQL 8.x** (utf8mb4)
- Base de datos: `dbdemocratic`

### Conexión MySQL (`.env`)

Copia `.env.example` a `.env` en la raíz de `Democratic/`:

```env
DB_HOST=127.0.0.1
DB_PORT=3306
DB_DATABASE=dbdemocratic
DB_USERNAME=root
DB_PASSWORD=tu_clave
DB_CHARSET=utf8mb4
```

`Modelo/Conexion.cs` lee estas variables al iniciar la app (busca `.env` desde `bin/Debug` hacia arriba). El archivo `.env` no se sube al repositorio.

---

## Base de datos

### Crear esquema genérico

```bash
"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe" -u root -p < sql/schema_generico_mysql8.sql
```

Crea tablas como `tb_organizacion`, `tb_grupo_opciones`, `tb_opcion`, `tb_sede`, `tb_mesa`, `tb_voto`, `tb_participante`, `tb_usuario`, catálogos de estado y roles semilla.

Documentación del dominio: **[docs/DOMINIO-VOTACION.md](docs/DOMINIO-VOTACION.md)**

---

## Compilación y ejecución

1. Ejecutar el script SQL anterior.
2. Abrir `Democratic.sln` en Visual Studio.
3. Proyecto de inicio: **Vista**.
4. Compilar y ejecutar.
5. Primer arranque: registrar **organización** (`FrmPrimerUso`) y **superadministrador** (`FrmPrimerUsuario`) si la base está vacía. No se solicita cuenta de correo en el primer uso; registro público y recuperación por email están deshabilitados.

---

## Estructura del repositorio

```
Democratic/
├── Democratic/          # Vista (WinForms)
├── Controlador/
├── Modelo/
├── docs/DOMINIO-VOTACION.md
├── sql/schema_generico_mysql8.sql
├── Democratic.sln
└── README.md
```
