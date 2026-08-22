using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelUsuarios
    {
        public static DataTable CargarEstadosUser()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_usuario";
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

        public static DataTable CargarTipoUser()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbtipo_usuario";
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

        public static DataTable CargarCentroVotacion()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbcentro_de_votación";
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

        public static DataTable CargarJRV()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_JRV, Correlativo_JRV FROM tbjrv";
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

        public static DataTable CargarMiembrosUser()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_Miembro, Nombre_Miembro FROM tbmiembros";
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

        public static DataTable CargarUsuario()
        {
            DataTable data;
            try
            {
                string query = "SELECT tu.id_Usuario, tu.Usuario, tu.Clave_Usuario, tu.intento, teu.Estado_Usuario, ttu.Tipo_Usuario, tcv.Nombre_Centro_Votación, tm.Nombre_Miembro FROM tbusuario tu, tbestado_usuario teu, tbtipo_usuario ttu, tbcentro_de_votación tcv, tbmiembros tm WHERE tu.id_Estado_Usuario = teu.id_Estado_Usuario AND tu.id_Tipo_Usuario = ttu.id_Tipo_Usuario AND tu.id_Centro_Votación = tcv.id_Centro_Votación AND tu.id_Miembro = tm.id_Miembro";
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

        public static bool RegistrarUsuario(string usuario, string clave, int intento, int Estado_Usuario, int Tipo_Usuario, int JRV, int id_Miembro)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbusuario (Usuario, Clave_Usuario, intento, id_Estado_Usuario, id_Tipo_Usuario, id_JRV, id_Miembro) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", usuario, clave, intento, Estado_Usuario, Tipo_Usuario, JRV, id_Miembro), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
            finally
            {
                Conexion.getConnect().Close();
            }
        }

        public static DataTable CargarEstadoUsuarioInner(string idEstado_Usuario)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_usuario WHERE Estado_Usuario = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idEstado_Usuario));
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

        public static DataTable CargarTipoUsuarioInner(string idTipo_usuario)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbtipo_usuario WHERE Tipo_Usuario = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idTipo_usuario));
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

        public static DataTable CargarCentroVotacionUsuarioInner2(int idCentro_Votacion)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbcentro_de_votación WHERE id_Centro_Votación = '"+ idCentro_Votacion + "'  ";
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

        public static DataTable CargarJRVInner2(int id_JRV)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbjrv WHERE id_JRV = '"+ id_JRV +"' ";
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

        public static DataTable CargarMiembroUsuarioInner(string idMiembro)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbmiembros WHERE Nombre_Miembro = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idMiembro));
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

        public static bool ActualizarUsuario(int idusuario, string usuario, string clave, int intento, int Estado_Usuario, int Tipo_Usuario, int JRV, int id_Miembro)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("UPDATE tbusuario SET Usuario = '" + usuario + "', Clave_Usuario = '" + clave + "', intento = '" + intento + "', id_Estado_Usuario = '" + Estado_Usuario + "', id_Tipo_Usuario = '" + Tipo_Usuario + "', id_JRV = '" + JRV + "', id_Miembro = '" + id_Miembro + "' WHERE id_Usuario = '" + idusuario + "'  "), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static int EliminarUsuario(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbusuario WHERE id_Usuario = '" + id + "' "), Conexion.getConnect());
                retorno = Convert.ToInt16(cmddel.ExecuteNonQuery());
                if (retorno == 1)
                {
                    retorno = 1;
                }
                else
                {
                    retorno = 2;
                }
                return retorno;
            }
            catch (Exception)
            {
                return retorno = -1;
            }
        }
    }
}
