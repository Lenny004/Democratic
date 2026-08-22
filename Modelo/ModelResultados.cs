using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>
    /// Agregación de Resultados de votación para gráficas e informes.
    /// </summary>
    public class ModelResultados
    {
        /// <summary>
        /// Conteo de votos por GrupoOpciones (GROUP BY id_Partido).
        /// Columnas: Nombre_GrupoOpciones, Cantidad_Votos.
        /// </summary>
        public static DataTable ObtenerConteoVotosPorGrupoOpciones()
        {
            DataTable data;
            try
            {
                string query = "SELECT tpp.Nombre_Partido, COUNT(tv.id_Partido) AS CANT FROM tbvoto tv, tbpartido_politico tpp WHERE tpp.id_Partido=tv.id_Partido GROUP BY tv.id_Partido,tpp.Nombre_Partido";
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
