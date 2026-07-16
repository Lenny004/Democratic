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
    /// CRUD de opciones de voto (tbcandidato). Plantilla genérica reutilizable.
    /// Opcion = ítem en papeleta; Grupo = agrupación de opciones (tbpartido_politico).
    /// </summary>
    public class CandidatosController : AtributosCandidato
    {
        public static DataTable CargarEstadoOpcion_Controller()
        {
            return CargarEstadoC_Controller();
        }

        public static DataTable CargarGruposOpcion_Controller()
        {
            return CargarPartidoC_Controller();
        }

        public static DataTable CargarOpciones_Controller()
        {
            return CargarCandidato_Controller();
        }

        public static DataTable CargarEstadoC_Controller()
        {
            return ModelCandidato.CargarEstadoCandidato();
        }

        public static DataTable CargarPartidoC_Controller()
        {
            return ModelCandidato.CargarPartidoC();
        }

        public static DataTable CargarCandidato_Controller()
        {
            return ModelCandidato.CargarCandidato();
        }

        public bool EnviarDatosOpcion_Controller()
        {
            return EnviarDatosCandidato_Controller();
        }

        public bool EnviarDatosCandidato_Controller()
        {
            return ModelCandidato.RegistrarCandidato(Nombre_Candidato, Apellido_Candidato, Género, Imagen_Candidato, Partido, Estado_Candidato);
        }

        public static byte[] RecuperarImagenOpcion_Controller(int id)
        {
            return RecuperarimagenPartido_Controller(id);
        }

        public static byte[] RecuperarimagenPartido_Controller(int id)
        {
            return ModelCandidato.ModelRecuperarImagenCandidato(id);
        }

        public DataTable CargarEstadoOpcionInnerJoin_Controller(string id)
        {
            return CargarEstadoCandidatoInnerJoin_Controller(id);
        }

        public DataTable CargarEstadoCandidatoInnerJoin_Controller(string id)
        {
            return ModelCandidato.CargarEstadoCandidatoInner(id);
        }

        public DataTable CargarGrupoOpcionInnerJoin_Controller(string id)
        {
            return CargarPartidoCInnerJoin_Controller(id);
        }

        public DataTable CargarPartidoCInnerJoin_Controller(string id)
        {
            return ModelCandidato.CargarPartidoCInner(id);
        }

        public bool ActualizarDatosOpcion_Controller()
        {
            return ActualizarDatosCandidato_Controller();
        }

        public bool ActualizarDatosCandidato_Controller()
        {
            return ModelCandidato.ActualizarCandidato(id_Candidato, Nombre_Candidato, Apellido_Candidato, Género, Imagen_Candidato, Partido, Estado_Candidato);
        }

        public int EliminarOpcion_Controller()
        {
            return EliminarCandidato_Controller();
        }

        public int EliminarCandidato_Controller()
        {
            return ModelCandidato.EliminarCandidato(id_Candidato);
        }

        public bool TruncateOpciones_Controller()
        {
            return TruncateCandidato_Controller();
        }

        public bool TruncateCandidato_Controller()
        {
            return ModelCandidato.TruncateCandidato();
        }
    }

    /// <summary>Atributos de una Opción de voto (mapeo tbcandidato).</summary>
    public class AtributosCandidato
    {
        /// <summary>Id de la Opción (id_Candidato en BD).</summary>
        public int id_Candidato { get; set; }

        /// <summary>Alias semántico de id_Candidato.</summary>
        public int id_Opcion
        {
            get { return id_Candidato; }
            set { id_Candidato = value; }
        }

        public string Nombre_Candidato { get; set; }
        public string Apellido_Candidato { get; set; }
        public string Género { get; set; }
        public string Imagen_Candidato { get; set; }

        /// <summary>Id del Grupo al que pertenece la Opción (id_Partido).</summary>
        public int Partido { get; set; }

        /// <summary>Alias semántico de Partido.</summary>
        public int id_Grupo
        {
            get { return Partido; }
            set { Partido = value; }
        }

        public int Estado_Candidato { get; set; }

        public AtributosCandidato() { }
    }
}
