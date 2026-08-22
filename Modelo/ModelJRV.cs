using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelJRV
    {
        public static DataTable CargarCentroVotacion()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbcentro_de_votación";
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

        public static DataTable CargarEstadoJRV()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_jrv";
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

        public static DataTable CargarTablaJRV()
        {
            DataTable data;
            try
            {
                string query = "SELECT tj.id_JRV, tj.Correlativo_JRV, tcv.Nombre_Centro_Votación, tej.Nombre_Estado_JRV FROM tbjrv tj , tbcentro_de_votación tcv , tbestado_jrv tej WHERE tj.id_Centro_Votación = tcv.id_Centro_Votación AND tj.id_Estado_JRV = tej.id_Estado_JRV";
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

        public static bool RegistrarJRV(string correlativo, int centrovotacion, int estadojrv)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbjrv (Correlativo_JRV, id_Centro_Votación, id_Estado_JRV) VALUE('{0}','{1}','{2}')", correlativo, centrovotacion, estadojrv), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static DataTable CargarCVInner(string id)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_Centro_Votación, Nombre_Centro_Votación FROM tbcentro_de_votación WHERE Nombre_Centro_Votación = ?param1";
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

        public static DataTable CargarEstadoJRVInner(string id)
        {
            DataTable data;
            try
            {
                string query = "SELECT 	id_Estado_JRV, Nombre_Estado_JRV FROM tbestado_jrv WHERE Nombre_Estado_JRV = ?param1";
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

        public static bool ActualizarJRV(int id, string correlativo, int centrovotacion, int estadojrv)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbjrv SET Correlativo_JRV = '" + correlativo + "', id_Centro_Votación = '" + centrovotacion + "', id_Estado_JRV = '" + estadojrv + "' WHERE id_JRV = '" + id + "'"), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static int EliminarJRV(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbjrv  WHERE id_JRV = '" + id + "'  "), Conexion.getConnect());
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
    }
}
