using System;
using MySql.Data.MySqlClient;

namespace Modelo
{
    /// <summary>
    /// Registro de la Organización y su Sede (plantilla genérica).
    /// Tabla física: tbtribunal.
    /// </summary>
    public class ModelTribunal
    {
        /// <summary>Registra datos de la Organización y la Sede asociada.</summary>
        public static bool RegistrarOrganizacionElectoral(string fundacion, string composicion, string imagenOrganizacion, string pais, string tipo, string jurisdiccion, string sede, string correoOrganizacion, string contrasenaOrganizacion)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbtribunal (Fundación, Composición, Imagen_Tribunal, Pais, Tipo, Jurisdicción, Sede, Correo_electronicoTribunal, Contra_Tribunal) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", fundacion, composicion, imagenOrganizacion, pais, tipo, jurisdiccion, sede, correoOrganizacion, contrasenaOrganizacion), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>Wrapper de compatibilidad con controladores existentes.</summary>
        public static bool RegistrarTribunal(string fundacion, string composicion, string imagenTribunal, string pais, string tipo, string jurisdicción, string sede, string correotribunal, string contratribunal)
        {
            return RegistrarOrganizacionElectoral(fundacion, composicion, imagenTribunal, pais, tipo, jurisdicción, sede, correotribunal, contratribunal);
        }
    }
}
