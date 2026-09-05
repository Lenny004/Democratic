using System;
using System.Collections.Generic;
using Modelo;

namespace Controlador
{
    /// <summary>
    /// Coordina la consulta de opciones de voto para la papeleta (tb_opcion) entre la Vista y el Modelo.
    /// </summary>
    public class VerCandidatoController
    {
        /// <summary>
        /// Obtiene los datos de una opción de voto por su identificador.
        /// </summary>
        /// <param name="idOpcion">Identificador de la opción a consultar.</param>
        /// <returns>Lista de cadenas con los datos de la opción.</returns>
        public static List<string> ObtenerOpcion_Controller(int idOpcion)
        {
            return ModelVer.ObtenerDatosOpcion(idOpcion);
        }

        /// <summary>
        /// Delega al método genérico <see cref="ObtenerOpcion_Controller"/> para la opción 1.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de la opción 1.</returns>
        public static List<string> Candidato1_Controller()
        {
            return ObtenerOpcion_Controller(1);
        }

        /// <summary>
        /// Delega al método genérico <see cref="ObtenerOpcion_Controller"/> para la opción 2.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de la opción 2.</returns>
        public static List<string> Candidato2_Controller()
        {
            return ObtenerOpcion_Controller(2);
        }

        /// <summary>
        /// Delega al método genérico <see cref="ObtenerOpcion_Controller"/> para la opción 3.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de la opción 3.</returns>
        public static List<string> Candidato3_Controller()
        {
            return ObtenerOpcion_Controller(3);
        }

        /// <summary>
        /// Delega al método genérico <see cref="ObtenerOpcion_Controller"/> para la opción 4.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de la opción 4.</returns>
        public static List<string> Candidato4_Controller()
        {
            return ObtenerOpcion_Controller(4);
        }

        /// <summary>
        /// Delega al método genérico <see cref="ObtenerOpcion_Controller"/> para la opción 5.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de la opción 5.</returns>
        public static List<string> Candidato5_Controller()
        {
            return ObtenerOpcion_Controller(5);
        }

        /// <summary>
        /// Delega al método genérico <see cref="ObtenerOpcion_Controller"/> para la opción 6.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de la opción 6.</returns>
        public static List<string> Candidato6_Controller()
        {
            return ObtenerOpcion_Controller(6);
        }

        /// <summary>
        /// Delega al método genérico <see cref="ObtenerOpcion_Controller"/> para la opción 7.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de la opción 7.</returns>
        public static List<string> Candidato7_Controller()
        {
            return ObtenerOpcion_Controller(7);
        }

        /// <summary>
        /// Delega al método genérico <see cref="ObtenerOpcion_Controller"/> para la opción 8.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de la opción 8.</returns>
        public static List<string> Candidato8_Controller()
        {
            return ObtenerOpcion_Controller(8);
        }

        /// <summary>
        /// Delega al método genérico <see cref="ObtenerOpcion_Controller"/> para la opción 9.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de la opción 9.</returns>
        public static List<string> Candidato9_Controller()
        {
            return ObtenerOpcion_Controller(9);
        }
    }
}
