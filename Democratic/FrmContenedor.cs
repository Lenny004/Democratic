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
    public partial class FrmContenedor : Form
    {
        public int idCentroV = VarSession.idCentroV;
        public int nivel = VarSession.nivelU;
        public string nombre = VarSession.nombre;
        public string apellido = VarSession.apellido;
        public string TipoU = VarSession.TipoUser;
        public string usuario = VarSession.usuario;
        
        private Color Oscuro = ColorTranslator.FromHtml("#0c0715");
        private Color Medio = ColorTranslator.FromHtml("#454356");
        private Color FondoAzul = ColorTranslator.FromHtml("#282638");
        private Color GrisH = ColorTranslator.FromHtml("#282638");
        private Color Morado = ColorTranslator.FromHtml("#272244");

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

        public FrmContenedor()
        {
            InitializeComponent();
            lblName.Text = nombre;
            LblLastName.Text = apellido;
            lblTipoUser.Text = TipoU;
            lblUsuario.Text = usuario;
        }

        void VerificarMode()
        {
            switch (VarSession.Color)
            {
                case 1:
                    //Cambio de color a los botones
                    BtnVotar.BackColor = Oscuro;
                    BtnEstadisticas.BackColor = Oscuro;
                    BtnAdminActas.BackColor = Oscuro;
                    BtnJRVyCV.BackColor = Oscuro;
                    BtnMiembroyUser.BackColor = Oscuro;
                    BtnPartidoCandidato.BackColor = Oscuro;
                    BtnVotos.BackColor = Oscuro;
                    BtnEstructura.BackColor = Oscuro;
                    BtnSalir.BackColor = Oscuro;
                    menuStrip1.BackColor = Oscuro;
                    BtnActas.BackColor = Medio;
                    BtnDetalleActas.BackColor = Medio;
                    BtnJRV.BackColor = Medio;
                    BtnCV.BackColor = Medio;
                    BtnMiembros.BackColor = Medio;
                    BtnDetalleM.BackColor = Medio;
                    BtnUsuarios.BackColor = Medio;
                    BtnPartidos.BackColor = Medio;
                    BtnC.BackColor = Medio;
                    //Normal
                    BtnCandidatos.Normalcolor = Oscuro;
                    BtnVotar.Normalcolor = Oscuro;
                    BtnEstadisticas.Normalcolor = Oscuro;
                    BtnAdminActas.Normalcolor = Oscuro;
                    BtnJRVyCV.Normalcolor = Oscuro;
                    BtnMiembroyUser.Normalcolor = Oscuro;
                    BtnPartidoCandidato.Normalcolor = Oscuro;
                    BtnVotos.Normalcolor = Oscuro;
                    BtnEstructura.Normalcolor = Oscuro;
                    BtnSalir.Normalcolor = Oscuro;
                    BtnActas.Normalcolor = Medio;
                    BtnDetalleActas.Normalcolor = Medio;
                    BtnJRV.Normalcolor = Medio;
                    BtnCV.Normalcolor = Medio;
                    BtnMiembros.Normalcolor = Medio;
                    BtnDetalleM.Normalcolor = Medio;
                    BtnUsuarios.Normalcolor = Medio;
                    BtnPartidos.Normalcolor = Medio;
                    BtnC.Normalcolor = Medio;
                    //Hover
                    BtnCandidatos.OnHovercolor = GrisH;
                    BtnVotar.OnHovercolor = GrisH;
                    BtnEstadisticas.OnHovercolor = GrisH;
                    BtnAdminActas.OnHovercolor = GrisH;
                    BtnJRVyCV.OnHovercolor = GrisH;
                    BtnMiembroyUser.OnHovercolor = GrisH;
                    BtnPartidoCandidato.OnHovercolor = GrisH;
                    BtnVotos.OnHovercolor = GrisH;
                    BtnEstructura.OnHovercolor = GrisH;
                    BtnSalir.OnHovercolor = GrisH;
                    BtnActas.OnHovercolor = GrisH;
                    BtnDetalleActas.OnHovercolor = GrisH;
                    BtnJRV.OnHovercolor = GrisH;
                    BtnCV.OnHovercolor = GrisH;
                    BtnMiembros.OnHovercolor = GrisH;
                    BtnDetalleM.OnHovercolor = GrisH;
                    BtnUsuarios.OnHovercolor = GrisH;
                    BtnPartidos.OnHovercolor = GrisH;
                    BtnC.OnHovercolor = GrisH;
                    //Otrosfijos
                    PanelUser.BackColor = FondoAzul;
                    PanelSidebar.BackColor = FondoAzul;
                    toolStrip1.BackColor = Morado;
                    toolStrip2.BackColor = Morado;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void VerificarIdioma()
        {
            switch (VarSession.idioma)
            {
                case 1:
                    BtnCandidatos.Text = Idiomas.English.btnvercandidatos;
                    BtnVotar.Text = Idiomas.English.btnvotar;
                    BtnEstadisticas.Text = Idiomas.English.btnverestadisticas;
                    BtnAdminActas.Text = Idiomas.English.btnadmindactas;
                    BtnActas.Text = Idiomas.English.btnactas;
                    BtnDetalleActas.Text = Idiomas.English.btndetalleacta;
                    BtnJRVyCV.Text = Idiomas.English.btnjrvandcv;
                    BtnJRV.Text = Idiomas.English.btnjrv;
                    BtnCV.Text = Idiomas.English.btncv;
                    BtnMiembroyUser.Text = Idiomas.English.btnadmindmiembrosanduser;
                    BtnMiembros.Text = Idiomas.English.btnmiembros;
                    BtnDetalleM.Text = Idiomas.English.btndetallemiembros;
                    BtnUsuarios.Text = Idiomas.English.btnusuarios;
                    BtnPartidoCandidato.Text = Idiomas.English.btnadmindpartidosycandidatos;
                    BtnPartidos.Text = Idiomas.English.btnpartido;
                    BtnC.Text = Idiomas.English.btncandidato;
                    BtnVotos.Text = Idiomas.English.btnvotos;
                    BtnEstructura.Text = Idiomas.English.btnestructura;
                    BtnSalir.Text = Idiomas.English.btnexit;
                    ToolSistema.Text = Idiomas.English.toolsistema;
                    CerrarToolStrip.Text = Idiomas.English.toolsalir;
                    SalirToolStrip.Text = Idiomas.English.toolcerrar;
                    ToolAyuda.Text = Idiomas.English.toolhelp;
                    ToolVerayuda.Text = Idiomas.English.toolverhelp;
                    ToolReq.Text = Idiomas.English.toolreq;
                    ToolAcerca.Text = Idiomas.English.toolacerca;
                    ToolError.Text = Idiomas.English.toolerror;
                    BtnCerrar.Text = Idiomas.English.btncerrar;
                    BtnMaximizar.Text = Idiomas.English.btnmaximizar;
                    BtnNormal.Text = Idiomas.English.btnnormal;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    BtnConectar.Text = Idiomas.English.btnconectar;
                    BtnRojo.Text = Idiomas.English.btnrojo;
                    BtnVerde.Text = Idiomas.English.btnverde;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
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
                    //Opción principal (nivel 3)
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
                    //Opción secundaria (nivel 4)
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
                    //Grupo (nivel 5)
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
                    //Miembro de mesa de votación (nivel 6)
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
                case 3://Opción principal (nivel 3)
                    BtnCandidatos.Location = pos1;
                    BtnVotar.Location = pos2;
                    BtnEstadisticas.Location = pos3;
                    break;
                case 4://Opción secundaria (nivel 4)
                    BtnCandidatos.Location = pos1;
                    BtnVotar.Location = pos2;
                    BtnEstadisticas.Location = pos3;
                    break;
                case 5://Grupo (nivel 5)
                    BtnCandidatos.Location = pos1;
                    BtnEstadisticas.Location = pos2;
                    break;
                case 6://Miembro de mesa de votación (nivel 6)
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
                    BtnMiembroyUser.Location = pos4;
                    BtnPartidoCandidato.Location = pos5;
                    BtnEstructura.Location = pos6;
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

        void TraerImagenTribunal()
        {
            try
            {
                MySqlConnection conexion = MainController.ConnectController();
                string query = "SELECT imagen FROM tb_organizacion";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion);
                MySqlDataReader Reader = cmdselect.ExecuteReader();
                while (Reader.Read())
                {
                    byte[] imagenP = Convert.FromBase64String(Reader.GetString(0));
                    MemoryStream ms = new MemoryStream(imagenP);
                    PictureLogoT.Image = Image.FromStream(ms);
                }
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjtribunal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjtribunal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            VerificarMode();
            VerificarIdioma();
            TraerImagenTribunal();
            PanelSidebar.Size = new Size(200, 648);
            Ubicarbotones_Paneles();
            switch (nivel)
            {
                case 1:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjroot);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjroot);
                    }
                    break;
                case 2:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjvotante);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjvotante);
                    }
                    break;
                case 3:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjpresi);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjpresi);
                    }
                    break;
                case 4:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjvice);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjvice);
                    }
                    break;
                case 5:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjpartido);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjpartido);
                    }
                    break;
                case 6:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjmiembro);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjmiembro);
                    }
                    break;
                case 7:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjadmind);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjadmind);
                    }
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
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjconexionno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show(Idiomas.MensajesEspanol.msjconexionno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BtnRojo.Visible = false;
                BtnVerde.Visible = true;
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjconexionsi, Idiomas.EnglishMessage.msjprocom, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjconexionsi, Idiomas.MensajesEspanol.msjprocom, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            Conexion();
        }

        //----------------------------------------------------------------------------------------------------------

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (VarSession.idioma == 1)
            {
                DialogResult dr = MessageBox.Show(Idiomas.EnglishMessage.msjseguro, Idiomas.EnglishMessage.msjsegurotitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show(Idiomas.MensajesEspanol.msjseguro, Idiomas.MensajesEspanol.msjsegurotitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        //Maximizar formulario
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            if (WindowState == FormWindowState.Maximized)
            {
                BtnNormal.Visible = true;
                BtnMaximizar.Visible = false;
            }
        }

        //Normalizar al tamaño normal
        private void BtnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            if (WindowState == FormWindowState.Normal)
            {
                BtnMaximizar.Visible = true;
                BtnNormal.Visible = false;
            }
        }

        //Minimizar aplicación
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

        ///Codigo de Botones---------------------------------------------------------------------------------------------------------

        private void BtnAdminActas_Click(object sender, EventArgs e)
        {
            switch (nivel)
            {
                case 1:
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
                    break;
                case 6:
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
                    BtnVotos.Location = pos8;
                    MenuJrv.Visible = false;
                    MenuMiembros.Visible = false;
                    MenuPartidos.Visible = false;

                    if (MenuActas.Visible == false)
                    {
                        Ubicarbotones_Paneles();
                    }
                    break;
            }
        }

        private void BtnJRVyCV_Click(object sender, EventArgs e)
        {
            switch (nivel)
            {
                case 1:
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
                    break;
                case 6:
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
                    BtnVotos.Location = pos8;
                    MenuActas.Visible = false;
                    MenuMiembros.Visible = false;
                    MenuPartidos.Visible = false;

                    if (MenuJrv.Visible == false)
                    {
                        Ubicarbotones_Paneles();
                    }
                    break;
                default:
                    break;
            }
        }

        private void BtnMiembroyUser_Click(object sender, EventArgs e)
        {
            switch (nivel)
            {
                case 1:
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
                    break;
                case 7:
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
                    BtnMiembroyUser.Location = pos4;
                    MenuMiembros.Location = pos5;
                    BtnPartidoCandidato.Location = pos8;
                    MenuActas.Visible = false;
                    MenuJrv.Visible = false;
                    MenuPartidos.Visible = false;

                    if (MenuMiembros.Visible == false)
                    {
                        Ubicarbotones_Paneles();
                    }
                    break;
                default:
                    break;
            }
        }

        private void BtnPartidoCandidato_Click(object sender, EventArgs e)
        {
            switch (nivel)
            {
                case 1:
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
                    break;
                case 7:
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
                    BtnMiembroyUser.Location = pos4;
                    BtnPartidoCandidato.Location = pos5;
                    MenuPartidos.Location = pos6;
                    MenuActas.Visible = false;
                    MenuMiembros.Visible = false;
                    MenuJrv.Visible = false;

                    if (MenuPartidos.Visible == false)
                    {
                        Ubicarbotones_Paneles();
                    }
                    break;
                default:
                    break;
            }
        }

        private void BtnCandidatos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmVerCandidatos>();
            PictureLogoT.Visible = false;
        }

        private void BtnVotar_Click(object sender, EventArgs e)
        { 
            AbrirFormulario<FrmVotar>();
            PictureLogoT.Visible = false;
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGraficos>();
            PictureLogoT.Visible = false;
        }

        private void BtnActas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmActas>();
            PictureLogoT.Visible = false;
        }

        private void BtnDetalleActas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmDetalleActa>();
            PictureLogoT.Visible = false;
        }

        private void BtnJRV_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmJRV>();
            PictureLogoT.Visible = false;
        }

        private void BtnCV_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCV>();
            PictureLogoT.Visible = false;
        }

        private void BtnMiembros_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmMiembros>();
            PictureLogoT.Visible = false;
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmUsuarios>();
            PictureLogoT.Visible = false;
        }

        private void BtnDetalleM_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmDetalleMiembro>();
            PictureLogoT.Visible = false;
        }

        private void BtnPartidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPartidos>();
            PictureLogoT.Visible = false;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCandidatos>();
            PictureLogoT.Visible = false;
        }

        private void acercaDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade acerca = new Acercade();
            acerca.Show();
            this.Hide();
        }

        private void BtnVotos_Click(object sender, EventArgs e)
        {

        }

        //Abrir formulario Reportar error
        private void ToolError_Click(object sender, EventArgs e)
        {
            FrmReportar report = new FrmReportar();
            report.Show();
            this.Hide();
        }

        //Abrir Formulario Ver Ayuda
        private void ToolVerayuda_Click(object sender, EventArgs e)
        {
            FrmAyuda ayuda = new FrmAyuda();
            ayuda.Show();
            this.Hide();
        }
    }
}
