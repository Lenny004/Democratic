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
    public class DetalleActaController : AtributosDetallesActa
    {
        public static DataTable CargarActaController()
        {
            return ModeloDetalleActa.CargarActa();
        }

        public static DataTable CargarPartidoController()
        {
            return ModeloDetalleActa.CargarPartido();
        }

        public static DataTable CargarDetalleActaController()
        {
            return ModeloDetalleActa.CargarDetalleActa();
        }

        public bool EnviarDatosDA_Controller()
        {
            return ModeloDetalleActa.RegistrarDetalleActa(cantidadvotos, acta, partido);
        }

        public DataTable CargarActaInnerJoin_Controller(string id)
        {
            return ModeloDetalleActa.CargarActaInner(id);
        }

        public DataTable CargarPartidoInnerJoin_Controller(string id)
        {
            return ModeloDetalleActa.CargarPartidoInner(id);
        }

        public bool ActualizarDatosController()
        {
            return ModeloDetalleActa.ActualizarDetalleActa(idDetalleacta, cantidadvotos, acta, partido);
        }

        public int EliminarInquilino_Controller()
        {
            return ModeloDetalleActa.EliminarDetalleActa(idDetalleacta);
        }
    }

    public class AtributosDetallesActa
    {
        public int idDetalleacta { get; set; }
        public int cantidadvotos { get; set; }
        public int acta { get; set; }
        public int partido { get; set; }

        public AtributosDetallesActa() { }
    }
}