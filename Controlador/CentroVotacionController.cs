using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;
using System.Data;

namespace Controlador
{
    /// <summary>
    /// Gestión de centros de votación (sedes del proceso electoral).
    /// Cada centro agrupa varias Mesas (JRV).
    /// </summary>
    public class CentroVotacionController : AtributosCV
    {
        public static DataTable CargarEstadoCV_Controller()
        {
            return ModelCV.CargarEstadoCentro();
        }

        public static DataTable CargarMunicipio_Controller()
        {
            return ModelCV.CargarMunicipio();
        }

        public static DataTable CargarActas_Controller()
        {
            return ModelCV.CargarActas();
        }

        /// <summary>Carga organizaciones disponibles (tbtribunal).</summary>
        public static DataTable CargarOrganizacion_Controller()
        {
            return CargarTribunal_Controller();
        }

        public static DataTable CargarTribunal_Controller()
        {
            return ModelCV.CargarTribunal();
        }

        public static DataTable CargarCV_Controller()
        {
            return ModelCV.CargarCV();
        }

        public bool EnviarDatosCV_Controller()
        {
            return ModelCV.RegistrarCV(NombreCentroVotacion, Acta, CantidadJRV, EstadoCentroVotacion, Municipio, Tribunal);
        }

        public DataTable CargarActaInnerJoin_Controller(string id)
        {
            return ModelCV.CargarActasInner(id);
        }

        public DataTable CargarEstadoCVInnerJoin_Controller(string id)
        {
            return ModelCV.CargarEstadoCVInner(id);
        }

        public DataTable CargarMunicipioInnerJoin_Controller(string id)
        {
            return ModelCV.CargarMunicipioInner(id);
        }

        public DataTable CargarOrganizacionInnerJoin_Controller(string id)
        {
            return CargarTribunalInnerJoin_Controller(id);
        }

        public DataTable CargarTribunalInnerJoin_Controller(string id)
        {
            return ModelCV.CargarTribunalInner(id);
        }

        public bool ActualizarDatosCV_Controller()
        {
            return ModelCV.ActualizarCentroVotacion(idCentro_Votacion, NombreCentroVotacion, Acta, CantidadJRV, EstadoCentroVotacion, Municipio, Tribunal);
        }

        public int EliminarCV_controller()
        {
            return ModelCV.EliminarCV(idCentro_Votacion);
        }
    }

    public class AtributosCV
    {
        public int idCentro_Votacion { get; set; }
        public string NombreCentroVotacion { get; set; }
        public int Acta { get; set; }

        /// <summary>Cantidad de Mesas (JRV) en el centro.</summary>
        public int CantidadJRV { get; set; }

        public int EstadoCentroVotacion { get; set; }
        public int Municipio { get; set; }

        /// <summary>Id de la Organización (tbtribunal).</summary>
        public int Tribunal { get; set; }

        public AtributosCV() { }
    }
}
