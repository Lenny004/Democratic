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
                string query = "SELECT tm.id_Miembro, tm.Nombre_Miembro, tm.Apellido_Miembro, tm.DUI, tm.Fecha_de_nacimiento, tm.Dirección_Usuario, tm.Correo_Electronico, tm.Numero_Telefonico, tem.Nombre_Estado_Miembros FROM tbmiembros tm, tbestado_miembros tem WHERE tm.id_Estado_Miembros = tem.id_Estado_Miembros";
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

        public static bool RegistrarMiembros(string nombre, string apellido, string dui, string Fecha_de_nacimiento, string dirección, string correo, string telefono, int estadomiembro)
        {
            bool retorno;
            try 
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbmiembros(Nombre_Miembro, Apellido_Miembro, DUI, Fecha_de_nacimiento, Dirección_Usuario, Correo_Electronico, Numero_Telefonico, id_Estado_Miembros) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",nombre, apellido, dui, Fecha_de_nacimiento, dirección, correo, telefono, estadomiembro), Conexion.getConnect());
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

        public static bool ActualizarMiembro(int id_Miembro, string nombre, string apellido, string dui, string Fecha_de_nacimiento, string dirección, string correo, string telefono, int estadomiembro)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbmiembros SET Nombre_Miembro = '" + nombre + "', Apellido_Miembro = '" + apellido + "', DUI = '" + dui + "', Fecha_de_nacimiento = '" + Fecha_de_nacimiento + "', Dirección_Usuario = '" + dirección + "', Correo_Electronico = '" + correo + "', 	Numero_Telefonico = '" + telefono + "', id_Estado_Miembros = '" + estadomiembro + "' WHERE id_Miembro = '" + id_Miembro + "'  "), Conexion.getConnect());
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
