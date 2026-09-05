using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    /// <summary>
    /// Capa Modelo: acceso a datos MySQL. CRUD de participantes del padrón electoral.
    /// Tablas físicas: tb_participante, tb_sede, tb_mesa, tb_estado_participante.
    /// </summary>
    public class ModelMiembro
    {
        /// <summary>
        /// Carga los estados posibles de un participante.
        /// </summary>
        /// <returns>Tabla con id y nombre del estado, o <c>null</c> si hay error.</returns>
        public static DataTable CargarEstadoMiembro()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_estado_participante AS id_Estado_Miembros, nombre_estado AS Nombre_Estado_Miembros FROM tb_estado_participante";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.getConnect().Close();
            }
        }

        /// <summary>
        /// Obtiene el listado completo de participantes con sus relaciones.
        /// </summary>
        /// <returns>Tabla con datos de participantes, sedes y mesas, o <c>null</c> si hay error.</returns>
        public static DataTable CargarMiembro()
        {
            DataTable data;
            try
            {
                string query = "SELECT p.id_participante AS id_Miembro, p.nombre AS Nombre_Miembro, p.apellido AS Apellido_Miembro, p.documento_identidad AS DUI, p.codigo_ocr AS OCR, p.imagen AS Imagen_Miembro, p.fecha_nacimiento AS Fecha_de_nacimiento, p.direccion AS Dirección_Usuario, p.telefono AS Numero_Telefonico, s.nombre_sede AS Nombre_Centro_Votación, m.codigo_mesa AS Correlativo_JRV, ep.nombre_estado AS Nombre_Estado_Miembros FROM tb_participante p INNER JOIN tb_sede s ON p.id_sede = s.id_sede INNER JOIN tb_mesa m ON p.id_mesa = m.id_mesa INNER JOIN tb_estado_participante ep ON p.id_estado_participante = ep.id_estado_participante";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.getConnect().Close();
            }
        }

        /// <summary>
        /// Registra un nuevo participante en el padrón electoral.
        /// </summary>
        /// <param name="nombre">Nombre del participante.</param>
        /// <param name="apellido">Apellido del participante.</param>
        /// <param name="dui">Documento único de identidad.</param>
        /// <param name="OCR">Código OCR del documento.</param>
        /// <param name="ImagenM">Imagen en formato codificado.</param>
        /// <param name="Fecha_de_nacimiento">Fecha de nacimiento.</param>
        /// <param name="dirección">Dirección del participante.</param>
        /// <param name="telefono">Número telefónico.</param>
        /// <param name="CV">Identificador de la sede de votación.</param>
        /// <param name="JRV">Identificador de la mesa asignada.</param>
        /// <param name="estadomiembro">Identificador del estado del participante.</param>
        /// <returns><c>true</c> si el registro fue exitoso; <c>false</c> en caso contrario.</returns>
        public static bool RegistrarMiembros(string nombre, string apellido, string dui, string OCR, string ImagenM, string Fecha_de_nacimiento, string dirección, string telefono, int CV, int JRV, int estadomiembro)
        {
            bool retorno;
            try 
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_participante(nombre, apellido, documento_identidad, codigo_ocr, imagen, fecha_nacimiento, direccion, telefono, id_sede, id_mesa, id_estado_participante) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", nombre, apellido, dui, OCR, ImagenM, Fecha_de_nacimiento, dirección, telefono, CV, JRV, estadomiembro), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        /// <summary>
        /// Busca un estado de participante por su nombre.
        /// </summary>
        /// <param name="idestadomiembro">Nombre del estado a buscar.</param>
        /// <returns>Tabla con los datos del estado, o <c>null</c> si hay error.</returns>
        public static DataTable CargarEstadoMiembrosInner(string idestadomiembro)
        {
            DataTable data;
            try
            {
                string query = "SELECT id_estado_participante AS id_Estado_Miembros, nombre_estado AS Nombre_Estado_Miembros FROM tb_estado_participante WHERE nombre_estado = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idestadomiembro));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.getConnect().Close();
            }
        }

        /// <summary>
        /// Busca un centro de votación por su nombre.
        /// </summary>
        /// <param name="idCentro_Votacion">Nombre de la sede a buscar.</param>
        /// <returns>Tabla con los datos de la sede, o <c>null</c> si hay error.</returns>
        public static DataTable CargarCentroVotacionUsuarioInner(string idCentro_Votacion)
        {
            DataTable data;
            try
            {
                string query = "SELECT s.id_sede AS id_Centro_Votación, s.nombre_sede AS Nombre_Centro_Votación, s.id_registro_escrutinio AS id_Acta, s.cantidad_mesas AS Cantidad_de_JRV, s.id_estado_sede AS id_Estado_CentroVotación, s.id_municipio AS id_Municipio, s.id_organizacion AS id_Tribunal FROM tb_sede s WHERE s.nombre_sede = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idCentro_Votacion));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.getConnect().Close();
            }
        }

        /// <summary>
        /// Busca una mesa de votación por su código correlativo.
        /// </summary>
        /// <param name="id_JRV">Código correlativo de la mesa.</param>
        /// <returns>Tabla con los datos de la mesa, o <c>null</c> si hay error.</returns>
        public static DataTable CargarJRVInner(string id_JRV)
        {
            DataTable data;
            try
            {
                string query = "SELECT m.id_mesa AS id_JRV, m.codigo_mesa AS Correlativo_JRV, m.id_sede AS id_Centro_Votación, m.id_estado_mesa AS id_Estado_JRV FROM tb_mesa m WHERE m.codigo_mesa = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", id_JRV));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.getConnect().Close();
            }
        }

        /// <summary>
        /// Actualiza los datos de un participante existente.
        /// </summary>
        /// <param name="id_Miembro">Identificador del participante.</param>
        /// <param name="nombre">Nombre del participante.</param>
        /// <param name="apellido">Apellido del participante.</param>
        /// <param name="dui">Documento único de identidad.</param>
        /// <param name="OCR">Código OCR del documento.</param>
        /// <param name="ImagenM">Imagen en formato codificado.</param>
        /// <param name="Fecha_de_nacimiento">Fecha de nacimiento.</param>
        /// <param name="dirección">Dirección del participante.</param>
        /// <param name="telefono">Número telefónico.</param>
        /// <param name="CV">Identificador de la sede de votación.</param>
        /// <param name="JRV">Identificador de la mesa asignada.</param>
        /// <param name="estadomiembro">Identificador del estado del participante.</param>
        /// <returns><c>true</c> si la actualización fue exitosa; <c>false</c> en caso contrario.</returns>
        public static bool ActualizarMiembro(int id_Miembro, string nombre, string apellido, string dui, string OCR, string ImagenM, string Fecha_de_nacimiento, string dirección, string telefono, int CV, int JRV, int estadomiembro)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tb_participante SET nombre = '" + nombre + "', apellido = '" + apellido + "', documento_identidad = '" + dui + "', codigo_ocr = '"+ OCR +"', imagen = '"+ ImagenM +"', fecha_nacimiento = '" + Fecha_de_nacimiento + "', direccion = '" + dirección + "', telefono = '" + telefono + "', id_sede = '"+ CV +"', id_mesa = '"+ JRV +"', id_estado_participante = '" + estadomiembro + "' WHERE id_participante = '" + id_Miembro + "'  "), Conexion.getConnect());
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
