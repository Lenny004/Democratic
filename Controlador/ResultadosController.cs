using System;
using System.Collections.Generic;
using System.Data;
using Modelo;

namespace Controlador
{
    /// <summary>
    /// Coordina la consulta de resultados agregados del proceso de votación entre la Vista y el Modelo.
    /// Plantilla genérica; delega en ModelResultados con métodos listos para extensión.
    /// </summary>
    public class ResultadosController
    {
        /// <summary>Conteo de votos por grupo de opciones.</summary>
        /// <returns>Tabla con el nombre del grupo y la cantidad de votos.</returns>
        public static DataTable ObtenerResultadosPorGrupo_Controller()
        {
            return ModelResultados.ObtenerConteoVotosPorGrupoOpciones();
        }

        /// <summary>Alias compatible con integraciones previas; delega a <see cref="ObtenerResultadosPorGrupo_Controller"/>.</summary>
        /// <returns>Lista de tuplas con nombre de grupo y cantidad de votos.</returns>
        public static List<Tuple<string, int>> ObtenerVotosPorGrupo_Controller()
        {
            var lista = new List<Tuple<string, int>>();
            DataTable tabla = ObtenerResultadosPorGrupo_Controller();
            if (tabla == null)
                return lista;

            foreach (DataRow fila in tabla.Rows)
            {
                string nombre = fila[0].ToString();
                int cantidad = Convert.ToInt32(fila[1]);
                lista.Add(Tuple.Create(nombre, cantidad));
            }
            return lista;
        }

        /// <summary>Datos listos para gráficos (nombre Grupo, cantidad); delega a <see cref="ObtenerVotosPorGrupo_Controller"/>.</summary>
        /// <returns>Diccionario con nombre de grupo como clave y cantidad de votos como valor.</returns>
        public static Dictionary<string, int> ObtenerDatosGraficoPorGrupo_Controller()
        {
            var datos = new Dictionary<string, int>();
            foreach (var item in ObtenerVotosPorGrupo_Controller())
                datos[item.Item1] = item.Item2;
            return datos;
        }

        /// <summary>
        /// Votos por Opción — pendiente de implementación en ModelResultados.
        /// </summary>
        /// <returns>Tabla con resultados por opción; actualmente retorna <c>null</c>.</returns>
        public static DataTable ObtenerResultadosPorOpcion_Controller()
        {
            return null;
        }

        /// <summary>
        /// Total global de votos — pendiente de implementación en ModelResultados.
        /// </summary>
        /// <returns>Total de votos; actualmente retorna <c>0</c>.</returns>
        public static int ObtenerTotalVotos_Controller()
        {
            return 0;
        }
    }
}
