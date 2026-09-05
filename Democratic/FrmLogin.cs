using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Controlador;
using System.IO;
using System.Linq;

namespace Democratic
{
    public partial class FrmLogin : Form
    {
        private Color azul = ColorTranslator.FromHtml("#324E7E");
        private Color Oscuro = ColorTranslator.FromHtml("#050334");
        private string User;
        private int intentos;
        private int idEstadoUsuario;
        private int idnivel;
        private int idmiembro;
        private string nombre;
        private string lastname;
        private string DUI;
        private string Tipo_Usuario;
        private int CentroV;
        private int JRV;
        private int numero = 1;
        private string DtNow = DateTime.Now.ToString("hh:mm:ss");
        private TimeSpan HoraBloqueo;
        private TimeSpan HoraDesbloqueo;

        public FrmLogin()
        {
            InitializeComponent();
        }

        void ObtenerDatos()
        {
            try
            {
                List<string> datos = LoginController.Nivel_Controller();
                User = datos[0];
                idEstadoUsuario = Convert.ToInt16(datos[2]);
                idnivel = Convert.ToInt16(datos[3]);
                idmiembro = Convert.ToInt16(datos[4]);
                nombre = datos[5];
                lastname = datos[6];
                DUI = datos[7];
                CentroV = Convert.ToInt16(datos[8]);
                JRV = Convert.ToInt16(datos[9]);
                Tipo_Usuario = datos[10];
            }
            catch (Exception)
            {
                if (Rdenglish.Checked == true){
                    FrmNoti.Noti(Idiomas.EnglishMessage.msjocubase, Idiomas.EnglishMessage.msjerrorconexion);
                }
                else{
                    FrmNoti.Noti(Idiomas.MensajesEspanol.msjocubase, Idiomas.MensajesEspanol.msjerrorconexion);
                }
            }
            VarSession.usuario = User;
            VarSession.EstadoUsuario = idEstadoUsuario;
            VarSession.nivelU = idnivel;
            VarSession.idCentroV = CentroV;
            VarSession.idJRV = JRV;
            VarSession.idmiembro = idmiembro;
            VarSession.nombre = nombre;
            VarSession.apellido = lastname;
            VarSession.DUI = DUI;
            VarSession.TipoUser = Tipo_Usuario;
        }

        void ObtenerDatos2()
        {
            try
            {
                List<string> datos = LoginController.Nivel_Controller2();
                idmiembro = Convert.ToInt16(datos[0]);
                nombre = datos[1];
                lastname = datos[2];
                DUI = datos[3];
                CentroV = Convert.ToInt16(datos[4]);
                JRV = Convert.ToInt16(datos[5]);
                idEstadoUsuario = Convert.ToInt16(datos[6]);
            }
            catch (Exception)
            {
                if (Rdenglish.Checked == true)
                {
                    FrmNoti.Noti(Idiomas.EnglishMessage.msjocubase, Idiomas.EnglishMessage.msjerrorconexion);
                }
                else{
                    FrmNoti.Noti(Idiomas.MensajesEspanol.msjocubase, Idiomas.MensajesEspanol.msjerrorconexion);
                }
            }
            VarSession.idCentroV = CentroV;
            VarSession.idJRV = JRV;
            VarSession.idmiembro = idmiembro;
            VarSession.nombre = nombre;
            VarSession.apellido = lastname;
            VarSession.DUI = DUI;
            VarSession.EstadoUsuario = idEstadoUsuario;
        }

