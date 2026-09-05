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
    /// Coordina la gestión de centros de votación (sedes del proceso electoral) entre la Vista y el Modelo.
    /// Cada centro agrupa varias Mesas (JRV).
    /// </summary>
    public class CentroVotacionController : AtributosCV
    {
        /// <summary>
        /// Carga los estados disponibles para un centro de votación.
        /// </summary>
        /// <returns>Tabla con los estados de centro de votación.</returns>
        public static DataTable CargarEstadoCV_Controller()
        {
            return ModelCV.CargarEstadoCentro();
        }

        /// <summary>
        /// Carga el listado de municipios disponibles.
        /// </summary>
        /// <returns>Tabla con los municipios.</returns>
        public static DataTable CargarMunicipio_Controller()
        {
            return ModelCV.CargarMunicipio();
        }

        /// <summary>
        /// Carga el listado de actas disponibles para asociar a centros.
        /// </summary>
        /// <returns>Tabla con las actas.</returns>
        public static DataTable CargarActas_Controller()
        {
            return ModelCV.CargarActas();
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarTribunal_Controller"/>.
        /// Carga organizaciones disponibles (tbtribunal).
        /// </summary>
        /// <returns>Tabla con las organizaciones o tribunales.</returns>
        public static DataTable CargarOrganizacion_Controller()
        {
            return CargarTribunal_Controller();
        }

        /// <summary>
        /// Carga el listado de tribunales u organizaciones electorales.
        /// </summary>
        /// <returns>Tabla con los tribunales.</returns>
        public static DataTable CargarTribunal_Controller()
        {
            return ModelCV.CargarTribunal();
        }

        /// <summary>
        /// Carga el listado completo de centros de votación.
        /// </summary>
        /// <returns>Tabla con los centros de votación.</returns>
        public static DataTable CargarCV_Controller()
        {
            return ModelCV.CargarCV();
        }

        /// <summary>
        /// Registra un nuevo centro de votación con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosCV_Controller()
        {
            return ModelCV.RegistrarCV(NombreCentroVotacion, Acta, CantidadJRV, EstadoCentroVotacion, Municipio, Tribunal);
        }

        /// <summary>
        /// Carga datos de acta mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador del acta a consultar.</param>
        /// <returns>Tabla con los datos relacionados del acta.</returns>
        public DataTable CargarActaInnerJoin_Controller(string id)
        {
            return ModelCV.CargarActasInner(id);
        }

        /// <summary>
        /// Carga el estado de un centro de votación mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador del estado a consultar.</param>
        /// <returns>Tabla con los datos del estado del centro.</returns>
        public DataTable CargarEstadoCVInnerJoin_Controller(string id)
        {
            return ModelCV.CargarEstadoCVInner(id);
        }

        /// <summary>
        /// Carga un municipio mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador del municipio a consultar.</param>
        /// <returns>Tabla con los datos del municipio.</returns>
        public DataTable CargarMunicipioInnerJoin_Controller(string id)
        {
            return ModelCV.CargarMunicipioInner(id);
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarTribunalInnerJoin_Controller"/>.
        /// </summary>
        /// <param name="id">Identificador de la organización a consultar.</param>
        /// <returns>Tabla con los datos de la organización.</returns>
        public DataTable CargarOrganizacionInnerJoin_Controller(string id)
        {
            return CargarTribunalInnerJoin_Controller(id);
        }

        /// <summary>
        /// Carga un tribunal u organización mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador del tribunal a consultar.</param>
        /// <returns>Tabla con los datos del tribunal.</returns>
        public DataTable CargarTribunalInnerJoin_Controller(string id)
        {
            return ModelCV.CargarTribunalInner(id);
        }

        /// <summary>
        /// Actualiza un centro de votación existente con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarDatosCV_Controller()
        {
            return ModelCV.ActualizarCentroVotacion(idCentro_Votacion, NombreCentroVotacion, Acta, CantidadJRV, EstadoCentroVotacion, Municipio, Tribunal);
        }

        /// <summary>
        /// Elimina un centro de votación según el identificador de la instancia actual.
        /// </summary>
        /// <returns>Código de resultado de la operación de eliminación.</returns>
        public int EliminarCV_controller()
        {
            return ModelCV.EliminarCV(idCentro_Votacion);
        }
    }

    /// <summary>
    /// Contiene los atributos de un centro de votación utilizados por la capa Controlador.
    /// </summary>
    public class AtributosCV
    {
        /// <summary>Identificador único del centro de votación.</summary>
        public int idCentro_Votacion { get; set; }

        /// <summary>Nombre del centro de votación.</summary>
        public string NombreCentroVotacion { get; set; }

        /// <summary>Identificador del acta asociada al centro.</summary>
        public int Acta { get; set; }

        /// <summary>Cantidad de Mesas (JRV) en el centro.</summary>
        public int CantidadJRV { get; set; }

        /// <summary>Identificador del estado del centro de votación.</summary>
        public int EstadoCentroVotacion { get; set; }

        /// <summary>Identificador del municipio donde se ubica el centro.</summary>
        public int Municipio { get; set; }

        /// <summary>Id de la Organización (tbtribunal).</summary>
        public int Tribunal { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosCV"/>.</summary>
        public AtributosCV() { }
    }
}
