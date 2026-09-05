using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>
    /// Capa Modelo: acceso a datos MySQL. Consulta datos de opciones de votación
    /// para visualización en boleta. Tabla física: tb_opcion.
    /// </summary>
    public class ModelVer
    {
        /// <summary>
        /// Obtiene el nombre y apellido de una opción por su identificador.
        /// </summary>
        /// <param name="idOpcion">Identificador de la opción.</param>
        /// <returns>Lista con nombre y apellido, o <c>null</c> si no se encuentra o hay error.</returns>
        public static List<string> ObtenerDatosOpcion(int idOpcion)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT nombre, apellido FROM tb_opcion WHERE id_opcion = " + idOpcion;
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataReader leer = cmdselect.ExecuteReader();
                while (leer.Read())
                {
                    datos = new List<string>();
                    datos.Add(leer.GetString(0));
                    datos.Add(leer.GetString(1));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }
    }
}
