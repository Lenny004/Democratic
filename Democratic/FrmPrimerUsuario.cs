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
    public partial class FrmPrimerUsuario : Form
    {
        private string CV;
        private string JRV;
        private string correoT;
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
                    lblproporcionado.Text = Idiomas.English.lblproporcionado;
                    lblPass2.Text = Idiomas.English.lblpass;
                    LblPassConfirm.Text = Idiomas.English.lblpassconfirm;
                    lblTipoUser.Text = Idiomas.English.lbltipouser;
                    LblCentroV.Text = Idiomas.English.lblcentrov;
                    lblEstadoUser.Text = Idiomas.English.lblestadouser;
                    lblDui.Text = Idiomas.English.lbldui;
                    BtnIngresar.Text = Idiomas.English.lblIntento;
                    lblMiembro.Text = Idiomas.English.lblmiembro;
                    BtnCerrar.Text = Idiomas.English.btncerrar;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void CargarEstadoU()
        {
            CmbEstado.DataSource = UsuariosController.CargarEstadoUsuario_Controller();
            CmbEstado.ValueMember = "id_Estado_Usuario";
            CmbEstado.DisplayMember = "Estado_Usuario";
        }

        void CargarTipoU()
        {
            CmbTipoUser.DataSource = UsuariosController.CargarTipoUser_Controller();
            CmbTipoUser.ValueMember = "id_Tipo_Usuario";
            CmbTipoUser.DisplayMember = "Tipo_Usuario";
        }

        void CargarCV()
        {
            CmbCV.DataSource = UsuariosController.CargarCentroVotacion_Controller();
            CmbCV.ValueMember = "id_Centro_Votación";
            CmbCV.DisplayMember = "Nombre_Centro_Votación";
        }

        void CargarJRV()
        {
            CmbJRV.DataSource = UsuariosController.CargarJRV_Controller();
            CmbJRV.ValueMember = "id_JRV";
            CmbJRV.DisplayMember = "Correlativo_JRV";
        }

        void CargarMiembroU()
        {
            CmbMiembro.DataSource = UsuariosController.CargarMiembrosU_Controller();
            CmbMiembro.ValueMember = "id_Miembro";
            CmbMiembro.DisplayMember = "Nombre_Miembro";
        }

        void CargarListasU()
        {
            try
            {
                CargarEstadoU();
                CargarTipoU();
                CargarCV();
                CargarJRV();
                CargarMiembroU();
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

        void EnvioDatosUser()
        {
            try
            {
                UsuariosController agregar = new UsuariosController();
                agregar.usuario = txtUsuario2.Text;
                agregar.clave = txtClave2.Text;
                agregar.Estado_Usuario = Convert.ToInt16(CmbEstado.SelectedValue);
                agregar.Tipo_Usuario = Convert.ToInt16(CmbTipoUser.SelectedValue);
                agregar.id_JRV = Convert.ToInt16(CmbJRV.SelectedValue);
                agregar.id_Miembro = Convert.ToInt16(CmbMiembro.SelectedValue);
                if (agregar.EnviarDatosUser_Controller() == false)
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

        void ObtenerCVJRV()
        {
            try
            {
                UsuariosController objselect = new UsuariosController();

                int id_CV = Convert.ToInt16(CV);
                CmbCV.DataSource = objselect.CargarCentroVotacionInnerJoin2_Controller(id_CV);
                CmbCV.ValueMember = "id_Centro_Votación";
                CmbCV.DisplayMember = "Nombre_Centro_Votación";

                int id_JRV = Convert.ToInt16(JRV);
                CmbJRV.DataSource = objselect.CargarJRVInnerJoin2_Controller(id_JRV);
                CmbJRV.ValueMember = "id_JRV";
                CmbJRV.DisplayMember = "Correlativo_JRV";
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

        void ObtenerDatosM()
        {
            try
            {
                List<string> datos = RegistroController.BuscarDUI_Controller();
                CmbMiembro.Text = datos[1];
                CV = datos[6];
                JRV = datos[7];
                ObtenerCVJRV();
                BtnIngresar.Enabled = true;
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

        void ExistenciaMiembro()
        {
            try
            {
                AtributosRegister.DUI = MskDui.Text;
                bool existe = RegistroController.Existencia_Controller();
                if (existe == true)
                {
                    ObtenerDatosM();
                }
                else
                {
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjduipuser, Idiomas.EnglishMessage.msjduipusertitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjduipuser, Idiomas.MensajesEspanol.msjduipusertitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
            try
            {
                List<string> datos = RegistroController.Credenciales_Controller();
                correoT = datos[0];
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

            string EncodedUser = correoT;
            byte[] data = Convert.FromBase64String(EncodedUser);
            string DecodificadoCorreo = Encoding.ASCII.GetString(data);

            if (string.IsNullOrWhiteSpace(txtUsuario2.Text.Trim())||
                string.IsNullOrWhiteSpace(txtClave2.Text.Trim())||
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
            else if(txtClave2.Text != txtClaveConfirm.Text)
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
            else if (txtUsuario2.Text != DecodificadoCorreo)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjbademailpuser, Idiomas.EnglishMessage.msjbademailpusertitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjbademailpuser, Idiomas.MensajesEspanol.msjbademailpusertitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            CargarListasU();
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
            if(string.IsNullOrWhiteSpace(MskDui.Text.Trim()))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjduinecesario, Idiomas.EnglishMessage.msjduimiembrotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjduinecesario, Idiomas.MensajesEspanol.msjduimiembrotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                ExistenciaMiembro();
            }
        }

        private void txtUsuario2_MouseEnter(object sender, EventArgs e)
        {
            lblUser2.ForeColor = Color.DarkBlue;
            lblproporcionado.ForeColor = Color.DarkBlue;
        }

        private void txtUsuario2_MouseLeave(object sender, EventArgs e)
        {
            lblUser2.ForeColor = Color.White;
            lblproporcionado.ForeColor = Color.White;
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
