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
            return ModelMiembro.RegistrarMiembros(nombre, apellido, dui, Fecha_de_nacimiento, dirección, correo, telefono, estadomiembro);
        }

        public DataTable CargarEstadoMiembroInnerJoin_Controller(string id)
        {
            return ModelMiembro.CargarEstadoMiembrosInner(id);
        }

        public bool ActualizarDatosM_Controller()
        {
            return ModelMiembro.ActualizarMiembro(id_Miembro, nombre, apellido, dui, Fecha_de_nacimiento, dirección, correo, telefono, estadomiembro);
        }
    }

    public class AtributosMiembro
    {
        public int id_Miembro { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dui { get; set; }
        public string Fecha_de_nacimiento { get; set; }
        public string dirección { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public int estadomiembro { get; set; }

        //Constructor
        public AtributosMiembro() { }
    }
}
