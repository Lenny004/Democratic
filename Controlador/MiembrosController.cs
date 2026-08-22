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
    public class MiembrosController : AtributosMiembro
    {
        public static DataTable CargarEstadoMiembro_Controller()
        {
            return ModelMiembro.CargarEstadoMiembro();
        }

        public static DataTable CargarMiembros_Controller()
        {
            return ModelMiembro.CargarMiembro();
        }

        public bool EnviarDatosMiembro_Controller()
        {
            return ModelMiembro.RegistrarMiembros(nombre, apellido, dui, OCR, ImagenM, Fecha_de_nacimiento, dirección, telefono, CV, JRV, estadomiembro);
        }

        public DataTable CargarCentroVotacionInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarCentroVotacionUsuarioInner(id);
        }

        public DataTable CargarJRVInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarJRVInner(id);
        }

        public DataTable CargarEstadoMiembroInnerJoin_Controller(string id)
        {
            return ModelMiembro.CargarEstadoMiembrosInner(id);
        }

        public bool ActualizarDatosM_Controller()
        {
            return ModelMiembro.ActualizarMiembro(id_Miembro, nombre, apellido, dui, OCR, ImagenM, Fecha_de_nacimiento, dirección, telefono, CV, JRV, estadomiembro);
        }
    }

    public class AtributosMiembro
    {
        public int id_Miembro { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dui { get; set; }
        public string OCR { get; set; }
        public string ImagenM { get; set; }
        public string Fecha_de_nacimiento { get; set; }
        public string dirección { get; set; }
        public string telefono { get; set; }
        public int CV { get; set; }
        public int JRV { get; set; }
        public int estadomiembro { get; set; }

        //Constructor
        public AtributosMiembro() { }
    }
}
