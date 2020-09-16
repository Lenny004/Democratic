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

namespace Democratic
{
    public partial class FrmCandidatos : Form
    {
        public FrmCandidatos()
        {
            InitializeComponent();
        }

        void CargarEstadoC()
        {
            CmbEstadoC.DataSource = CandidatosController.CargarEstadoC_Controller();
            CmbEstadoC.ValueMember = "id_Estado_Candidato";
            CmbEstadoC.DisplayMember = "Estado_Candidato";
        }

        void CargarPartidoC()
        {
            CmbPartidoC.DataSource = CandidatosController.CargarPartidoC_Controller();
            CmbPartidoC.ValueMember = "id_Partido";
            CmbPartidoC.DisplayMember = "Nombre_Partido";
        }

        void CargarListasC()
        {
            try
            {
                CargarEstadoC();
                CargarPartidoC();

                DgvCandidatos.DataSource = CandidatosController.CargarCandidato_Controller();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar al menos una de las tres listas, consulte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCandidatos_Load(object sender, EventArgs e)
        {
            CargarListasC();
        }

        private void BtnCargarImageC_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFDSeleccionarImage = new OpenFileDialog();
            OFDSeleccionarImage.Filter = "Imagenes | *.jpg; *.png; *.jpeg";
            OFDSeleccionarImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            OFDSeleccionarImage.Title = "Seleccionar imagen";

            if (OFDSeleccionarImage.ShowDialog() == DialogResult.OK)
            {
                PbCandidato.Image = Image.FromFile(OFDSeleccionarImage.FileName);
            }
        }
    }
}
