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
    /// <summary>
    /// Gestión de Mesas de votación (JRV — Junta Receptora de Votos).
    /// Mesa = unidad operativa donde se reciben y registran los votos.
    /// </summary>
    public class JRVController : AtributosJRV
    {
        public static DataTable CargarCentroVotacion_controller()
        {
            return ModelJRV.CargarCentroVotacion();
        }

        public static DataTable CargarEstadoMesa_controller()
        {
            return CargarEstadojrv_controller();
        }

        public static DataTable CargarEstadojrv_controller()
        {
            return ModelJRV.CargarEstadoJRV();
        }

        public static DataTable CargarMesas_controller()
        {
            return CargarJRV_controller();
        }

        public static DataTable CargarJRV_controller()
        {
            return ModelJRV.CargarTablaJRV();
        }

        public bool EnviarDatosMesa_Controller()
        {
            return EnviarDatosJRV_Controller();
        }

        public bool EnviarDatosJRV_Controller()
        {
            return ModelJRV.RegistrarJRV(correlativo, centrovotacion, estadojrv);
        }

        public DataTable CargarCVInnerJoin_Controller(string id)
        {
            return ModelJRV.CargarCVInner(id);
        }

        public DataTable CargarEstadoMesaInnerJoin_Controller(string id)
        {
            return CargarEstadoJRVInnerJoin_Controller(id);
        }

        public DataTable CargarEstadoJRVInnerJoin_Controller(string id)
        {
            return ModelJRV.CargarEstadoJRVInner(id);
        }

        public bool ActualizarDatosMesa_Controller()
        {
            return ActualizarDatosJRV_Controller();
        }

        public bool ActualizarDatosJRV_Controller()
        {
            return ModelJRV.ActualizarJRV(idjrv, correlativo, centrovotacion, estadojrv);
        }

        public int EliminarMesa_controller()
        {
            return EliminarJRV_controller();
        }

        public int EliminarJRV_controller()
        {
            return ModelJRV.EliminarJRV(idjrv);
        }
    }

    /// <summary>Atributos de una Mesa / JRV (mapeo tbjrv).</summary>
    public class AtributosJRV
    {
        /// <summary>Id de la Mesa (id_JRV en BD).</summary>
        public int idjrv { get; set; }

        /// <summary>Alias semántico de idjrv.</summary>
        public int idMesa
        {
            get { return idjrv; }
            set { idjrv = value; }
        }

        public string correlativo { get; set; }
        public int centrovotacion { get; set; }
        public int estadojrv { get; set; }

        public AtributosJRV() { }
    }
}
