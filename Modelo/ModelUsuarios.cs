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
    /// Capa Modelo: acceso a datos MySQL. CRUD de usuarios del sistema.
    /// Tablas físicas: tb_usuario, tb_rol, tb_estado_usuario, tb_sede, tb_mesa, tb_participante.
    /// </summary>
    public class ModelUsuarios
    {
        /// <summary>
        /// Carga los estados posibles de un usuario.
        /// </summary>
        /// <returns>Tabla con id y nombre del estado, o <c>null</c> si hay error.</returns>
        public static DataTable CargarEstadosUser()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_estado_usuario AS id_Estado_Usuario, nombre_estado AS Estado_Usuario FROM tb_estado_usuario";
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
        /// Carga los tipos o roles de usuario disponibles.
        /// </summary>
        /// <returns>Tabla con id y nombre del rol, o <c>null</c> si hay error.</returns>
        public static DataTable CargarTipoUser()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_rol AS id_Tipo_Usuario, nombre_rol AS Tipo_Usuario FROM tb_rol";
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
        /// Carga el listado de mesas de votación (JRV).
        /// </summary>
        /// <returns>Tabla con id_JRV y Correlativo_JRV, o <c>null</c> si hay error.</returns>
        public static DataTable CargarJRV()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_mesa AS id_JRV, codigo_mesa AS Correlativo_JRV FROM tb_mesa";
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
        /// Carga el listado de participantes disponibles para asociar a usuarios.
        /// </summary>
        /// <returns>Tabla con id_Miembro y Nombre_Miembro, o <c>null</c> si hay error.</returns>
        public static DataTable CargarMiembrosUser()
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
        /// Obtiene el listado completo de usuarios con sus relaciones.
        /// </summary>
        /// <returns>Tabla con datos de usuarios, roles, sedes y participantes, o <c>null</c> si hay error.</returns>
        public static DataTable CargarUsuario()
        {
            DataTable data;
            try
            {
                string query = "SELECT u.id_usuario AS id_Usuario, u.nombre_usuario AS Usuario, u.clave AS Clave_Usuario, u.intentos_fallidos AS intento, eu.nombre_estado AS Estado_Usuario, r.nombre_rol AS Tipo_Usuario, s.nombre_sede AS Nombre_Centro_Votación, p.nombre AS Nombre_Miembro FROM tb_usuario u INNER JOIN tb_estado_usuario eu ON u.id_estado_usuario = eu.id_estado_usuario INNER JOIN tb_rol r ON u.id_rol = r.id_rol INNER JOIN tb_sede s ON u.id_sede = s.id_sede INNER JOIN tb_participante p ON u.id_participante = p.id_participante";
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
        /// Registra un nuevo usuario del sistema.
        /// </summary>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <param name="clave">Contraseña.</param>
        /// <param name="intento">Número de intentos fallidos.</param>
        /// <param name="Estado_Usuario">Identificador del estado del usuario.</param>
        /// <param name="Tipo_Usuario">Identificador del rol.</param>
        /// <param name="JRV">Identificador de la mesa asignada.</param>
        /// <param name="id_Miembro">Identificador del participante asociado.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarUsuario(string usuario, string clave, int intento, int Estado_Usuario, int Tipo_Usuario, int JRV, int id_Miembro)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_usuario (nombre_usuario, clave, intentos_fallidos, id_estado_usuario, id_rol, id_mesa, id_participante) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", usuario, clave, intento, Estado_Usuario, Tipo_Usuario, JRV, id_Miembro), Conexion.getConnect());
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
        /// Registra el primer usuario administrador del sistema (sin mesa ni participante).
        /// </summary>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <param name="clave">Contraseña.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarUsuarioRoot(string usuario, string clave)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_usuario (nombre_usuario, clave, intentos_fallidos, id_estado_usuario, id_rol) VALUES ('{0}','{1}',0,1,1)", usuario, clave), Conexion.getConnect());
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
        /// Busca un estado de usuario por su nombre.
        /// </summary>
        /// <param name="idEstado_Usuario">Nombre del estado a buscar.</param>
        /// <returns>Tabla con los datos del estado, o <c>null</c> si hay error.</returns>
        public static DataTable CargarEstadoUsuarioInner(string idEstado_Usuario)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_estado_usuario AS id_Estado_Usuario, nombre_estado AS Estado_Usuario FROM tb_estado_usuario WHERE nombre_estado = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idEstado_Usuario));
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
        /// Busca un tipo de usuario (rol) por su nombre.
        /// </summary>
        /// <param name="idTipo_usuario">Nombre del rol a buscar.</param>
        /// <returns>Tabla con los datos del rol, o <c>null</c> si hay error.</returns>
        public static DataTable CargarTipoUsuarioInner(string idTipo_usuario)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_rol AS id_Tipo_Usuario, nombre_rol AS Tipo_Usuario FROM tb_rol WHERE nombre_rol = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idTipo_usuario));
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
        /// Busca un centro de votación por su nombre.
        /// </summary>
        /// <param name="idCentro_Votacion">Nombre de la sede a buscar.</param>
        /// <returns>Tabla con los datos de la sede, o <c>null</c> si hay error.</returns>
        public static DataTable CargarCentroVotacionUsuarioInner(string idCentro_Votacion)
        {
            DataTable data;
            try
            {
                string query = "SELECT s.id_sede AS id_Centro_Votación, s.nombre_sede AS Nombre_Centro_Votación, s.id_registro_escrutinio AS id_Acta, s.cantidad_mesas AS Cantidad_de_JRV, s.id_estado_sede AS id_Estado_CentroVotación, s.id_municipio AS id_Municipio, s.id_organizacion AS id_Tribunal FROM tb_sede s WHERE s.nombre_sede = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idCentro_Votacion));
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
        /// Obtiene un centro de votación por su identificador numérico.
        /// </summary>
        /// <param name="idCentro_Votacion">Identificador de la sede.</param>
        /// <returns>Tabla con los datos de la sede, o <c>null</c> si hay error.</returns>
        public static DataTable CargarCentroVotacionUsuarioInner2(int idCentro_Votacion)
        {
            DataTable data;
            try
            {
                string query = "SELECT s.id_sede AS id_Centro_Votación, s.nombre_sede AS Nombre_Centro_Votación, s.id_registro_escrutinio AS id_Acta, s.cantidad_mesas AS Cantidad_de_JRV, s.id_estado_sede AS id_Estado_CentroVotación, s.id_municipio AS id_Municipio, s.id_organizacion AS id_Tribunal FROM tb_sede s WHERE s.id_sede = '" + idCentro_Votacion + "'";
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
        /// Busca una mesa de votación por su código correlativo.
        /// </summary>
        /// <param name="id_JRV">Código correlativo de la mesa.</param>
        /// <returns>Tabla con los datos de la mesa, o <c>null</c> si hay error.</returns>
        public static DataTable CargarJRVInner(string id_JRV)
        {
            DataTable data;
            try
            {
                string query = "SELECT m.id_mesa AS id_JRV, m.codigo_mesa AS Correlativo_JRV, m.id_sede AS id_Centro_Votación, m.id_estado_mesa AS id_Estado_JRV FROM tb_mesa m WHERE m.codigo_mesa = ?param1";
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
        /// Obtiene una mesa de votación por su identificador numérico.
        /// </summary>
        /// <param name="id_JRV">Identificador de la mesa.</param>
        /// <returns>Tabla con los datos de la mesa, o <c>null</c> si hay error.</returns>
        public static DataTable CargarJRVInner2(int id_JRV)
        {
            DataTable data;
            try
            {
                string query = "SELECT m.id_mesa AS id_JRV, m.codigo_mesa AS Correlativo_JRV, m.id_sede AS id_Centro_Votación, m.id_estado_mesa AS id_Estado_JRV FROM tb_mesa m WHERE m.id_mesa = '" + id_JRV + "'";
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
        /// Busca un participante por su nombre para asociarlo a un usuario.
        /// </summary>
        /// <param name="idMiembro">Nombre del participante a buscar.</param>
        /// <returns>Tabla con los datos del participante, o <c>null</c> si hay error.</returns>
        public static DataTable CargarMiembroUsuarioInner(string idMiembro)
        {
            DataTable data;
            try
            {
                string query = "SELECT p.id_participante AS id_Miembro, p.nombre AS Nombre_Miembro, p.apellido AS Apellido_Miembro, p.documento_identidad AS DUI, p.codigo_ocr AS OCR, p.imagen AS Imagen_Miembro, p.fecha_nacimiento AS Fecha_de_nacimiento, p.direccion AS Dirección_Usuario, p.telefono AS Numero_Telefonico, p.id_sede AS id_Centro_Votación, p.id_mesa AS id_JRV, p.id_estado_participante AS id_Estado_Miembros FROM tb_participante p WHERE p.nombre = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idMiembro));
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
        /// Actualiza los datos de un usuario existente.
        /// </summary>
        /// <param name="idusuario">Identificador del usuario.</param>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <param name="clave">Contraseña.</param>
        /// <param name="intento">Número de intentos fallidos.</param>
        /// <param name="Estado_Usuario">Identificador del estado del usuario.</param>
        /// <param name="Tipo_Usuario">Identificador del rol.</param>
        /// <param name="JRV">Identificador de la mesa asignada.</param>
        /// <param name="id_Miembro">Identificador del participante asociado.</param>
        /// <returns><c>true</c> si la actualización fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool ActualizarUsuario(int idusuario, string usuario, string clave, int intento, int Estado_Usuario, int Tipo_Usuario, int JRV, int id_Miembro)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tb_usuario SET nombre_usuario = '" + usuario + "', clave = '" + clave + "', intentos_fallidos = '" + intento + "', id_estado_usuario = '" + Estado_Usuario + "', id_rol = '" + Tipo_Usuario + "', id_mesa = '" + JRV + "', id_participante = '" + id_Miembro + "' WHERE id_usuario = '" + idusuario + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Elimina un usuario por su identificador.
        /// </summary>
        /// <param name="id">Identificador del usuario a eliminar.</param>
        /// <returns>1 si se eliminó correctamente, 2 si no se encontró fila, -1 si hay error.</returns>
        public static int EliminarUsuario(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tb_usuario WHERE id_usuario = '" + id + "' "), Conexion.getConnect());
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
