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
    /// Capa Modelo: acceso a datos MySQL. CRUD de mesas de votación (JRV).
    /// Tablas físicas: tb_mesa, tb_sede, tb_estado_mesa.
    /// </summary>
    public class ModelJRV
    {
        /// <summary>
        /// Carga el listado de centros de votación.
        /// </summary>
        /// <returns>Tabla con datos de sedes, o <c>null</c> si hay error.</returns>
        public static DataTable CargarCentroVotacion()
        {
            DataTable data;
            try
            {
                string query = "SELECT s.id_sede AS id_Centro_Votación, s.nombre_sede AS Nombre_Centro_Votación, s.id_registro_escrutinio AS id_Acta, s.cantidad_mesas AS Cantidad_de_JRV, s.id_estado_sede AS id_Estado_CentroVotación, s.id_municipio AS id_Municipio, s.id_organizacion AS id_Tribunal FROM tb_sede s";
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
        /// Carga los estados posibles de una mesa de votación.
        /// </summary>
        /// <returns>Tabla con id y nombre del estado, o <c>null</c> si hay error.</returns>
        public static DataTable CargarEstadoJRV()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_estado_mesa AS id_Estado_JRV, nombre_estado AS Nombre_Estado_JRV FROM tb_estado_mesa";
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
        /// Obtiene el listado de mesas con su sede y estado.
        /// </summary>
        /// <returns>Tabla con datos de mesas y relaciones, o <c>null</c> si hay error.</returns>
        public static DataTable CargarTablaJRV()
        {
            DataTable data;
            try
            {
                string query = "SELECT m.id_mesa AS id_JRV, m.codigo_mesa AS Correlativo_JRV, s.nombre_sede AS Nombre_Centro_Votación, e.nombre_estado AS Nombre_Estado_JRV FROM tb_mesa m INNER JOIN tb_sede s ON m.id_sede = s.id_sede INNER JOIN tb_estado_mesa e ON m.id_estado_mesa = e.id_estado_mesa";
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
        /// Registra una nueva mesa de votación.
        /// </summary>
        /// <param name="correlativo">Código correlativo de la mesa.</param>
        /// <param name="centrovotacion">Identificador de la sede de votación.</param>
        /// <param name="estadojrv">Identificador del estado de la mesa.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarJRV(string correlativo, int centrovotacion, int estadojrv)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_mesa (codigo_mesa, id_sede, id_estado_mesa) VALUE('{0}','{1}','{2}')", correlativo, centrovotacion, estadojrv), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Busca un centro de votación por su nombre.
        /// </summary>
        /// <param name="id">Nombre de la sede a buscar.</param>
        /// <returns>Tabla con los datos de la sede, o <c>null</c> si hay error.</returns>
        public static DataTable CargarCVInner(string id)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_sede AS id_Centro_Votación, nombre_sede AS Nombre_Centro_Votación FROM tb_sede WHERE nombre_sede = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", id));
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
        /// Busca un estado de mesa por su nombre.
        /// </summary>
        /// <param name="id">Nombre del estado a buscar.</param>
        /// <returns>Tabla con los datos del estado, o <c>null</c> si hay error.</returns>
        public static DataTable CargarEstadoJRVInner(string id)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_estado_mesa AS id_Estado_JRV, nombre_estado AS Nombre_Estado_JRV FROM tb_estado_mesa WHERE nombre_estado = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", id));
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
        /// Actualiza los datos de una mesa de votación existente.
        /// </summary>
        /// <param name="id">Identificador de la mesa.</param>
        /// <param name="correlativo">Código correlativo de la mesa.</param>
        /// <param name="centrovotacion">Identificador de la sede de votación.</param>
        /// <param name="estadojrv">Identificador del estado de la mesa.</param>
        /// <returns><c>true</c> si la actualización fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool ActualizarJRV(int id, string correlativo, int centrovotacion, int estadojrv)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tb_mesa SET codigo_mesa = '" + correlativo + "', id_sede = '" + centrovotacion + "', id_estado_mesa = '" + estadojrv + "' WHERE id_mesa = '" + id + "'"), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Elimina una mesa de votación por su identificador.
        /// </summary>
        /// <param name="id">Identificador de la mesa a eliminar.</param>
        /// <returns>1 si se eliminó correctamente, 2 si no se encontró fila, -1 si hay error.</returns>
        public static int EliminarJRV(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tb_mesa WHERE id_mesa = '" + id + "'  "), Conexion.getConnect());
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
