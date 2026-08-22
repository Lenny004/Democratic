using System;
using System.Collections.Generic;
using System.Data;
using Modelo;

namespace Controlador
{
    /// <summary>
    /// Resultados agregados del proceso de votación (plantilla genérica).
    /// Delega en ModelResultados; métodos adicionales listos para extensión del modelo.
    /// </summary>
    public class ResultadosController
    {
        /// <summary>Conteo de votos por grupo de opciones.</summary>
        public static DataTable ObtenerResultadosPorGrupo_Controller()
        {
            return ModelResultados.ObtenerConteoVotosPorGrupoOpciones();
        }

        /// <summary>Alias compatible con integraciones previas.</summary>
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

        /// <summary>Datos listos para gráficos (nombre Grupo, cantidad).</summary>
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
        public static DataTable ObtenerResultadosPorOpcion_Controller()
        {
            return null;
        }

        /// <summary>
        /// Total global de votos — pendiente de implementación en ModelResultados.
        /// </summary>
        public static int ObtenerTotalVotos_Controller()
        {
            return 0;
        }
    }
}
