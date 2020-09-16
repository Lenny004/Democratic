using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelPartido
    {
        public static DataTable CargarEstadoPartido()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_partido";
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

        public static bool RegistrarPartido(byte[] image, string nombrep, int Cantidadvotosp, int Estado_Partido)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbpartido_politico (Imagen_Partido, Nombre_Partido, Cantidad_Votos, id_Estado_Partido) VALUES ('{0}', '{1}', '{2}', '{3}')", image, nombrep, Cantidadvotosp, Estado_Partido), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static DataTable CargarPartido()
        {
            DataTable data;
            try
            {
                string query = "SELECT tpp.id_Partido, tpp.Imagen_Partido, tpp.Nombre_Partido, tpp.Cantidad_Votos, tep.Estado_Partido FROM tbpartido_politico tpp, tbestado_partido tep WHERE tpp.id_Estado_Partido = tep.id_Estado_Partido";
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

        public static DataTable CargarEstadoPartidoInner(string Estado_Partido)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_partido WHERE id_Estado_Partido = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", Estado_Partido));
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

        public static bool ActualizarPartido(int idPartido, byte[] image, string nombrep, int Cantidadvotosp, int Estado_Partido)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbpartido_politico SET Imagen_Partido = '" + image + "', Nombre_Partido = '" + nombrep + "', Cantidad_Votos = '" + Cantidadvotosp + "', id_Estado_Partido = '" + Estado_Partido + "' WHERE id_Partido = '" + idPartido + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static int EliminarPartido(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbpartido_politico WHERE id_Partido = '" + id + "' "), Conexion.getConnect());
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
