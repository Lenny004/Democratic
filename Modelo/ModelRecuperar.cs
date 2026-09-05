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
    /// Capa Modelo: acceso a datos MySQL. Recuperación de contraseña de usuario.
    /// Tabla física: tb_usuario.
    /// </summary>
    public class ModelRecuperar
    {
        /// <summary>
        /// Verifica si existe un usuario con el correo o nombre de usuario indicado.
        /// </summary>
        /// <param name="correo">Correo o nombre de usuario a buscar.</param>
        /// <returns><c>true</c> si el usuario existe; <c>false</c> si no existe o hay error.</returns>
        public static bool ExistenciaCorreo(string correo)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tb_usuario WHERE nombre_usuario = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", correo));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Actualiza la contraseña de un usuario existente.
        /// </summary>
        /// <param name="correo2">Correo o nombre de usuario del usuario.</param>
        /// <param name="contraUpd">Nueva contraseña.</param>
        /// <returns><c>true</c> si la actualización fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool ActualizarContraseña(string correo2, string contraUpd)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tb_usuario SET clave = '" + contraUpd + "' WHERE nombre_usuario = '" + correo2 + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
    }
}
