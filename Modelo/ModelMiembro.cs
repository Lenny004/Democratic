using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelMiembro
    {
        public static DataTable CargarEstadoMiembro()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_miembros";
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

        public static DataTable CargarMiembro()
        {
            DataTable data;
            try
            {
                string query = "SELECT tm.id_Miembro, tm.Nombre_Miembro, tm.Apellido_Miembro, tm.DUI, tm.OCR, tm.Imagen_Miembro, tm.Fecha_de_nacimiento, tm.Dirección_Usuario, tm.Numero_Telefonico, tcv.Nombre_Centro_Votación, tj.Correlativo_JRV ,tem.Nombre_Estado_Miembros FROM tbmiembros tm, tbcentro_de_votación tcv , tbjrv tj, tbestado_miembros tem WHERE tm.id_Centro_Votación = tcv.id_Centro_Votación AND tm.id_JRV = tj.id_JRV  AND tm.id_Estado_Miembros = tem.id_Estado_Miembros";
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

        public static bool RegistrarMiembros(string nombre, string apellido, string dui, string OCR, string ImagenM, string Fecha_de_nacimiento, string dirección, string telefono, int CV, int JRV, int estadomiembro)
        {
            bool retorno;
            try 
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbmiembros(Nombre_Miembro, Apellido_Miembro, DUI, OCR, Imagen_Miembro, Fecha_de_nacimiento, Dirección_Usuario, Numero_Telefonico, id_Centro_Votación, id_JRV, id_Estado_Miembros) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", nombre, apellido, dui, OCR, ImagenM, Fecha_de_nacimiento, dirección, telefono, CV, JRV, estadomiembro), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static DataTable CargarEstadoMiembrosInner(string idestadomiembro)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_miembros WHERE Nombre_Estado_Miembros = ?param1";
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

        public static DataTable CargarCentroVotacionUsuarioInner(string idCentro_Votacion)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbcentro_de_votación WHERE Nombre_Centro_Votación = ?param1";
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

        public static DataTable CargarJRVInner(string id_JRV)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbjrv WHERE Correlativo_JRV = ?param1";
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

        public static bool ActualizarMiembro(int id_Miembro, string nombre, string apellido, string dui, string OCR, string ImagenM, string Fecha_de_nacimiento, string dirección, string telefono, int CV, int JRV, int estadomiembro)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbmiembros SET Nombre_Miembro = '" + nombre + "', Apellido_Miembro = '" + apellido + "', DUI = '" + dui + "', OCR = '"+ OCR +"', Imagen_Miembro = '"+ ImagenM +"', Fecha_de_nacimiento = '" + Fecha_de_nacimiento + "', Dirección_Usuario = '" + dirección + "', Numero_Telefonico = '" + telefono + "', id_Centro_Votación = '"+ CV +"', id_JRV = '"+ JRV +"', id_Estado_Miembros = '" + estadomiembro + "' WHERE id_Miembro = '" + id_Miembro + "'  "), Conexion.getConnect());
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
