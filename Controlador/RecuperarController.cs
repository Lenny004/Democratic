using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Modelo;


namespace Controlador
{
    public class RecuperarController : AtributosRecuperar
    {
        public static bool ExistenciaCorreo_Controller()
        {
            return ModelRecuperar.ExistenciaCorreo(correo);
        }

        public bool ActualizarContra_Controller()
        {
            return ModelRecuperar.ActualizarContraseña(correo2, ContraUpd);
        }
    }

    public class AtributosRecuperar
    {
        public static string correo { get; set; }

        public string correo2 { get; set; }

        public string ContraUpd { get; set; }

        public AtributosRecuperar() { }
    }
}
