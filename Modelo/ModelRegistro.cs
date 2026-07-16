using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Modelo
{
    public class ModelRegistro
    {
        public static bool Existencia(string DUI)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tbmiembros WHERE DUI = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", DUI));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public static List<string> BuscarDUI(string DUI)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT * FROM tbmiembros WHERE DUI = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", DUI));
                MySqlDataReader Leer = cmdselect.ExecuteReader();
                while (Leer.Read())
                {
                    datos = new List<string>();
                    //CAPTURO ID MIEMBRO
                    datos.Add(Leer.GetString(0));
                    //CAPTURO NOMBRE
                    datos.Add(Leer.GetString(1));
                    //CAPTURO APELLIDO
                    datos.Add(Leer.GetString(2));
                    //CAPTURO FECHA
                    datos.Add(Leer.GetString(6));
                    //CAPTURO DIRECCIÓN
                    datos.Add(Leer.GetString(7));
                    //CAPTURO TELEFONO
                    datos.Add(Leer.GetString(8));
                    //CAPTURO CENTRO DE VOTACIÓN
                    datos.Add(Leer.GetString(9));
                    //CAPTURO JRV
                    datos.Add(Leer.GetString(10));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        public static List<string> BuscarCredenciales()
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT * FROM tbtribunal WHERE id_Tribunal = 1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataReader Leer = cmdselect.ExecuteReader();
                while (Leer.Read())
                {
                    datos = new List<string>();
                    //CAPTURO CORREO
                    datos.Add(Leer.GetString(8));
                    //CAPTURO CONTRASEÑA
                    datos.Add(Leer.GetString(9));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        public static bool RegistrarUsuario(string usuario, string clave, int Centro_Votación, int id_Miembro)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbusuario (Usuario, Clave_Usuario, id_Centro_Votación, id_Miembro) VALUES ('{0}','{1}','{2}','{3}')", usuario, clave, Centro_Votación, id_Miembro), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
            finally
            {
                Conexion.getConnect().Close();
            }
        }
    }
}