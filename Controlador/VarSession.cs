using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    /// <summary>
    /// Coordina el estado de sesión del usuario autenticado entre la Vista y el Modelo.
    /// Los ids numéricos coinciden con tbtipousuario / id_Tipo_Usuario en BD.
    /// </summary>
    public class VarSession
    {
        /// <summary>Roles del sistema (semántica genérica; ids sin cambio en BD).</summary>
        public static class Roles
        {
            /// <summary>1 — Acceso total al sistema.</summary>
            public const int Root = 1;

            /// <summary>2 — Emite voto en papeleta.</summary>
            public const int Votante = 2;

            /// <summary>3 — Supervisa el proceso de votación.</summary>
            public const int Supervisor = 3;

            /// <summary>4 — Audita resultados y actas.</summary>
            public const int Auditor = 4;

            /// <summary>5 — Representa un grupo de opciones.</summary>
            public const int Grupo = 5;

            /// <summary>6 — Miembro de Mesa / JRV.</summary>
            public const int MiembroMesa = 6;

            /// <summary>7 — Administrador de usuarios y configuración.</summary>
            public const int Administrador = 7;
        }

        /// <summary>Nombre de usuario de la sesión activa.</summary>
        public static string usuario { get; set; }

        /// <summary>Contador de intentos de acceso fallidos en la sesión.</summary>
        public static int intentos { get; set; }

        /// <summary>Estado actual del usuario en la sesión.</summary>
        public static int EstadoUsuario { get; set; }

        /// <summary>Id de rol (Roles.*). Alias histórico: nivelU.</summary>
        public static int nivelU { get; set; }

        /// <summary>Identificador del miembro asociado a la sesión.</summary>
        public static int idmiembro { get; set; }

        /// <summary>Nombre del usuario en la sesión.</summary>
        public static string nombre { get; set; }

        /// <summary>Apellido del usuario en la sesión.</summary>
        public static string apellido { get; set; }

        /// <summary>Documento Único de Identidad del usuario en la sesión.</summary>
        public static string DUI { get; set; }

        /// <summary>Id del centro de votación asignado.</summary>
        public static int idCentroV { get; set; }

        /// <summary>Id de la Mesa / JRV asignada.</summary>
        public static int idJRV { get; set; }

        /// <summary>Etiqueta legible del rol (Tipo_Usuario en BD).</summary>
        public static string TipoUser { get; set; }

        /// <summary>Identificador del idioma seleccionado en la interfaz.</summary>
        public static int idioma { get; set; }

        /// <summary>Identificador del esquema de color de la interfaz.</summary>
        public static int Color { get; set; }

        /// <summary>Omitir el diálogo informativo al abrir login (p. ej. tras configuración inicial).</summary>
        public static bool OmitirDialogoInfoInicio { get; set; }

        /// <summary>Indica si el rol actual es Votante.</summary>
        /// <returns><c>true</c> si el rol es <see cref="Roles.Votante"/>; en caso contrario, <c>false</c>.</returns>
        public static bool EsVotante()
        {
            return nivelU == Roles.Votante;
        }

        /// <summary>Indica si el rol actual es Miembro de Mesa.</summary>
        /// <returns><c>true</c> si el rol es <see cref="Roles.MiembroMesa"/>; en caso contrario, <c>false</c>.</returns>
        public static bool EsMiembroMesa()
        {
            return nivelU == Roles.MiembroMesa;
        }

        /// <summary>Inicializa una nueva instancia de <see cref="VarSession"/>.</summary>
        public VarSession() { }
    }
}
