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
    /// <summary>
    /// Coordina la gestión de detalles de miembros de mesa entre la Vista y el Modelo.
    /// Vincula miembros con JRV y sus funciones en el proceso electoral.
    /// </summary>
    public class DetalleMiembrosController : AtributosDetalleMiembros
    {
        /// <summary>
        /// Carga el listado de miembros disponibles para asociar a detalles.
        /// </summary>
        /// <returns>Tabla con los miembros.</returns>
        public static DataTable CargarDetalleMiembrosMiembro_Controller()
        {
            return ModelDetalleMiembro.CargarDetalleMiembrosMiembro();
        }

        /// <summary>
        /// Carga el listado de JRV disponibles para asociar a detalles de miembros.
        /// </summary>
        /// <returns>Tabla con las JRV.</returns>
        public static DataTable CargarDetalleMiembrosJRV_Controller()
        {
            return ModelDetalleMiembro.CargarDetalleMiembrosJRV();
        }

        /// <summary>
        /// Carga el listado completo de detalles de miembros registrados.
        /// </summary>
        /// <returns>Tabla con los detalles de miembros.</returns>
        public static DataTable CargarTablaDetallesMiembro_Controller()
        {
            return ModelDetalleMiembro.CargarDatosDetalleMiembros();
        }

        /// <summary>
        /// Registra un nuevo detalle de miembro con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosDetalleMiembro_Controller()
        {
            return ModelDetalleMiembro.RegistrarDetalleMiembros(Detalle_de_Miembros, id_Miembro, id_JRV);
        }

        /// <summary>
        /// Actualiza un detalle de miembro existente con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarDetalleMiembros_Controller()
        {
            return ModelDetalleMiembro.ActualizarDetalleMiembros(id_Detalle, Detalle_de_Miembros, id_Miembro, id_JRV);
        }

        /// <summary>
        /// Elimina un detalle de miembro según el identificador de la instancia actual.
        /// </summary>
        /// <returns>Código de resultado de la operación de eliminación.</returns>
        public int EliminarDetalleMiembro_Controller()
        {
            return ModelDetalleMiembro.EliminarDetalleMiembro(id_Detalle);
        }

        /// <summary>
        /// Carga datos de JRV mediante consulta con inner join para detalle de miembros.
        /// </summary>
        /// <param name="id">Identificador de la JRV a consultar.</param>
        /// <returns>Tabla con los datos relacionados de la JRV.</returns>
        public DataTable CargarDetalleMiembroJRVInnerJoin_Controller(string id)
        {
            return ModelDetalleMiembro.CargarDetalleMiembroJRVInner(id);
        }

        /// <summary>
        /// Carga datos de miembro mediante consulta con inner join para detalle de miembros.
        /// </summary>
        /// <param name="id">Identificador del miembro a consultar.</param>
        /// <returns>Tabla con los datos relacionados del miembro.</returns>
        public DataTable CargarDetalleMiembroMiembroInnerJoin_Controller(string id)
        {
            return ModelDetalleMiembro.CargarDetalleMiembroMiembroInner(id);
        }
    }

    /// <summary>
    /// Contiene los atributos de un detalle de miembro utilizados por la capa Controlador.
    /// </summary>
    public class AtributosDetalleMiembros
    {
        /// <summary>Identificador único del detalle de miembro.</summary>
        public int id_Detalle { get; set; }

        /// <summary>Descripción o función del miembro en la mesa.</summary>
        public string Detalle_de_Miembros { get; set; }

        /// <summary>Identificador del miembro asociado.</summary>
        public int id_Miembro { get; set; }

        /// <summary>Identificador de la JRV asociada.</summary>
        public int id_JRV { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosDetalleMiembros"/>.</summary>
        public AtributosDetalleMiembros() { }
    }
}
