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
using System.Net.Mail;//Libreria para mandar mensajes
using System.Net;//Libreria de protocolo que usan las redes y servicios de red

namespace Democratic
{
    public partial class FrmReportar : Form
    {
        public FrmReportar()
        {
            InitializeComponent();
        }
        //Declaramos variables
        private string DecodificadoCorreo;
        private string DecodificadoContra;
        private string correoT;
        private string contraT;
        private string Archivo;

        //Obtenemos las credenciales (correo y contraseña) de la organización configurada en primer uso
        void ObtenerCredenciales()
        {
            List<string> datos = RegistroController.Credenciales_Controller();
            correoT = datos[0];
            contraT = datos[1];

            //Decodificamos la contraseña y correo que están en la base de datos
            string EncodedUser = correoT;
            byte[] data = Convert.FromBase64String(EncodedUser);
            DecodificadoCorreo = Encoding.ASCII.GetString(data);

            string EncodedPass = contraT;
            byte[] data2 = Convert.FromBase64String(EncodedPass);
            DecodificadoContra = Encoding.ASCII.GetString(data2);
        }

        //Proceso de enviar mensaje al correo
        private void BtnPrimerUsuario_Click(object sender, EventArgs e)
        {
            //Validamos campos vacios
            if (string.IsNullOrWhiteSpace(TxtNombre.Text.Trim()) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text.Trim()) ||
                string.IsNullOrWhiteSpace(TxtAsunto.Text.Trim()) ||
                string.IsNullOrWhiteSpace(TxtDes.Text.Trim()))
            {
                //Si hay campos vacios mostrara un mensaje
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjFieldsP, Idiomas.EnglishMessage.msjfaltan, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjFieldsP, Idiomas.MensajesEspanol.msjfaltan, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                ObtenerCredenciales();
                string CorreoD;
                string ContraD;
                CorreoD = DecodificadoCorreo;
                ContraD = DecodificadoContra;

                MailMessage mmsg = new MailMessage();
                mmsg.To.Add(CorreoD);
                mmsg.Subject = TxtAsunto.Text;
                mmsg.SubjectEncoding = Encoding.UTF8;

                mmsg.Body = "Nombre: "+ TxtNombre.Text + "\n\r Correo electrónico: " + TxtEmail.Text + "\n\r Descripción del error: " + TxtDes.Text +" ";
                //Comparamos si archivo esta vacio y si no lo esta se lo declaramos a Attachments
                if (string.IsNullOrEmpty(Archivo) == false)
                {
                    Attachment Imagen = new Attachment(Archivo);
                    mmsg.Attachments.Add(Imagen);
                }
                mmsg.BodyEncoding = Encoding.UTF8;
                mmsg.IsBodyHtml = true;
                mmsg.From = new MailAddress(CorreoD);

                SmtpClient cliente = new SmtpClient();
                cliente.Credentials = new NetworkCredential(CorreoD, ContraD);
                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Host = "smtp.gmail.com";

                try
                {
                    MessageBox.Show("Reporte ha sido enviado","Mensaje enviado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cliente.Send(mmsg);
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
        //Abrir ventana del explorador de windows para seleccionar imagen
        private void BtnImagen_Click(object sender, EventArgs e)
        {
            string Seleccion = "Ha seleccionado una imagen";
            try
            {
                //Cuadro de dialogo de Ok/Cancelar cuando estan en el explorador de windows
                OpenFileDialog OFDSeleccionarImage = new OpenFileDialog();
                OFDSeleccionarImage.Filter = "Imagenes | *.jpg; *.png; *.jpeg";
                OFDSeleccionarImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                OFDSeleccionarImage.Title = "Seleccionar imagen";
                if (OFDSeleccionarImage.ShowDialog() == DialogResult.OK)
                {
                    Archivo = OFDSeleccionarImage.FileName;
                    lblinfo.Text = Seleccion;
                    lblinfo.ForeColor = Color.Navy;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar imagen","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        //Ir al Login
        private void cerrarSesiónTool_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        //Ir a Formulario Contenedor
        private void ToolMenu_Click(object sender, EventArgs e)
        {
            FrmContenedor contenedor = new FrmContenedor();
            contenedor.Show();
            this.Hide();
        }

        //Ir a Formulario Acerca de...
        private void acercaDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade acerca = new Acercade();
            acerca.Show();
            this.Hide();
        }

        //Cerrar Aplicación
        private void salirTool_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimizar aplicación
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Normalizar Formulario
        private void BtnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            if (WindowState == FormWindowState.Normal)
            {
                BtnMaximizar.Visible = true;
                BtnNormal.Visible = false;
            }
        }

        //Maximizar aplicación
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            if (WindowState == FormWindowState.Maximized)
            {
                BtnNormal.Visible = true;
                BtnMaximizar.Visible = false;
            }
        }

        //Abrir Formulario Ayuda
        private void ToolVerAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda AYUDA = new FrmAyuda();
            AYUDA.Show();
            this.Hide();
        }
    }
}
