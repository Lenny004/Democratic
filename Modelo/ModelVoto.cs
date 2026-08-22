using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>
    /// Acceso a datos de Boleta y Voto (plantilla genérica de votación).
    /// Tablas físicas: tbboleta, tbvoto, tbcandidato (Opción → GrupoOpciones).
    /// </summary>
    public class ModelVoto
    {
        /// <summary>Registra una boleta emitida en una mesa (JRV).</summary>
        public static bool RegistrarBoleta(string fechaVotacion, int idEstadoBoleta, int idMesa)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbboleta (Fecha_Votación, id_Estado_Boleta, id_JRV) VALUES ('{0}','{1}','{2}')", fechaVotacion, idEstadoBoleta, idMesa), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>Obtiene el identificador de la última boleta registrada.</summary>
        public static List<string> ObtenerUltimaBoleta()
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT * FROM tbboleta order by id_Boleta desc limit 1";
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

        /// <summary>Wrapper de compatibilidad con controladores existentes.</summary>
        public static List<string> ObtenerBoleta()
        {
            return ObtenerUltimaBoleta();
        }

        /// <summary>
        /// Registra un voto asociado a un GrupoOpciones (columna id_Partido en tbvoto).
        /// </summary>
        public static bool RegistrarVotoPorGrupo(int grupoOpcionesId, int idBoleta, int idEstadoVoto, string fechaVotacion, string horaVotacion)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbvoto (id_Partido, id_Boleta, id_Estado_Voto, Fecha_Votación, Hora_Votacion) VALUES ('{0}','{1}','{2}','{3}','{4}')", grupoOpcionesId, idBoleta, idEstadoVoto, fechaVotacion, horaVotacion), Conexion.getConnect());
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
        /// Registra un voto a partir del identificador de la Opción elegida.
        /// Resuelve el GrupoOpciones (id_Partido) desde tbcandidato.
        /// </summary>
        public static bool RegistrarVoto(int opcionId, int idBoleta, int idEstadoVoto, string fechaVotacion, string horaVotacion)
        {
            List<string> grupo = ObtenerGrupoOpcionesDeOpcion(opcionId);
            if (grupo == null || grupo.Count == 0)
            {
                return false;
            }
            return RegistrarVotoPorGrupo(Convert.ToInt32(grupo[0]), idBoleta, idEstadoVoto, fechaVotacion, horaVotacion);
        }

        /// <summary>Wrapper de compatibilidad: recibe id de GrupoOpciones directamente.</summary>
        public static bool RegistrarVoto1(int partido, int boleta, int estadoV, string fechaV, string horaV)
        {
            return RegistrarVotoPorGrupo(partido, boleta, estadoV, fechaV, horaV);
        }

        /// <summary>Obtiene el id de GrupoOpciones (id_Partido) al que pertenece una Opción.</summary>
        public static List<string> ObtenerGrupoOpcionesDeOpcion(int opcionId)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT * FROM tbcandidato tc WHERE tc.id_Candidato = '" + opcionId + "'  ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataReader leer = cmdselect.ExecuteReader();
                while (leer.Read())
                {
                    datos = new List<string>();
                    datos.Add(leer.GetString(5));
                }
                return datos;
            }
            catch (Exception)
            {
                return datos;
            }
        }

        public static List<string> BuscarIDPartido1(int idCandidato) { return ObtenerGrupoOpcionesDeOpcion(idCandidato); }
        public static List<string> BuscarIDPartido2(int idCandidato) { return ObtenerGrupoOpcionesDeOpcion(idCandidato); }
        public static List<string> BuscarIDPartido3(int idCandidato) { return ObtenerGrupoOpcionesDeOpcion(idCandidato); }
        public static List<string> BuscarIDPartido4(int idCandidato) { return ObtenerGrupoOpcionesDeOpcion(idCandidato); }
        public static List<string> BuscarIDPartido5(int idCandidato) { return ObtenerGrupoOpcionesDeOpcion(idCandidato); }
        public static List<string> BuscarIDPartido6(int idCandidato) { return ObtenerGrupoOpcionesDeOpcion(idCandidato); }
        public static List<string> BuscarIDPartido7(int idCandidato) { return ObtenerGrupoOpcionesDeOpcion(idCandidato); }
        public static List<string> BuscarIDPartido8(int idCandidato) { return ObtenerGrupoOpcionesDeOpcion(idCandidato); }
        public static List<string> BuscarIDPartido9(int idCandidato) { return ObtenerGrupoOpcionesDeOpcion(idCandidato); }
    }
}
