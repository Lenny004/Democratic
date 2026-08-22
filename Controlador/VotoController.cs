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
    /// Controlador genérico de votación (plantilla reutilizable).
    /// Opcion: ítem votable en papeleta (tbcandidato).
    /// Grupo: agrupación de opciones u organizativa (tbpartido_politico).
    /// Mesa: junta receptora de votos / JRV (tbjrv).
    /// </summary>
    public class VotoController : AtributosVoto
    {
        /// <summary>Registra una boleta en la mesa (JRV) indicada.</summary>
        public bool RegistrarBoleta_Controller()
        {
            return ModelVoto.RegistrarBoleta(FechaV, idEstadoBoleta, JRV);
        }

        /// <summary>
        /// Registra el voto usando las propiedades de instancia
        /// (Grupo, Boleta, EstadoVoto, FechaV, HoraV).
        /// </summary>
        public bool RegistrarVoto_Controller()
        {
            return ModelVoto.RegistrarVoto1(Partido, Boleta, EstadoVoto, FechaV, HoraV);
        }

        /// <summary>
        /// Resuelve el id del grupo de opciones asociado a una opción de voto.
        /// Sustituye los nueve métodos BuscarIDPartidoN_Controller.
        /// </summary>
        public static List<string> BuscarIdGrupoPorOpcion_Controller(int idOpcion)
        {
            idCandidato = idOpcion;
            return ModelVoto.BuscarIDPartido1(idOpcion);
        }

        /// <summary>
        /// Registra voto para una Opción concreta resolviendo su Grupo.
        /// API genérica de un solo punto de entrada.
        /// </summary>
        public static bool RegistrarVoto(int idOpcion, int boleta, int estadoVoto, string fechaV, string horaV)
        {
            List<string> grupo = BuscarIdGrupoPorOpcion_Controller(idOpcion);
            if (grupo == null || grupo.Count == 0)
                return false;

            int idGrupo = Convert.ToInt32(grupo[0]);
            return ModelVoto.RegistrarVoto1(idGrupo, boleta, estadoVoto, fechaV, horaV);
        }

        public static List<string> ObtenerBoleta_Controller()
        {
            return ModelVoto.ObtenerBoleta();
        }

        #region Compatibilidad — delegación a API genérica

        [Obsolete("Usar BuscarIdGrupoPorOpcion_Controller(int idOpcion).")]
        public static List<string> BuscarIDPartido1_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(1);
        }

        [Obsolete("Usar BuscarIdGrupoPorOpcion_Controller(int idOpcion).")]
        public static List<string> BuscarIDPartido2_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(2);
        }

        [Obsolete("Usar BuscarIdGrupoPorOpcion_Controller(int idOpcion).")]
        public static List<string> BuscarIDPartido3_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(3);
        }

        [Obsolete("Usar BuscarIdGrupoPorOpcion_Controller(int idOpcion).")]
        public static List<string> BuscarIDPartido4_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(4);
        }

        [Obsolete("Usar BuscarIdGrupoPorOpcion_Controller(int idOpcion).")]
        public static List<string> BuscarIDPartido5_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(5);
        }

        [Obsolete("Usar BuscarIdGrupoPorOpcion_Controller(int idOpcion).")]
        public static List<string> BuscarIDPartido6_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(6);
        }

        [Obsolete("Usar BuscarIdGrupoPorOpcion_Controller(int idOpcion).")]
        public static List<string> BuscarIDPartido7_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(7);
        }

        [Obsolete("Usar BuscarIdGrupoPorOpcion_Controller(int idOpcion).")]
        public static List<string> BuscarIDPartido8_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(8);
        }

        [Obsolete("Usar BuscarIdGrupoPorOpcion_Controller(int idOpcion).")]
        public static List<string> BuscarIDPartido9_Controller()
        {
            return BuscarIdGrupoPorOpcion_Controller(9);
        }

        [Obsolete("Usar RegistrarVoto_Controller().")]
        public bool EnviarDatos1_Controller()
        {
            return RegistrarVoto_Controller();
        }

        #endregion
    }

    /// <summary>Atributos de sesión para el flujo de votación genérico.</summary>
    public class AtributosVoto
    {
        /// <summary>Id de la Opción seleccionada (tbcandidato.id_Candidato).</summary>
        public static int idCandidato { get; set; }

        /// <summary>Alias semántico de idCandidato.</summary>
        public static int idOpcion
        {
            get { return idCandidato; }
            set { idCandidato = value; }
        }

        public int idEstadoBoleta { get; set; }

        public static int CentroVotacion { get; set; }

        /// <summary>Id de la Mesa / JRV.</summary>
        public int JRV { get; set; }

        /// <summary>Id del grupo de opciones al que pertenece la opción.</summary>
        public int Partido { get; set; }

        /// <summary>Alias semántico de Partido (Grupo).</summary>
        public int idGrupo
        {
            get { return Partido; }
            set { Partido = value; }
        }

        public int Boleta { get; set; }

        public int EstadoVoto { get; set; }

        public string FechaV { get; set; }

        public string HoraV { get; set; }

        public AtributosVoto() { }
    }
}
