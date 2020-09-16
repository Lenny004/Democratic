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
    public partial class FrmContenedor : Form
    {
        public int nivel;
        Point pos1 = new Point(0,85);
        Point pos2 = new Point(0,129);
        Point pos3 = new Point(0,173);
        Point pos4 = new Point(0,217);
        Point pos5 = new Point(0,261);
        Point pos6 = new Point(0,305);
        Point pos7 = new Point(0,349);
        Point pos8 = new Point(0,393);
        Point pos9 = new Point(0,437);
        Point pos10 = new Point(0,481);
        Point pos11 = new Point(0,524);
        Point pos12 = new Point(0,568);

        public FrmContenedor(string User, int idnivel, string nombre, string lastname, string Tipo_Usuario)
        {
            InitializeComponent();
            lblUsuario.Text = User;
            lblName.Text = nombre;
            LblLastName.Text = lastname;
            lblTipoUser.Text = Tipo_Usuario;
            nivel = idnivel;
        }

        void Accesos()
        {
            switch (nivel)
            {
                case 1:
                    //Root
                    break;
                case 2:
                    //Votante
                    MenuMiembros.Visible = false;
                    MenuActas.Visible = false;
                    MenuJrv.Visible = false;
                    MenuPartidos.Visible = false;
                    BtnAdminActas.Visible = false;
                    BtnJRVyCV.Visible = false;
                    BtnMiembroyUser.Visible = false;
                    BtnPartidoCandidato.Visible = false;
                    BtnVotos.Visible = false;
                    BtnEstructura.Visible = false;
                    break;
                case 3:
                    //Candidato a Presidencia
                    MenuMiembros.Visible = false;
                    MenuActas.Visible = false;
                    MenuJrv.Visible = false;
                    MenuPartidos.Visible = false;
                    BtnAdminActas.Visible = false;
                    BtnJRVyCV.Visible = false;
                    BtnMiembroyUser.Visible = false;
                    BtnPartidoCandidato.Visible = false;
                    BtnVotos.Visible = false;
                    BtnEstructura.Visible = false;
                    break;
                case 4:
                    //Candidato a VicePresidencia
                    MenuMiembros.Visible = false;
                    MenuActas.Visible = false;
                    MenuJrv.Visible = false;
                    MenuPartidos.Visible = false;
                    BtnAdminActas.Visible = false;
                    BtnJRVyCV.Visible = false;
                    BtnMiembroyUser.Visible = false;
                    BtnPartidoCandidato.Visible = false;
                    BtnVotos.Visible = false;
                    BtnEstructura.Visible = false;
                    break;
                case 5:
                    //Partido
                    MenuMiembros.Visible = false;
                    MenuActas.Visible = false;
                    MenuJrv.Visible = false;
                    MenuPartidos.Visible = false;
                    BtnVotar.Visible = false;
                    BtnAdminActas.Visible = false;
                    BtnJRVyCV.Visible = false;
                    BtnMiembroyUser.Visible = false;
                    BtnPartidoCandidato.Visible = false;
                    BtnVotos.Visible = false;
                    BtnEstructura.Visible = false;
                    break;
                case 6:
                    //Miembro de una JRV
                    MenuMiembros.Visible = false;
                    MenuActas.Visible = false;
                    MenuJrv.Visible = false;
                    MenuPartidos.Visible = false;
                    BtnMiembroyUser.Visible = false;
                    BtnPartidoCandidato.Visible = false;
                    BtnEstructura.Visible = false;
                    break;
                case 7:
                    //Administrador
                    MenuMiembros.Visible = false;
                    MenuActas.Visible = false;
                    MenuJrv.Visible = false;
                    MenuPartidos.Visible = false;
                    BtnAdminActas.Visible = false;
                    BtnJRVyCV.Visible = false;
                    BtnVotos.Visible = false;
                    BtnEstructura.Visible = false;
                    break;
                default:
                    break;
            }
        }

        void Ubicarbotones_Paneles()
        {
            //OcultarPaneles();
            Accesos();
            switch (nivel)
            {
                case 1://Root
                    BtnCandidatos.Location = pos1;
                    BtnVotar.Location = pos2;
                    BtnEstadisticas.Location = pos3;
                    BtnAdminActas.Location = pos4;
                    BtnJRVyCV.Location = pos5;
                    BtnMiembroyUser.Location = pos6;
                    BtnPartidoCandidato.Location = pos7;
                    BtnVotos.Location = pos8;
                    BtnEstructura.Location = pos9;
                    break;
                case 2://Votante
                    BtnCandidatos.Location = pos1;
                    BtnVotar.Location = pos2;
                    BtnEstadisticas.Location = pos3;
                    break;
                case 3://Candidato a Presidencia
                    BtnCandidatos.Location = pos1;
                    BtnVotar.Location = pos2;
                    BtnEstadisticas.Location = pos3;
                    break;
                case 4://Candidato a VicePresidencia
                    BtnCandidatos.Location = pos1;
                    BtnVotar.Location = pos2;
                    BtnEstadisticas.Location = pos3;
                    break;
                case 5://Partido
                    BtnCandidatos.Location = pos1;
                    BtnEstadisticas.Location = pos2;
                    break;
                case 6://Miembro de una JRV
                    BtnCandidatos.Location = pos1;
                    BtnVotar.Location = pos2;
                    BtnEstadisticas.Location = pos3;
                    BtnAdminActas.Location = pos4;
                    BtnJRVyCV.Location = pos5;
                    BtnVotos.Location = pos6;
                    break;
                case 7://Administrador
                    BtnCandidatos.Location = pos1;
                    BtnVotar.Location = pos2;
                    BtnEstadisticas.Location = pos3;
                    BtnMiembroyUser.Location = pos6;
                    BtnPartidoCandidato.Location = pos7;
                    BtnEstructura.Location = pos9;
                    break;
                default:
                    break;
            }
        }

        Form currentForm;
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Busca en la colecion el formulario
            formulario = PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    PanelContenedor.Controls.Remove(currentForm);
                }

                currentForm = formulario;
                PanelContenedor.Controls.Add(formulario);
                PanelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            foreach (var control in PanelContenedor.Controls)
            {

            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            PanelSidebar.Size = new Size(200, 648);
            Ubicarbotones_Paneles();
            switch (nivel)
            {
                case 1:
                    MessageBox.Show("Bienvenido, su nivel de acceso es: Root");
                    break;
                case 2:
                    MessageBox.Show("Bienvenido, Votante");
                    break;
                case 3:
                    MessageBox.Show("Bienvenido, Candidato a Presidencia");
                    break;
                case 4:
                    MessageBox.Show("Bienvenido, Candidato a VicePresidencia");
                    break;
                case 5:
                    MessageBox.Show("Bienvenido, Partido");
                    break;
                case 6:
                    MessageBox.Show("Bienvenido, es Miembro de una JRV");
                    break;
                case 7:
                    MessageBox.Show("Bienvenido, su nivel de acceso es: Administrador");
                    break;
                default:
                    break;
            }
            BtnNormal.Visible = false;
        }

        //----------------------------------------------------------------------------------------------------------

        void Conexion()
        {
            if (MainController.ConnectController() == null)
            {
                BtnRojo.Visible = true;
                BtnVerde.Visible = false;
                MessageBox.Show("No se pudo establecer conexión", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BtnRojo.Visible = false;
                BtnVerde.Visible = true;
                MessageBox.Show("Conexión exitosa", "Proceso completado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            Conexion();
        }

        //----------------------------------------------------------------------------------------------------------

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void CerrarToolStrip_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void SalirToolStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdminActas_Click(object sender, EventArgs e)
        {
            if (MenuActas.Visible == true)
            {
                MenuActas.Visible = false;
            }
            else
            {
                MenuActas.Visible = true;
            }

            BtnCandidatos.Location = pos1;
            BtnVotar.Location = pos2;
            BtnEstadisticas.Location = pos3;
            BtnAdminActas.Location = pos4;
            MenuActas.Location = pos5;
            BtnJRVyCV.Location = pos7;
            BtnMiembroyUser.Location = pos8;
            BtnPartidoCandidato.Location = pos9;
            BtnVotos.Location = pos10;
            BtnEstructura.Location = pos11;
            MenuJrv.Visible = false;
            MenuMiembros.Visible = false;
            MenuPartidos.Visible = false;

            if (MenuActas.Visible == false)
            {
                Ubicarbotones_Paneles();
            }
        }

        private void BtnJRVyCV_Click(object sender, EventArgs e)
        {
            if (MenuJrv.Visible == true)
            {
                MenuJrv.Visible = false;
            }
            else
            {
                MenuJrv.Visible = true;
            }
            BtnCandidatos.Location = pos1;
            BtnVotar.Location = pos2;
            BtnEstadisticas.Location = pos3;
            BtnAdminActas.Location = pos4;
            BtnJRVyCV.Location = pos5;
            MenuJrv.Location = pos6;
            BtnMiembroyUser.Location = pos8;
            BtnPartidoCandidato.Location = pos9;
            BtnVotos.Location = pos10;
            BtnEstructura.Location = pos11;
            MenuActas.Visible = false;
            MenuMiembros.Visible = false;
            MenuPartidos.Visible = false;

            if (MenuJrv.Visible == false)
            {
                Ubicarbotones_Paneles();
            }
        }

        private void BtnMiembroyUser_Click(object sender, EventArgs e)
        {
            if (MenuMiembros.Visible == true)
            {
                MenuMiembros.Visible = false;
            }
            else
            {
                MenuMiembros.Visible = true;
            }
            BtnCandidatos.Location = pos1;
            BtnVotar.Location = pos2;
            BtnEstadisticas.Location = pos3;
            BtnAdminActas.Location = pos4;
            BtnJRVyCV.Location = pos5;
            BtnMiembroyUser.Location = pos6;
            MenuMiembros.Location = pos7;
            BtnPartidoCandidato.Location = pos10;
            BtnVotos.Location = pos11;
            BtnEstructura.Location = pos12;
            MenuActas.Visible = false;
            MenuJrv.Visible = false;
            MenuPartidos.Visible = false;

            if (MenuMiembros.Visible == false)
            {
                Ubicarbotones_Paneles();
            }
        }

        private void BtnPartidoCandidato_Click(object sender, EventArgs e)
        {
            if (MenuPartidos.Visible == true)
            {
                MenuPartidos.Visible = false;
            }
            else
            {
                MenuPartidos.Visible = true;
            }
            BtnCandidatos.Location = pos1;
            BtnVotar.Location = pos2;
            BtnEstadisticas.Location = pos3;
            BtnAdminActas.Location = pos4;
            BtnJRVyCV.Location = pos5;
            BtnMiembroyUser.Location = pos6;
            BtnPartidoCandidato.Location = pos7;
            MenuPartidos.Location = pos8;
            BtnVotos.Location = pos10;
            BtnEstructura.Location = pos11;
            MenuActas.Visible = false;
            MenuMiembros.Visible = false;
            MenuJrv.Visible = false;

            if (MenuPartidos.Visible == false)
            {
                Ubicarbotones_Paneles();
            }
        }
    }
}
