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
    public class DetalleMiembrosController : AtributosDetalleMiembros
    {
        public static DataTable CargarDetalleMiembrosMiembro_Controller()
        {
            return ModelDetalleMiembro.CargarDetalleMiembrosMiembro();
        }

        public static DataTable CargarDetalleMiembrosJRV_Controller()
        {
            return ModelDetalleMiembro.CargarDetalleMiembrosJRV();
        }

        public static DataTable CargarTablaDetallesMiembro_Controller()
        {
            return ModelDetalleMiembro.CargarDatosDetalleMiembros();
        }

        public bool EnviarDatosDetalleMiembro_Controller()
        {
            return ModelDetalleMiembro.RegistrarDetalleMiembros(Detalle_de_Miembros, id_Miembro, id_JRV);
        }

        public bool ActualizarDetalleMiembros_Controller()
        {
            return ModelDetalleMiembro.ActualizarDetalleMiembros(id_Detalle, Detalle_de_Miembros, id_Miembro, id_JRV);
        }

        public int EliminarDetalleMiembro_Controller()
        {
            return ModelDetalleMiembro.EliminarDetalleMiembro(id_Detalle);
        }

        public DataTable CargarDetalleMiembroJRVInnerJoin_Controller(string id)
        {
            return ModelDetalleMiembro.CargarDetalleMiembroJRVInner(id);
        }

        public DataTable CargarDetalleMiembroMiembroInnerJoin_Controller(string id)
        {
            return ModelDetalleMiembro.CargarDetalleMiembroMiembroInner(id);
        }
    }

    public class AtributosDetalleMiembros
    {
        public int id_Detalle { get; set; }
        public string Detalle_de_Miembros { get; set; }
        public int id_Miembro { get; set; }
        public int id_JRV { get; set; }

        //Constructor
        public AtributosDetalleMiembros() { }
    }
}
