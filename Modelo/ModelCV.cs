using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelCV
    {
        public static DataTable CargarEstadoCentro()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_Estado_CentroVotación, Nombre_Estado_CentroVotación FROM tbestado_centrovotación";
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

        public static DataTable CargarMunicipio()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_Municipio, Nombre_Municipio FROM tbmunicipio";
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

        public static DataTable CargarActas()
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

        public static DataTable CargarTribunal()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_Tribunal, Tipo FROM tbtribunal";
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

        public static DataTable CargarCV()
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

        public static bool RegistrarCV(string NombreCentroVotacion, int Acta, int CantidadJRV, int EstadoCentroVotacion, int Municipio, int Tribunal)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbcentro_de_votación(Nombre_Centro_Votación, id_Acta, Cantidad_de_JRV, id_Estado_CentroVotación, id_Municipio, id_Tribunal) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", NombreCentroVotacion, Acta, CantidadJRV, EstadoCentroVotacion, Municipio, Tribunal), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static DataTable CargarActasInner(string acta)
        {
            DataTable data;

            try
            {
                string query = "SELECT id_Acta, Cantidad_Boletas FROM tbacta WHERE id_Acta = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", acta));
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

        public static DataTable CargarEstadoCVInner(string estado)
        {
            DataTable data;

            try
            {
                string query = "SELECT id_Estado_CentroVotación, Nombre_Estado_CentroVotación FROM tbestado_centrovotación WHERE id_Estado_CentroVotación = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", estado));
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

        public static DataTable CargarMunicipioInner(string municipio)
        {
            DataTable data;

            try
            {
                string query = "SELECT id_Municipio, Nombre_Municipio FROM tbmunicipio WHERE id_Municipio = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", municipio));
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

        public static DataTable CargarTribunalInner(string tribunal)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_Tribunal, Tipo FROM tbtribunal WHERE id_Tribunal = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", tribunal));
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

        public static bool ActualizarCentroVotacion(int id, string NombreCentroVotacion, int Acta, int CantidadJRV, int EstadoCentroVotacion, int Municipio, int Tribunal)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbcentro_de_votación SET Nombre_Centro_Votación = '" + NombreCentroVotacion + "', id_Acta = '" + Acta + "', Cantidad_de_JRV = '" + CantidadJRV + "', id_Estado_CentroVotación = '" + EstadoCentroVotacion + "', id_Municipio = '" + Municipio + "', id_Tribunal = '" + Tribunal + "' WHERE id_Centro_Votación = '" + id + "'"), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static int EliminarCV(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbcentro_de_votación  WHERE id_Centro_Votación = '" + id + "'"), Conexion.getConnect());
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
