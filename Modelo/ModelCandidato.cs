using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>
    /// Capa Modelo: acceso a datos MySQL. CRUD de opciones de votación (plantilla genérica).
    /// Tablas físicas: tb_opcion, tb_grupo_opciones, tb_estado_opcion.
    /// </summary>
    public class ModelCandidato
    {
        /// <summary>
        /// Lista los grupos de opciones disponibles para asociar a una opción.
        /// </summary>
        /// <returns>Tabla con id_Partido y Nombre_Partido, o <c>null</c> si hay error.</returns>
        public static DataTable CargarGruposOpciones()
        {
            DataTable data;
            try
            {
                string query = "SELECT g.id_grupo_opciones AS id_Partido, g.nombre_grupo AS Nombre_Partido FROM tb_grupo_opciones g";
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
        /// Carga los estados posibles de una opción de votación.
        /// </summary>
        /// <returns>Tabla con id y nombre del estado, o <c>null</c> si hay error.</returns>
        public static DataTable CargarEstadoOpcion()
        {
            DataTable data;
            try
            {
                string query = "SELECT e.id_estado_opcion AS id_Estado_Candidato, e.nombre_estado AS Estado_Candidato FROM tb_estado_opcion e";
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
        /// Obtiene el listado de opciones con su grupo y estado.
        /// </summary>
        /// <returns>Tabla con datos de opciones y relaciones, o <c>null</c> si hay error.</returns>
        public static DataTable CargarOpciones()
        {
            DataTable data;
            try
            {
                string query = "SELECT o.id_opcion AS id_Candidato, o.nombre AS Nombre_Candidato, o.apellido AS Apellido_Candidato, o.genero AS Género, o.imagen AS Imagen_Candidato, g.nombre_grupo AS Nombre_Partido, e.nombre_estado AS Estado_Candidato FROM tb_opcion o INNER JOIN tb_grupo_opciones g ON g.id_grupo_opciones = o.id_grupo_opciones INNER JOIN tb_estado_opcion e ON e.id_estado_opcion = o.id_estado_opcion";
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
        /// Registra una nueva opción de votación.
        /// </summary>
        /// <param name="nombreOpcion">Nombre de la opción.</param>
        /// <param name="apellidoOpcion">Apellido de la opción.</param>
        /// <param name="genero">Género.</param>
        /// <param name="imagenOpcion">Imagen en formato codificado.</param>
        /// <param name="idGrupoOpciones">Identificador del grupo de opciones.</param>
        /// <param name="idEstadoOpcion">Identificador del estado de la opción.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarOpcion(string nombreOpcion, string apellidoOpcion, string genero, string imagenOpcion, int idGrupoOpciones, int idEstadoOpcion)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_opcion (nombre, apellido, genero, imagen, id_grupo_opciones, id_estado_opcion) VALUES ('{0}', '{1}', '{2}', '{3}','{4}','{5}')", nombreOpcion, apellidoOpcion, genero, imagenOpcion, idGrupoOpciones, idEstadoOpcion), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
            finally
            {
                Conexion.getConnect().Close();
            }
        }

        /// <summary>
        /// Busca un estado de opción por su nombre.
        /// </summary>
        /// <param name="estadoOpcion">Nombre del estado a buscar.</param>
        /// <returns>Tabla con los datos del estado, o <c>null</c> si hay error.</returns>
        public static DataTable CargarEstadoOpcionPorNombre(string estadoOpcion)
        {
            DataTable data;
            try
            {
                string query = "SELECT e.id_estado_opcion AS id_Estado_Candidato, e.nombre_estado AS Estado_Candidato FROM tb_estado_opcion e WHERE e.nombre_estado = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", estadoOpcion));
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
        /// <param name="nombreGrupoOpciones">Nombre del grupo a buscar.</param>
        /// <returns>Tabla con los datos del grupo, o <c>null</c> si hay error.</returns>
        public static DataTable CargarGrupoOpcionesPorNombre(string nombreGrupoOpciones)
        {
            DataTable data;
            try
            {
                string query = "SELECT g.id_grupo_opciones AS id_Partido, g.nombre_grupo AS Nombre_Partido, g.imagen AS Imagen_Partido, g.total_votos AS Cantidad_Votos, g.id_estado_grupo AS id_Estado_Partido FROM tb_grupo_opciones g WHERE g.nombre_grupo = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", nombreGrupoOpciones));
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
        /// Recupera la imagen de una opción decodificada desde Base64.
        /// </summary>
        /// <param name="idOpcion">Identificador de la opción.</param>
        /// <returns>Bytes de la imagen, o <c>null</c> si no existe o hay error.</returns>
        public static byte[] RecuperarImagenOpcion(int idOpcion)
        {
            try
            {
                string query = "SELECT imagen FROM tb_opcion WHERE id_opcion = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idOpcion));
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
        /// Actualiza los datos de una opción de votación existente.
        /// </summary>
        /// <param name="idOpcion">Identificador de la opción.</param>
        /// <param name="nombreOpcion">Nombre de la opción.</param>
        /// <param name="apellidoOpcion">Apellido de la opción.</param>
        /// <param name="genero">Género.</param>
        /// <param name="imagenOpcion">Imagen en formato codificado.</param>
        /// <param name="idGrupoOpciones">Identificador del grupo de opciones.</param>
        /// <param name="idEstadoOpcion">Identificador del estado de la opción.</param>
        /// <returns><c>true</c> si la actualización fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool ActualizarOpcion(int idOpcion, string nombreOpcion, string apellidoOpcion, string genero, string imagenOpcion, int idGrupoOpciones, int idEstadoOpcion)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tb_opcion SET nombre = '" + nombreOpcion + "', apellido = '" + apellidoOpcion + "', genero = '" + genero + "', imagen = '" + imagenOpcion + "', id_grupo_opciones = '" + idGrupoOpciones + "', id_estado_opcion = '" + idEstadoOpcion + "' WHERE id_opcion = '" + idOpcion + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Elimina una opción de votación por su identificador.
        /// </summary>
        /// <param name="idOpcion">Identificador de la opción a eliminar.</param>
        /// <returns>1 si se eliminó correctamente, 2 si no se encontró fila, -1 si hay error.</returns>
        public static int EliminarOpcion(int idOpcion)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tb_opcion WHERE id_opcion = '" + idOpcion + "' "), Conexion.getConnect());
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
        /// Vacía la tabla de opciones de votación.
        /// </summary>
        /// <returns><c>true</c> si la operación fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool TruncateOpciones()
        {
            bool retorno;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("TRUNCATE TABLE tb_opcion"), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
    }
}

