using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Controlador;
using MySql.Data.MySqlClient;
using System.IO;

namespace Democratic
{
    public partial class FrmRecuperarPass : Form
    {
        public string contraA;
        public string contraD;
        public string correoD;
        public string DecodificadoCorreo;
        public string DecodificadoContra;
        private Color Oscuro = ColorTranslator.FromHtml("#050334");

        public FrmRecuperarPass()
        {
            InitializeComponent();
        }

        void VerificarMode()
        {
            switch (VarSession.Color)
            {
                case 1:
                    toolStrip1.BackColor = Oscuro;
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
                    lblrecuperarform.Text = Idiomas.English.lblrecuperarpass;
                    lblCuenta2.Text = Idiomas.English.lblCuenta2;
                    BtnGenerar.Text = Idiomas.English.BtnGenerar;
                    lblgenerarc.Text = Idiomas.English.lblgenerarc;
                    BtnCerrar.Text = Idiomas.English.btncerrar;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void ObtenerCredenciales()
        {
            List<string> datos = RegistroController.Credenciales_Controller();
            correoD = datos[0];
            contraD = datos[1];

            string EncodedUser = correoD;
            byte[] data = Convert.FromBase64String(EncodedUser);
            DecodificadoCorreo = Encoding.ASCII.GetString(data);

            string EncodedPass = contraD;
            byte[] data2 = Convert.FromBase64String(EncodedPass);
            DecodificadoContra = Encoding.ASCII.GetString(data2);
        }

        void ExistenciaCorreo()
        {
            AtributosRecuperar.correo = txtRecuperar.Text;
            bool existe = RecuperarController.ExistenciaCorreo_Controller();
            if (existe == true)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjexele);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjexele);
                }
                ObtenerCredenciales();
                string CorreoEnvio = txtRecuperar.Text;
                Random rdn = new Random();
                int a = rdn.Next(1000, 9999);
                int b = rdn.Next(1000, 9999);
                contraA = a.ToString() + "-" + b.ToString();

                MailMessage mmsg = new MailMessage();
                mmsg.To.Add(txtRecuperar.Text);
                mmsg.Subject = "CONTRASEÑA DEMOCRATIC";
                mmsg.SubjectEncoding = Encoding.UTF8;

                mmsg.Body = "La contraseña para ingresar es: " + contraA;
                mmsg.BodyEncoding = Encoding.UTF8;
                mmsg.IsBodyHtml = true;
                mmsg.From = new MailAddress(CorreoEnvio);

                SmtpClient cliente = new SmtpClient();
                cliente.Credentials = new NetworkCredential(DecodificadoCorreo, DecodificadoContra);
                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Host = "smtp.gmail.com";
                cliente.Send(mmsg);
                try
                {
                    RecuperarController objactualizar = new RecuperarController();
                    objactualizar.correo2 = CorreoEnvio;
                    objactualizar.ContraUpd = contraA;
                    if (objactualizar.ActualizarContra_Controller() == false)
                    {
                        if (VarSession.idioma == 1)
                        {
                            MessageBox.Show(Idiomas.EnglishMessage.mjsactuer, Idiomas.EnglishMessage.mjsactuer, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show(Idiomas.MensajesEspanol.mjsco, Idiomas.MensajesEspanol.mjsactuer, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        FrmLogin2 login2 = new FrmLogin2(CorreoEnvio, contraA);
                        login2.Show();
                        this.Hide();
                    }
                }
                catch (Exception)
                {
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.mjsconen, Idiomas.EnglishMessage.mjsmesageno, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.mjsconen, Idiomas.MensajesEspanol.mjsmesageno, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjinco, Idiomas.EnglishMessage.msjcheyo,  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjinco, Idiomas.MensajesEspanol.msjcheyo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRecuperar.Text.Trim()))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjblank, Idiomas.EnglishMessage.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjblank, Idiomas.MensajesEspanol.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                ExistenciaCorreo();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmLogin frmlogin = new FrmLogin();
            frmlogin.Show();
            this.Hide();
        }

        private void txtRecuperar_MouseEnter(object sender, EventArgs e)
        {
            lblCuenta2.ForeColor = Color.DarkBlue;
        }

        private void txtRecuperar_MouseLeave(object sender, EventArgs e)
        {
            lblCuenta2.ForeColor = Color.White;
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
                    PBTRegistrar.Image = Image.FromStream(ms);
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

        private void FrmRecuperarPass_Load(object sender, EventArgs e)
        {
            VerificarMode();
            VerificarIdioma();
            TraerImagenTribunal();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
