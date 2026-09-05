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
    /// Coordina la autenticación y gestión de sesión del sistema de votación entre la Vista y el Modelo.
    /// </summary>
    public class LoginController : AtributosLogin
    {
        /// <summary>
        /// Valida el acceso de un usuario mediante credenciales almacenadas en <see cref="AtributosLogin.usuario"/> y <see cref="AtributosLogin.Clave_Usuario"/>.
        /// </summary>
        /// <returns>Código de resultado de la validación de acceso.</returns>
        public static int Acceso_Controller()
        {
            return ModelLogin.Acceso(usuario, Clave_Usuario);
        }

        /// <summary>
        /// Valida el acceso de un usuario mediante el DUI almacenado en <see cref="AtributosLogin.DUI"/>.
        /// </summary>
        /// <returns>Código de resultado de la validación de acceso.</returns>
        public static int DUI_Controller()
        {
            return ModelLogin.Acceso2(DUI);
        }

        /// <summary>
        /// Valida el acceso de un usuario mediante el OCR almacenado en <see cref="AtributosLogin.OCR"/>.
        /// </summary>
        /// <returns>Código de resultado de la validación de acceso.</returns>
        public static int OCR_Controller()
        {
            return ModelLogin.Acceso3(OCR);
        }

        /// <summary>
        /// Obtiene datos de sesión incluyendo rol (VarSession.Roles.*) para el usuario autenticado.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de sesión del usuario.</returns>
        public static List<string> Nivel_Controller()
        {
            return ModelLogin.ObtenerDatos(usuario);
        }

        /// <summary>
        /// Obtiene datos de sesión mediante el DUI del usuario autenticado.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de sesión del usuario.</returns>
        public static List<string> Nivel_Controller2()
        {
            return ModelLogin.ObtenerDatos2(DUI);
        }

        /// <summary>
        /// Delega al método genérico <see cref="VerificacionTribunal_Controller"/>.
        /// Verifica si ya existe una Organización registrada.
        /// </summary>
        /// <returns>Código indicando si existe una organización registrada.</returns>
        public static int VerificacionOrganizacion_Controller()
        {
            return VerificacionTribunal_Controller();
        }

        /// <summary>
        /// Verifica si ya existe un tribunal u organización electoral registrada.
        /// </summary>
        /// <returns>Código indicando si existe un tribunal registrado.</returns>
        public static int VerificacionTribunal_Controller()
        {
            return ModelLogin.ObtenerTribunal();
        }

        /// <summary>
        /// Verifica si existen usuarios registrados en el sistema.
        /// </summary>
        /// <returns>Código indicando la existencia de usuarios.</returns>
        public static int VerificacionUsuario_Controller()
        {
            return ModelLogin.ObtenerUsuarios();
        }

        /// <summary>
        /// Actualiza el contador de intentos de acceso fallidos del usuario.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public static bool ActualizarIntentos_Controller()
        {
            return ModelLogin.ActualizarIntentos(usuario, intento);
        }

        /// <summary>
        /// Actualiza el estado del usuario en el sistema.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public static bool ActualizarEstado_Controller()
        {
            return ModelLogin.ActualizarEstado(usuario, EstadoU);
        }

        /// <summary>
        /// Registra la hora de inicio de sesión del usuario.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public static bool AgregarHoraI_Controller()
        {
            return ModelLogin.RegistrarHoraI(usuario, HoraI, HoraA);
        }

        /// <summary>
        /// Verifica si existe un registro de hora de sesión para el usuario.
        /// </summary>
        /// <returns><c>true</c> si existe el registro de hora; en caso contrario, <c>false</c>.</returns>
        public static bool ExistenciaHora_Controller()
        {
            return ModelLogin.ExistenciaHora(usuario, HoraB, HoraD);
        }

        /// <summary>
        /// Obtiene los registros de hora de sesión del usuario.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de hora de sesión.</returns>
        public static List<string> Hora_Controller()
        {
            return ModelLogin.ObtenerHora(usuario);
        }

        /// <summary>
        /// Delega al método genérico <see cref="BuscarCV_Controller"/>.
        /// Busca centro de votación por id.
        /// </summary>
        /// <returns>Lista de cadenas con los datos del centro de votación.</returns>
        public static List<string> BuscarCentroVotacion_Controller()
        {
            return BuscarCV_Controller();
        }

        /// <summary>
        /// Busca un centro de votación por el identificador almacenado en <see cref="AtributosLogin.CV"/>.
        /// </summary>
        /// <returns>Lista de cadenas con los datos del centro de votación.</returns>
        public static List<string> BuscarCV_Controller()
        {
            return ModelLogin.ObtenerCV(CV);
        }

        /// <summary>
        /// Delega al método genérico <see cref="BuscarJRV_Controller"/>.
        /// Busca Mesa / JRV por id.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de la mesa o JRV.</returns>
        public static List<string> BuscarMesa_Controller()
        {
            return BuscarJRV_Controller();
        }

        /// <summary>
        /// Busca una JRV o mesa por el identificador almacenado en <see cref="AtributosLogin.JRV"/>.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de la JRV.</returns>
        public static List<string> BuscarJRV_Controller()
        {
            return ModelLogin.ObtenerJRV(JRV);
        }
    }

    /// <summary>
    /// Contiene los atributos de autenticación y sesión utilizados por la capa Controlador.
    /// </summary>
    public class AtributosLogin
    {
        /// <summary>Nombre de usuario para autenticación.</summary>
        public static string usuario { get; set; }

        /// <summary>Clave o contraseña del usuario.</summary>
        public static string Clave_Usuario { get; set; }

        /// <summary>Contador de intentos de acceso fallidos.</summary>
        public static int intento { get; set; }

        /// <summary>Hora de inicio de sesión.</summary>
        public static string HoraI { get; set; }

        /// <summary>Hora auxiliar de registro de sesión.</summary>
        public static string HoraA { get; set; }

        /// <summary>Hora de inicio para verificación de existencia.</summary>
        public static string HoraB { get; set; }

        /// <summary>Hora de fin para verificación de existencia.</summary>
        public static string HoraD { get; set; }

        /// <summary>Estado actual del usuario en el sistema.</summary>
        public static int EstadoU { get; set; }

        /// <summary>Id del centro de votación.</summary>
        public static int CV { get; set; }

        /// <summary>Id de la Mesa / JRV.</summary>
        public static int JRV { get; set; }

        /// <summary>Documento Único de Identidad del usuario.</summary>
        public static string DUI { get; set; }

        /// <summary>Código OCR del documento de identidad.</summary>
        public static string OCR { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosLogin"/>.</summary>
        public AtributosLogin() { }
    }
}
