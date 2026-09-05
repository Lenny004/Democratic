using System;
using System.Collections.Generic;
using System.IO;

namespace Modelo
{
    /// <summary>
    /// Capa Modelo: acceso a datos MySQL. Carga variables desde un archivo .env
    /// en la raíz del repositorio o junto al ejecutable.
    /// </summary>
    internal static class EnvConfig
    {
        private static readonly Dictionary<string, string> Variables = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private static bool _loaded;

        /// <summary>
        /// Obtiene el valor de una variable de entorno cargada desde el archivo .env.
        /// </summary>
        /// <param name="key">Nombre de la variable.</param>
        /// <param name="defaultValue">Valor por defecto si la clave no existe o está vacía.</param>
        /// <returns>Valor de la variable o <paramref name="defaultValue"/>.</returns>
        public static string Get(string key, string defaultValue = "")
        {
            EnsureLoaded();
            string value;
            return Variables.TryGetValue(key, out value) && !string.IsNullOrWhiteSpace(value)
                ? value.Trim()
                : defaultValue;
        }

        private static void EnsureLoaded()
        {
            if (_loaded)
            {
                return;
            }

            _loaded = true;
            string envPath = FindEnvFile();
            if (envPath == null)
            {
                return;
            }

            foreach (string line in File.ReadAllLines(envPath))
            {
                string trimmed = line.Trim();
                if (trimmed.Length == 0 || trimmed.StartsWith("#"))
                {
                    continue;
                }

                int separator = trimmed.IndexOf('=');
                if (separator <= 0)
                {
                    continue;
                }

                string key = trimmed.Substring(0, separator).Trim();
                string value = trimmed.Substring(separator + 1).Trim();

                if (value.StartsWith("\"") && value.EndsWith("\"") && value.Length >= 2)
                {
                    value = value.Substring(1, value.Length - 2);
                }

                Variables[key] = value;
            }
        }

        private static string FindEnvFile()
        {
            DirectoryInfo directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            for (int level = 0; level < 8 && directory != null; level++)
            {
                string candidate = Path.Combine(directory.FullName, ".env");
                if (File.Exists(candidate))
                {
                    return candidate;
                }

                directory = directory.Parent;
            }

            return null;
        }
    }
}
