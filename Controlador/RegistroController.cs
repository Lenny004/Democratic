using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;
using System.Data;

namespace Controlador
{
    public class RegistroController : AtributosRegister
    {
        public static bool Existencia_Controller()
        {
            return ModelRegistro.Existencia(DUI);
        }

        public static List<string> BuscarDUI_Controller()
        {
            return ModelRegistro.BuscarDUI(DUI);
        }

        public static List<string> Credenciales_Controller()
        {
            return ModelRegistro.BuscarCredenciales();
        }

        public bool RegistrarUsuario_Controller()
        {
            return ModelRegistro.RegistrarUsuario(usuario, clave, Centro_Votación, id_Miembro);
        }

    }

    public class AtributosRegister
    {

        public static string DUI { get; set; }

        public static string miembros { get; set; }

        public string usuario { get; set; }

        public string clave { get; set; }

        public int Centro_Votación { get; set; }

        public int id_Miembro { get; set; }

        public AtributosRegister() { }
    }
}