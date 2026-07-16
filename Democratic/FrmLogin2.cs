using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using MySql.Data.MySqlClient;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Mail;

namespace Democratic
{
    public partial class FrmLogin2 : Form
    {
        public string DecodificadoCorreo;
        public string DecodificadoContra;
        public string contraA;
        public string contraT;
        public string correoT;
        public string contraD;
        public string correoD;

        public string User;
        public int idEstadoUsuario;
        public int idnivel;
        public string nombre;
        public string lastname;
        public string Tipo_Usuario;
        public int CentroV;
        public string ContraAleatoria;
        public string CorreoI;
        private Color Oscuro = ColorTranslator.FromHtml("#050334");

        public FrmLogin2(string correo, string contraA)
        {
            InitializeComponent();
            CorreoI = correo;
            ContraAleatoria = contraA;
        }

        void VerificarMode()
        {
            switch (VarSession.Color)
            {
                case 1:
                    ToolS2.BackColor = Oscuro;
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
                    lblInicio.Text = Idiomas.English.lblinicio;
                    lblUser2.Text = Idiomas.English.lbluser2;
                    lblinfo.Text = Idiomas.English.lblproporcionado;
                    lblPass2.Text = Idiomas.English.lblpass;
                    lblReenviar.Text = Idiomas.English.lblreenviar;
                    BtnReenviar.Text = Idiomas.English.btnreenviar;
                    BtnAcceder.Text = Idiomas.English.lblinicio;
                    BtnCerrar.Text = Idiomas.English.btncerrar;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void ObtenerDatos()
        {
            AtributosLogin.usuario = txtUsuario2.Text;
            List<string> datos = LoginController.Nivel_Controller();
            User = datos[0];
            idEstadoUsuario = Convert.ToInt16(datos[2]);
            idnivel = Convert.ToInt16(datos[3]);
            CentroV = Convert.ToInt16(datos[4]);
            nombre = datos[5];
            lastname = datos[6];
            Tipo_Usuario = datos[7];

            VarSession.usuario = User;
            VarSession.EstadoUsuario = idEstadoUsuario;
            VarSession.nivelU = idnivel;
            VarSession.idCentroV = CentroV;
            VarSession.nombre = nombre;
            VarSession.apellido = lastname;
            VarSession.TipoUser = Tipo_Usuario;
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
                    PBTLogin2.Image = Image.FromStream(ms);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar la imagen de la organización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin2_Load(object sender, EventArgs e)
        {
            VerificarMode();
            VerificarIdioma();
            TraerImagenTribunal();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario2.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtClave2.Text.Trim()))
            {
                MessageBox.Show("Todos los campos son requeridos.", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtUsuario2.Text != CorreoI)
            {
                MessageBox.Show("El correo ingresado incorrecto", "Correo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtClave2.Text != ContraAleatoria)
            {
                MessageBox.Show("La contraseña ingresada es incorrecta", "Correo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ObtenerDatos();
                FrmContenedor Contenedor = new FrmContenedor();
                Contenedor.Show();
                this.Hide();
            }
        }

        private void txtUsuario2_MouseEnter(object sender, EventArgs e)
        {
            lblUser2.ForeColor = Color.White;
        }

        private void txtUsuario2_MouseLeave(object sender, EventArgs e)
        {
            lblUser2.ForeColor = Color.Black;
        }

        private void txtClave2_MouseEnter(object sender, EventArgs e)
        {
            lblPass2.ForeColor = Color.White;
        }

        private void txtClave2_MouseLeave(object sender, EventArgs e)
        {
            lblPass2.ForeColor = Color.Black;
        }

        private void txtUsuario2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }

        private void txtClave2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloNumeros(e);
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
        }

        private void txtUsuario2_MouseEnter_1(object sender, EventArgs e)
        {
            lblinfo.ForeColor = Color.DarkBlue;
            lblUser2.ForeColor = Color.DarkBlue;
        }

        private void txtUsuario2_MouseLeave_1(object sender, EventArgs e)
        {
            lblinfo.ForeColor = Color.White;
            lblUser2.ForeColor = Color.White;
        }

        private void txtClave2_MouseEnter_1(object sender, EventArgs e)
        {
            lblPass2.ForeColor = Color.DarkBlue;
        }

        private void txtClave2_MouseLeave_1(object sender, EventArgs e)
        {
            lblPass2.ForeColor = Color.White;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void BtnReenviar_Click(object sender, EventArgs e)
        {
            ObtenerCredenciales();
            correoD = DecodificadoCorreo;
            contraD = DecodificadoContra;
            string CorreoEnvio = CorreoI;
            Random rdn = new Random();
            int a = rdn.Next(1000, 9999);
            int b = rdn.Next(1000, 9999);
            contraA = a.ToString() + "-" + b.ToString();

            MailMessage mmsg = new MailMessage();
            mmsg.To.Add(CorreoI);
            mmsg.Subject = "CONTRASEÑA DEMOCRATIC";
            mmsg.SubjectEncoding = Encoding.UTF8;

            mmsg.Body = "La nueva contraseña para ingresar es: " + contraA;
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
                MySqlConnection conexion = MainController.ConnectController();
                string query = "UPDATE tbusuario SET Clave_Usuario = '"+ contraA +"' WHERE Usuario = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion);
                cmdselect.Parameters.Add(new MySqlParameter("param1", CorreoI));
            }
            catch (Exception)
            {
                MessageBox.Show("Mensaje no se pudo enviar");
            }
        }
    }
}
