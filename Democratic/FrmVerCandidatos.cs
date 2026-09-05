using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Democratic
{
    public partial class FrmVerCandidatos : Form
    {
        private const int TotalOpciones = 9;

        private readonly Color Gris = ColorTranslator.FromHtml("#3b3f48");

        private PictureBox[] _pbOpciones;
        private Label[] _lblNombreOpcion;
        private Label[] _lblDetalleOpcion;

        public FrmVerCandidatos()
        {
            InitializeComponent();
            InicializarControlesOpcion();
        }

        private void InicializarControlesOpcion()
        {
            _pbOpciones = new[]
            {
                PbVer1, PbVer2, PbVer3, PbVer4, PbVer5,
                PbVer6, PbVer7, PbVer8, PbVer9
            };
            _lblNombreOpcion = new[]
            {
                lblNombreC1, lblNombreC2, lblNombreC3, lblNombreC4, lblNombreC5,
                lblNombreC6, lblNombreC7, lblNombreC8, lblNombreC9
            };
            _lblDetalleOpcion = new[]
            {
                lblApellidoC1, lblApellidoC2, lblApellidoC3, lblApellidoC4, lblApellidoC5,
                lblApellidoC6, lblApellidoC7, lblApellidoC8, lblApellidoC9
            };
        }

        private void VerificarMode()
        {
            switch (VarSession.Color)
            {
                case 1:
                    panel1.BackColor = Gris;
                    toolStrip1.BackColor = Gris;
                    BtnMinimizar.ForeColor = Color.White;
                    for (int i = 0; i < TotalOpciones; i++)
                    {
                        _lblNombreOpcion[i].ForeColor = Color.Cyan;
                        _lblDetalleOpcion[i].ForeColor = Color.Cyan;
                    }
                    break;
            }
        }

        private void BtnMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void CargarImagenOpcion(int idOpcion, PictureBox destino)
        {
            byte[] imagen = ModelCandidato.RecuperarImagenOpcion(idOpcion);
            if (imagen == null)
            {
                return;
            }

            using (MemoryStream ms = new MemoryStream(imagen))
            {
                destino.Image = Image.FromStream(ms);
            }
        }

        private void CargarDatosOpcion(int indice)
        {
            int idOpcion = indice + 1;
            CargarImagenOpcion(idOpcion, _pbOpciones[indice]);

            List<string> datos = VerCandidatoController.ObtenerOpcion_Controller(idOpcion);
            if (datos == null || datos.Count < 2)
            {
                return;
            }

            _lblNombreOpcion[indice].Text = datos[0];
            _lblDetalleOpcion[indice].Text = datos[1];
        }

        private void CargarTodasLasOpciones()
        {
            for (int i = 0; i < TotalOpciones; i++)
            {
                CargarDatosOpcion(i);
            }
        }

        private void MostrarMensajeImagenesFaltantes()
        {
            if (VarSession.idioma == 1)
            {
                MessageBox.Show(
                    "One or more option images were not uploaded",
                    Idiomas.EnglishMessage.msjerima,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(
                    "Una o más imágenes de las opciones no fueron cargadas",
                    Idiomas.MensajesEspanol.msjerima,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmVerCandidatos_Load(object sender, EventArgs e)
        {
            VerificarMode();
            try
            {
                CargarTodasLasOpciones();
            }
            catch (Exception)
            {
                MostrarMensajeImagenesFaltantes();
            }
        }
    }
}
