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
    /// Registro de la Organización (tbtribunal).
    /// Organizacion = ente rector del proceso (junta, comisión, asociación, etc.).
    /// </summary>
    public class TribunalController : AtributosTribunal
    {
        public bool EnviarDatosOrganizacion_Controller()
        {
            return EnviarDatosTribunal_Controller();
        }

        public bool EnviarDatosTribunal_Controller()
        {
            return ModelTribunal.RegistrarTribunal(fundacion, composicion, imagenTribunal, pais, tipo, jurisdicción, sede, correotribunal, contratribunal);
        }
    }

    /// <summary>Atributos de la Organización (mapeo tbtribunal).</summary>
    public class AtributosTribunal
    {
        public string fundacion { get; set; }
        public string composicion { get; set; }
        public string imagenTribunal { get; set; }
        public string pais { get; set; }
        public string tipo { get; set; }
        public string jurisdicción { get; set; }
        public string sede { get; set; }
        public string correotribunal { get; set; }
        public string contratribunal { get; set; }

        public AtributosTribunal() { }
    }
}
