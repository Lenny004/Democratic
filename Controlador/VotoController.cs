using System;
using System.Collections.Generic;
using Modelo;

namespace Controlador
{
    /// <summary>
    /// Coordina el proceso de votación (tb_boleta, tb_voto, tb_opcion) entre la Vista y el Modelo.
    /// Controlador genérico para registro de boletas y emisión de votos.
    /// </summary>
    public class VotoController : AtributosVoto
    {
        /// <summary>
        /// Registra una nueva boleta con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool RegistrarBoleta_Controller()
        {
            return ModelVoto.RegistrarBoleta(FechaV, idEstadoBoleta, JRV);
        }

        /// <summary>
        /// Registra un voto por grupo con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool RegistrarVoto_Controller()
        {
            return ModelVoto.RegistrarVotoPorGrupo(Partido, Boleta, EstadoVoto, FechaV, HoraV);
        }

        /// <summary>
        /// Busca el identificador del grupo de opciones asociado a una opción de voto.
        /// </summary>
        /// <param name="idOpcion">Identificador de la opción de voto.</param>
        /// <returns>Lista de cadenas con los datos del grupo de opciones.</returns>
        public static List<string> BuscarIdGrupoPorOpcion_Controller(int idOpcion)
        {
            idCandidato = idOpcion;
            return ModelVoto.ObtenerGrupoOpcionesDeOpcion(idOpcion);
        }

        /// <summary>
        /// Registra un voto para una opción específica, resolviendo su grupo asociado.
        /// </summary>
        /// <param name="idOpcion">Identificador de la opción seleccionada.</param>
        /// <param name="boleta">Número de boleta del voto.</param>
        /// <param name="estadoVoto">Estado del voto emitido.</param>
        /// <param name="fechaV">Fecha del voto.</param>
        /// <param name="horaV">Hora del voto.</param>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public static bool RegistrarVoto(int idOpcion, int boleta, int estadoVoto, string fechaV, string horaV)
        {
            List<string> grupo = BuscarIdGrupoPorOpcion_Controller(idOpcion);
            if (grupo == null || grupo.Count == 0)
            {
                return false;
            }

            int idGrupo = Convert.ToInt32(grupo[0]);
            return ModelVoto.RegistrarVotoPorGrupo(idGrupo, boleta, estadoVoto, fechaV, horaV);
        }

        /// <summary>
        /// Obtiene el identificador de la última boleta registrada.
        /// </summary>
        /// <returns>Lista de cadenas con los datos de la última boleta.</returns>
        public static List<string> ObtenerBoleta_Controller()
        {
            return ModelVoto.ObtenerUltimaBoleta();
        }

        /// <summary>
        /// Delega al método genérico <see cref="BuscarIdGrupoPorOpcion_Controller"/> para la opción 1.
        /// </summary>
        /// <returns>Lista de cadenas con el grupo de la opción 1.</returns>
        public static List<string> BuscarIDPartido1_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(1);
        }

        /// <summary>
        /// Delega al método genérico <see cref="BuscarIdGrupoPorOpcion_Controller"/> para la opción 2.
        /// </summary>
        /// <returns>Lista de cadenas con el grupo de la opción 2.</returns>
        public static List<string> BuscarIDPartido2_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(2);
        }

        /// <summary>
        /// Delega al método genérico <see cref="BuscarIdGrupoPorOpcion_Controller"/> para la opción 3.
        /// </summary>
        /// <returns>Lista de cadenas con el grupo de la opción 3.</returns>
        public static List<string> BuscarIDPartido3_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(3);
        }

        /// <summary>
        /// Delega al método genérico <see cref="BuscarIdGrupoPorOpcion_Controller"/> para la opción 4.
        /// </summary>
        /// <returns>Lista de cadenas con el grupo de la opción 4.</returns>
        public static List<string> BuscarIDPartido4_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(4);
        }

        /// <summary>
        /// Delega al método genérico <see cref="BuscarIdGrupoPorOpcion_Controller"/> para la opción 5.
        /// </summary>
        /// <returns>Lista de cadenas con el grupo de la opción 5.</returns>
        public static List<string> BuscarIDPartido5_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(5);
        }

        /// <summary>
        /// Delega al método genérico <see cref="BuscarIdGrupoPorOpcion_Controller"/> para la opción 6.
        /// </summary>
        /// <returns>Lista de cadenas con el grupo de la opción 6.</returns>
        public static List<string> BuscarIDPartido6_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(6);
        }

        /// <summary>
        /// Delega al método genérico <see cref="BuscarIdGrupoPorOpcion_Controller"/> para la opción 7.
        /// </summary>
        /// <returns>Lista de cadenas con el grupo de la opción 7.</returns>
        public static List<string> BuscarIDPartido7_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(7);
        }

        /// <summary>
        /// Delega al método genérico <see cref="BuscarIdGrupoPorOpcion_Controller"/> para la opción 8.
        /// </summary>
        /// <returns>Lista de cadenas con el grupo de la opción 8.</returns>
        public static List<string> BuscarIDPartido8_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(8);
        }

        /// <summary>
        /// Delega al método genérico <see cref="BuscarIdGrupoPorOpcion_Controller"/> para la opción 9.
        /// </summary>
        /// <returns>Lista de cadenas con el grupo de la opción 9.</returns>
        public static List<string> BuscarIDPartido9_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(9);
        }

        /// <summary>
        /// Delega al método genérico <see cref="RegistrarVoto_Controller"/>.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatos1_Controller()
        {
            return RegistrarVoto_Controller();
        }
    }

    /// <summary>
    /// Contiene los atributos de votación utilizados por la capa Controlador.
    /// </summary>
    public class AtributosVoto
    {
        /// <summary>Identificador de la opción o candidato seleccionado.</summary>
        public static int idCandidato { get; set; }

        /// <summary>Alias semántico de <see cref="idCandidato"/>.</summary>
        public static int idOpcion
        {
            get { return idCandidato; }
            set { idCandidato = value; }
        }

        /// <summary>Identificador del estado de la boleta.</summary>
        public int idEstadoBoleta { get; set; }

        /// <summary>Identificador del centro de votación.</summary>
        public static int CentroVotacion { get; set; }

        /// <summary>Identificador de la JRV donde se emite el voto.</summary>
        public int JRV { get; set; }

        /// <summary>Identificador del grupo o partido del voto.</summary>
        public int Partido { get; set; }

        /// <summary>Alias semántico de <see cref="Partido"/>.</summary>
        public int idGrupo
        {
            get { return Partido; }
            set { Partido = value; }
        }

        /// <summary>Número de boleta asociada al voto.</summary>
        public int Boleta { get; set; }

        /// <summary>Identificador del estado del voto.</summary>
        public int EstadoVoto { get; set; }

        /// <summary>Fecha de emisión del voto.</summary>
        public string FechaV { get; set; }

        /// <summary>Hora de emisión del voto.</summary>
        public string HoraV { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosVoto"/>.</summary>
        public AtributosVoto() { }
    }
}
