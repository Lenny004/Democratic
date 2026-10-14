using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>Registra boletas y votos con consultas parametrizadas.</summary>
    public class ModelVoto
    {
        public static bool RegistrarBoleta(string fecha, int estado, int mesa)
        {
            using (MySqlConnection connection = Conexion.getConnect())
            using (MySqlCommand command = new MySqlCommand("INSERT INTO tb_boleta (fecha_votacion, id_estado_boleta, id_mesa) VALUES (?fecha, ?estado, ?mesa)", connection))
            {
                command.Parameters.AddWithValue("fecha", fecha); command.Parameters.AddWithValue("estado", estado); command.Parameters.AddWithValue("mesa", mesa);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public static bool RegistrarBoletaYVoto(int opcionId, string fecha, string hora, int estadoBoleta, int estadoVoto, int mesa)
        {
            using (MySqlConnection connection = Conexion.getConnect())
            using (MySqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    long ballotId;
                    using (MySqlCommand ballot = new MySqlCommand("INSERT INTO tb_boleta (fecha_votacion, id_estado_boleta, id_mesa) VALUES (?fecha, ?estadoBoleta, ?mesa); SELECT LAST_INSERT_ID();", connection, transaction))
                    {
                        ballot.Parameters.AddWithValue("fecha", fecha); ballot.Parameters.AddWithValue("estadoBoleta", estadoBoleta); ballot.Parameters.AddWithValue("mesa", mesa); ballotId = Convert.ToInt64(ballot.ExecuteScalar());
                    }
                    using (MySqlCommand vote = new MySqlCommand("INSERT INTO tb_voto (id_grupo_opciones, id_boleta, id_estado_voto, fecha_votacion, hora_votacion) SELECT id_grupo_opciones, ?boleta, ?estadoVoto, ?fecha, ?hora FROM tb_opcion WHERE id_opcion = ?opcion", connection, transaction))
                    {
                        vote.Parameters.AddWithValue("boleta", ballotId); vote.Parameters.AddWithValue("estadoVoto", estadoVoto); vote.Parameters.AddWithValue("fecha", fecha); vote.Parameters.AddWithValue("hora", hora); vote.Parameters.AddWithValue("opcion", opcionId);
                        if (vote.ExecuteNonQuery() != 1) throw new InvalidOperationException("La opción no existe.");
                    }
                    transaction.Commit(); return true;
                }
                catch { transaction.Rollback(); return false; }
            }
        }

        public static List<string> ObtenerUltimaBoleta()
        {
            using (MySqlConnection connection = Conexion.getConnect())
            using (MySqlCommand command = new MySqlCommand("SELECT id_boleta FROM tb_boleta ORDER BY id_boleta DESC LIMIT 1", connection))
            using (MySqlDataReader reader = command.ExecuteReader())
            { return reader.Read() ? new List<string> { reader.GetString(0) } : null; }
        }

        public static bool RegistrarVotoPorGrupo(int grupo, int boleta, int estado, string fecha, string hora)
        {
            using (MySqlConnection connection = Conexion.getConnect())
            using (MySqlCommand command = new MySqlCommand("INSERT INTO tb_voto (id_grupo_opciones, id_boleta, id_estado_voto, fecha_votacion, hora_votacion) VALUES (?grupo, ?boleta, ?estado, ?fecha, ?hora)", connection))
            { command.Parameters.AddWithValue("grupo", grupo); command.Parameters.AddWithValue("boleta", boleta); command.Parameters.AddWithValue("estado", estado); command.Parameters.AddWithValue("fecha", fecha); command.Parameters.AddWithValue("hora", hora); return command.ExecuteNonQuery() == 1; }
        }

        public static List<string> ObtenerGrupoOpcionesDeOpcion(int opcionId)
        {
            using (MySqlConnection connection = Conexion.getConnect())
            using (MySqlCommand command = new MySqlCommand("SELECT id_grupo_opciones FROM tb_opcion WHERE id_opcion = ?opcion", connection))
            { command.Parameters.AddWithValue("opcion", opcionId); object value = command.ExecuteScalar(); return value == null ? null : new List<string> { Convert.ToString(value) }; }
        }

        public static bool RegistrarVoto(int opcionId, int boleta, int estado, string fecha, string hora)
        { List<string> grupo = ObtenerGrupoOpcionesDeOpcion(opcionId); return grupo != null && RegistrarVotoPorGrupo(Convert.ToInt32(grupo[0]), boleta, estado, fecha, hora); }
    }
}
