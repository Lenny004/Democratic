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
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_organizacion (fecha_fundacion, descripcion, imagen, pais, tipo_organizacion, jurisdiccion, sede_principal, correo, contrasena_contacto) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", fundacion, composicion, imagenOrganizacion, pais, tipo, jurisdiccion, sede, correoOrganizacion, contrasenaOrganizacion), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
    }
}
