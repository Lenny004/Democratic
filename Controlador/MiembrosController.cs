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
    /// Coordina la gestión de miembros de mesa electoral entre la Vista y el Modelo.
    /// Permite registrar, consultar y actualizar datos de participantes del proceso.
    /// </summary>
    public class MiembrosController : AtributosMiembro
    {
        /// <summary>
        /// Carga los estados disponibles para un miembro de mesa.
        /// </summary>
        /// <returns>Tabla con los estados de miembro.</returns>
        public static DataTable CargarEstadoMiembro_Controller()
        {
            return ModelMiembro.CargarEstadoMiembro();
        }

        /// <summary>
        /// Carga el listado completo de miembros registrados.
        /// </summary>
        /// <returns>Tabla con los miembros.</returns>
        public static DataTable CargarMiembros_Controller()
        {
            return ModelMiembro.CargarMiembro();
        }

        /// <summary>
        /// Registra un nuevo miembro con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosMiembro_Controller()
        {
            return ModelMiembro.RegistrarMiembros(nombre, apellido, dui, OCR, ImagenM, Fecha_de_nacimiento, dirección, telefono, CV, JRV, estadomiembro);
        }

        /// <summary>
        /// Carga datos de centro de votación mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador del centro de votación a consultar.</param>
        /// <returns>Tabla con los datos relacionados del centro.</returns>
        public DataTable CargarCentroVotacionInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarCentroVotacionUsuarioInner(id);
        }

        /// <summary>
        /// Carga datos de JRV mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador de la JRV a consultar.</param>
        /// <returns>Tabla con los datos relacionados de la JRV.</returns>
        public DataTable CargarJRVInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarJRVInner(id);
        }

        /// <summary>
        /// Carga el estado de un miembro mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador del estado a consultar.</param>
        /// <returns>Tabla con los datos del estado del miembro.</returns>
        public DataTable CargarEstadoMiembroInnerJoin_Controller(string id)
        {
            return ModelMiembro.CargarEstadoMiembrosInner(id);
        }

        /// <summary>
        /// Actualiza un miembro existente con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarDatosM_Controller()
        {
            return ModelMiembro.ActualizarMiembro(id_Miembro, nombre, apellido, dui, OCR, ImagenM, Fecha_de_nacimiento, dirección, telefono, CV, JRV, estadomiembro);
        }
    }

    /// <summary>
    /// Contiene los atributos de un miembro de mesa utilizados por la capa Controlador.
    /// </summary>
    public class AtributosMiembro
    {
        /// <summary>Identificador único del miembro.</summary>
        public int id_Miembro { get; set; }

        /// <summary>Nombre del miembro.</summary>
        public string nombre { get; set; }

        /// <summary>Apellido del miembro.</summary>
        public string apellido { get; set; }

        /// <summary>Documento Único de Identidad del miembro.</summary>
        public string dui { get; set; }

        /// <summary>Código OCR del documento de identidad.</summary>
        public string OCR { get; set; }

        /// <summary>Ruta o referencia de la imagen del miembro.</summary>
        public string ImagenM { get; set; }

        /// <summary>Fecha de nacimiento del miembro.</summary>
        public string Fecha_de_nacimiento { get; set; }

        /// <summary>Dirección de residencia del miembro.</summary>
        public string dirección { get; set; }

        /// <summary>Número de teléfono del miembro.</summary>
        public string telefono { get; set; }

        /// <summary>Identificador del centro de votación asignado.</summary>
        public int CV { get; set; }

        /// <summary>Identificador de la JRV asignada.</summary>
        public int JRV { get; set; }

        /// <summary>Identificador del estado del miembro.</summary>
        public int estadomiembro { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosMiembro"/>.</summary>
        public AtributosMiembro() { }
    }
}
