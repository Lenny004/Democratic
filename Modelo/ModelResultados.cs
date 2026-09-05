using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>
    /// Capa Modelo: acceso a datos MySQL. Agregación de resultados de votación
    /// para gráficas e informes. Tablas físicas: tb_voto, tb_grupo_opciones.
    /// </summary>
    public class ModelResultados
    {
        /// <summary>
        /// Obtiene el conteo de votos agrupado por grupo de opciones.
        /// </summary>
        /// <returns>Tabla con columnas Nombre_Partido y CANT, o <c>null</c> si hay error.</returns>
        public static DataTable ObtenerConteoVotosPorGrupoOpciones()
        {
            DataTable data;
            try
            {
                string query = "SELECT g.nombre_grupo AS Nombre_Partido, COUNT(v.id_voto) AS CANT FROM tb_voto v INNER JOIN tb_grupo_opciones g ON g.id_grupo_opciones = v.id_grupo_opciones GROUP BY g.id_grupo_opciones, g.nombre_grupo";
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
