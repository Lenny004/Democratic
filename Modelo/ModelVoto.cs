using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>
    /// Capa Modelo: acceso a datos MySQL. Gestión de boletas y votos
    /// en la plantilla genérica de votación. Tablas físicas: tb_boleta, tb_voto, tb_opcion.
    /// </summary>
    public class ModelVoto
    {
        /// <summary>
        /// Registra una boleta emitida en una mesa de votación.
        /// </summary>
        /// <param name="fechaVotacion">Fecha de la votación.</param>
        /// <param name="idEstadoBoleta">Identificador del estado de la boleta.</param>
        /// <param name="idMesa">Identificador de la mesa (JRV).</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarBoleta(string fechaVotacion, int idEstadoBoleta, int idMesa)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_boleta (fecha_votacion, id_estado_boleta, id_mesa) VALUES ('{0}','{1}','{2}')", fechaVotacion, idEstadoBoleta, idMesa), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Obtiene el identificador de la última boleta registrada.
        /// </summary>
        /// <returns>Lista con el id de la boleta, o <c>null</c> si no hay registros o hay error.</returns>
        public static List<string> ObtenerUltimaBoleta()
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT id_boleta FROM tb_boleta ORDER BY id_boleta DESC LIMIT 1";
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
        /// Registra un voto asociado directamente a un grupo de opciones.
        /// </summary>
        /// <param name="grupoOpcionesId">Identificador del grupo de opciones.</param>
        /// <param name="idBoleta">Identificador de la boleta.</param>
        /// <param name="idEstadoVoto">Identificador del estado del voto.</param>
        /// <param name="fechaVotacion">Fecha de la votación.</param>
        /// <param name="horaVotacion">Hora de la votación.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarVotoPorGrupo(int grupoOpcionesId, int idBoleta, int idEstadoVoto, string fechaVotacion, string horaVotacion)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_voto (id_grupo_opciones, id_boleta, id_estado_voto, fecha_votacion, hora_votacion) VALUES ('{0}','{1}','{2}','{3}','{4}')", grupoOpcionesId, idBoleta, idEstadoVoto, fechaVotacion, horaVotacion), Conexion.getConnect());
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
        /// Registra un voto a partir del identificador de la opción elegida.
        /// </summary>
        /// <param name="opcionId">Identificador de la opción seleccionada.</param>
        /// <param name="idBoleta">Identificador de la boleta.</param>
        /// <param name="idEstadoVoto">Identificador del estado del voto.</param>
        /// <param name="fechaVotacion">Fecha de la votación.</param>
        /// <param name="horaVotacion">Hora de la votación.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> si no se encuentra el grupo o hay error.</returns>
        public static bool RegistrarVoto(int opcionId, int idBoleta, int idEstadoVoto, string fechaVotacion, string horaVotacion)
        {
            List<string> grupo = ObtenerGrupoOpcionesDeOpcion(opcionId);
            if (grupo == null || grupo.Count == 0)
            {
                return false;
            }
            return RegistrarVotoPorGrupo(Convert.ToInt32(grupo[0]), idBoleta, idEstadoVoto, fechaVotacion, horaVotacion);
        }

        /// <summary>
        /// Obtiene el identificador del grupo de opciones al que pertenece una opción.
        /// </summary>
        /// <param name="opcionId">Identificador de la opción.</param>
        /// <returns>Lista con el id del grupo, o <c>null</c> si no se encuentra o hay error.</returns>
        public static List<string> ObtenerGrupoOpcionesDeOpcion(int opcionId)
        {
            List<string> datos = null;
            try
            {
                string query = "SELECT id_grupo_opciones FROM tb_opcion WHERE id_opcion = '" + opcionId + "'";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataReader leer = cmdselect.ExecuteReader();
                while (leer.Read())
                {
                    datos = new List<string>();
                    datos.Add(leer.GetString(0));
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
