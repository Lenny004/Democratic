using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelDetalleMiembro
    {
        public static DataTable CargarDetalleMiembrosJRV()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbjrv";
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

        public static DataTable CargarDetalleMiembrosMiembro()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_Miembro, Nombre_Miembro FROM tbmiembros";
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

        public static DataTable CargarDatosDetalleMiembros()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbdetalle_de_miembros";
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

        public static bool RegistrarDetalleMiembros(string Detalle_de_Miembros, int id_Miembro, int id_JRV)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbdetalle_de_miembros (Detalle_de_Miembros, id_Miembro, id_JRV) VALUES ('{0}', '{1}', '{2}')", Detalle_de_Miembros, id_Miembro, id_JRV), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static bool ActualizarDetalleMiembros(int id_Detalle, string Detalle_De_Miembros, int id_Miembro, int id_JRV)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbdetalle_de_miembros SET Detalle_de_Miembros = '" + Detalle_De_Miembros + "', id_Miembro = '" + id_Miembro + "', id_JRV = '" + id_JRV + "' WHERE id_Detalle = '" + id_Detalle + "' "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static int EliminarDetalleMiembro(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbdetalle_de_miembros WHERE id_Detalle = '" + id + "' "), Conexion.getConnect());
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

        public static DataTable CargarDetalleMiembroJRVInner(string id_JRV)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_JRV, Correlativo_JRV  FROM tbjrv WHERE id_JRV = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", id_JRV));
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

        public static DataTable CargarDetalleMiembroMiembroInner(string id_Miembro)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_Miembro, Nombre_Miembro FROM tbmiembros WHERE id_Miembro = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", id_Miembro));
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
    }
}