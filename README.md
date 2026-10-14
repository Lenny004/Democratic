<!-- readme-standard:v1 -->
<!-- section:header -->
# Democratic

Aplicación WinForms para configurar procesos de votación y registrar sus resultados.

<!-- section:toc -->
## 📑 Contenido

- [Aspectos destacados](#-aspectos-destacados)
- [Descripción](#ℹ️-descripción)
- [Requisitos](#📋-requisitos)
- [Instalación](#⬇️-instalación)
- [Uso](#🚀-uso)
- [Configuración](#⚙️-configuración)
- [Estructura](#🗂️-estructura-del-proyecto)
- [Desarrollo](#🛠️-desarrollo)
- [Soporte y contribuciones](#💭-soporte-y-contribuciones)
- [Licencia](#📄-licencia)

<!-- section:highlights -->
## 🌟 Aspectos destacados

- **Votación configurable**: administra grupos y opciones con IDs reales de la base de datos.
- **Autenticación segura**: PBKDF2 con sal y migración automática de claves legadas.
- **Integridad del voto**: boleta y voto se registran en una sola transacción MySQL.
- **Gestión electoral**: incluye participantes, sedes, mesas, usuarios y escrutinio.

<!-- section:overview -->
## ℹ️ Descripción

Democratic es una aplicación de escritorio para organizar un proceso de votación, administrar su padrón y registrar votos por grupo de opciones. La separación Vista–Controlador–Modelo mantiene los formularios, la lógica y el acceso a MySQL diferenciados.

**Stack:** C# WinForms, .NET Framework 4.8, MySQL 8 y MySql.Data.

<!-- section:requirements -->
## 📋 Requisitos

- Windows con .NET Framework 4.8.
- Visual Studio 2019 o posterior con las herramientas de escritorio .NET.
- MySQL 8.x y una base creada con `sql/schema_generico_mysql8.sql`.

<!-- section:installation -->
## ⬇️ Instalación

1. Copia `.env.example` a `.env` y completa la conexión local.
2. Ejecuta `sql/schema_generico_mysql8.sql` en MySQL.
3. Abre `Democratic.sln` en Visual Studio.
4. Compila y ejecuta el proyecto `Vista`.

<!-- section:usage -->
## 🚀 Uso

En el primer arranque registra la organización y el superadministrador. Después configura sedes, mesas, grupos y opciones; finalmente inicia sesión para emitir votos y consultar resultados.

<!-- section:configuration -->
## ⚙️ Configuración

**`.env`**

| Variable | Descripción | Ejemplo | Requerida |
|---|---|---|---|
| `DB_HOST` | Host de MySQL | `127.0.0.1` | Sí |
| `DB_PORT` | Puerto de MySQL | `3306` | Sí |
| `DB_DATABASE` | Base de datos | `dbdemocratic` | Sí |
| `DB_USERNAME` | Usuario de MySQL | `root` | Sí |
| `DB_PASSWORD` | Contraseña de MySQL | `TU_CLAVE_LOCAL` | Sí |
| `DB_CHARSET` | Codificación de conexión | `utf8mb4` | Sí |

<!-- section:structure -->
## 🗂️ Estructura del proyecto

```text
.
├── Democratic/       # Formularios y recursos WinForms
├── Controlador/      # Coordinación de la interfaz y el modelo
├── Modelo/           # Conexión, consultas y seguridad de datos
├── sql/              # Esquema inicial de MySQL
├── docs/             # Documentación del dominio
└── Democratic.sln    # Solución de Visual Studio
```

<!-- section:development -->
## 🛠️ Desarrollo

```powershell
msbuild Democratic.sln /t:Build /p:Configuration=Debug
```

La DLL de MySQL y Bunifu se resuelven desde `lib/`, mediante rutas relativas al repositorio.

<!-- section:contributing -->
## 💭 Soporte y contribuciones

Reporta errores describiendo pasos para reproducirlos, versión de Windows, versión de MySQL y mensajes relevantes. Las contribuciones deben mantener consultas parametrizadas y conexiones dentro de `using`.

<!-- section:license -->
## 📄 Licencia

TODO(readme): indicar la licencia del proyecto.

