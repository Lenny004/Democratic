using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador
{
    /// <summary>
    /// Consulta de Opciones de voto para la papeleta (plantilla genérica).
    /// Mantiene el nombre de clase por compatibilidad con referencias existentes.
    /// </summary>
    public class VerCandidatoController
    {
        /// <summary>
        /// Obtiene nombre y apellido de una Opción por su id.
        /// Sustituye los nueve métodos CandidatoN_Controller.
        /// </summary>
        public static List<string> ObtenerOpcion_Controller(int idOpcion)
        {
            switch (idOpcion)
            {
                case 1: return ModelVer.ObtenerDatosC1();
                case 2: return ModelVer.ObtenerDatosC2();
                case 3: return ModelVer.ObtenerDatosC3();
                case 4: return ModelVer.ObtenerDatosC4();
                case 5: return ModelVer.ObtenerDatosC5();
                case 6: return ModelVer.ObtenerDatosC6();
                case 7: return ModelVer.ObtenerDatosC7();
                case 8: return ModelVer.ObtenerDatosC8();
                case 9: return ModelVer.ObtenerDatosC9();
                default: return ObtenerOpcionDesdeBd(idOpcion);
            }
        }

        /// <summary>Consulta genérica cuando idOpcion no está en el rango 1–9.</summary>
        private static List<string> ObtenerOpcionDesdeBd(int idOpcion)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT Nombre_Candidato, Apellido_Candidato FROM tbcandidato WHERE id_Candidato = @id";
                MySqlCommand cmd = new MySqlCommand(query, MainController.ConnectController());
                cmd.Parameters.AddWithValue("@id", idOpcion);
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    datos = new List<string>();
                    datos.Add(leer.GetString(0));
                    datos.Add(leer.GetString(1));
                }
                leer.Close();
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        #region Compatibilidad — delegación a API parametrizada

        [Obsolete("Usar ObtenerOpcion_Controller(int idOpcion).")]
        public static List<string> Candidato1_Controller()
        {
            return ObtenerOpcion_Controller(1);
        }

        [Obsolete("Usar ObtenerOpcion_Controller(int idOpcion).")]
        public static List<string> Candidato2_Controller()
        {
            return ObtenerOpcion_Controller(2);
        }

        [Obsolete("Usar ObtenerOpcion_Controller(int idOpcion).")]
        public static List<string> Candidato3_Controller()
        {
            return ObtenerOpcion_Controller(3);
        }

        [Obsolete("Usar ObtenerOpcion_Controller(int idOpcion).")]
        public static List<string> Candidato4_Controller()
        {
            return ObtenerOpcion_Controller(4);
        }

        [Obsolete("Usar ObtenerOpcion_Controller(int idOpcion).")]
        public static List<string> Candidato5_Controller()
        {
            return ObtenerOpcion_Controller(5);
        }

        [Obsolete("Usar ObtenerOpcion_Controller(int idOpcion).")]
        public static List<string> Candidato6_Controller()
        {
            return ObtenerOpcion_Controller(6);
        }

        [Obsolete("Usar ObtenerOpcion_Controller(int idOpcion).")]
        public static List<string> Candidato7_Controller()
        {
            return ObtenerOpcion_Controller(7);
        }

        [Obsolete("Usar ObtenerOpcion_Controller(int idOpcion).")]
        public static List<string> Candidato8_Controller()
        {
            return ObtenerOpcion_Controller(8);
        }

        [Obsolete("Usar ObtenerOpcion_Controller(int idOpcion).")]
        public static List<string> Candidato9_Controller()
        {
            return ObtenerOpcion_Controller(9);
        }

        #endregion
    }
}
