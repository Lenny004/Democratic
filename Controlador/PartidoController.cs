using System;
using System.Data;
using Modelo;

namespace Controlador
{
    /// <summary>
    /// Coordina el CRUD de grupos de opciones (tb_grupo_opciones) entre la Vista y el Modelo.
    /// Gestiona partidos u organizaciones que agrupan candidatos en la papeleta.
    /// </summary>
    public class PartidoController : AtributosPartido
    {
        /// <summary>
        /// Carga los estados disponibles para un grupo de opciones.
        /// </summary>
        /// <returns>Tabla con los estados de grupo.</returns>
        public static DataTable CargarEstadoGrupo_Controller()
        {
            return ModelPartido.CargarEstadoOrganizacion();
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarEstadoGrupo_Controller"/>.
        /// </summary>
        /// <returns>Tabla con los estados de partido.</returns>
        public static DataTable CargarEstadoPartido_Controller()
        {
            return CargarEstadoGrupo_Controller();
        }

        /// <summary>
        /// Registra un nuevo grupo de opciones con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosGrupo_Controller()
        {
            return ModelPartido.RegistrarOrganizacion(image, nombrep, Cantidadvotosp, Estado_Partido);
        }

        /// <summary>
        /// Delega al método genérico <see cref="EnviarDatosGrupo_Controller"/>.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosPartido_Controller()
        {
            return EnviarDatosGrupo_Controller();
        }

        /// <summary>
        /// Carga el listado completo de grupos de opciones registrados.
        /// </summary>
        /// <returns>Tabla con los grupos de opciones.</returns>
        public static DataTable CargarGrupos_Controller()
        {
            return ModelPartido.CargarOrganizaciones();
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarGrupos_Controller"/>.
        /// </summary>
        /// <returns>Tabla con los partidos.</returns>
        public static DataTable CargarPartido_Controller()
        {
            return CargarGrupos_Controller();
        }

        /// <summary>
        /// Recupera la imagen asociada a un grupo de opciones.
        /// </summary>
        /// <param name="id">Identificador del grupo.</param>
        /// <returns>Arreglo de bytes con la imagen del grupo.</returns>
        public static byte[] RecuperarImagenGrupo_Controller(int id)
        {
            return ModelPartido.RecuperarImagenOrganizacion(id);
        }

        /// <summary>
        /// Delega al método genérico <see cref="RecuperarImagenGrupo_Controller"/>.
        /// </summary>
        /// <param name="id">Identificador del partido.</param>
        /// <returns>Arreglo de bytes con la imagen del partido.</returns>
        public static byte[] RecuperarImagenPartido_Controller(int id)
        {
            return RecuperarImagenGrupo_Controller(id);
        }

        /// <summary>
        /// Carga el estado de un grupo mediante consulta con inner join por identificador.
        /// </summary>
        /// <param name="id">Identificador del grupo a consultar.</param>
        /// <returns>Tabla con los datos del estado del grupo.</returns>
        public DataTable CargarEstadoGrupoInner_Controller(string id)
        {
            return ModelPartido.CargarEstadoOrganizacionPorId(id);
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarEstadoGrupoInner_Controller"/>.
        /// </summary>
        /// <param name="id">Identificador del partido a consultar.</param>
        /// <returns>Tabla con los datos del estado del partido.</returns>
        public DataTable CargarEstadoPartidoInnerJoin_Controller(string id)
        {
            return CargarEstadoGrupoInner_Controller(id);
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarEstadoGrupoInner_Controller"/>.
        /// </summary>
        /// <param name="id">Identificador del grupo a consultar.</param>
        /// <returns>Tabla con los datos del estado de votos.</returns>
        public DataTable CargarEstadoVotosInnerJoin_Controller(string id)
        {
            return CargarEstadoGrupoInner_Controller(id);
        }

        /// <summary>
        /// Delega al método genérico <see cref="ActualizarPartido_Controller"/>.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarDatosPartido_Controller()
        {
            return ActualizarPartido_Controller();
        }

        /// <summary>
        /// Actualiza un grupo de opciones existente con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarGrupo_Controller()
        {
            return ModelPartido.ActualizarOrganizacion(idPartido, image, nombrep, Cantidadvotosp, Estado_Partido);
        }

        /// <summary>
        /// Delega al método genérico <see cref="ActualizarGrupo_Controller"/>.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarPartido_Controller()
        {
            return ActualizarGrupo_Controller();
        }

        /// <summary>
        /// Elimina un grupo de opciones según el identificador de la instancia actual.
        /// </summary>
        /// <returns>Código de resultado de la operación de eliminación.</returns>
        public int EliminarGrupo_Controller()
        {
            return ModelPartido.EliminarOrganizacion(idPartido);
        }

        /// <summary>
        /// Delega al método genérico <see cref="EliminarGrupo_Controller"/>.
        /// </summary>
        /// <returns>Código de resultado de la operación de eliminación.</returns>
        public int EliminarPartido_Controller()
        {
            return EliminarGrupo_Controller();
        }
    }

    /// <summary>
    /// Contiene los atributos de un grupo o partido utilizados por la capa Controlador.
    /// </summary>
    public class AtributosPartido
    {
        /// <summary>Identificador único del partido o grupo.</summary>
        public int idPartido { get; set; }

        /// <summary>Ruta o referencia de la imagen del partido.</summary>
        public string image { get; set; }

        /// <summary>Nombre del partido o grupo.</summary>
        public string nombrep { get; set; }

        /// <summary>Cantidad de votos registrados para el partido.</summary>
        public int Cantidadvotosp { get; set; }

        /// <summary>Identificador del estado del partido.</summary>
        public int Estado_Partido { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosPartido"/>.</summary>
        public AtributosPartido() { }
    }
}
