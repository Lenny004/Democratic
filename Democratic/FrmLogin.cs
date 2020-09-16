using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Controlador;

namespace Democratic
{
    public partial class FrmLogin : Form
    {
        public string User;
        public int idnivel;
        public string nombre;
        public string lastname;
        public string Tipo_Usuario;

        public FrmLogin()
        {
            InitializeComponent();
        }

        void ObtenerDatos()
        {
            List<string> datos = LoginController.Nivel_Controller();
            User = datos[0];
            idnivel = Convert.ToInt16(datos[1]);
            nombre = datos[2];
            lastname= datos[3];
            Tipo_Usuario = datos[4];
        }

        void EnvioDatosLog()
        { 
            AtributosLogin.usuario = txtUsuario.Text;
            AtributosLogin.Clave_Usuario = txtClave.Text;
            int acceso = LoginController.Acceso_Controller();

            if (acceso == 1)
            {
                ObtenerDatos();
                FrmContenedor Contenedor = new FrmContenedor(User, idnivel, nombre, lastname, Tipo_Usuario);
                Contenedor.Show();
                this.Hide();
            }
            else if (acceso == 2)
            {
                MessageBox.Show("Usuario o clave incorrecto, verifique sus credenciales", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Se perdió la conexión con la base de datos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Todos los campos son requeridos.", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EnvioDatosLog();
            }
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
                }
                else if (valor2 == 0)
                {
                    PicturePrimerUsuario.Visible = true;
                    BtnPrimerUsuario.Visible = true;
                    PicturePrimerUso.Visible = false;
                    BtnPrimerUso.Visible = false;
                    lblUser.Visible = false;
                    txtUsuario.Visible = false;
                    Separador1.Visible = false;
                    lblPass.Visible = false;
                    txtClave.Visible = false;
                    Separador2.Visible = false;
                    BtnAcceder.Visible = false;
                    lblCuenta.Visible = false;
                    lblRegistrar.Visible = false;
                    lblOlvidar.Visible = false;
                }
                else if (valor2 < 0)
                {
                    PicturePrimerUso.Visible = false;
                    BtnPrimerUso.Visible = false;
                    PicturePrimerUsuario.Visible = false;
                    BtnPrimerUsuario.Visible = false;
                    MessageBox.Show("Ocurrió un error de verificación, consulte con su administrador.", "Información de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (valor == 0)
            {
                PicturePrimerUso.Visible = true;
                BtnPrimerUso.Visible = true;
                lblUser.Visible = false;
                txtUsuario.Visible = false;
                Separador1.Visible = false;
                lblPass.Visible = false;
                txtClave.Visible = false;
                Separador2.Visible = false;
                BtnAcceder.Visible = false;
                lblCuenta.Visible = false;
                lblRegistrar.Visible = false;
                lblOlvidar.Visible = false;
                PicturePrimerUsuario.Visible = false;
                BtnPrimerUsuario.Visible = false;
            }
            else if (valor < 0)
            {
                MessageBox.Show("Ocurrió un error de verificación, consulte con su administrador.", "Información de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            VerificarTribunalYUser();
        }

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
    }
}

