using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelActas
    {
        public static DataTable CargarJRV()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_JRV, Correlativo_JRV FROM tbjrv";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.getConnect().Close();
            }
        }

        public static DataTable ObtenerActas()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbacta";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.getConnect().Close();
            }
        }

        public static bool RegistrarActas(string Cantidad_Boletas, int JRV)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbacta(Cantidad_Boletas, id_JRV) VALUES ('{0}','{1}')", Cantidad_Boletas, JRV), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static DataTable CargarJRVInner(string id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbjrv WHERE id_JRV = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.getConnect().Close();
            }
        }

        public static bool ActualizarActas(int id_Acta, string Cantidad_Boletas, int JRV)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbacta SET Cantidad_Boletas = '" + Cantidad_Boletas + "', id_JRV = '" + JRV + "' WHERE id_Acta = '" + id_Acta + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static int EliminarActa(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbacta WHERE id_Acta = '" + id + "' "), Conexion.getConnect());
                retorno = Convert.ToInt16(cmddel.ExecuteNonQuery());
                if (retorno == 1)
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
                return retorno = -1;
            }
        }

        public static List<string> BuscarJRV(string CorrelativoJrv)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT * FROM tbjrv WHERE Correlativo_JRV = '"+ CorrelativoJrv +"'   ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataReader Leer = cmdselect.ExecuteReader();
                while (Leer.Read())
                {
                    datos = new List<string>();
                    //CAPTURO Correlativo de la JRV
                    datos.Add(Leer.GetString(1));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        public static bool ExistenciaJRV(string CorrelativoJRV)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tbjrv WHERE Correlativo_JRV = '" + CorrelativoJRV + "'  ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }
    }
}
