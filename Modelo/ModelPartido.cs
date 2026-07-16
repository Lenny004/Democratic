using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>
    /// CRUD de GruposOpciones / Organizaciones (plantilla genérica de votación).
    /// Tabla física: tbpartido_politico.
    /// </summary>
    public class ModelPartido
    {
        /// <summary>Estados posibles de un GrupoOpciones.</summary>
        public static DataTable CargarEstadoOrganizacion()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_partido";
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

        public static DataTable CargarEstadoPartido()
        {
            return CargarEstadoOrganizacion();
        }

        public static bool RegistrarOrganizacion(string imagen, string nombreGrupoOpciones, int cantidadVotos, int idEstadoOrganizacion)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbpartido_politico (Imagen_Partido, Nombre_Partido, Cantidad_Votos, id_Estado_Partido) VALUES ('{0}', '{1}', '{2}', '{3}')", imagen, nombreGrupoOpciones, cantidadVotos, idEstadoOrganizacion), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static bool RegistrarPartido(string image, string nombrep, int Cantidadvotosp, int Estado_Partido)
        {
            return RegistrarOrganizacion(image, nombrep, Cantidadvotosp, Estado_Partido);
        }

        public static byte[] RecuperarImagenOrganizacion(int idOrganizacion)
        {
            byte[] retorno;
            try
            {
                string query = "SELECT Imagen_Partido FROM tbpartido_politico WHERE id_Partido = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idOrganizacion));
                MySqlDataReader reader = cmdselect.ExecuteReader();
                do
                {
                    retorno = Convert.FromBase64String(reader.GetString(0));
                    return retorno;
                } while (reader.Read());
            }
            catch (Exception)
            {
                return retorno = null;
            }
        }

        public static byte[] ModelRecuperarImagenPartido(int id)
        {
            return RecuperarImagenOrganizacion(id);
        }

        /// <summary>Listado de GruposOpciones con su estado.</summary>
        public static DataTable CargarOrganizaciones()
        {
            DataTable data;
            try
            {
                string query = "SELECT tpp.id_Partido, tpp.Imagen_Partido, tpp.Nombre_Partido, tpp.Cantidad_Votos, tep.Estado_Partido FROM tbpartido_politico tpp, tbestado_partido tep WHERE tpp.id_Estado_Partido = tep.id_Estado_Partido";
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

        public static DataTable CargarPartido()
        {
            return CargarOrganizaciones();
        }

        public static DataTable CargarEstadoOrganizacionPorId(string idEstadoOrganizacion)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_partido WHERE id_Estado_Partido = ?param1";
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

        public static DataTable CargarEstadoPartidoInner(string Estado_Partido)
        {
            return CargarEstadoOrganizacionPorId(Estado_Partido);
        }

        public static bool ActualizarOrganizacion(int idOrganizacion, string imagen, string nombreGrupoOpciones, int cantidadVotos, int idEstadoOrganizacion)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbpartido_politico SET Imagen_Partido = '" + imagen + "', Nombre_Partido = '" + nombreGrupoOpciones + "', Cantidad_Votos = '" + cantidadVotos + "', id_Estado_Partido = '" + idEstadoOrganizacion + "' WHERE id_Partido = '" + idOrganizacion + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static bool ActualizarPartido(int idPartido, string image, string nombrep, int Cantidadvotosp, int Estado_Partido)
        {
            return ActualizarOrganizacion(idPartido, image, nombrep, Cantidadvotosp, Estado_Partido);
        }

        public static int EliminarOrganizacion(int idOrganizacion)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbpartido_politico WHERE id_Partido = '" + idOrganizacion + "' "), Conexion.getConnect());
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

        public static int EliminarPartido(int id)
        {
            return EliminarOrganizacion(id);
        }
    }
}
