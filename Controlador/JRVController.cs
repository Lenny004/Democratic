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
    /// Coordina la gestión de Mesas de votación (JRV — Junta Receptora de Votos) entre la Vista y el Modelo.
    /// Mesa = unidad operativa donde se reciben y registran los votos.
    /// </summary>
    public class JRVController : AtributosJRV
    {
        /// <summary>
        /// Carga el listado de centros de votación disponibles para asociar a mesas.
        /// </summary>
        /// <returns>Tabla con los centros de votación.</returns>
        public static DataTable CargarCentroVotacion_controller()
        {
            return ModelJRV.CargarCentroVotacion();
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarEstadojrv_controller"/>.
        /// </summary>
        /// <returns>Tabla con los estados de mesa.</returns>
        public static DataTable CargarEstadoMesa_controller()
        {
            return CargarEstadojrv_controller();
        }

        /// <summary>
        /// Carga los estados disponibles para una JRV o mesa.
        /// </summary>
        /// <returns>Tabla con los estados de JRV.</returns>
        public static DataTable CargarEstadojrv_controller()
        {
            return ModelJRV.CargarEstadoJRV();
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarJRV_controller"/>.
        /// </summary>
        /// <returns>Tabla con las mesas o JRV.</returns>
        public static DataTable CargarMesas_controller()
        {
            return CargarJRV_controller();
        }

        /// <summary>
        /// Carga el listado completo de JRV o mesas registradas.
        /// </summary>
        /// <returns>Tabla con las JRV.</returns>
        public static DataTable CargarJRV_controller()
        {
            return ModelJRV.CargarTablaJRV();
        }

        /// <summary>
        /// Delega al método genérico <see cref="EnviarDatosJRV_Controller"/>.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosMesa_Controller()
        {
            return EnviarDatosJRV_Controller();
        }

        /// <summary>
        /// Registra una nueva JRV o mesa con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosJRV_Controller()
        {
            return ModelJRV.RegistrarJRV(correlativo, centrovotacion, estadojrv);
        }

        /// <summary>
        /// Carga datos de centro de votación mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador del centro de votación a consultar.</param>
        /// <returns>Tabla con los datos relacionados del centro.</returns>
        public DataTable CargarCVInnerJoin_Controller(string id)
        {
            return ModelJRV.CargarCVInner(id);
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarEstadoJRVInnerJoin_Controller"/>.
        /// </summary>
        /// <param name="id">Identificador del estado a consultar.</param>
        /// <returns>Tabla con los datos del estado de la mesa.</returns>
        public DataTable CargarEstadoMesaInnerJoin_Controller(string id)
        {
            return CargarEstadoJRVInnerJoin_Controller(id);
        }

        /// <summary>
        /// Carga el estado de una JRV mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador del estado a consultar.</param>
        /// <returns>Tabla con los datos del estado de la JRV.</returns>
        public DataTable CargarEstadoJRVInnerJoin_Controller(string id)
        {
            return ModelJRV.CargarEstadoJRVInner(id);
        }

        /// <summary>
        /// Delega al método genérico <see cref="ActualizarDatosJRV_Controller"/>.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarDatosMesa_Controller()
        {
            return ActualizarDatosJRV_Controller();
        }

        /// <summary>
        /// Actualiza una JRV o mesa existente con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarDatosJRV_Controller()
        {
            return ModelJRV.ActualizarJRV(idjrv, correlativo, centrovotacion, estadojrv);
        }

        /// <summary>
        /// Delega al método genérico <see cref="EliminarJRV_controller"/>.
        /// </summary>
        /// <returns>Código de resultado de la operación de eliminación.</returns>
        public int EliminarMesa_controller()
        {
            return EliminarJRV_controller();
        }

        /// <summary>
        /// Elimina una JRV o mesa según el identificador de la instancia actual.
        /// </summary>
        /// <returns>Código de resultado de la operación de eliminación.</returns>
        public int EliminarJRV_controller()
        {
            return ModelJRV.EliminarJRV(idjrv);
        }
    }

    /// <summary>
    /// Contiene los atributos de una Mesa / JRV (mapeo tbjrv) utilizados por la capa Controlador.
    /// </summary>
    public class AtributosJRV
    {
        /// <summary>Id de la Mesa (id_JRV en BD).</summary>
        public int idjrv { get; set; }

        /// <summary>Alias semántico de <see cref="idjrv"/>.</summary>
        public int idMesa
        {
            get { return idjrv; }
            set { idjrv = value; }
        }

        /// <summary>Correlativo o número identificador de la mesa.</summary>
        public string correlativo { get; set; }

        /// <summary>Identificador del centro de votación al que pertenece la mesa.</summary>
        public int centrovotacion { get; set; }

        /// <summary>Identificador del estado de la JRV o mesa.</summary>
        public int estadojrv { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosJRV"/>.</summary>
        public AtributosJRV() { }
    }
}
