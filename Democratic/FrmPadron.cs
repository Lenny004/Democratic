using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using MySql.Data.MySqlClient;
using System.IO;

namespace Democratic
{
    public partial class FrmPadron : Form
    {
        private Color Oscuro = ColorTranslator.FromHtml("#050334");

        public FrmPadron()
        {
            InitializeComponent();
        }

        void VerificarMode()
        {
            switch (VarSession.Color)
            {
                case 1:
                    ToolP.BackColor = Oscuro;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void TraerImagenMiembro()
        {
            try
            {
                int id = VarSession.idmiembro;
                MySqlConnection conexion = MainController.ConnectController();
                string query = "SELECT imagen FROM tb_participante WHERE id_participante = '"+ id +"'  ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion);
                MySqlDataReader Reader = cmdselect.ExecuteReader();
                while (Reader.Read())
                {
                    byte[] imagenP = Convert.FromBase64String(Reader.GetString(0));
                    MemoryStream ms = new MemoryStream(imagenP);
                    PBPersona.Image = Image.FromStream(ms);
                }
            }
            catch (Exception)
            {

            }
        }

        void ObtenerCVJRV()
        {
            try
            {
                AtributosLogin.CV = VarSession.idCentroV;
                AtributosLogin.JRV = VarSession.idJRV;
                List<string> datos = LoginController.BuscarCV_Controller();
                List<string> datos2 = LoginController.BuscarJRV_Controller();
                lblCV.Text = datos[0];
                JrvCorrelativo.Text = datos2[0];
            }
            catch (Exception)
            {
                throw;
            }
        }

        void ObtenerDatos()
        {
            ObtenerCVJRV();
            try
            {
                lblNombre.Text = VarSession.nombre;
                lblApellido.Text = VarSession.apellido;
                lblDui.Text = VarSession.DUI;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmPadron_Load(object sender, EventArgs e)
        {
            TraerImagenMiembro();
            ObtenerDatos();
            VerificarMode();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            FrmContenedor Contenedor = new FrmContenedor();
            Contenedor.Show();
            this.Hide();
        }
    }
}
