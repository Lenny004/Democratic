using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>
    /// CRUD de Opciones de votación (plantilla genérica).
    /// Tablas físicas: tbcandidato, tbpartido_politico, tbestado_candidato.
    /// </summary>
    public class ModelCandidato
    {
        /// <summary>Lista GruposOpciones disponibles para asociar a una Opción.</summary>
        public static DataTable CargarGruposOpciones()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_Partido, Nombre_Partido FROM tbpartido_politico";
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

        public static DataTable CargarPartidoC()
        {
            return CargarGruposOpciones();
        }

        /// <summary>Estados posibles de una Opción.</summary>
        public static DataTable CargarEstadoOpcion()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_candidato";
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

        public static DataTable CargarEstadoCandidato()
        {
            return CargarEstadoOpcion();
        }

        /// <summary>Listado de Opciones con su GrupoOpciones y estado.</summary>
        public static DataTable CargarOpciones()
        {
            DataTable data;
            try
            {
                string query = "SELECT tc.id_Candidato, tc.Nombre_Candidato, tc.Apellido_Candidato, tc.Género, tc.Imagen_Candidato, tpp.Nombre_Partido, tec.Estado_Candidato FROM tbcandidato tc, tbpartido_politico tpp, tbestado_candidato tec WHERE tc.id_Partido = tpp.id_Partido AND tc.id_Estado_Candidato = tec.id_Estado_Candidato";
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

        public static DataTable CargarCandidato()
        {
            return CargarOpciones();
        }

        public static bool RegistrarOpcion(string nombreOpcion, string apellidoOpcion, string genero, string imagenOpcion, int idGrupoOpciones, int idEstadoOpcion)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbcandidato (Nombre_Candidato, Apellido_Candidato, Género, Imagen_Candidato, id_Partido, id_Estado_Candidato) VALUES ('{0}', '{1}', '{2}', '{3}','{4}','{5}')", nombreOpcion, apellidoOpcion, genero, imagenOpcion, idGrupoOpciones, idEstadoOpcion), Conexion.getConnect());
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

        public static bool RegistrarCandidato(string Nombre_Candidato, string Apellido_Candidato, string Género, string Imagen_Candidato, int Partido, int Estado_Candidato)
        {
            return RegistrarOpcion(Nombre_Candidato, Apellido_Candidato, Género, Imagen_Candidato, Partido, Estado_Candidato);
        }

        public static DataTable CargarEstadoOpcionPorNombre(string estadoOpcion)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_candidato WHERE Estado_Candidato = ?param1";
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

        public static DataTable CargarEstadoCandidatoInner(string Estado_Candidato)
        {
            return CargarEstadoOpcionPorNombre(Estado_Candidato);
        }

        public static DataTable CargarGrupoOpcionesPorNombre(string nombreGrupoOpciones)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbpartido_politico WHERE Nombre_Partido = ?param1";
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

        public static DataTable CargarPartidoCInner(string Partido)
        {
            return CargarGrupoOpcionesPorNombre(Partido);
        }

        public static byte[] RecuperarImagenOpcion(int idOpcion)
        {
            byte[] retorno;
            try
            {
                string query = "SELECT Imagen_Candidato FROM tbcandidato WHERE id_Candidato = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idOpcion));
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

        public static byte[] ModelRecuperarImagenCandidato(int id)
        {
            return RecuperarImagenOpcion(id);
        }

        public static bool ActualizarOpcion(int idOpcion, string nombreOpcion, string apellidoOpcion, string genero, string imagenOpcion, int idGrupoOpciones, int idEstadoOpcion)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbcandidato SET Nombre_Candidato = '" + nombreOpcion + "', Apellido_Candidato = '" + apellidoOpcion + "', Género = '" + genero + "', Imagen_Candidato = '" + imagenOpcion + "', id_Partido  = '" + idGrupoOpciones + "', id_Estado_Candidato = '" + idEstadoOpcion + "' WHERE id_Candidato = '" + idOpcion + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static bool ActualizarCandidato(int id_Candidato, string Nombre_Candidato, string Apellido_Candidato, string Género, string Imagen_Candidato, int Partido, int Estado_Candidato)
        {
            return ActualizarOpcion(id_Candidato, Nombre_Candidato, Apellido_Candidato, Género, Imagen_Candidato, Partido, Estado_Candidato);
        }

        public static int EliminarOpcion(int idOpcion)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbcandidato WHERE id_Candidato = '" + idOpcion + "' "), Conexion.getConnect());
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

        public static int EliminarCandidato(int id)
        {
            return EliminarOpcion(id);
        }

        public static bool TruncateOpciones()
        {
            bool retorno;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("TRUNCATE TABLE tbcandidato"), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static bool TruncateCandidato()
        {
            return TruncateOpciones();
        }
    }
}
