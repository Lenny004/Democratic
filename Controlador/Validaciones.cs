using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Controlador
{
    /// <summary>
    /// Proporciona utilidades de validación y transformación de datos en la capa Controlador.
    /// Coordina operaciones de seguridad entre la Vista y el procesamiento de credenciales.
    /// </summary>
    public class Validaciones
    {
        /// <summary>
        /// Genera el hash MD5 de una cadena de texto en formato hexadecimal.
        /// </summary>
        /// <param name="str">Cadena de texto a hashear.</param>
        /// <returns>Representación hexadecimal del hash MD5 de la cadena.</returns>
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
