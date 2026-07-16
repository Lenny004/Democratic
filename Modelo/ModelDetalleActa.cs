using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloDetalleActa
    {
        public static DataTable CargarActa()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_Acta, Cantidad_Boletas FROM tbacta";
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

        public static DataTable CargarPartido()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_Partido, Nombre_Partido FROM tbpartido_politico";
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


        public static DataTable CargarDetalleActa()
        {
            DataTable data;
            try
            {
                string query = "SELECT tda.id_Detalle_Acta, tda.Cantidad_Votos, ta.Cantidad_Boletas, tpp.Nombre_Partido FROM tbdetalle_acta tda, tbacta ta, tbpartido_politico tpp WHERE tda.id_Acta = ta.id_Acta AND tda.id_Partido = tpp.id_Partido";
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

        public static bool RegistrarDetalleActa(int cantidadvotos, int acta, int partido)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbdetalle_acta (Cantidad_Votos, id_Acta, id_Partido ) VALUES ('{0}','{1}','{2}')", cantidadvotos, acta, partido), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static DataTable CargarActaInner(string id)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_Acta, Cantidad_Boletas FROM tbacta WHERE Cantidad_Boletas = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("?param1", id));
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

        public static DataTable CargarPartidoInner(string id)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_Partido, Nombre_Partido FROM tbpartido_politico WHERE Nombre_Partido = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("?param1", id));
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


        public static bool ActualizarDetalleActa(int id, int cantidadvotos, int acta, int partido)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbdetalle_acta SET Cantidad_Votos = '" + cantidadvotos + "', id_Acta = '" + acta + "', id_Partido = '" + partido + "' WHERE id_Detalle_Acta = '" + id + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static int EliminarDetalleActa(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbdetalle_acta WHERE id_Detalle_Acta = '" + id + "'  "), Conexion.getConnect());
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