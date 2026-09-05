using System;
using System.Drawing;
using System.Windows.Forms;
using Controlador;

namespace Democratic
{
    public partial class FrmPrimerUsuario : Form
    {
        private Label lblMostrarPass;

        public FrmPrimerUsuario()
        {
            InitializeComponent();
        }

        void VerificarIdioma()
        {
            switch (VarSession.idioma)
            {
                case 1:
                    lblPUser.Text = Idiomas.English.lblpuser;
                    lblUser2.Text = Idiomas.English.lbluser2;
                    lblPass2.Text = Idiomas.English.lblpass;
                    LblPassConfirm.Text = Idiomas.English.lblpassconfirm;
                    BtnIngresar.Text = Idiomas.English.lblIntento;
                    BtnCerrar.Text = Idiomas.English.btncerrar;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    if (lblMostrarPass != null)
                    {
                        lblMostrarPass.Text = Idiomas.English.lblMostrar;
                    }
                    break;
                case 2:
                    if (lblMostrarPass != null)
                    {
                        lblMostrarPass.Text = "Mostrar";
                    }
                    break;
                default:
                    break;
            }
        }

        void OcultarCamposAvanzados()
        {
            MskDui.Visible = false;
            lblDui.Visible = false;
            PictureLupa.Visible = false;
            CmbMiembro.Visible = false;
            lblMiembro.Visible = false;
            CmbCV.Visible = false;
            LblCentroV.Visible = false;
            CmbJRV.Visible = false;
            lblcorrelativo.Visible = false;
            CmbEstado.Visible = false;
            lblEstadoUser.Visible = false;
            CmbTipoUser.Visible = false;
            lblTipoUser.Visible = false;
            lblproporcionado.Visible = false;
        }

        void CrearLabelMostrar()
        {
            lblMostrarPass = new Label();
            lblMostrarPass.AutoSize = true;
            lblMostrarPass.BackColor = Color.Transparent;
            lblMostrarPass.Cursor = Cursors.Hand;
            lblMostrarPass.Font = new Font("Century Gothic", 9.75F);
            lblMostrarPass.ForeColor = Color.White;
            lblMostrarPass.Text = VarSession.idioma == 1 ? Idiomas.English.lblMostrar : "Mostrar";
            lblMostrarPass.Click += (s, e) => { checkPass.Checked = !checkPass.Checked; };
            panel2.Controls.Add(lblMostrarPass);
            lblMostrarPass.BringToFront();
        }

        void ReacomodarLayout()
        {
            const int anchoCampo = 272;
            const int campoX = 264;
            const int btnX = (800 - 147) / 2;

            lblUser2.Location = new Point(campoX - 2, 100);
            txtUsuario2.SetBounds(campoX, 123, anchoCampo, 27);
            bunifuSeparator3.Location = new Point(campoX - 2, 155);
            lblPass2.Location = new Point(campoX - 2, 175);
            txtClave2.SetBounds(campoX, 198, anchoCampo, 24);
            checkPass.Location = new Point(campoX, 232);
            if (lblMostrarPass != null)
            {
                lblMostrarPass.Location = new Point(campoX + 28, 232);
            }
            bunifuSeparator1.Location = new Point(campoX - 2, 258);
            LblPassConfirm.Location = new Point(campoX - 2, 278);
            txtClaveConfirm.SetBounds(campoX, 301, anchoCampo, 24);
            bunifuSeparator2.Location = new Point(campoX, 333);
            lblCoincidencia.Location = new Point(campoX + 90, 308);
            BtnIngresar.Location = new Point(btnX, 360);
        }

