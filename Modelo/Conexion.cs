using System;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>
    /// Capa Modelo: acceso a datos MySQL. Gestiona la apertura de conexiones
    /// usando la configuración definida en <see cref="EnvConfig"/>.
    /// </summary>
    public class Conexion
    {
        /// <summary>
        /// Abre y devuelve una conexión activa a la base de datos MySQL.
        /// </summary>
        /// <returns>Conexión abierta.</returns>
        public static MySqlConnection getConnect()
        {
            try
            {
                string server = EnvConfig.Get("DB_HOST", "127.0.0.1");
                string port = EnvConfig.Get("DB_PORT", "3306");
                string database = EnvConfig.Get("DB_DATABASE", "dbdemocratic");
                string user = EnvConfig.Get("DB_USERNAME", "root");
                string password = EnvConfig.Get("DB_PASSWORD", "");
                string charset = EnvConfig.Get("DB_CHARSET", "utf8mb4");

                string connectionString = string.Format(
                    "server={0};port={1};database={2};uid={3};pwd={4};CharSet={5}",
                    server,
                    port,
                    database,
                    user,
                    password,
                    charset);

                MySqlConnection connect = new MySqlConnection(connectionString);
                connect.Open();
                return connect;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.TraceError("Error al conectar con MySQL: {0}", ex);
                throw;
            }
        }
    }
}
