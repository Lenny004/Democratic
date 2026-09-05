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
    /// Coordina la gestión de detalles de actas electorales entre la Vista y el Modelo.
    /// Vincula actas con partidos y cantidades de votos registradas.
    /// </summary>
    public class DetalleActaController : AtributosDetallesActa
    {
        /// <summary>
        /// Carga el listado de actas disponibles para detalle.
        /// </summary>
        /// <returns>Tabla con las actas.</returns>
        public static DataTable CargarActaController()
        {
            return ModeloDetalleActa.CargarActa();
        }

        /// <summary>
        /// Carga el listado de partidos disponibles para asociar al detalle.
        /// </summary>
        /// <returns>Tabla con los partidos.</returns>
        public static DataTable CargarPartidoController()
        {
            return ModeloDetalleActa.CargarPartido();
        }

        /// <summary>
        /// Carga el listado completo de detalles de acta registrados.
        /// </summary>
        /// <returns>Tabla con los detalles de acta.</returns>
        public static DataTable CargarDetalleActaController()
        {
            return ModeloDetalleActa.CargarDetalleActa();
        }

        /// <summary>
        /// Registra un nuevo detalle de acta con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosDA_Controller()
        {
            return ModeloDetalleActa.RegistrarDetalleActa(cantidadvotos, acta, partido);
        }

        /// <summary>
        /// Carga datos de acta mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador del acta a consultar.</param>
        /// <returns>Tabla con los datos relacionados del acta.</returns>
        public DataTable CargarActaInnerJoin_Controller(string id)
        {
            return ModeloDetalleActa.CargarActaInner(id);
        }

        /// <summary>
        /// Carga datos de partido mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador del partido a consultar.</param>
        /// <returns>Tabla con los datos relacionados del partido.</returns>
        public DataTable CargarPartidoInnerJoin_Controller(string id)
        {
            return ModeloDetalleActa.CargarPartidoInner(id);
        }

        /// <summary>
        /// Actualiza un detalle de acta existente con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarDatosController()
        {
            return ModeloDetalleActa.ActualizarDetalleActa(idDetalleacta, cantidadvotos, acta, partido);
        }

        /// <summary>
        /// Elimina un detalle de acta según el identificador de la instancia actual.
        /// </summary>
        /// <returns>Código de resultado de la operación de eliminación.</returns>
        public int EliminarInquilino_Controller()
        {
            return ModeloDetalleActa.EliminarDetalleActa(idDetalleacta);
        }
    }

    /// <summary>
    /// Contiene los atributos de un detalle de acta utilizados por la capa Controlador.
    /// </summary>
    public class AtributosDetallesActa
    {
        /// <summary>Identificador único del detalle de acta.</summary>
        public int idDetalleacta { get; set; }

        /// <summary>Cantidad de votos registrados en el detalle.</summary>
        public int cantidadvotos { get; set; }

        /// <summary>Identificador del acta asociada.</summary>
        public int acta { get; set; }

        /// <summary>Identificador del partido asociado.</summary>
        public int partido { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosDetallesActa"/>.</summary>
        public AtributosDetallesActa() { }
    }
}
