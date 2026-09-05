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
    /// Coordina la gestión de actas electorales entre la Vista y el Modelo.
    /// Permite registrar, consultar, actualizar y eliminar actas asociadas a JRV.
    /// </summary>
    public class ActasController : AtributosActa
    {
        /// <summary>
        /// Carga el listado de JRV disponibles para asociar a actas.
        /// </summary>
        /// <returns>Tabla con los datos de las JRV.</returns>
        public static DataTable CargarJRV_Controller()
        {
            return ModelActas.CargarJRV();
        }

        /// <summary>
        /// Busca una JRV por su correlativo almacenado en <see cref="AtributosActa.CorrelativoJrv"/>.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de la JRV encontrada.</returns>
        public static List<string> BuscarJRV_Controller()
        {
            return ModelActas.BuscarJRV(CorrelativoJrv);
        }

        /// <summary>
        /// Verifica si existe una JRV con el correlativo indicado en <see cref="AtributosActa.CorrelativoJrv"/>.
        /// </summary>
        /// <returns><c>true</c> si la JRV existe; en caso contrario, <c>false</c>.</returns>
        public static bool ExistenciaJRV_Controller()
        {
            return ModelActas.ExistenciaJRV(CorrelativoJrv);
        }

        /// <summary>
        /// Registra una nueva acta con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosActas_Controller()
        {
            return ModelActas.RegistrarActas(Cantidad_Boletas, JRV);
        }

        /// <summary>
        /// Obtiene todas las actas registradas en el sistema.
        /// </summary>
        /// <returns>Tabla con el listado de actas.</returns>
        public static DataTable CargarActas_Controller()
        {
            return ModelActas.ObtenerActas();
        }

        /// <summary>
        /// Carga los datos de una JRV mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador de la JRV a consultar.</param>
        /// <returns>Tabla con los datos relacionados de la JRV.</returns>
        public DataTable CargarJRVInnerJoin_Controller(string id)
        {
            return ModelActas.CargarJRVInner(id);
        }

        /// <summary>
        /// Actualiza los datos de una acta existente con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarDatos_Controller()
        {
            return ModelActas.ActualizarActas(id_Acta, Cantidad_Boletas, JRV);
        }

        /// <summary>
        /// Elimina una acta del sistema según el identificador de la instancia actual.
        /// </summary>
        /// <returns>Código de resultado de la operación de eliminación.</returns>
        public int EliminarActa_Controller()
        {
            return ModelActas.EliminarActa(id_Acta);
        }
    }

    /// <summary>
    /// Contiene los atributos de una acta electoral utilizados por la capa Controlador.
    /// </summary>
    public class AtributosActa
    {
        /// <summary>Identificador único de la acta.</summary>
        public int id_Acta { get; set; }

        /// <summary>Cantidad de boletas registradas en el acta.</summary>
        public string Cantidad_Boletas { get; set; }

        /// <summary>Correlativo de la JRV asociada a la búsqueda o validación.</summary>
        public static string CorrelativoJrv { get; set; }

        /// <summary>Identificador de la JRV vinculada al acta.</summary>
        public int JRV { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosActa"/>.</summary>
        public AtributosActa() { }
    }
}
