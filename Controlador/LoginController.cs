using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador
{
    /// <summary>
    /// Autenticación y sesión del sistema de votación genérico.
    /// </summary>
    public class LoginController : AtributosLogin
    {
        public static int Acceso_Controller()
        {
            return ModelLogin.Acceso(usuario, Clave_Usuario);
        }

        public static int DUI_Controller()
        {
            return ModelLogin.Acceso2(DUI);
        }

        public static int OCR_Controller()
        {
            return ModelLogin.Acceso3(OCR);
        }

        /// <summary>Obtiene datos de sesión incluyendo rol (VarSession.Roles.*).</summary>
        public static List<string> Nivel_Controller()
        {
            return ModelLogin.ObtenerDatos(usuario);
        }

        public static List<string> Nivel_Controller2()
        {
            return ModelLogin.ObtenerDatos2(DUI);
        }

        /// <summary>Verifica si ya existe una Organización registrada.</summary>
        public static int VerificacionOrganizacion_Controller()
        {
            return VerificacionTribunal_Controller();
        }

        public static int VerificacionTribunal_Controller()
        {
            return ModelLogin.ObtenerTribunal();
        }

        public static int VerificacionUsuario_Controller()
        {
            return ModelLogin.ObtenerUsuarios();
        }

        public static bool ActualizarIntentos_Controller()
        {
            return ModelLogin.ActualizarIntentos(usuario, intento);
        }

        public static bool ActualizarEstado_Controller()
        {
            return ModelLogin.ActualizarEstado(usuario, EstadoU);
        }

        public static bool AgregarHoraI_Controller()
        {
            return ModelLogin.RegistrarHoraI(usuario, HoraI, HoraA);
        }

        public static bool ExistenciaHora_Controller()
        {
            return ModelLogin.ExistenciaHora(usuario, HoraB, HoraD);
        }

        public static List<string> Hora_Controller()
        {
            return ModelLogin.ObtenerHora(usuario);
        }

        /// <summary>Busca centro de votación por id.</summary>
        public static List<string> BuscarCentroVotacion_Controller()
        {
            return BuscarCV_Controller();
        }

        public static List<string> BuscarCV_Controller()
        {
            return ModelLogin.ObtenerCV(CV);
        }

        /// <summary>Busca Mesa / JRV por id.</summary>
        public static List<string> BuscarMesa_Controller()
        {
            return BuscarJRV_Controller();
        }

        public static List<string> BuscarJRV_Controller()
        {
            return ModelLogin.ObtenerJRV(JRV);
        }
    }

    public class AtributosLogin
    {
        public static string usuario { get; set; }

        public static string Clave_Usuario { get; set; }

        public static int intento { get; set; }

        public static string HoraI { get; set; }

        public static string HoraA { get; set; }

        public static string HoraB { get; set; }

        public static string HoraD { get; set; }

        public static int EstadoU { get; set; }

        /// <summary>Id del centro de votación.</summary>
        public static int CV { get; set; }

        /// <summary>Id de la Mesa / JRV.</summary>
        public static int JRV { get; set; }

        public static string DUI { get; set; }

        public static string OCR { get; set; }

        public AtributosLogin() { }
    }
}
