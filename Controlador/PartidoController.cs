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
    /// CRUD de grupos de opciones (tbpartido_politico). Plantilla genérica reutilizable.
    /// Grupo = bloque, lista o categoría organizativa según el proceso de votación.
    /// </summary>
    public class PartidoController : AtributosPartido
    {
        public static DataTable CargarEstadoGrupo_Controller()
        {
            return CargarEstadoPartido_Controller();
        }

        public static DataTable CargarEstadoPartido_Controller()
        {
            return ModelPartido.CargarEstadoPartido();
        }

        public bool EnviarDatosGrupo_Controller()
        {
            return EnviarDatosPartido_Controller();
        }

        public bool EnviarDatosPartido_Controller()
        {
            return ModelPartido.RegistrarPartido(image, nombrep, Cantidadvotosp, Estado_Partido);
        }

        public static DataTable CargarGrupos_Controller()
        {
            return CargarPartido_Controller();
        }

        public static DataTable CargarPartido_Controller()
        {
            return ModelPartido.CargarPartido();
        }

        public static byte[] RecuperarImagenGrupo_Controller(int id)
        {
            return RecuperarimagenPartido_Controller(id);
        }

        public static byte[] RecuperarimagenPartido_Controller(int id)
        {
            return ModelPartido.ModelRecuperarImagenPartido(id);
        }

        public DataTable CargarEstadoGrupoInnerJoin_Controller(string id)
        {
            return CargarEstadoVotosInnerJoin_Controller(id);
        }

        public DataTable CargarEstadoVotosInnerJoin_Controller(string id)
        {
            return ModelPartido.CargarEstadoPartidoInner(id);
        }

        public bool ActualizarDatosGrupo_Controller()
        {
            return ActualizarDatosPartido_Controller();
        }

        public bool ActualizarDatosPartido_Controller()
        {
            return ModelPartido.ActualizarPartido(idPartido, image, nombrep, Cantidadvotosp, Estado_Partido);
        }

        public int EliminarGrupo_Controller()
        {
            return EliminarPartido_Controller();
        }

        public int EliminarPartido_Controller()
        {
            return ModelPartido.EliminarPartido(idPartido);
        }
    }

    /// <summary>Atributos de un Grupo (mapeo tbpartido_politico).</summary>
    public class AtributosPartido
    {
        /// <summary>Id del Grupo (id_Partido en BD).</summary>
        public int idPartido { get; set; }

        /// <summary>Alias semántico de idPartido.</summary>
        public int id_Grupo
        {
            get { return idPartido; }
            set { idPartido = value; }
        }

        public string image { get; set; }
        public string nombrep { get; set; }
        public int Cantidadvotosp { get; set; }
        public int Estado_Partido { get; set; }

        public AtributosPartido() { }
    }
}
