using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class Conexion
    {
        ///<sumary>
        ///
        ///</sumary>
        ///<returns>MySqlConnection</returns>
        public static MySqlConnection getConnect()
        {
            //Declarando variable de tipo MySqlConnection que servira como retorno
            MySqlConnection connect;
            //Declarando variables que permitirán conexión
            string server = "127.0.0.1";
            string database = "dbdemocratic";
            string user = "root";
            string password = "";

            //Urtilizamos Try Catch para capturar cualquier error al establecer la conexión
            //Si todo resulta correcto Try se ejecutara completamente
            //Si existe algun error no controlado se ejecutara el Catch
            try
            {
                //Instanciamos la variable connect para que sea un objeto.
                //Pasamos todos los valores necesarios para conectarnos a nuestra base.
                connect = new MySqlConnection("server = " + server +
                                              "; database = " + database +
                                              "; uid = " + user +
                                              "; pwd = " + password);
                //Abrimos conexión
                connect.Open();
                //Retornamos conexión abierta lista para gestionar datos.
                return connect;
            }
            catch (Exception)
            {
                return connect = null;
            }
        }
    }
}