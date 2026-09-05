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
    /// Coordina el registro de la Organización electoral (tbtribunal) entre la Vista y el Modelo.
    /// Organización = ente rector del proceso (junta, comisión, asociación, etc.).
    /// </summary>
    public class TribunalController : AtributosTribunal
    {
        /// <summary>
        /// Delega al método genérico <see cref="EnviarDatosTribunal_Controller"/>.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosOrganizacion_Controller()
        {
            return EnviarDatosTribunal_Controller();
        }

        /// <summary>
        /// Registra una nueva organización electoral con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosTribunal_Controller()
        {
            return ModelTribunal.RegistrarOrganizacionElectoral(fundacion, composicion, imagenTribunal, pais, tipo, jurisdicción, sede, correotribunal, contratribunal);
        }
    }

    /// <summary>
    /// Contiene los atributos de la Organización electoral (mapeo tbtribunal) utilizados por la capa Controlador.
    /// </summary>
    public class AtributosTribunal
    {
        /// <summary>Fecha de fundación de la organización.</summary>
        public string fundacion { get; set; }

        /// <summary>Composición o estructura de la organización.</summary>
        public string composicion { get; set; }

        /// <summary>Ruta o referencia de la imagen del tribunal.</summary>
        public string imagenTribunal { get; set; }

        /// <summary>País donde opera la organización.</summary>
        public string pais { get; set; }

        /// <summary>Tipo de organización electoral.</summary>
        public string tipo { get; set; }

        /// <summary>Jurisdicción territorial de la organización.</summary>
        public string jurisdicción { get; set; }

        /// <summary>Sede principal de la organización.</summary>
        public string sede { get; set; }

        /// <summary>Correo electrónico de contacto del tribunal.</summary>
        public string correotribunal { get; set; }

        /// <summary>Contraseña o credencial de acceso del tribunal.</summary>
        public string contratribunal { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosTribunal"/>.</summary>
        public AtributosTribunal() { }
    }
}
