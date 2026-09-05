using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;
using System.Data;

namespace Controlador
{
    /// <summary>
    /// Coordina el registro de nuevos usuarios del sistema entre la Vista y el Modelo.
    /// Valida DUI y vincula usuarios con miembros y centros de votación.
    /// </summary>
    public class RegistroController : AtributosRegister
    {
        /// <summary>
        /// Verifica si ya existe un registro con el DUI almacenado en <see cref="AtributosRegister.DUI"/>.
        /// </summary>
        /// <returns><c>true</c> si el DUI ya existe; en caso contrario, <c>false</c>.</returns>
        public static bool Existencia_Controller()
        {
            return ModelRegistro.Existencia(DUI);
        }

        /// <summary>
        /// Busca datos de un miembro por el DUI almacenado en <see cref="AtributosRegister.DUI"/>.
        /// </summary>
        /// <returns>Lista de cadenas con los datos del miembro encontrado.</returns>
        public static List<string> BuscarDUI_Controller()
        {
            return ModelRegistro.BuscarDUI(DUI);
        }

        /// <summary>
        /// Obtiene las credenciales de registro disponibles en el sistema.
        /// </summary>
        /// <returns>Lista de cadenas con las credenciales de registro.</returns>
        public static List<string> Credenciales_Controller()
        {
            return ModelRegistro.BuscarCredenciales();
        }

        /// <summary>
        /// Registra un nuevo usuario con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool RegistrarUsuario_Controller()
        {
            return ModelRegistro.RegistrarUsuario(usuario, clave, Centro_Votación, id_Miembro);
        }

    }

    /// <summary>
    /// Contiene los atributos de registro de usuario utilizados por la capa Controlador.
    /// </summary>
    public class AtributosRegister
    {

        /// <summary>Documento Único de Identidad para validación de registro.</summary>
        public static string DUI { get; set; }

        /// <summary>Datos de miembros disponibles para vinculación.</summary>
        public static string miembros { get; set; }

        /// <summary>Nombre de usuario a registrar.</summary>
        public string usuario { get; set; }

        /// <summary>Clave o contraseña del nuevo usuario.</summary>
        public string clave { get; set; }

        /// <summary>Identificador del centro de votación asignado.</summary>
        public int Centro_Votación { get; set; }

        /// <summary>Identificador del miembro vinculado al usuario.</summary>
        public int id_Miembro { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosRegister"/>.</summary>
        public AtributosRegister() { }
    }
}
