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
    public class ActasController : AtributosActa
    {
        public static DataTable CargarJRV_Controller()
        {
            return ModelActas.CargarJRV();
        }

        public static List<string> BuscarJRV_Controller()
        {
            return ModelActas.BuscarJRV(CorrelativoJrv);
        }

        public static bool ExistenciaJRV_Controller()
        {
            return ModelActas.ExistenciaJRV(CorrelativoJrv);
        }

        public bool EnviarDatosActas_Controller()
        {
            return ModelActas.RegistrarActas(Cantidad_Boletas, JRV);
        }

        public static DataTable CargarActas_Controller()
        {
            return ModelActas.ObtenerActas();
        }

        public DataTable CargarJRVInnerJoin_Controller(string id)
        {
            return ModelActas.CargarJRVInner(id);
        }

        public bool ActualizarDatos_Controller()
        {
            return ModelActas.ActualizarActas(id_Acta, Cantidad_Boletas, JRV);
        }

        public int EliminarActa_Controller()
        {
            return ModelActas.EliminarActa(id_Acta);
        }
    }

    public class AtributosActa
    {
        public int id_Acta { get; set; }
        public string Cantidad_Boletas { get; set; }
        public static string CorrelativoJrv { get; set; }
        public int JRV { get; set; }

        //Constructor
        public AtributosActa() { }
    }
}
