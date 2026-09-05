using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>
    /// Capa Modelo: acceso a datos MySQL. CRUD de grupos de opciones (plantilla genérica de votación).
    /// Tabla física: tb_grupo_opciones.
    /// </summary>
    public class ModelPartido
    {
        /// <summary>
        /// Carga los estados posibles de un grupo de opciones.
        /// </summary>
        /// <returns>Tabla con id y nombre del estado, o <c>null</c> si hay error.</returns>
        public static DataTable CargarEstadoOrganizacion()
        {
            DataTable data;
            try
            {
                string query = "SELECT e.id_estado_grupo AS id_Estado_Partido, e.nombre_estado AS Estado_Partido FROM tb_estado_grupo e";
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
        /// Registra un nuevo grupo de opciones.
        /// </summary>
        /// <param name="imagen">Imagen en formato codificado.</param>
        /// <param name="nombreGrupoOpciones">Nombre del grupo.</param>
        /// <param name="cantidadVotos">Total de votos del grupo.</param>
        /// <param name="idEstadoOrganizacion">Identificador del estado del grupo.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarOrganizacion(string imagen, string nombreGrupoOpciones, int cantidadVotos, int idEstadoOrganizacion)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_grupo_opciones (imagen, nombre_grupo, total_votos, id_estado_grupo) VALUES ('{0}', '{1}', '{2}', '{3}')", imagen, nombreGrupoOpciones, cantidadVotos, idEstadoOrganizacion), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Recupera la imagen de un grupo de opciones decodificada desde Base64.
        /// </summary>
        /// <param name="idOrganizacion">Identificador del grupo de opciones.</param>
        /// <returns>Bytes de la imagen, o <c>null</c> si no existe o hay error.</returns>
        public static byte[] RecuperarImagenOrganizacion(int idOrganizacion)
        {
            try
            {
                string query = "SELECT imagen FROM tb_grupo_opciones WHERE id_grupo_opciones = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idOrganizacion));
                using (MySqlDataReader reader = cmdselect.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return Convert.FromBase64String(reader.GetString(0));
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Obtiene el listado de grupos de opciones con su estado.
        /// </summary>
        /// <returns>Tabla con datos de grupos y estados, o <c>null</c> si hay error.</returns>
        public static DataTable CargarOrganizaciones()
        {
            DataTable data;
            try
            {
                string query = "SELECT g.id_grupo_opciones AS id_Partido, g.imagen AS Imagen_Partido, g.nombre_grupo AS Nombre_Partido, g.total_votos AS Cantidad_Votos, e.nombre_estado AS Estado_Partido FROM tb_grupo_opciones g INNER JOIN tb_estado_grupo e ON g.id_estado_grupo = e.id_estado_grupo";
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
        /// Obtiene un estado de grupo de opciones por su identificador.
        /// </summary>
        /// <param name="idEstadoOrganizacion">Identificador del estado.</param>
        /// <returns>Tabla con los datos del estado, o <c>null</c> si hay error.</returns>
        public static DataTable CargarEstadoOrganizacionPorId(string idEstadoOrganizacion)
        {
            DataTable data;
            try
            {
                string query = "SELECT e.id_estado_grupo AS id_Estado_Partido, e.nombre_estado AS Estado_Partido FROM tb_estado_grupo e WHERE e.id_estado_grupo = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idEstadoOrganizacion));
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
        /// Actualiza los datos de un grupo de opciones existente.
        /// </summary>
        /// <param name="idOrganizacion">Identificador del grupo.</param>
        /// <param name="imagen">Imagen en formato codificado.</param>
        /// <param name="nombreGrupoOpciones">Nombre del grupo.</param>
        /// <param name="cantidadVotos">Total de votos del grupo.</param>
        /// <param name="idEstadoOrganizacion">Identificador del estado del grupo.</param>
        /// <returns><c>true</c> si la actualización fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool ActualizarOrganizacion(int idOrganizacion, string imagen, string nombreGrupoOpciones, int cantidadVotos, int idEstadoOrganizacion)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tb_grupo_opciones SET imagen = '" + imagen + "', nombre_grupo = '" + nombreGrupoOpciones + "', total_votos = '" + cantidadVotos + "', id_estado_grupo = '" + idEstadoOrganizacion + "' WHERE id_grupo_opciones = '" + idOrganizacion + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Elimina un grupo de opciones por su identificador.
        /// </summary>
        /// <param name="idOrganizacion">Identificador del grupo a eliminar.</param>
        /// <returns>1 si se eliminó correctamente, 2 si no se encontró fila, -1 si hay error.</returns>
        public static int EliminarOrganizacion(int idOrganizacion)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tb_grupo_opciones WHERE id_grupo_opciones = '" + idOrganizacion + "' "), Conexion.getConnect());
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
