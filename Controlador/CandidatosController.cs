using System;
using System.Collections.Generic;
using System.Data;
using Modelo;

namespace Controlador
{
    /// <summary>
    /// Coordina el CRUD de opciones de votación (tb_opcion) entre la Vista y el Modelo.
    /// Plantilla genérica reutilizable para candidatos u opciones de papeleta.
    /// </summary>
    public class CandidatosController : AtributosCandidato
    {
        /// <summary>
        /// Carga los estados disponibles para una opción de voto.
        /// </summary>
        /// <returns>Tabla con los estados de opción.</returns>
        public static DataTable CargarEstadoOpcion_Controller()
        {
            return ModelCandidato.CargarEstadoOpcion();
        }

        /// <summary>
        /// Carga los grupos de opciones (partidos u organizaciones) disponibles.
        /// </summary>
        /// <returns>Tabla con los grupos de opciones.</returns>
        public static DataTable CargarGruposOpcion_Controller()
        {
            return ModelCandidato.CargarGruposOpciones();
        }

        /// <summary>
        /// Carga el listado completo de opciones de voto registradas.
        /// </summary>
        /// <returns>Tabla con las opciones de voto.</returns>
        public static DataTable CargarOpciones_Controller()
        {
            return ModelCandidato.CargarOpciones();
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarEstadoOpcion_Controller"/>.
        /// </summary>
        /// <returns>Tabla con los estados de opción.</returns>
        public static DataTable CargarEstadoC_Controller()
        {
            return CargarEstadoOpcion_Controller();
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarGruposOpcion_Controller"/>.
        /// </summary>
        /// <returns>Tabla con los grupos de opciones.</returns>
        public static DataTable CargarPartidoC_Controller()
        {
            return CargarGruposOpcion_Controller();
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarOpciones_Controller"/>.
        /// </summary>
        /// <returns>Tabla con las opciones de voto.</returns>
        public static DataTable CargarCandidato_Controller()
        {
            return CargarOpciones_Controller();
        }

        /// <summary>
        /// Registra una nueva opción de voto con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosOpcion_Controller()
        {
            return ModelCandidato.RegistrarOpcion(
                Nombre_Candidato,
                Apellido_Candidato,
                Género,
                Imagen_Candidato,
                Partido,
                Estado_Candidato);
        }

        /// <summary>
        /// Delega al método genérico <see cref="EnviarDatosOpcion_Controller"/>.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosCandidato_Controller()
        {
            return EnviarDatosOpcion_Controller();
        }

        /// <summary>
        /// Recupera la imagen asociada a una opción de voto.
        /// </summary>
        /// <param name="id">Identificador de la opción.</param>
        /// <returns>Arreglo de bytes con la imagen de la opción.</returns>
        public static byte[] RecuperarImagenOpcion_Controller(int id)
        {
            return ModelCandidato.RecuperarImagenOpcion(id);
        }

        /// <summary>
        /// Delega al método genérico <see cref="RecuperarImagenOpcion_Controller"/>.
        /// </summary>
        /// <param name="id">Identificador de la opción.</param>
        /// <returns>Arreglo de bytes con la imagen de la opción.</returns>
        public static byte[] RecuperarimagenPartido_Controller(int id)
        {
            return RecuperarImagenOpcion_Controller(id);
        }

        /// <summary>
        /// Carga el estado de una opción mediante consulta con inner join por nombre.
        /// </summary>
        /// <param name="id">Nombre o identificador de la opción a consultar.</param>
        /// <returns>Tabla con los datos del estado de la opción.</returns>
        public DataTable CargarEstadoOpcionInnerJoin_Controller(string id)
        {
            return ModelCandidato.CargarEstadoOpcionPorNombre(id);
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarEstadoOpcionInnerJoin_Controller"/>.
        /// </summary>
        /// <param name="id">Nombre o identificador de la opción a consultar.</param>
        /// <returns>Tabla con los datos del estado de la opción.</returns>
        public DataTable CargarEstadoCandidatoInnerJoin_Controller(string id)
        {
            return CargarEstadoOpcionInnerJoin_Controller(id);
        }

        /// <summary>
        /// Carga un grupo de opciones mediante consulta con inner join por nombre.
        /// </summary>
        /// <param name="id">Nombre o identificador del grupo a consultar.</param>
        /// <returns>Tabla con los datos del grupo de opciones.</returns>
        public DataTable CargarGrupoOpcionInnerJoin_Controller(string id)
        {
            return ModelCandidato.CargarGrupoOpcionesPorNombre(id);
        }

        /// <summary>
        /// Delega al método genérico <see cref="CargarGrupoOpcionInnerJoin_Controller"/>.
        /// </summary>
        /// <param name="id">Nombre o identificador del grupo a consultar.</param>
        /// <returns>Tabla con los datos del grupo de opciones.</returns>
        public DataTable CargarPartidoCInnerJoin_Controller(string id)
        {
            return CargarGrupoOpcionInnerJoin_Controller(id);
        }

        /// <summary>
        /// Actualiza una opción de voto existente con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarDatosOpcion_Controller()
        {
            return ModelCandidato.ActualizarOpcion(
                id_Candidato,
                Nombre_Candidato,
                Apellido_Candidato,
                Género,
                Imagen_Candidato,
                Partido,
                Estado_Candidato);
        }

        /// <summary>
        /// Delega al método genérico <see cref="ActualizarDatosOpcion_Controller"/>.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarDatosCandidato_Controller()
        {
            return ActualizarDatosOpcion_Controller();
        }

        /// <summary>
        /// Elimina una opción de voto según el identificador de la instancia actual.
        /// </summary>
        /// <returns>Código de resultado de la operación de eliminación.</returns>
        public int EliminarOpcion_Controller()
        {
            return ModelCandidato.EliminarOpcion(id_Candidato);
        }

        /// <summary>
        /// Delega al método genérico <see cref="EliminarOpcion_Controller"/>.
        /// </summary>
        /// <returns>Código de resultado de la operación de eliminación.</returns>
        public int EliminarCandidato_Controller()
        {
            return EliminarOpcion_Controller();
        }

        /// <summary>
        /// Elimina todas las opciones de voto de la tabla (truncate).
        /// </summary>
        /// <returns><c>true</c> si la operación fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool TruncateOpciones_Controller()
        {
            return ModelCandidato.TruncateOpciones();
        }

        /// <summary>
        /// Delega al método genérico <see cref="TruncateOpciones_Controller"/>.
        /// </summary>
        /// <returns><c>true</c> si la operación fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool TruncateCandidato_Controller()
        {
            return TruncateOpciones_Controller();
        }
    }

    /// <summary>
    /// Contiene los atributos de una opción de voto utilizados por la capa Controlador.
    /// </summary>
    public class AtributosCandidato
    {
        /// <summary>Identificador único de la opción o candidato.</summary>
        public int id_Candidato { get; set; }

        /// <summary>Alias semántico de <see cref="id_Candidato"/>.</summary>
        public int id_Opcion
        {
            get { return id_Candidato; }
            set { id_Candidato = value; }
        }

        /// <summary>Nombre de la opción o candidato.</summary>
        public string Nombre_Candidato { get; set; }

        /// <summary>Apellido de la opción o candidato.</summary>
        public string Apellido_Candidato { get; set; }

        /// <summary>Género de la opción o candidato.</summary>
        public string Género { get; set; }

        /// <summary>Ruta o referencia de la imagen de la opción.</summary>
        public string Imagen_Candidato { get; set; }

        /// <summary>Identificador del grupo o partido al que pertenece la opción.</summary>
        public int Partido { get; set; }

        /// <summary>Alias semántico de <see cref="Partido"/>.</summary>
        public int id_Grupo
        {
            get { return Partido; }
            set { Partido = value; }
        }

        /// <summary>Identificador del estado de la opción o candidato.</summary>
        public int Estado_Candidato { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosCandidato"/>.</summary>
        public AtributosCandidato() { }
    }
}
