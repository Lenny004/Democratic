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
    public class UsuariosController : AtributosUsuario
    {
        public static DataTable CargarEstadoUsuario_Controller()
        {
            return ModelUsuarios.CargarEstadosUser();
        }

        public static DataTable CargarTipoUser_Controller()
        {
            return ModelUsuarios.CargarTipoUser();
        }

        public static DataTable CargarCentroVotacion_Controller()
        {
            return ModelUsuarios.CargarCentroVotacion();
        }

        public static DataTable CargarJRV_Controller()
        {
            return ModelUsuarios.CargarJRV();
        }

        public static DataTable CargarMiembrosU_Controller()
        {
            return ModelUsuarios.CargarMiembrosUser();
        }

        public static DataTable CargarUsuarios_Controller()
        {
            return ModelUsuarios.CargarUsuario();
        }

        public bool EnviarDatosUser_Controller()
        {
            return ModelUsuarios.RegistrarUsuario(usuario, clave, intento, Estado_Usuario, Tipo_Usuario, id_JRV, id_Miembro);
        }

        public DataTable CargarEstadoUsuarioInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarEstadoUsuarioInner(id);
        }

        public DataTable CargarTipoUserInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarTipoUsuarioInner(id);
        }

        public DataTable CargarCentroVotacionInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarCentroVotacionUsuarioInner(id);
        }

        public DataTable CargarCentroVotacionInnerJoin2_Controller(int id)
        {
            return ModelUsuarios.CargarCentroVotacionUsuarioInner2(id);
        }

        public DataTable CargarJRVInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarJRVInner(id);
        }

        public DataTable CargarJRVInnerJoin2_Controller(int id)
        {
            return ModelUsuarios.CargarJRVInner2(id);
        }

        public DataTable CargarMiembrosInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarMiembroUsuarioInner(id);
        }

        public bool ActualizarDatos_Controller()
        {
            return ModelUsuarios.ActualizarUsuario(idusuario, usuario, clave, intento, Estado_Usuario, Tipo_Usuario, id_JRV, id_Miembro);
        }

        public int EliminarUsuario_Controller()
        {
            return ModelUsuarios.EliminarUsuario(idusuario);
        }

    }

    public class AtributosUsuario
    {
        public int idusuario { get; set; }

        public string usuario { get; set; }

        public string clave { get; set; }

        public int intento { get; set; }

        public int Estado_Usuario { get; set; }

        public int Tipo_Usuario { get; set; }

        public int id_JRV { get; set; }

        public int id_Miembro { get; set; }

        //Constructor
        public AtributosUsuario() { }
    }
}
