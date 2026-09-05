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
    /// Capa Modelo: acceso a datos MySQL. Registro de usuarios vinculados
    /// a participantes del padrón. Tablas físicas: tb_participante, tb_organizacion, tb_usuario.
    /// </summary>
    public class ModelRegistro
    {
        /// <summary>
        /// Verifica si ya existe un participante con el DUI indicado.
        /// </summary>
        /// <param name="DUI">Documento único de identidad.</param>
        /// <returns><c>true</c> si el participante existe; <c>false</c> si no existe o hay error.</returns>
        public static bool Existencia(string DUI)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tb_participante WHERE documento_identidad = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", DUI));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Busca los datos de un participante por su DUI.
        /// </summary>
        /// <param name="DUI">Documento único de identidad.</param>
        /// <returns>Lista con los campos del participante, o <c>null</c> si no se encuentra o hay error.</returns>
        public static List<string> BuscarDUI(string DUI)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT * FROM tb_participante WHERE documento_identidad = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", DUI));
                MySqlDataReader Leer = cmdselect.ExecuteReader();
                while (Leer.Read())
                {
                    datos = new List<string>();
                    datos.Add(Leer.GetString(0));
                    datos.Add(Leer.GetString(1));
                    datos.Add(Leer.GetString(2));
                    datos.Add(Leer.GetString(6));
                    datos.Add(Leer.GetString(7));
                    datos.Add(Leer.GetString(8));
                    datos.Add(Leer.GetString(9));
                    datos.Add(Leer.GetString(10));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        /// <summary>
        /// Obtiene las credenciales de contacto de la organización electoral principal.
        /// </summary>
        /// <returns>Lista con correo y contraseña de contacto, o <c>null</c> si no se encuentra o hay error.</returns>
        public static List<string> BuscarCredenciales()
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT * FROM tb_organizacion WHERE id_organizacion = 1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataReader Leer = cmdselect.ExecuteReader();
                while (Leer.Read())
                {
                    datos = new List<string>();
                    datos.Add(Leer.GetString(8));
                    datos.Add(Leer.GetString(9));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        /// <summary>
        /// Registra un nuevo usuario vinculado a un participante y sede de votación.
        /// </summary>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <param name="clave">Contraseña del usuario.</param>
        /// <param name="Centro_Votación">Identificador de la sede de votación.</param>
        /// <param name="id_Miembro">Identificador del participante asociado.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarUsuario(string usuario, string clave, int Centro_Votación, int id_Miembro)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_usuario (nombre_usuario, clave, id_sede, id_participante) VALUES ('{0}','{1}','{2}','{3}')", usuario, clave, Centro_Votación, id_Miembro), Conexion.getConnect());
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
    }
}
