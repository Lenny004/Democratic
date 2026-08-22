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
    public partial class FrmRegistrar : Form
    {
        public string DecodificadoCorreo;
        public string DecodificadoContra;
        public string contraA;
        public string contraT;
        public string correoT;
        public string contraD;
        public string correoD;

        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private void FrmRegistrar_Load(object sender, EventArgs e)
        {
            TraerImagenTribunal();
        }

        void TraerImagenTribunal()
        {
            try
            {
                MySqlConnection conexion = MainController.ConnectController();
                string query = "SELECT Imagen_Tribunal FROM tbtribunal";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion);
                MySqlDataReader Reader = cmdselect.ExecuteReader();
                while (Reader.Read())
                {
                    byte[] imagenP = Convert.FromBase64String(Reader.GetString(0));
                    MemoryStream ms = new MemoryStream(imagenP);
                    PBTribunalRegistrar.Image = Image.FromStream(ms);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("","");
            }
        }

        void ObtenerDatos()
        {
            List<string> datos = RegistroController.BuscarDUI_Controller();
            TxtIDM.Text = datos[0];
            txtnombre.Text = datos[1];
            txtapellido.Text = datos[2];
            DtpNacimiento.Text = datos[3];
            txtDirección.Text = datos[4];
            TxtTelefono.Text = datos[5];
        }

        void ExistenciaDUI()
        {
            AtributosRegister.DUI = MskDui.Text;
            bool existe = RegistroController.Existencia_Controller();
            if (existe == true)
            {
                ObtenerDatos();
                ObtenerCredenciales();
            }
            else{
                MessageBox.Show("DUI incorrecto, verifique sus credenciales he intentelo de nuevo", "DUI no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ObtenerCredenciales()
        {
            List<string> datos = RegistroController.Credenciales_Controller();
            correoT = datos[0];
            contraT = datos[1];

            string EncodedUser = correoT;
            byte[] data = Convert.FromBase64String(EncodedUser);
            DecodificadoCorreo = Encoding.ASCII.GetString(data);

            string EncodedPass = contraT;
            byte[] data2 = Convert.FromBase64String(EncodedPass);
            DecodificadoContra = Encoding.ASCII.GetString(data2);
        }
        
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MskDui.Text.Trim()))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjchema, Idiomas.EnglishMessage.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjchema, Idiomas.MensajesEspanol.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                ExistenciaDUI();
                TxtCorreoElectronico.Enabled = true;
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCorreoElectronico.Text))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjcore, Idiomas.EnglishMessage.msjfaltan, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjcore, Idiomas.MensajesEspanol.msjfaltan, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                correoD = DecodificadoCorreo;
                contraD = DecodificadoContra;
                string CorreoEnvio = TxtCorreoElectronico.Text;
                Random rdn = new Random();
                int a = rdn.Next(1000, 9999);
                int b = rdn.Next(1000, 9999);
                contraA = a.ToString() + "-" + b.ToString();

                MailMessage mmsg = new MailMessage();
                mmsg.To.Add(TxtCorreoElectronico.Text);
                mmsg.Subject = "CONTRASEÑA DEMOCRATIC";
                mmsg.SubjectEncoding = Encoding.UTF8;

                mmsg.Body = "La contraseña para ingresar es: " + contraA;
                mmsg.BodyEncoding = Encoding.UTF8;
                mmsg.IsBodyHtml = true;
                mmsg.From = new MailAddress(CorreoEnvio);

                SmtpClient cliente = new SmtpClient();
                cliente.Credentials = new NetworkCredential(correoD, contraD);
                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Host = "smtp.gmail.com";
                try
                {
                    cliente.Send(mmsg);

                    Random rdn2 = new Random();
                    int random = rdn.Next(1, 6);

                    RegistroController agregar = new RegistroController();
                    agregar.usuario = TxtCorreoElectronico.Text;
                    agregar.clave = contraA;
                    agregar.Centro_Votación = random;
                    agregar.id_Miembro = Convert.ToInt16(TxtIDM.Text);
                    if (agregar.RegistrarUsuario_Controller() == false)
                    {
                        if (VarSession.idioma == 1)
                        {
                            MessageBox.Show(Idiomas.EnglishMessage.msjusunop, Idiomas.EnglishMessage.msjerint, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show(Idiomas.MensajesEspanol.msjusunop, Idiomas.MensajesEspanol.msjerint, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (VarSession.idioma == 1)
                        {
                            MessageBox.Show(Idiomas.EnglishMessage.msjnoi, Idiomas.EnglishMessage.msjcreaex, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(Idiomas.MensajesEspanol.msjnoi, Idiomas.MensajesEspanol.msjcreaex, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        FrmLogin2 login2 = new FrmLogin2(CorreoEnvio, contraA);
                        login2.Show();
                        this.Hide();
                    }
                }
                catch (Exception)
                {
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.mjsmesageno);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.mjsmesageno);
                    }
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

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MskDui_MouseEnter(object sender, EventArgs e)
        {
            lblDui.ForeColor = Color.DarkBlue;
        }

        private void MskDui_MouseLeave(object sender, EventArgs e)
        {
            lblDui.ForeColor = Color.White;
        }

        private void TxtCorreoElectronico_MouseEnter(object sender, EventArgs e)
        {
            lblCorreo.ForeColor = Color.DarkBlue;
        }

        private void TxtCorreoElectronico_MouseLeave(object sender, EventArgs e)
        {
            lblCorreo.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmLogin inicio = new FrmLogin();
            inicio.Show();
            this.Hide();
        }
    }
}