        void EnvioDatosUser()
        {
            try
            {
                UsuariosController agregar = new UsuariosController();
                agregar.usuario = txtUsuario2.Text;
                agregar.clave = txtClave2.Text;
                if (agregar.EnviarDatosUsuarioRoot_Controller() == false)
                {
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjinsertusererror, Idiomas.EnglishMessage.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjinsertusererror, Idiomas.MensajesEspanol.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjloggedpuser, Idiomas.EnglishMessage.msjloggedpusertitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjloggedpuser, Idiomas.MensajesEspanol.msjloggedpusertitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    FrmLogin FrmLogin = new FrmLogin();
                    FrmLogin.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    FrmNoti.Noti(Idiomas.EnglishMessage.msjocubase, Idiomas.EnglishMessage.msjerrorconexion);
                }
                else
                {
                    FrmNoti.Noti(Idiomas.MensajesEspanol.msjocubase, Idiomas.MensajesEspanol.msjerrorconexion);
                }
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario2.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtClave2.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtClaveConfirm.Text.Trim()))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjfieldspu, Idiomas.EnglishMessage.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjfieldspu, Idiomas.MensajesEspanol.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (txtClave2.Text != txtClaveConfirm.Text)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjpassbadpuser, Idiomas.EnglishMessage.msjpassbadpusertitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjpassbadpuser, Idiomas.MensajesEspanol.msjpassbadpusertitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnvioDatosUser();
            }
        }

        private void FrmPrimerUsuario_Load(object sender, EventArgs e)
        {
            VerificarIdioma();
            OcultarCamposAvanzados();
            CrearLabelMostrar();
            ReacomodarLayout();
            UiTheme.ApplySetupForm(
                ToolSPUser,
                panel2,
                txtUsuario2,
                txtClave2,
                txtClaveConfirm,
                lblUser2, lblPass2, LblPassConfirm);
            BtnIngresar.Enabled = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void checkPass_OnChange(object sender, EventArgs e)
        {
            if (checkPass.Checked == true)
            {
                if (txtClave2.PasswordChar == '*')
                {
                    txtClave2.PasswordChar = '\0';
                }
            }
            else
            {
                txtClave2.PasswordChar = '*';
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtClave2.Text == txtClaveConfirm.Text)
            {
                if (VarSession.idioma == 1)
                {
                    lblCoincidencia.Visible = true;
                    lblCoincidencia.Text = Idiomas.English.lblcoincidencia;
                    lblCoincidencia.ForeColor = Color.Green;
                }
                else
                {
                    lblCoincidencia.Visible = true;
                    lblCoincidencia.Text = Idiomas.Espanol.lblcoincidencia;
                    lblCoincidencia.ForeColor = Color.Green;
                }
            }
            else
            {
                if (VarSession.idioma == 1)
                {
                    lblCoincidencia.Visible = true;
                    lblCoincidencia.Text = Idiomas.English.lblnocoincidencia;
                    lblCoincidencia.ForeColor = Color.Red;
                }
                else
                {
                    lblCoincidencia.Visible = true;
                    lblCoincidencia.Text = Idiomas.Espanol.lblnocoincidencia;
                    lblCoincidencia.ForeColor = Color.Red;
                }
            }
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            if (txtClave2.Text == txtClaveConfirm.Text)
            {
                if (VarSession.idioma == 1)
                {
                    lblCoincidencia.Visible = true;
                    lblCoincidencia.Text = Idiomas.English.lblcoincidencia;
                    lblCoincidencia.ForeColor = Color.Green;
                }
                else
                {
                    lblCoincidencia.Visible = true;
                    lblCoincidencia.Text = Idiomas.Espanol.lblcoincidencia;
                    lblCoincidencia.ForeColor = Color.Green;
                }
            }
            else
            {
                if (VarSession.idioma == 1)
                {
                    lblCoincidencia.Visible = true;
                    lblCoincidencia.Text = Idiomas.English.lblnocoincidencia;
                    lblCoincidencia.ForeColor = Color.Red;
                }
                else
                {
                    lblCoincidencia.Visible = true;
                    lblCoincidencia.Text = Idiomas.Espanol.lblnocoincidencia;
                    lblCoincidencia.ForeColor = Color.Red;
                }
            }
        }

        private void PictureLupa_Click(object sender, EventArgs e)
        {
        }

        private void txtUsuario2_MouseEnter(object sender, EventArgs e)
        {
            lblUser2.ForeColor = Color.DarkBlue;
        }

        private void txtUsuario2_MouseLeave(object sender, EventArgs e)
        {
            lblUser2.ForeColor = Color.White;
        }

        private void txtClave2_MouseEnter(object sender, EventArgs e)
        {
            lblPass2.ForeColor = Color.DarkBlue;
        }

        private void txtClave2_MouseLeave(object sender, EventArgs e)
        {
            lblPass2.ForeColor = Color.White;
        }

        private void txtClaveConfirm_MouseEnter(object sender, EventArgs e)
        {
            LblPassConfirm.ForeColor = Color.DarkBlue;
        }

        private void txtClaveConfirm_MouseLeave(object sender, EventArgs e)
        {
            LblPassConfirm.ForeColor = Color.White;
        }
    }
}
