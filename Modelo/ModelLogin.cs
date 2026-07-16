using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


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

        public static int Acceso2(string DUI)
        {
            int retorno = 0;
            bool retornoDUI;
            try
            {
                string query = "SELECT * FROM tbmiembros WHERE DUI = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", DUI));
                retornoDUI = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (retornoDUI == true)
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

        public static int Acceso3(string OCR)
        {
            int retorno = 0;
            bool retornoOCR;
            try
            {
                string query = "SELECT * FROM tbmiembros WHERE OCR = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", OCR));
                retornoOCR = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retornoOCR == true)
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
                string query = "SELECT tu.Usuario, tu.intento, tu.id_Estado_Usuario, tu.id_Tipo_Usuario, tm.id_Miembro, tm.Nombre_Miembro, tm.Apellido_Miembro, tm.DUI, tm.id_Centro_Votación , tm.id_JRV, ttu.Tipo_Usuario FROM tbusuario tu, tbmiembros tm, tbtipo_usuario ttu WHERE tu.Usuario = BINARY ?param1 AND tu.id_Miembro = tm.id_Miembro AND tu.id_Tipo_Usuario = ttu.id_Tipo_Usuario";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", usuario));
                MySqlDataReader reader = cmdselect.ExecuteReader();

                while (reader.Read())
                {
                    datos = new List<string>();
                    //Capturando usuario
                    datos.Add(reader.GetString(0));
                    //Capturando intento
                    datos.Add(reader.GetString(1));
                    //Capturando estado del usuario
                    datos.Add(reader.GetString(2));
                    //Capturando idtipoUsuario del usuario
                    datos.Add(reader.GetString(3));
                    //Capturando idmiembro
                    datos.Add(reader.GetString(4));
                    //Capturando nombre del miembro
                    datos.Add(reader.GetString(5));
                    //Capturando apellido del miembro
                    datos.Add(reader.GetString(6));
                    //Capturando DUI del miembro
                    datos.Add(reader.GetString(7));
                    //Capturando id_Centro_Votación del miembro
                    datos.Add(reader.GetString(8));
                    //Capturando id_jrv del miembro
                    datos.Add(reader.GetString(9));
                    //Capturando nombre tipo de usuario
                    datos.Add(reader.GetString(10));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        public static List<string> ObtenerDatos2(string DUI)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT * FROM tbmiembros WHERE DUI = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", DUI));
                MySqlDataReader reader = cmdselect.ExecuteReader();

                while (reader.Read())
                {
                    datos = new List<string>();
                    //Capturando idmiembro
                    datos.Add(reader.GetString(0));
                    //Capturando nombre del miembro
                    datos.Add(reader.GetString(1));
                    //Capturando apellido del miembro
                    datos.Add(reader.GetString(2));
                    //Capturando DUI del miembro
                    datos.Add(reader.GetString(3));
                    //Capturando id_Centro_Votación del miembro
                    datos.Add(reader.GetString(9));
                    //Capturando id_jrv del miembro
                    datos.Add(reader.GetString(10));
                    //Capturando nombre tipo de usuario
                    datos.Add(reader.GetString(11));
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

        public static bool ExistenciaHora(string usuario, string horaB, string horaD)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tbusuario WHERE Usuario = BINARY ?param1 AND HoraBlock = BINARY ?param2 AND HoraDesBlock = BINARY ?param3";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", usuario));
                cmdselect.Parameters.Add(new MySqlParameter("param2", horaB));
                cmdselect.Parameters.Add(new MySqlParameter("param3", horaD));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public static bool ActualizarIntentos(string usuario, int intento)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbusuario SET intento = '" + intento + "' WHERE Usuario = BINARY ?param1"), Conexion.getConnect());
                cmdinsert.Parameters.Add(new MySqlParameter("param1", usuario));
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static bool RegistrarHoraI(string usuario, string horaI, string horaA)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbusuario SET HoraBlock = '" + horaI + "', HoraDesBlock = '"+ horaA +"' WHERE Usuario = BINARY ?param1"), Conexion.getConnect());
                cmdinsert.Parameters.Add(new MySqlParameter("param1", usuario));
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static List<string> ObtenerHora(string usuario)
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
                    //Capturando hora bloqueo
                    datos.Add(reader.GetString(4));
                    //Capturando hora desbloqueo
                    datos.Add(reader.GetString(5));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        public static bool ActualizarEstado(string usuario, int EstadoU)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbusuario SET id_Estado_Usuario = '"+ EstadoU +"' WHERE Usuario = '" + usuario + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static List<string> ObtenerCV(int id)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT Nombre_Centro_Votación FROM tbcentro_de_votación WHERE id_Centro_Votación = '"+ id +"'  ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataReader reader = cmdselect.ExecuteReader();
                while (reader.Read())
                {
                    datos = new List<string>();
                    //Capturando nombre del CV
                    datos.Add(reader.GetString(0));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        public static List<string> ObtenerJRV(int id)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT Correlativo_JRV  FROM tbjrv WHERE id_JRV = '" + id + "'  ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataReader reader = cmdselect.ExecuteReader();
                while (reader.Read())
                {
                    datos = new List<string>();
                    //Capturando correlativo de la JRV
                    datos.Add(reader.GetString(0));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }
    }
}