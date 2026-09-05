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
    /// Capa Modelo: acceso a datos MySQL. CRUD de sedes de votación (centros de votación).
    /// Tablas físicas: tb_sede, tb_estado_sede, tb_municipio, tb_organizacion, tb_registro_escrutinio.
    /// </summary>
    public class ModelCV
    {
        /// <summary>
        /// Carga los estados posibles de un centro de votación.
        /// </summary>
        /// <returns>Tabla con id y nombre del estado, o <c>null</c> si hay error.</returns>
        public static DataTable CargarEstadoCentro()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_estado_sede AS id_Estado_CentroVotación, nombre_estado AS Nombre_Estado_CentroVotación FROM tb_estado_sede";
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
        /// Carga el listado de municipios disponibles.
        /// </summary>
        /// <returns>Tabla con id y nombre del municipio, o <c>null</c> si hay error.</returns>
        public static DataTable CargarMunicipio()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_municipio AS id_Municipio, nombre_municipio AS Nombre_Municipio FROM tb_municipio";
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
        /// Carga el listado de actas de escrutinio.
        /// </summary>
        /// <returns>Tabla con id_Acta y Cantidad_Boletas, o <c>null</c> si hay error.</returns>
        public static DataTable CargarActas()
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
        /// Carga el listado de organizaciones (tribunales).
        /// </summary>
        /// <returns>Tabla con id_Tribunal y Tipo, o <c>null</c> si hay error.</returns>
        public static DataTable CargarTribunal()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_organizacion AS id_Tribunal, tipo_organizacion AS Tipo FROM tb_organizacion";
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
        /// Carga el listado completo de centros de votación.
        /// </summary>
        /// <returns>Tabla con todos los campos de sede, o <c>null</c> si hay error.</returns>
        public static DataTable CargarCV()
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
        /// Registra un nuevo centro de votación.
        /// </summary>
        /// <param name="NombreCentroVotacion">Nombre de la sede.</param>
        /// <param name="Acta">Identificador del acta de escrutinio.</param>
        /// <param name="CantidadJRV">Cantidad de mesas (JRV) de la sede.</param>
        /// <param name="EstadoCentroVotacion">Identificador del estado de la sede.</param>
        /// <param name="Municipio">Identificador del municipio.</param>
        /// <param name="Tribunal">Identificador de la organización.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarCV(string NombreCentroVotacion, int Acta, int CantidadJRV, int EstadoCentroVotacion, int Municipio, int Tribunal)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_sede(nombre_sede, id_registro_escrutinio, cantidad_mesas, id_estado_sede, id_municipio, id_organizacion) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", NombreCentroVotacion, Acta, CantidadJRV, EstadoCentroVotacion, Municipio, Tribunal), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Obtiene un acta de escrutinio por su identificador.
        /// </summary>
        /// <param name="acta">Identificador del acta.</param>
        /// <returns>Tabla con los datos del acta, o <c>null</c> si hay error.</returns>
        public static DataTable CargarActasInner(string acta)
        {
            DataTable data;

            try
            {
                string query = "SELECT id_registro_escrutinio AS id_Acta, cantidad_boletas AS Cantidad_Boletas FROM tb_registro_escrutinio WHERE id_registro_escrutinio = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", acta));
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
        /// Obtiene un estado de centro de votación por su identificador.
        /// </summary>
        /// <param name="estado">Identificador del estado.</param>
        /// <returns>Tabla con los datos del estado, o <c>null</c> si hay error.</returns>
        public static DataTable CargarEstadoCVInner(string estado)
        {
            DataTable data;

            try
            {
                string query = "SELECT id_estado_sede AS id_Estado_CentroVotación, nombre_estado AS Nombre_Estado_CentroVotación FROM tb_estado_sede WHERE id_estado_sede = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", estado));
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
        /// Obtiene un municipio por su identificador.
        /// </summary>
        /// <param name="municipio">Identificador del municipio.</param>
        /// <returns>Tabla con los datos del municipio, o <c>null</c> si hay error.</returns>
        public static DataTable CargarMunicipioInner(string municipio)
        {
            DataTable data;

            try
            {
                string query = "SELECT id_municipio AS id_Municipio, nombre_municipio AS Nombre_Municipio FROM tb_municipio WHERE id_municipio = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", municipio));
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
        /// Obtiene una organización (tribunal) por su identificador.
        /// </summary>
        /// <param name="tribunal">Identificador de la organización.</param>
        /// <returns>Tabla con los datos del tribunal, o <c>null</c> si hay error.</returns>
        public static DataTable CargarTribunalInner(string tribunal)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_organizacion AS id_Tribunal, tipo_organizacion AS Tipo FROM tb_organizacion WHERE id_organizacion = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", tribunal));
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
        /// Actualiza los datos de un centro de votación existente.
        /// </summary>
        /// <param name="id">Identificador de la sede.</param>
        /// <param name="NombreCentroVotacion">Nombre de la sede.</param>
        /// <param name="Acta">Identificador del acta de escrutinio.</param>
        /// <param name="CantidadJRV">Cantidad de mesas (JRV).</param>
        /// <param name="EstadoCentroVotacion">Identificador del estado de la sede.</param>
        /// <param name="Municipio">Identificador del municipio.</param>
        /// <param name="Tribunal">Identificador de la organización.</param>
        /// <returns><c>true</c> si la actualización fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool ActualizarCentroVotacion(int id, string NombreCentroVotacion, int Acta, int CantidadJRV, int EstadoCentroVotacion, int Municipio, int Tribunal)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tb_sede SET nombre_sede = '" + NombreCentroVotacion + "', id_registro_escrutinio = '" + Acta + "', cantidad_mesas = '" + CantidadJRV + "', id_estado_sede = '" + EstadoCentroVotacion + "', id_municipio = '" + Municipio + "', id_organizacion = '" + Tribunal + "' WHERE id_sede = '" + id + "'"), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Elimina un centro de votación por su identificador.
        /// </summary>
        /// <param name="id">Identificador de la sede a eliminar.</param>
        /// <returns>1 si se eliminó correctamente, 2 si no se encontró fila, -1 si hay error.</returns>
        public static int EliminarCV(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tb_sede WHERE id_sede = '" + id + "'"), Conexion.getConnect());
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
