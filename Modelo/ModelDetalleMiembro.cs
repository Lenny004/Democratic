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
    /// Capa Modelo: acceso a datos MySQL. CRUD de detalle de participantes por mesa.
    /// Tablas físicas: tb_detalle_participante, tb_mesa, tb_participante.
    /// </summary>
    public class ModelDetalleMiembro
    {
        /// <summary>
        /// Carga el listado de mesas de votación para el detalle de participantes.
        /// </summary>
        /// <returns>Tabla con datos de mesas, o <c>null</c> si hay error.</returns>
        public static DataTable CargarDetalleMiembrosJRV()
        {
            DataTable data;
            try
            {
                string query = "SELECT m.id_mesa AS id_JRV, m.codigo_mesa AS Correlativo_JRV, m.id_sede AS id_Centro_Votación, m.id_estado_mesa AS id_Estado_JRV FROM tb_mesa m";
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
        /// Carga el listado de participantes para el detalle por mesa.
        /// </summary>
        /// <returns>Tabla con id_Miembro y Nombre_Miembro, o <c>null</c> si hay error.</returns>
        public static DataTable CargarDetalleMiembrosMiembro()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_participante AS id_Miembro, nombre AS Nombre_Miembro FROM tb_participante";
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
        /// Obtiene el listado completo de detalles de participantes por mesa.
        /// </summary>
        /// <returns>Tabla con datos del detalle y relaciones, o <c>null</c> si hay error.</returns>
        public static DataTable CargarDatosDetalleMiembros()
        {
            DataTable data;
            try
            {
                string query = "SELECT d.id_detalle AS id_Detalle, d.detalle AS Detalle_de_Miembros, d.id_participante AS id_Miembro, d.id_mesa AS id_JRV FROM tb_detalle_participante d";
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
        /// Registra un nuevo detalle de participante asociado a una mesa.
        /// </summary>
        /// <param name="Detalle_de_Miembros">Texto descriptivo del detalle.</param>
        /// <param name="id_Miembro">Identificador del participante.</param>
        /// <param name="id_JRV">Identificador de la mesa.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarDetalleMiembros(string Detalle_de_Miembros, int id_Miembro, int id_JRV)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_detalle_participante (detalle, id_participante, id_mesa) VALUES ('{0}', '{1}', '{2}')", Detalle_de_Miembros, id_Miembro, id_JRV), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Actualiza un detalle de participante existente.
        /// </summary>
        /// <param name="id_Detalle">Identificador del detalle.</param>
        /// <param name="Detalle_De_Miembros">Texto descriptivo del detalle.</param>
        /// <param name="id_Miembro">Identificador del participante.</param>
        /// <param name="id_JRV">Identificador de la mesa.</param>
        /// <returns><c>true</c> si la actualización fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool ActualizarDetalleMiembros(int id_Detalle, string Detalle_De_Miembros, int id_Miembro, int id_JRV)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tb_detalle_participante SET detalle = '" + Detalle_De_Miembros + "', id_participante = '" + id_Miembro + "', id_mesa = '" + id_JRV + "' WHERE id_detalle = '" + id_Detalle + "' "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Elimina un detalle de participante por su identificador.
        /// </summary>
        /// <param name="id">Identificador del detalle a eliminar.</param>
        /// <returns>1 si se eliminó correctamente, 2 si no se encontró fila, -1 si hay error.</returns>
        public static int EliminarDetalleMiembro(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tb_detalle_participante WHERE id_detalle = '" + id + "' "), Conexion.getConnect());
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

        /// <summary>
        /// Obtiene una mesa de votación por su identificador para el detalle de participantes.
        /// </summary>
        /// <param name="id_JRV">Identificador de la mesa.</param>
        /// <returns>Tabla con id_JRV y Correlativo_JRV, o <c>null</c> si hay error.</returns>
        public static DataTable CargarDetalleMiembroJRVInner(string id_JRV)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_mesa AS id_JRV, codigo_mesa AS Correlativo_JRV FROM tb_mesa WHERE id_mesa = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", id_JRV));
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
        /// Obtiene un participante por su identificador para el detalle por mesa.
        /// </summary>
        /// <param name="id_Miembro">Identificador del participante.</param>
        /// <returns>Tabla con id_Miembro y Nombre_Miembro, o <c>null</c> si hay error.</returns>
        public static DataTable CargarDetalleMiembroMiembroInner(string id_Miembro)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_participante AS id_Miembro, nombre AS Nombre_Miembro FROM tb_participante WHERE id_participante = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", id_Miembro));
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
