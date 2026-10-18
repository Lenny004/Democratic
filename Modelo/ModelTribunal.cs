using System;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>
    /// Capa Modelo: acceso a datos MySQL. Registro de la organización electoral
    /// y su sede principal. Tabla física: tb_organizacion.
    /// </summary>
    public class ModelTribunal
    {
        /// <summary>
        /// Registra una nueva organización electoral con sus datos y sede principal.
        /// </summary>
        /// <param name="fundacion">Fecha de fundación.</param>
        /// <param name="composicion">Descripción o composición de la organización.</param>
        /// <param name="imagenOrganizacion">Imagen en formato codificado.</param>
        /// <param name="pais">País de la organización.</param>
        /// <param name="tipo">Tipo de organización.</param>
        /// <param name="jurisdiccion">Jurisdicción territorial.</param>
        /// <param name="sede">Sede principal.</param>
        /// <param name="correoOrganizacion">Correo de contacto.</param>
        /// <param name="contrasenaOrganizacion">Contraseña de contacto.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarOrganizacionElectoral(string fundacion, string composicion, string imagenOrganizacion, string pais, string tipo, string jurisdiccion, string sede, string correoOrganizacion, string contrasenaOrganizacion)
        {
            bool retorno;
            try
            {
                retorno = Convert.ToBoolean(Conexion.ExecuteNonQuery("INSERT INTO tb_organizacion (fecha_fundacion, descripcion, imagen, pais, tipo_organizacion, jurisdiccion, sede_principal, correo, contrasena_contacto) VALUES (?fundacion, ?descripcion, ?imagen, ?pais, ?tipo, ?jurisdiccion, ?sede, ?correo, ?contrasena)", new MySqlParameter("fundacion", fundacion), new MySqlParameter("descripcion", composicion), new MySqlParameter("imagen", imagenOrganizacion), new MySqlParameter("pais", pais), new MySqlParameter("tipo", tipo), new MySqlParameter("jurisdiccion", jurisdiccion), new MySqlParameter("sede", sede), new MySqlParameter("correo", correoOrganizacion), new MySqlParameter("contrasena", contrasenaOrganizacion)));
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
    }
}
