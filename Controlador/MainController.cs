using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Controlador
{
    public class MainController
    {
        /// <summary>
        /// El metodo ConnectController hará de Intermediario entre la accion que ejecute el usuario y la base de datos.
        /// </summary>
        /// <returns>Retornará un valor de conexión en caso se haya realizado correctamente 
        /// de lo contrario retornará un valor null</returns>
        public static MySqlConnection ConnectController()
        {
            return Modelo.Conexion.getConnect();
        }

    }
}
