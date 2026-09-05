using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Controlador
{
    /// <summary>
    /// Punto de entrada del sistema de votación genérico.
    /// Intermediario entre la capa Vista y la base de datos (Modelo) para operaciones de conexión.
    /// </summary>
    public class MainController
    {
        /// <summary>
        /// Obtiene la conexión activa a la base de datos del proceso electoral.
        /// </summary>
        /// <returns>Conexión MySQL o <c>null</c> si falla.</returns>
        public static MySqlConnection ConnectController()
        {
            return Modelo.Conexion.getConnect();
        }
    }
}
