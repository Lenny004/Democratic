using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    /// <summary>
    /// Estado de sesión del usuario autenticado en el sistema de votación genérico.
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

        public static string usuario { get; set; }

        public static int intentos { get; set; }

        public static int EstadoUsuario { get; set; }

        /// <summary>Id de rol (Roles.*). Alias histórico: nivelU.</summary>
        public static int nivelU { get; set; }

        public static int idmiembro { get; set; }

        public static string nombre { get; set; }

        public static string apellido { get; set; }

        public static string DUI { get; set; }

        /// <summary>Id del centro de votación asignado.</summary>
        public static int idCentroV { get; set; }

        /// <summary>Id de la Mesa / JRV asignada.</summary>
        public static int idJRV { get; set; }

        /// <summary>Etiqueta legible del rol (Tipo_Usuario en BD).</summary>
        public static string TipoUser { get; set; }

        public static int idioma { get; set; }

        public static int Color { get; set; }

        /// <summary>Indica si el rol actual es Votante.</summary>
        public static bool EsVotante()
        {
            return nivelU == Roles.Votante;
        }

        /// <summary>Indica si el rol actual es Miembro de Mesa.</summary>
        public static bool EsMiembroMesa()
        {
            return nivelU == Roles.MiembroMesa;
        }

        public VarSession() { }
    }
}
