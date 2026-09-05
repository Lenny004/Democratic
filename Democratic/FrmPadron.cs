using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Controlador;
using MySql.Data.MySqlClient;

namespace Democratic
{
    public partial class FrmPadron : Form
    {
        public FrmPadron()
        {
            InitializeComponent();
        }

        void VerificarMode()
        {
            UiTheme.ApplyToolbar(ToolP);
        }

        string TextoSinAsignar()
        {
            return VarSession.idioma == 1 ? "Unassigned" : "Sin asignar";
        }

        void TraerImagenMiembro()
        {
            try
            {
                if (VarSession.idmiembro <= 0)
                {
                    return;
                }

                int id = VarSession.idmiembro;
                MySqlConnection conexion = MainController.ConnectController();
                if (conexion == null)
                {
                    return;
                }

                MySqlCommand cmdselect = new MySqlCommand("SELECT imagen FROM tb_participante WHERE id_participante = ?param1", conexion);
                cmdselect.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataReader Reader = cmdselect.ExecuteReader();
                while (Reader.Read())
                {
                    if (Reader.IsDBNull(0))
                    {
                        continue;
                    }

                    byte[] imagenP = Convert.FromBase64String(Reader.GetString(0));
                    MemoryStream ms = new MemoryStream(imagenP);
                    PBPersona.Image = Image.FromStream(ms);
                }
                Reader.Close();
                conexion.Close();
            }
            catch (Exception)
            {
            }
        }

        void ObtenerCVJRV()
        {
            string vacio = TextoSinAsignar();
            lblCV.Text = vacio;
            JrvCorrelativo.Text = vacio;

            try
            {
                AtributosLogin.CV = VarSession.idCentroV;
                AtributosLogin.JRV = VarSession.idJRV;
                List<string> datos = LoginController.BuscarCV_Controller();
                List<string> datos2 = LoginController.BuscarJRV_Controller();
                if (datos != null && datos.Count > 0 && !string.IsNullOrWhiteSpace(datos[0]))
                {
                    lblCV.Text = datos[0];
                }
                if (datos2 != null && datos2.Count > 0 && !string.IsNullOrWhiteSpace(datos2[0]))
                {
                    JrvCorrelativo.Text = datos2[0];
                }
            }
            catch (Exception)
            {
            }
        }

        void ObtenerDatos()
        {
            ObtenerCVJRV();
            lblNombre.Text = string.IsNullOrWhiteSpace(VarSession.nombre) ? VarSession.usuario : VarSession.nombre;
            lblApellido.Text = string.IsNullOrWhiteSpace(VarSession.apellido) ? TextoSinAsignar() : VarSession.apellido;
            lblDui.Text = string.IsNullOrWhiteSpace(VarSession.DUI) ? TextoSinAsignar() : VarSession.DUI;
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
