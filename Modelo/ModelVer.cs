using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>
    /// Consulta de datos de Opciones para visualización en boleta (plantilla genérica).
    /// Tabla física: tbcandidato.
    /// </summary>
    public class ModelVer
    {
        /// <summary>Obtiene nombre y apellido de una Opción por su identificador.</summary>
        public static List<string> ObtenerDatosOpcion(int idOpcion)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT * FROM tbcandidato WHERE id_Candidato = " + idOpcion;
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataReader leer = cmdselect.ExecuteReader();
                while (leer.Read())
                {
                    datos = new List<string>();
                    datos.Add(leer.GetString(1));
                    datos.Add(leer.GetString(2));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        public static List<string> ObtenerDatosC1() { return ObtenerDatosOpcion(1); }
        public static List<string> ObtenerDatosC2() { return ObtenerDatosOpcion(2); }
        public static List<string> ObtenerDatosC3() { return ObtenerDatosOpcion(3); }
        public static List<string> ObtenerDatosC4() { return ObtenerDatosOpcion(4); }
        public static List<string> ObtenerDatosC5() { return ObtenerDatosOpcion(5); }
        public static List<string> ObtenerDatosC6() { return ObtenerDatosOpcion(6); }
        public static List<string> ObtenerDatosC7() { return ObtenerDatosOpcion(7); }
        public static List<string> ObtenerDatosC8() { return ObtenerDatosOpcion(8); }
        public static List<string> ObtenerDatosC9() { return ObtenerDatosOpcion(9); }
    }
}
