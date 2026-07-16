using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelRecuperar
    {
        public static bool ExistenciaCorreo(string correo)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tbusuario WHERE Usuario = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", correo));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public static bool ActualizarContraseña(string correo2, string contraUpd)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbusuario SET Clave_Usuario = '" + contraUpd + "' WHERE Usuario = '" + correo2 + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
    }
}
