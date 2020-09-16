using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelLogin
    {
        public static int Acceso(string usuario, string Clave_Usuario)
        {
            int retorno = 0;
            bool retornoaux;
            try
            {
                string query = "SELECT * FROM tbusuario tu WHERE Usuario = BINARY ?param1 AND Clave_Usuario = BINARY ?param2";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", usuario));
                cmdselect.Parameters.Add(new MySqlParameter("param2", Clave_Usuario));
                retornoaux = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (retornoaux == true)
                {
                    retorno = 1;
                }
                else
                {
                    retorno = 2;
                }
                return retorno;
            }
            catch (Exception)
            {
                return retorno = 3;
            }
        }

        public static List<string>ObtenerDatos(string usuario)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT * FROM tbusuario tu, tbmiembros tm, tbtipo_usuario ttu  WHERE tu.Usuario = BINARY ?param1 AND tu.id_Miembro = tm.id_Miembro AND tu.id_Tipo_Usuario = ttu.id_Tipo_Usuario";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", usuario));
                MySqlDataReader reader = cmdselect.ExecuteReader();

                while (reader.Read())
                {
                    datos = new List<string>();
                    //Capturando usuario
                    datos.Add(reader.GetString(1));
                    //Capturando idtipoUsuario del usuario
                    datos.Add(reader.GetString(5));
                    //Capturando nombre del usuario
                    datos.Add(reader.GetString(9));
                    //Capturando apellido del usuario
                    datos.Add(reader.GetString(10));
                    //Capturando tipo de usuario
                    datos.Add(reader.GetString(18));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        public static int ObtenerTribunal()
        {
            int retorno;
            try
            {
                string query = "SELECT * FROM tbtribunal";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                retorno = Convert.ToInt16(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = -1;
            }
        }

        public static int ObtenerUsuarios()
        {
            int retorno;
            try
            {
                string query = "SELECT * FROM tbusuario";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                retorno = Convert.ToInt16(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = -1;
            }
        }
    }
}