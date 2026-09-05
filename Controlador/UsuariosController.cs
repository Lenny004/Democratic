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
    /// Coordina la gestión de usuarios del sistema entre la Vista y el Modelo.
    /// Permite registrar, consultar, actualizar y eliminar cuentas de acceso.
    /// </summary>
    public class UsuariosController : AtributosUsuario
    {
        /// <summary>
        /// Carga los estados disponibles para un usuario.
        /// </summary>
        /// <returns>Tabla con los estados de usuario.</returns>
        public static DataTable CargarEstadoUsuario_Controller()
        {
            return ModelUsuarios.CargarEstadosUser();
        }

        /// <summary>
        /// Carga los tipos de usuario disponibles en el sistema.
        /// </summary>
        /// <returns>Tabla con los tipos de usuario.</returns>
        public static DataTable CargarTipoUser_Controller()
        {
            return ModelUsuarios.CargarTipoUser();
        }

        /// <summary>
        /// Carga el listado de centros de votación disponibles.
        /// </summary>
        /// <returns>Tabla con los centros de votación.</returns>
        public static DataTable CargarCentroVotacion_Controller()
        {
            return ModelUsuarios.CargarCentroVotacion();
        }

        /// <summary>
        /// Carga el listado de JRV disponibles.
        /// </summary>
        /// <returns>Tabla con las JRV.</returns>
        public static DataTable CargarJRV_Controller()
        {
            return ModelUsuarios.CargarJRV();
        }

        /// <summary>
        /// Carga el listado de miembros disponibles para vincular a usuarios.
        /// </summary>
        /// <returns>Tabla con los miembros.</returns>
        public static DataTable CargarMiembrosU_Controller()
        {
            return ModelUsuarios.CargarMiembrosUser();
        }

        /// <summary>
        /// Carga el listado completo de usuarios registrados.
        /// </summary>
        /// <returns>Tabla con los usuarios.</returns>
        public static DataTable CargarUsuarios_Controller()
        {
            return ModelUsuarios.CargarUsuario();
        }

        /// <summary>
        /// Registra un nuevo usuario con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosUser_Controller()
        {
            return ModelUsuarios.RegistrarUsuario(usuario, clave, intento, Estado_Usuario, Tipo_Usuario, id_JRV, id_Miembro);
        }

        /// <summary>
        /// Registra el primer superadministrador durante la configuración inicial.
        /// </summary>
        /// <returns><c>true</c> si el registro fue exitoso; en caso contrario, <c>false</c>.</returns>
        public bool EnviarDatosUsuarioRoot_Controller()
        {
            return ModelUsuarios.RegistrarUsuarioRoot(usuario, clave);
        }

        /// <summary>
        /// Carga el estado de un usuario mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador del estado a consultar.</param>
        /// <returns>Tabla con los datos del estado del usuario.</returns>
        public DataTable CargarEstadoUsuarioInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarEstadoUsuarioInner(id);
        }

        /// <summary>
        /// Carga el tipo de usuario mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador del tipo a consultar.</param>
        /// <returns>Tabla con los datos del tipo de usuario.</returns>
        public DataTable CargarTipoUserInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarTipoUsuarioInner(id);
        }

        /// <summary>
        /// Carga datos de centro de votación mediante consulta con inner join por cadena.
        /// </summary>
        /// <param name="id">Identificador del centro de votación a consultar.</param>
        /// <returns>Tabla con los datos relacionados del centro.</returns>
        public DataTable CargarCentroVotacionInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarCentroVotacionUsuarioInner(id);
        }

        /// <summary>
        /// Carga datos de centro de votación mediante consulta con inner join por entero.
        /// </summary>
        /// <param name="id">Identificador numérico del centro de votación a consultar.</param>
        /// <returns>Tabla con los datos relacionados del centro.</returns>
        public DataTable CargarCentroVotacionInnerJoin2_Controller(int id)
        {
            return ModelUsuarios.CargarCentroVotacionUsuarioInner2(id);
        }

        /// <summary>
        /// Carga datos de JRV mediante consulta con inner join por cadena.
        /// </summary>
        /// <param name="id">Identificador de la JRV a consultar.</param>
        /// <returns>Tabla con los datos relacionados de la JRV.</returns>
        public DataTable CargarJRVInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarJRVInner(id);
        }

        /// <summary>
        /// Carga datos de JRV mediante consulta con inner join por entero.
        /// </summary>
        /// <param name="id">Identificador numérico de la JRV a consultar.</param>
        /// <returns>Tabla con los datos relacionados de la JRV.</returns>
        public DataTable CargarJRVInnerJoin2_Controller(int id)
        {
            return ModelUsuarios.CargarJRVInner2(id);
        }

        /// <summary>
        /// Carga datos de miembro mediante consulta con inner join.
        /// </summary>
        /// <param name="id">Identificador del miembro a consultar.</param>
        /// <returns>Tabla con los datos relacionados del miembro.</returns>
        public DataTable CargarMiembrosInnerJoin_Controller(string id)
        {
            return ModelUsuarios.CargarMiembroUsuarioInner(id);
        }

        /// <summary>
        /// Actualiza un usuario existente con los atributos de la instancia actual.
        /// </summary>
        /// <returns><c>true</c> si la actualización fue exitosa; en caso contrario, <c>false</c>.</returns>
        public bool ActualizarDatos_Controller()
        {
            return ModelUsuarios.ActualizarUsuario(idusuario, usuario, clave, intento, Estado_Usuario, Tipo_Usuario, id_JRV, id_Miembro);
        }

        /// <summary>
        /// Elimina un usuario según el identificador de la instancia actual.
        /// </summary>
        /// <returns>Código de resultado de la operación de eliminación.</returns>
        public int EliminarUsuario_Controller()
        {
            return ModelUsuarios.EliminarUsuario(idusuario);
        }

    }

    /// <summary>
    /// Contiene los atributos de un usuario del sistema utilizados por la capa Controlador.
    /// </summary>
    public class AtributosUsuario
    {
        /// <summary>Identificador único del usuario.</summary>
        public int idusuario { get; set; }

        /// <summary>Nombre de usuario para autenticación.</summary>
        public string usuario { get; set; }

        /// <summary>Clave o contraseña del usuario.</summary>
        public string clave { get; set; }

        /// <summary>Contador de intentos de acceso fallidos.</summary>
        public int intento { get; set; }

        /// <summary>Identificador del estado del usuario.</summary>
        public int Estado_Usuario { get; set; }

        /// <summary>Identificador del tipo o rol del usuario.</summary>
        public int Tipo_Usuario { get; set; }

        /// <summary>Identificador de la JRV asignada al usuario.</summary>
        public int id_JRV { get; set; }

        /// <summary>Identificador del miembro vinculado al usuario.</summary>
        public int id_Miembro { get; set; }

        /// <summary>Inicializa una nueva instancia de <see cref="AtributosUsuario"/>.</summary>
        public AtributosUsuario() { }
    }
}
