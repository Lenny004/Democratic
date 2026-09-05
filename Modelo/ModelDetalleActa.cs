using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    /// <summary>
    /// Capa Modelo: acceso a datos MySQL. CRUD de detalle de escrutinio por grupo de opciones.
    /// Tablas físicas: tb_detalle_escrutinio, tb_registro_escrutinio, tb_grupo_opciones.
    /// </summary>
    public class ModeloDetalleActa
    {
        /// <summary>
        /// Carga el listado de actas de escrutinio.
        /// </summary>
        /// <returns>Tabla con id_Acta y Cantidad_Boletas, o <c>null</c> si hay error.</returns>
        public static DataTable CargarActa()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_registro_escrutinio AS id_Acta, cantidad_boletas AS Cantidad_Boletas FROM tb_registro_escrutinio";
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

        /// <summary>
        /// Carga el listado de grupos de opciones (partidos).
        /// </summary>
        /// <returns>Tabla con id_Partido y Nombre_Partido, o <c>null</c> si hay error.</returns>
        public static DataTable CargarPartido()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_grupo_opciones AS id_Partido, nombre_grupo AS Nombre_Partido FROM tb_grupo_opciones";
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


        /// <summary>
        /// Obtiene el listado de detalles de escrutinio con acta y grupo de opciones.
        /// </summary>
        /// <returns>Tabla con datos del detalle y relaciones, o <c>null</c> si hay error.</returns>
        public static DataTable CargarDetalleActa()
        {
            DataTable data;
            try
            {
                string query = "SELECT d.id_detalle_escrutinio AS id_Detalle_Acta, d.cantidad_votos AS Cantidad_Votos, r.cantidad_boletas AS Cantidad_Boletas, g.nombre_grupo AS Nombre_Partido FROM tb_detalle_escrutinio d INNER JOIN tb_registro_escrutinio r ON d.id_registro_escrutinio = r.id_registro_escrutinio INNER JOIN tb_grupo_opciones g ON d.id_grupo_opciones = g.id_grupo_opciones";
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

        /// <summary>
        /// Registra un nuevo detalle de escrutinio para un acta y grupo de opciones.
        /// </summary>
        /// <param name="cantidadvotos">Cantidad de votos del detalle.</param>
        /// <param name="acta">Identificador del acta de escrutinio.</param>
        /// <param name="partido">Identificador del grupo de opciones.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarDetalleActa(int cantidadvotos, int acta, int partido)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_detalle_escrutinio (cantidad_votos, id_registro_escrutinio, id_grupo_opciones) VALUES ('{0}','{1}','{2}')", cantidadvotos, acta, partido), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Busca un acta de escrutinio por su cantidad de boletas.
        /// </summary>
        /// <param name="id">Cantidad de boletas a buscar.</param>
        /// <returns>Tabla con los datos del acta, o <c>null</c> si hay error.</returns>
        public static DataTable CargarActaInner(string id)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_registro_escrutinio AS id_Acta, cantidad_boletas AS Cantidad_Boletas FROM tb_registro_escrutinio WHERE cantidad_boletas = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("?param1", id));
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

        /// <summary>
        /// Busca un grupo de opciones por su nombre.
        /// </summary>
        /// <param name="id">Nombre del grupo a buscar.</param>
        /// <returns>Tabla con los datos del grupo, o <c>null</c> si hay error.</returns>
        public static DataTable CargarPartidoInner(string id)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_grupo_opciones AS id_Partido, nombre_grupo AS Nombre_Partido FROM tb_grupo_opciones WHERE nombre_grupo = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("?param1", id));
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


        /// <summary>
        /// Actualiza un detalle de escrutinio existente.
        /// </summary>
        /// <param name="id">Identificador del detalle.</param>
        /// <param name="cantidadvotos">Cantidad de votos del detalle.</param>
        /// <param name="acta">Identificador del acta de escrutinio.</param>
        /// <param name="partido">Identificador del grupo de opciones.</param>
        /// <returns><c>true</c> si la actualización fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool ActualizarDetalleActa(int id, int cantidadvotos, int acta, int partido)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tb_detalle_escrutinio SET cantidad_votos = '" + cantidadvotos + "', id_registro_escrutinio = '" + acta + "', id_grupo_opciones = '" + partido + "' WHERE id_detalle_escrutinio = '" + id + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Elimina un detalle de escrutinio por su identificador.
        /// </summary>
        /// <param name="id">Identificador del detalle a eliminar.</param>
        /// <returns>1 si se eliminó correctamente, 2 si no se encontró fila, -1 si hay error.</returns>
        public static int EliminarDetalleActa(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tb_detalle_escrutinio WHERE id_detalle_escrutinio = '" + id + "'  "), Conexion.getConnect());
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
