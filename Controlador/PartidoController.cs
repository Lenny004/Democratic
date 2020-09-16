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
    public class PartidoController : AtributosPartido
    {
        public static DataTable CargarEstadoPartido_Controller()
        {
            return ModelPartido.CargarEstadoPartido();
        }

        public bool EnviarDatosPartido_Controller()
        {
            return ModelPartido.RegistrarPartido(image, nombrep, Cantidadvotosp, Estado_Partido);
        }

        public static DataTable CargarPartido_Controller()
        {
            return ModelPartido.CargarPartido();
        }

        public DataTable CargarEstadoVotosInnerJoin_Controller(string id)
        {
            return ModelPartido.CargarEstadoPartidoInner(id);
        }

        public bool ActualizarDatosPartido_Controller()
        {
            return ModelPartido.ActualizarPartido(idPartido, image, nombrep, Cantidadvotosp, Estado_Partido);
        }

        public int EliminarPartido_Controller()
        {
            return ModelPartido.EliminarPartido(idPartido);
        }
    }

    public class AtributosPartido
    {
        public int idPartido { get; set; }
        public byte[] image { get; set; }
        public string nombrep { get; set; }
        public int Cantidadvotosp { get; set; }
        public int Estado_Partido { get; set; }

        //Constructor
        public AtributosPartido() { }
    }
}
