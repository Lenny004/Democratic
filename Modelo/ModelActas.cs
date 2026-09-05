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
    /// Capa Modelo: acceso a datos MySQL. CRUD de registros de escrutinio (actas).
    /// Tablas físicas: tb_registro_escrutinio, tb_mesa.
    /// </summary>
    public class ModelActas
    {
        /// <summary>
        /// Carga el listado de todas las mesas de votación (JRV).
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
        /// Obtiene todos los registros de escrutinio (actas).
        /// </summary>
        /// <returns>Tabla con id_Acta, Cantidad_Boletas e id_JRV, o <c>null</c> si hay error.</returns>
        public static DataTable ObtenerActas()
        {
            DataTable data;
            try
            {
                string query = "SELECT r.id_registro_escrutinio AS id_Acta, r.cantidad_boletas AS Cantidad_Boletas, r.id_mesa AS id_JRV FROM tb_registro_escrutinio r";
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
        /// Registra un nuevo acta de escrutinio asociada a una mesa.
        /// </summary>
        /// <param name="Cantidad_Boletas">Cantidad de boletas del acta.</param>
        /// <param name="JRV">Identificador de la mesa de votación.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarActas(string Cantidad_Boletas, int JRV)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_registro_escrutinio(cantidad_boletas, id_mesa) VALUES ('{0}','{1}')", Cantidad_Boletas, JRV), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Obtiene los datos de una mesa por su identificador.
        /// </summary>
        /// <param name="id">Identificador de la mesa.</param>
        /// <returns>Tabla con los datos de la mesa, o <c>null</c> si hay error.</returns>
        public static DataTable CargarJRVInner(string id)
        {
            DataTable data;
            try
            {
                string query = "SELECT m.id_mesa AS id_JRV, m.codigo_mesa AS Correlativo_JRV, m.id_sede AS id_Centro_Votación, m.id_estado_mesa AS id_Estado_JRV FROM tb_mesa m WHERE m.id_mesa = ?param1";
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
        /// Actualiza la cantidad de boletas y la mesa de un acta existente.
        /// </summary>
        /// <param name="id_Acta">Identificador del acta.</param>
        /// <param name="Cantidad_Boletas">Nueva cantidad de boletas.</param>
        /// <param name="JRV">Identificador de la mesa de votación.</param>
        /// <returns><c>true</c> si la actualización fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool ActualizarActas(int id_Acta, string Cantidad_Boletas, int JRV)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tb_registro_escrutinio SET cantidad_boletas = '" + Cantidad_Boletas + "', id_mesa = '" + JRV + "' WHERE id_registro_escrutinio = '" + id_Acta + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Elimina un acta de escrutinio por su identificador.
        /// </summary>
        /// <param name="id">Identificador del acta a eliminar.</param>
        /// <returns>1 si se eliminó correctamente, 2 si no se encontró fila, -1 si hay error.</returns>
        public static int EliminarActa(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tb_registro_escrutinio WHERE id_registro_escrutinio = '" + id + "' "), Conexion.getConnect());
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
        /// Busca una mesa por su código correlativo.
        /// </summary>
        /// <param name="CorrelativoJrv">Código correlativo de la mesa.</param>
        /// <returns>Lista con el id de la mesa, o <c>null</c> si no se encuentra o hay error.</returns>
        public static List<string> BuscarJRV(string CorrelativoJrv)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT * FROM tb_mesa WHERE codigo_mesa = '"+ CorrelativoJrv +"'   ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataReader Leer = cmdselect.ExecuteReader();
                while (Leer.Read())
                {
                    datos = new List<string>();
                    datos.Add(Leer.GetString(1));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        /// <summary>
        /// Verifica si existe una mesa con el correlativo indicado.
        /// </summary>
        /// <param name="CorrelativoJRV">Código correlativo de la mesa.</param>
        /// <returns><c>true</c> si la mesa existe; <c>false</c> si no existe o hay error.</returns>
        public static bool ExistenciaJRV(string CorrelativoJRV)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tb_mesa WHERE codigo_mesa = '" + CorrelativoJRV + "'  ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }
    }
}