        void EnvioDatosLog()
        { 
            AtributosLogin.usuario = txtUsuario.Text;
            string claveEncriptada = Validaciones.GetMD5(txtClave.Text);
            AtributosLogin.Clave_Usuario = txtClave.Text;
            ObtenerDatos();
            int acceso = LoginController.Acceso_Controller();

            if (acceso == 1 && (VarSession.EstadoUsuario == 1 || VarSession.EstadoUsuario == 3))
            {
                if (Rdenglish.Checked == true)
                {
                    VarSession.idioma = 1;
                }
                else if (Rdespanol.Checked == true)
                {
                    VarSession.idioma = 2;
                }
                else
                {
                    VarSession.idioma = 2;
                }

                if (SwitchDark.Value == true)
                {
                    VarSession.Color = 1;
                }
                else
                {
                    VarSession.Color = 2;
                }
                ObtenerDatos();
                FrmPadron padron = new FrmPadron();
                padron.Show();
                this.Hide();
            }
            else if (acceso == 2 || VarSession.EstadoUsuario == 2)
            {
                if (Rdenglish.Checked == true)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjuserdenied, Idiomas.EnglishMessage.msjperdioconexiontitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ActualizarIntentos();
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjuserdenied, Idiomas.MensajesEspanol.msjperdioconexiontitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ActualizarIntentos();
                }
            }
            else
            {
                if (Rdenglish.Checked == true)
                {
                    FrmNoti.Noti(Idiomas.EnglishMessage.msjocubase, Idiomas.EnglishMessage.msjerrorconexion);
                }
                else
                {
                    FrmNoti.Noti(Idiomas.MensajesEspanol.msjocubase, Idiomas.MensajesEspanol.msjerrorconexion);
                }
            }
        }

