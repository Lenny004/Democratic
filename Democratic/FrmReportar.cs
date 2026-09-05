using System;
using System.Drawing;
using System.Windows.Forms;

namespace Democratic
{
    public partial class FrmReportar : Form
    {
        private string Archivo;

        public FrmReportar()
        {
            InitializeComponent();
        }

        private void BtnPrimerUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "El envío de reportes por correo está deshabilitado temporalmente.",
                "Función no disponible",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        //Abrir ventana del explorador de windows para seleccionar imagen
        private void BtnImagen_Click(object sender, EventArgs e)
        {
            string Seleccion = "Ha seleccionado una imagen";
            try
            {
                //Cuadro de dialogo de Ok/Cancelar cuando estan en el explorador de windows
                OpenFileDialog OFDSeleccionarImage = new OpenFileDialog();
                OFDSeleccionarImage.Filter = "Imagenes | *.jpg; *.png; *.jpeg";
                OFDSeleccionarImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                OFDSeleccionarImage.Title = "Seleccionar imagen";
                if (OFDSeleccionarImage.ShowDialog() == DialogResult.OK)
                {
                    Archivo = OFDSeleccionarImage.FileName;
                    lblinfo.Text = Seleccion;
                    lblinfo.ForeColor = Color.Navy;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar imagen","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        //Ir al Login
        private void cerrarSesiónTool_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        //Ir a Formulario Contenedor
        private void ToolMenu_Click(object sender, EventArgs e)
        {
            FrmContenedor contenedor = new FrmContenedor();
            contenedor.Show();
            this.Hide();
        }

        //Ir a Formulario Acerca de...
        private void acercaDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade acerca = new Acercade();
            acerca.Show();
            this.Hide();
        }

        //Cerrar Aplicación
        private void salirTool_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimizar aplicación
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Normalizar Formulario
        private void BtnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            if (WindowState == FormWindowState.Normal)
            {
                BtnMaximizar.Visible = true;
                BtnNormal.Visible = false;
            }
        }

        //Maximizar aplicación
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            if (WindowState == FormWindowState.Maximized)
            {
                BtnNormal.Visible = true;
                BtnMaximizar.Visible = false;
            }
        }

        //Abrir Formulario Ayuda
        private void ToolVerAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda AYUDA = new FrmAyuda();
            AYUDA.Show();
            this.Hide();
        }
    }
}
