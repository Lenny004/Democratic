using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador
{
    public class LoginController : AtributosLogin
    {
        public static int Acceso_Controller()
        {
            return ModelLogin.Acceso(usuario, Clave_Usuario);
        }

        public static List<string> Nivel_Controller()
        {
            return ModelLogin.ObtenerDatos(usuario);
        }

        public static int VerificacionTribunal_Controller()
        {
            return ModelLogin.ObtenerTribunal();
        }

        public static int VerificacionUsuario_Controller()
        {
            return ModelLogin.ObtenerUsuarios();
        }
    }

    public class AtributosLogin
    {
        public static string usuario { get; set; }

        public static string Clave_Usuario { get; set; }

        public AtributosLogin() { }
    }
}