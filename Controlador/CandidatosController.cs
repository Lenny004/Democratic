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
    public class CandidatosController
    {
        public static DataTable CargarEstadoC_Controller()
        {
            return ModelCandidato.CargarEstadoCandidato();
        }

        public static DataTable CargarPartidoC_Controller()
        {
            return ModelCandidato.CargarPartidoC();
        }

        public static DataTable CargarCandidato_Controller()
        {
            return ModelCandidato.CargarCandidato();
        }
    }
}
