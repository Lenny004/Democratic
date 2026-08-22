using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Democratic
{
    public partial class Acercade : Form
    {
        public Acercade()
        {
            InitializeComponent();
        }

        void VerificarIdioma()
        {
            switch (VarSession.idioma)
            {
                case 1:
                    lblTema.Text = Idiomas.English.lbltema;
                    lblinfo1.Text = Idiomas.English.lblinfo1;
                    lbinfo2.Text = Idiomas.English.lblinfo2;
                    ToolSistema.Text = Idiomas.English.toolsistema;
                    CerrarToolStrip.Text = Idiomas.English.toolsalir;
                    SalirToolStrip.Text = Idiomas.English.toolcerrar;
                    ToolAyuda.Text = Idiomas.English.toolhelp;
                    ToolVerayuda.Text = Idiomas.English.toolverhelp;
                    ToolReq.Text = Idiomas.English.toolreq;
                    ToolAcerca.Text = Idiomas.English.toolacerca;
                    ToolError.Text = Idiomas.English.toolerror;
                    ToolMenu.Text = Idiomas.English.toolmenu;
                    BtnCerrar.Text = Idiomas.English.btncerrar;
                    BtnMaximizar.Text = Idiomas.English.btnmaximizar;
                    BtnNormal.Text = Idiomas.English.btnnormal;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void CerrarToolStrip_Click_1(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void SalirToolStrip_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContenedor FrmC = new FrmContenedor();
            FrmC.Show();
            this.Hide();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Asegurese de guardar todos los datos para evitar perdidas de información", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            if (WindowState == FormWindowState.Maximized)
            {
                BtnNormal.Visible = true;
                BtnMaximizar.Visible = false;
            }
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            if (WindowState == FormWindowState.Normal)
            {
                BtnMaximizar.Visible = true;
                BtnNormal.Visible = false;
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Acercade_Load(object sender, EventArgs e)
        {
            BtnNormal.Visible = false;
            VerificarIdioma();
        }

        private void ToolError_Click(object sender, EventArgs e)
        {
            FrmReportar report = new FrmReportar();
            report.Show();
            this.Hide();
        }

        //Abrir formulario Ayuda
        private void ToolVerayuda_Click(object sender, EventArgs e)
        {
            FrmAyuda ayuda = new FrmAyuda();
            ayuda.Show();
            this.Hide();
        }
    }
}
