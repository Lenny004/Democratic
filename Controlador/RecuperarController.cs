using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Modelo;


namespace Controlador
{
    /// <summary>
    /// Coordina la recuperación de contraseña de usuarios entre la Vista y el Modelo.
    /// Valida correo electrónico y actualiza credenciales de acceso.
    /// </summary>
    public class RecuperarController : AtributosRecuperar
    {
        /// <summary>
        /// Verifica si existe un usuario registrado con el correo almacenado en <see cref="AtributosRecuperar.correo"/>.
        /// </summary>
        /// <returns><c>true</c> si el correo existe; en caso contrario, <c>false</c>.</returns>
        public static bool ExistenciaCorreo_Controller()
        {
            return ModelRecuperar.ExistenciaCorreo(correo);
        }

        /// <summary>
        /// Actualiza la contraseña del usuario asociado al correo de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarContra_Controller()
        {
            return ModelRecuperar.ActualizarContraseña(correo2, ContraUpd);
        }
    }

    /// <summary>
    /// Contiene los atributos de recuperación de contraseña utilizados por la capa Controlador.
    /// </summary>
    public class AtributosRecuperar
    {
        /// <summary>Correo electrónico para verificación de existencia.</summary>
        public static string correo { get; set; }

        /// <summary>Correo electrónico del usuario a actualizar.</summary>
        public string correo2 { get; set; }

        /// <summary>Nueva contraseña a asignar al usuario.</summary>
        public string ContraUpd { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosRecuperar"/>.</summary>
        public AtributosRecuperar() { }
    }
}
