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
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {

        }

        //Volver a Formulario Contenedor
        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContenedor contenedor = new FrmContenedor();
            contenedor.Show();
            this.Hide();
        }

        //Volver al Login
        private void cerrarSesiónTool_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        //Cerrar programa
        private void salirTool_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Ir a formulario Acerca de...
        private void ToolAcerca_Click(object sender, EventArgs e)
        {
            Acercade acerca = new Acercade();
            acerca.Show();
            this.Hide();
        }

        //Ir a formulario Reportar Error
        private void ToolError_Click(object sender, EventArgs e)
        {
            FrmReportar report = new FrmReportar();
            report.Show();
            this.Hide();
        }

        //Cerrar Programa
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Maximizar pestaña
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            if (WindowState == FormWindowState.Maximized)
            {
                BtnNormal.Visible = true;
                BtnMaximizar.Visible = false;
            }
        }

        //Normalizar pestaña
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
    }
}