        void EnvioDatosLog2()
        {
            AtributosLogin.DUI = TxtDui.Text;
            AtributosLogin.OCR = TxtOCR.Text;
            ObtenerDatos2();
            int acceso2 = LoginController.DUI_Controller();
            int acceso3 = LoginController.OCR_Controller();
            if (acceso2 == 1 && acceso3 == 1 && (VarSession.EstadoUsuario == 1 || VarSession.EstadoUsuario == 4))
            {
                if (Rdenglish.Checked == true)
                {
                    VarSession.idioma = 1;
                }
                else if (Rdespanol.Checked == true)
                {
                    VarSession.idioma = 2;
                }
                else
                {
                    VarSession.idioma = 2;
                }

                if (SwitchDark.Value == true)
                {
                    VarSession.Color = 1;
                }
                else
                {
                    VarSession.Color = 2;
                }
                ObtenerDatos2();
                FrmPadron padron = new FrmPadron();
                padron.Show();
                this.Hide();
            }
            else if (acceso2 == 2)
            {
                if (Rdenglish.Checked == true)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjduipuser, Idiomas.EnglishMessage.msjduipusertitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjduipuser, Idiomas.MensajesEspanol.msjduipusertitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (acceso3 == 2)
            {
                if (Rdenglish.Checked == true)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjOCR, Idiomas.EnglishMessage.msjOCRTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjOCR, Idiomas.MensajesEspanol.msjOCRTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(VarSession.EstadoUsuario == 2)
            {
                if (Rdenglish.Checked == true)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjMinactivo, Idiomas.EnglishMessage.msjestadoinactivotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjMinactivo, Idiomas.MensajesEspanol.msjestadoinactivotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (Rdenglish.Checked == true)
                {
                    FrmNoti.Noti(Idiomas.EnglishMessage.msjocubase, Idiomas.EnglishMessage.msjerrorconexion);
                }
                else
                {
                    FrmNoti.Noti(Idiomas.MensajesEspanol.msjocubase, Idiomas.MensajesEspanol.msjerrorconexion);
                }
            }
        }

        void HabilitarIntento()
        {
            try
            {
                int Estado = 1;
                AtributosLogin.EstadoU = Estado;
                int newintento = 0;
                AtributosLogin.intento = newintento;
                if (LoginController.ActualizarEstado_Controller() == true)
                {
                    if (Rdenglish.Checked == true)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjactivo, Idiomas.EnglishMessage.msjinactivatitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjactivo, Idiomas.MensajesEspanol.msjinactivatitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (Rdenglish.Checked == true)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjintentosmas, Idiomas.EnglishMessage.msjintentosmastitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjintentosmas, Idiomas.MensajesEspanol.msjintentosmastitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (LoginController.ActualizarIntentos_Controller() == false)
                {
                    if (Rdenglish.Checked == true)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjnoactualizado, Idiomas.EnglishMessage.msjnoactualizadotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjnoactualizado, Idiomas.MensajesEspanol.msjnoactualizadotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                if (Rdenglish.Checked == true)
                {
                    FrmNoti.Noti(Idiomas.EnglishMessage.msjocubase, Idiomas.EnglishMessage.msjerrorconexion);
                }
                else
                {
                    FrmNoti.Noti(Idiomas.MensajesEspanol.msjocubase, Idiomas.MensajesEspanol.msjerrorconexion);
                }
            }
        }

        void ActualizarIntentos()
        {
            try
            {
                List<string> datos = LoginController.Nivel_Controller();
                intentos = Convert.ToInt16(datos[1]);
                AtributosLogin.usuario = txtUsuario.Text;
                VarSession.intentos = intentos;
                if (VarSession.intentos < 5)
                {
                    VarSession.intentos = VarSession.intentos + 1;
                    AtributosLogin.intento = VarSession.intentos;
                    AtributosLogin.usuario = txtUsuario.Text;
                    if (LoginController.ActualizarIntentos_Controller() == true)
                    {
                        int op = 5;
                        int totalop = op - VarSession.intentos;
                        if (Rdenglish.Checked == true)
                        {
                            MessageBox.Show(Idiomas.EnglishMessage.msjintentosrestantes1 + totalop + Idiomas.EnglishMessage.msjintentosrestantes2, Idiomas.EnglishMessage.msjintentosrestantestitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show(Idiomas.MensajesEspanol.msjintentosrestantes1 + totalop + Idiomas.MensajesEspanol.msjintentosrestantes2, Idiomas.MensajesEspanol.msjintentosrestantestitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                if (VarSession.intentos == 5)
                {
                    List<string> datos2 = LoginController.Hora_Controller();
                    if (datos2 != null && datos2.Any())
                    {
                        HoraBloqueo = TimeSpan.Parse(datos2[0]);
                        HoraDesbloqueo = TimeSpan.Parse(datos2[1]);
                        AtributosLogin.HoraB = Convert.ToString(HoraBloqueo);
                        AtributosLogin.HoraD = Convert.ToString(HoraDesbloqueo);
                        bool horaE = LoginController.ExistenciaHora_Controller();
                        if (horaE == true)
                        {
                            string Actual = DateTime.Now.ToString("hh:mm:ss");
                            if (TimeSpan.Parse(Actual) >= HoraDesbloqueo)
                            {
                                HabilitarIntento();
                            }
                            else
                            {
                                if (Rdenglish.Checked == true)
                                {
                                    MessageBox.Show(Idiomas.EnglishMessage.msjintentosesperar, Idiomas.EnglishMessage.msjintentosesperartitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(Idiomas.MensajesEspanol.msjintentosesperar, Idiomas.MensajesEspanol.msjintentosesperartitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else if (horaE == false)
                        {
                            TimeSpan HoraActual = TimeSpan.Parse(DtNow);
                            TimeSpan Minutos = TimeSpan.Parse("00:03:00");
                            TimeSpan HoraDesblock = HoraActual + Minutos;
                            AtributosLogin.HoraI = DtNow;
                            AtributosLogin.HoraA = Convert.ToString(HoraDesblock);
                            AtributosLogin.usuario = txtUsuario.Text;
                            if (LoginController.AgregarHoraI_Controller() == true)
                            {
                                if (Rdenglish.Checked == true)
                                {
                                    MessageBox.Show(Idiomas.EnglishMessage.msjintentosesperarmas, Idiomas.EnglishMessage.msjintentosesperartitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(Idiomas.MensajesEspanol.msjintentosesperarmas, Idiomas.MensajesEspanol.msjintentosesperartitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            if (Rdenglish.Checked == true)
                            {
                                MessageBox.Show(Idiomas.EnglishMessage.msjerrorrevisarhora, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show(Idiomas.MensajesEspanol.msjerrorrevisarhora, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        TimeSpan HoraActual = TimeSpan.Parse(DtNow);
                        TimeSpan Minutos = TimeSpan.Parse("00:03:00");
                        TimeSpan HoraDesblock = HoraActual + Minutos;
                        AtributosLogin.HoraI = DtNow;
                        AtributosLogin.HoraA = Convert.ToString(HoraDesblock);
                        AtributosLogin.usuario = txtUsuario.Text;
                        if (LoginController.AgregarHoraI_Controller() == true)
                        {
                            if (Rdenglish.Checked == true)
                            {
                                MessageBox.Show(Idiomas.EnglishMessage.msjintentosesperarmas, Idiomas.EnglishMessage.msjintentosesperartitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                int Estado = 2;
                                AtributosLogin.EstadoU = Estado;
                                if (LoginController.ActualizarEstado_Controller() == true)
                                {
                                    if (Rdenglish.Checked == true)
                                    {
                                        MessageBox.Show(Idiomas.EnglishMessage.msjinactiva, Idiomas.EnglishMessage.msjinactivatitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        MessageBox.Show(Idiomas.MensajesEspanol.msjinactiva, Idiomas.MensajesEspanol.msjinactivatitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show(Idiomas.MensajesEspanol.msjintentosesperarmas, Idiomas.MensajesEspanol.msjintentosesperartitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                int Estado = 2;
                                AtributosLogin.EstadoU = Estado;
                                if (LoginController.ActualizarEstado_Controller() == true)
                                {
                                    if (Rdenglish.Checked == true)
                                    {
                                        MessageBox.Show(Idiomas.EnglishMessage.msjinactiva, Idiomas.EnglishMessage.msjinactivatitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        MessageBox.Show(Idiomas.MensajesEspanol.msjinactiva, Idiomas.MensajesEspanol.msjinactivatitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                if (Rdenglish.Checked == true)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjusernoencontrado, Idiomas.EnglishMessage.msjusernoencontradotitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjusernoencontrado, Idiomas.MensajesEspanol.msjusernoencontradotitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    PbITLogin.Image = Image.FromStream(ms);
                }
            }
            catch (Exception)
            {
                if (Rdenglish.Checked == true)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjtribunal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjtribunal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text.Trim()) ||
               string.IsNullOrWhiteSpace(txtClave.Text.Trim()))
            {
                if (Rdenglish.Checked == true)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjLogin, Idiomas.EnglishMessage.msjLoginTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjLogin, Idiomas.MensajesEspanol.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnvioDatosLog();
            }
        }

        private void BtnAcceder2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtDui.Text.Trim()) ||
                string.IsNullOrWhiteSpace(TxtOCR.Text.Trim()))
            {
                if (Rdenglish.Checked == true)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjduiocr, Idiomas.EnglishMessage.msjfaltan, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjduiocr, Idiomas.MensajesEspanol.msjfaltan, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnvioDatosLog2();
            }
        }

        void OcultarRegistroPorCorreo()
        {
            lblCuenta.Visible = false;
            lblRegistrar.Visible = false;
            lblOlvidar.Visible = false;
        }

        void VerificarTribunalYUser()
        {
            int valor = LoginController.VerificacionTribunal_Controller();
            if (valor == 1)
            {
                int valor2 = LoginController.VerificacionUsuario_Controller();
                if (valor2 == 1)
                {
                    PicturePrimerUso.Visible = false;
                    BtnPrimerUso.Visible = false;
                    PicturePrimerUsuario.Visible = false;
                    BtnPrimerUsuario.Visible = false;
                    PBcourt.Visible = false;
                    PBuser.Visible = false;
                    if (numero == 1)
                    {
                        numero = numero + 1;
                        FrmInfo.Frminfo();
                    }
                }
                else if (valor2 == 0)
                {
                    if (Rdenglish.Checked == true)
                    {
                        PBuser.Visible = true;
                        PicturePrimerUsuario.Visible = false;
                    }
                    else
                    {
                        PicturePrimerUsuario.Visible = true;
                        PBuser.Visible = false;
                    }
                    BtnPrimerUsuario.Visible = true;
                    PBcourt.Visible = false;
                    PicturePrimerUso.Visible = false;
                    PbITLogin.Visible = false;
                    BtnPrimerUso.Visible = false;
                    lblUser.Visible = false;
                    txtUsuario.Visible = false;
                    txtClave.Visible = false;
                    TxtDui.Visible = false;
                    TxtOCR.Visible = false;
                    Separador1.Visible = false;
                    Separador2.Visible = false;
                    Separador3.Visible = false;
                    Separador4.Visible = false;
                    Separador5.Visible = false;
                    Separador6.Visible = false;
                    BtnAcceder.Visible = false;
                    BtnAcceder2.Visible = false;
                    lblOr.Visible = false;
                    lblPass.Visible = false;
                    LblDui.Visible = false;
                    LblOCR.Visible = false;
                    lblCuenta.Visible = false;
                    lblRegistrar.Visible = false;
                    lblOlvidar.Visible = false;
                }
                else if (valor2 < 0)
                {
                    PBcourt.Visible = false;
                    PBuser.Visible = false;
                    PicturePrimerUso.Visible = false;
                    BtnPrimerUso.Visible = false;
                    PicturePrimerUsuario.Visible = false;
                    BtnPrimerUsuario.Visible = false;
                    if (Rdenglish.Checked == true)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjverificar, Idiomas.EnglishMessage.msjverificartitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjverificar, Idiomas.MensajesEspanol.msjverificarTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (valor == 0)
            {
                if (Rdenglish.Checked == true)
                {
                    PBcourt.Visible = true;
                    PicturePrimerUso.Visible = false;
                }
                else
                {
                    PicturePrimerUso.Visible = true;
                    PBcourt.Visible = false;
                }
                PBuser.Visible = false;
                PbITLogin.Visible = false;
                BtnPrimerUso.Visible = true;
                lblUser.Visible = false;
                txtUsuario.Visible = false;
                txtClave.Visible = false;
                TxtDui.Visible = false;
                TxtOCR.Visible = false;
                Separador1.Visible = false;
                Separador2.Visible = false;
                Separador3.Visible = false;
                Separador4.Visible = false;
                Separador5.Visible = false;
                Separador6.Visible = false;
                BtnAcceder.Visible = false;
                BtnAcceder2.Visible = false;
                lblOr.Visible = false;
                LblDui.Visible = false;
                LblOCR.Visible = false;
                lblCuenta.Visible = false;
                lblPass.Visible = false;
                lblRegistrar.Visible = false;
                lblOlvidar.Visible = false;
                PicturePrimerUsuario.Visible = false;
                BtnPrimerUsuario.Visible = false;
            }
            else if (valor < 0)
            {
                if (Rdenglish.Checked == true)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjverificar, Idiomas.EnglishMessage.msjverificartitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjverificar, Idiomas.MensajesEspanol.msjverificarTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void VerificarIdioma()
        {
            if (Rdenglish.Checked == true)
            {
                VarSession.idioma = 1;
            }
            else if (Rdespanol.Checked == true)
            {
                VarSession.idioma = 2;
            }
            else
            {
                VarSession.idioma = 2;
            }

            if (SwitchDark.Value == true)
            {
                VarSession.Color = 1;
            }
            else
            {
                VarSession.Color = 2;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            VerificarIdioma();
            VerificarTribunalYUser();
            OcultarRegistroPorCorreo();
            TraerImagenTribunal();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------

        private void BtnPrimerUso_Click(object sender, EventArgs e)
        {
            FrmPrimerUso frmpu = new FrmPrimerUso();
            frmpu.Show();
            this.Hide();
        }

        private void BtnPrimerUsuario_Click(object sender, EventArgs e)
        {
            FrmPrimerUsuario Frmpuser = new FrmPrimerUsuario();
            Frmpuser.Show();
            this.Hide();
        }

        private void PicturePrimerUso_Click(object sender, EventArgs e)
        {
            FrmPrimerUso frmpu = new FrmPrimerUso();
            frmpu.Show();
            this.Hide();
        }

        private void PicturePrimerUsuario_Click(object sender, EventArgs e)
        {
            FrmPrimerUsuario Frmpuser = new FrmPrimerUsuario();
            Frmpuser.Show();
            this.Hide();
        }
        
        private void lblRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void lblOlvidar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void PBcourt_Click(object sender, EventArgs e)
        {
            FrmPrimerUso frmpu = new FrmPrimerUso();
            frmpu.Show();
            this.Hide();
        }

        private void PBuser_Click(object sender, EventArgs e)
        {
            FrmPrimerUsuario Frmpuser = new FrmPrimerUsuario();
            Frmpuser.Show();
            this.Hide();
        }

        //---------------------------------------------------------------------------------------------------------------------------------

        private void Rdenglish_CheckedChanged(object sender, EventArgs e)
        {
            VerificarIdioma();
            lblUser.Text = Idiomas.English.lbluser;
            lblPass.Text = Idiomas.English.lblpass;
            lblCuenta.Text = Idiomas.English.lblcuenta;
            lblRegistrar.Text = Idiomas.English.lblregistrar;
            lblOlvidar.Text = Idiomas.English.lblolvidar;
            lblInicio.Text = Idiomas.English.lblinicio;
            lblModo.Text = Idiomas.English.lbldarkmode;
            LblOCR.Text = Idiomas.English.lblOCR;
            BtnAcceder.Text = Idiomas.English.btnIniciar;
            BtnAcceder2.Text = Idiomas.English.lblinicio;
            BtnPrimerUso.Text = Idiomas.English.btnprimeruso;
            BtnPrimerUsuario.Text = Idiomas.English.btnprimerusuario;
            VerificarTribunalYUser();
            OcultarRegistroPorCorreo();
        }

        private void Rdespanol_CheckedChanged(object sender, EventArgs e)
        {
            VerificarIdioma();
            lblUser.Text = Idiomas.Espanol.lbluser;
            lblPass.Text = Idiomas.Espanol.lblpass;
            lblOlvidar.Text = Idiomas.Espanol.lblolvidar;
            lblRegistrar.Text = Idiomas.Espanol.lblregistrar;
            lblCuenta.Text = Idiomas.Espanol.lblcuenta;
            lblInicio.Text = Idiomas.Espanol.lblinicio;
            lblModo.Text = Idiomas.Espanol.lbldarkmode;
            LblOCR.Text = Idiomas.Espanol.lblOCR;
            BtnAcceder.Text = Idiomas.Espanol.btnIniciar;
            BtnAcceder2.Text = Idiomas.Espanol.BtnAcceder2;
            BtnPrimerUso.Text = Idiomas.Espanol.btnprimeruso;
            BtnPrimerUsuario.Text = Idiomas.Espanol.btnprimerusuario;
            VerificarTribunalYUser();
            OcultarRegistroPorCorreo();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------

        private void TxtDui_MouseEnter(object sender, EventArgs e)
        {
            LblDui.ForeColor = Color.White;
        }

        private void TxtDui_MouseLeave(object sender, EventArgs e)
        {
            LblDui.ForeColor = Color.Black;
        }

        private void TxtOCR_MouseEnter(object sender, EventArgs e)
        {
            LblOCR.ForeColor = Color.White;
        }

        private void TxtOCR_MouseLeave(object sender, EventArgs e)
        {
            LblOCR.ForeColor = Color.Black;
        }

        private void txtUsuario_MouseEnter(object sender, EventArgs e)
        {
            lblUser.ForeColor = Color.White;
        }

        private void txtUsuario_MouseLeave(object sender, EventArgs e)
        {
            lblUser.ForeColor = Color.Black;
        }

        private void txtClave_MouseEnter(object sender, EventArgs e)
        {
            lblPass.ForeColor = Color.White;
        }

        private void txtClave_MouseLeave(object sender, EventArgs e)
        {
            lblPass.ForeColor = Color.Black;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloNumeros(e);
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
        }

        private void SwitchDark_Click(object sender, EventArgs e)
        {
            if (SwitchDark.Value == true)
            {
                VarSession.Color = 1;
                ToolS1.BackColor = Oscuro;
            }
            else
            {
                VarSession.Color = 2;
                ToolS1.BackColor = azul;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            FrmInfo.Frminfo();
        }
    }
}
