using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelCandidato
    {
        public static DataTable CargarPartidoC()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbpartido_politico";
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

        public static DataTable CargarEstadoCandidato()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_candidato";
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

        public static DataTable CargarCandidato()
        {
            DataTable data;
            try
            {
                string query = "SELECT tc.id_Candidato, tc.Nombre_Candidato, tc.Apellido_Candidato, tc.Género, tc.Imagen_Candidato, tpp.Nombre_Partido, tec.Estado_Candidato FROM tbcandidato tc, tbpartido_politico tpp, tbestado_candidato tec WHERE tc.id_Partido = tpp.id_Partido AND tc.id_Estado_Candidato = tec.id_Estado_Candidato";
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
    }
}
