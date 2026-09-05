using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace Modelo
{
    /// <summary>
    /// Capa Modelo: acceso a datos MySQL. Autenticación y gestión de sesión de usuario.
    /// Tablas físicas: tb_usuario, tb_participante, tb_rol, tb_sede, tb_mesa, tb_organizacion.
    /// </summary>
    public class ModelLogin
    {
        /// <summary>
        /// Valida las credenciales de un usuario por nombre y contraseña.
        /// </summary>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <param name="Clave_Usuario">Contraseña del usuario.</param>
        /// <returns>1 si las credenciales son válidas, 2 si son inválidas, 3 si hay error.</returns>
        public static int Acceso(string usuario, string Clave_Usuario)
        {
            int retorno = 0;
            bool retornoaux;
            try
            {
                string query = "SELECT * FROM tb_usuario tu WHERE tu.nombre_usuario = BINARY ?param1 AND tu.clave = BINARY ?param2";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", usuario));
                cmdselect.Parameters.Add(new MySqlParameter("param2", Clave_Usuario));
                retornoaux = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (retornoaux == true)
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
                return retorno = 3;
            }
        }

        /// <summary>
        /// Valida la existencia de un participante por su DUI.
        /// </summary>
        /// <param name="DUI">Documento único de identidad.</param>
        /// <returns>1 si el DUI existe, 2 si no existe, 3 si hay error.</returns>
        public static int Acceso2(string DUI)
        {
            int retorno = 0;
            bool retornoDUI;
            try
            {
                string query = "SELECT * FROM tb_participante WHERE documento_identidad = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", DUI));
                retornoDUI = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (retornoDUI == true)
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
                return retorno = 3;
            }
        }

        /// <summary>
        /// Valida la existencia de un participante por su código OCR.
        /// </summary>
        /// <param name="OCR">Código OCR del documento.</param>
        /// <returns>1 si el OCR existe, 2 si no existe, 3 si hay error.</returns>
        public static int Acceso3(string OCR)
        {
            int retorno = 0;
            bool retornoOCR;
            try
            {
                string query = "SELECT * FROM tb_participante WHERE codigo_ocr = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", OCR));
                retornoOCR = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (retornoOCR == true)
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
                return retorno = 3;
            }
        }

        /// <summary>
        /// Obtiene los datos completos de un usuario autenticado por nombre de usuario.
        /// </summary>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <returns>Lista con datos de usuario, participante y rol, o <c>null</c> si no se encuentra o hay error.</returns>
        public static List<string>ObtenerDatos(string usuario)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT tu.nombre_usuario, tu.intentos_fallidos, tu.id_estado_usuario, tu.id_rol, COALESCE(CAST(tu.id_participante AS CHAR), '0'), COALESCE(tm.nombre, ''), COALESCE(tm.apellido, ''), COALESCE(tm.documento_identidad, ''), COALESCE(CAST(COALESCE(tm.id_sede, tu.id_sede) AS CHAR), '0'), COALESCE(CAST(COALESCE(tm.id_mesa, tu.id_mesa) AS CHAR), '0'), r.nombre_rol FROM tb_usuario tu INNER JOIN tb_rol r ON tu.id_rol = r.id_rol LEFT JOIN tb_participante tm ON tu.id_participante = tm.id_participante WHERE tu.nombre_usuario = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", usuario));
                MySqlDataReader reader = cmdselect.ExecuteReader();

                while (reader.Read())
                {
                    datos = new List<string>();
                    datos.Add(reader.GetString(0));
                    datos.Add(reader.GetString(1));
                    datos.Add(reader.GetString(2));
                    datos.Add(reader.GetString(3));
                    datos.Add(reader.GetString(4));
                    datos.Add(reader.GetString(5));
                    datos.Add(reader.GetString(6));
                    datos.Add(reader.GetString(7));
                    datos.Add(reader.GetString(8));
                    datos.Add(reader.GetString(9));
                    datos.Add(reader.GetString(10));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        /// <summary>
        /// Obtiene los datos de un participante por su DUI.
        /// </summary>
        /// <param name="DUI">Documento único de identidad.</param>
        /// <returns>Lista con campos del participante, o <c>null</c> si no se encuentra o hay error.</returns>
        public static List<string> ObtenerDatos2(string DUI)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT * FROM tb_participante WHERE documento_identidad = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", DUI));
                MySqlDataReader reader = cmdselect.ExecuteReader();

                while (reader.Read())
                {
                    datos = new List<string>();
                    datos.Add(reader.GetString(0));
                    datos.Add(reader.GetString(1));
                    datos.Add(reader.GetString(2));
                    datos.Add(reader.GetString(3));
                    datos.Add(reader.GetString(9));
                    datos.Add(reader.GetString(10));
                    datos.Add(reader.GetString(11));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        /// <summary>
        /// Cuenta el número de organizaciones electorales registradas.
        /// </summary>
        /// <returns>Cantidad de organizaciones, o -1 si hay error.</returns>
        public static int ObtenerTribunal()
        {
            int retorno;
            try
            {
                string query = "SELECT COUNT(*) FROM tb_organizacion";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                retorno = Convert.ToInt16(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = -1;
            }
        }

        /// <summary>
        /// Cuenta el número de usuarios registrados en el sistema.
        /// </summary>
        /// <returns>Cantidad de usuarios, o -1 si hay error.</returns>
        public static int ObtenerUsuarios()
        {
            int retorno;
            try
            {
                string query = "SELECT COUNT(*) FROM tb_usuario";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                retorno = Convert.ToInt16(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = -1;
            }
        }

        /// <summary>
        /// Verifica si un usuario tiene registradas las horas de bloqueo y desbloqueo indicadas.
        /// </summary>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <param name="horaB">Hora de bloqueo.</param>
        /// <param name="horaD">Hora de desbloqueo.</param>
        /// <returns><c>true</c> si coinciden las horas; <c>false</c> si no coinciden o hay error.</returns>
        public static bool ExistenciaHora(string usuario, string horaB, string horaD)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tb_usuario WHERE nombre_usuario = BINARY ?param1 AND hora_bloqueo = BINARY ?param2 AND hora_desbloqueo = BINARY ?param3";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", usuario));
                cmdselect.Parameters.Add(new MySqlParameter("param2", horaB));
                cmdselect.Parameters.Add(new MySqlParameter("param3", horaD));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Actualiza el contador de intentos fallidos de un usuario.
        /// </summary>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <param name="intento">Número de intentos fallidos.</param>
        /// <returns><c>true</c> si la actualización fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool ActualizarIntentos(string usuario, int intento)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tb_usuario SET intentos_fallidos = '" + intento + "' WHERE nombre_usuario = BINARY ?param1"), Conexion.getConnect());
                cmdinsert.Parameters.Add(new MySqlParameter("param1", usuario));
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Registra las horas de bloqueo y desbloqueo de un usuario.
        /// </summary>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <param name="horaI">Hora de inicio del bloqueo.</param>
        /// <param name="horaA">Hora de desbloqueo.</param>
        /// <returns><c>true</c> si la actualización fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarHoraI(string usuario, string horaI, string horaA)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tb_usuario SET hora_bloqueo = '" + horaI + "', hora_desbloqueo = '"+ horaA +"' WHERE nombre_usuario = BINARY ?param1"), Conexion.getConnect());
                cmdinsert.Parameters.Add(new MySqlParameter("param1", usuario));
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Obtiene las horas de bloqueo y desbloqueo de un usuario.
        /// </summary>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <returns>Lista con hora de bloqueo y desbloqueo, o <c>null</c> si no se encuentra o hay error.</returns>
        public static List<string> ObtenerHora(string usuario)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT tu.hora_bloqueo, tu.hora_desbloqueo FROM tb_usuario tu WHERE tu.nombre_usuario = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", usuario));
                MySqlDataReader reader = cmdselect.ExecuteReader();

                while (reader.Read())
                {
                    datos = new List<string>();
                    datos.Add(reader.GetString(0));
                    datos.Add(reader.GetString(1));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        /// <summary>
        /// Actualiza el estado de un usuario.
        /// </summary>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <param name="EstadoU">Identificador del nuevo estado.</param>
        /// <returns><c>true</c> si la actualización fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool ActualizarEstado(string usuario, int EstadoU)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tb_usuario SET id_estado_usuario = '"+ EstadoU +"' WHERE nombre_usuario = '" + usuario + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Obtiene el nombre de un centro de votación por su identificador.
        /// </summary>
        /// <param name="id">Identificador de la sede.</param>
        /// <returns>Lista con el nombre de la sede, o <c>null</c> si no se encuentra o hay error.</returns>
        public static List<string> ObtenerCV(int id)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT nombre_sede FROM tb_sede WHERE id_sede = '"+ id +"'  ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataReader reader = cmdselect.ExecuteReader();
                while (reader.Read())
                {
                    datos = new List<string>();
                    datos.Add(reader.GetString(0));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        /// <summary>
        /// Obtiene el código correlativo de una mesa por su identificador.
        /// </summary>
        /// <param name="id">Identificador de la mesa.</param>
        /// <returns>Lista con el correlativo de la mesa, o <c>null</c> si no se encuentra o hay error.</returns>
        public static List<string> ObtenerJRV(int id)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT codigo_mesa FROM tb_mesa WHERE id_mesa = '" + id + "'  ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataReader reader = cmdselect.ExecuteReader();
                while (reader.Read())
                {
                    datos = new List<string>();
                    datos.Add(reader.GetString(0));
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
