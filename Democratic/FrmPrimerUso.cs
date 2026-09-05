using System;
using System.Drawing;
using System.IO;//Para Cargar imagen(permiten leer y escribir en archivos y flujos de datos)
using System.Drawing.Imaging;//Para Cargar imagen
using System.Windows.Forms;
using Controlador;

namespace Democratic
{
    public partial class FrmPrimerUso : Form
    {
        public FrmPrimerUso()
        {
            InitializeComponent();
        }

        void VerificarIdioma()
        {
            switch (VarSession.idioma)
            {
                case 1:
                    LblPrimerU.Text = Idiomas.English.lblprimerU;
                    lblPais.Text = Idiomas.English.lblpais;
                    lblTipo.Text = Idiomas.English.lbltipo;
                    lblComposicion.Text = Idiomas.English.lblcomposicion;
                    lblFecha.Text = Idiomas.English.lblfecha;
                    lblJurisdiccion.Text = Idiomas.English.lbljurisdiccion;
                    lblSede.Text = Idiomas.English.lblsede;
                    LblContrainfo.Text = Idiomas.English.Lblcontrainfo;
                    LblimgT.Text = Idiomas.English.lblimgT;
                    Lblimgmax.Text = Idiomas.English.lblimgmax;
                    BtnCargarImagen.Text = Idiomas.English.btncargarimagen;
                    BtnContinuar.Text = Idiomas.English.btncontinuar;
                    BtnCerrar.Text = Idiomas.English.btncerrar;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void OcultarControlesCorreo()
        {
            txtCorreoRegister.Visible = false;
            TxtContraseñaRegister.Visible = false;
            lblCorreoTribunalRegister.Visible = false;
            lblContraRegister.Visible = false;
            lblinfo.Visible = false;
            lblmenosseguras.Visible = false;
            LblContrainfo.Visible = false;
        }

        void ReacomodarLayout()
        {
            BtnContinuar.Location = new Point(324, 295);
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFDSeleccionarImage = new OpenFileDialog();
            OFDSeleccionarImage.Filter = "Imagenes | *.jpg; *.png; *.jpeg";
            OFDSeleccionarImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            OFDSeleccionarImage.Title = "Seleccionar imagen";

            if (OFDSeleccionarImage.ShowDialog() == DialogResult.OK)
            {
                PBtribunal.Image = Image.FromFile(OFDSeleccionarImage.FileName);
            }
        }

        void LimpiarCamposTribunal()
        {
            txtComposicion.Clear();
            txtpais.Clear();
            txtTipo.Clear();
            txtJurisdiccion.Clear();
            txtSede.Clear();
        }

        void EnvioDatosTribunal()
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                PBtribunal.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                string imagenTribunal = Convert.ToBase64String(aByte);

                TribunalController agregar = new TribunalController();
                agregar.fundacion = DtpFundacion.Text;
                agregar.composicion = txtComposicion.Text;
                agregar.imagenTribunal = imagenTribunal;
                agregar.pais = txtpais.Text;
                agregar.tipo = txtTipo.Text;
                agregar.jurisdicción = txtJurisdiccion.Text;
                agregar.sede = txtSede.Text;
                agregar.correotribunal = string.Empty;
                agregar.contratribunal = string.Empty;

                if (agregar.EnviarDatosTribunal_Controller() == false)
                {
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjtribunalerrorpu, Idiomas.EnglishMessage.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjtribunalerrorpu, Idiomas.MensajesEspanol.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    LimpiarCamposTribunal();
                }
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjfaltadatapu, Idiomas.EnglishMessage.msjfaltadataputitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjfaltadatapu, Idiomas.MensajesEspanol.msjfaltadataputitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            DateTime date2 = new DateTime(1600, 01, 01);
            try
            {
                if (string.IsNullOrWhiteSpace(txtpais.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txtTipo.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txtJurisdiccion.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txtComposicion.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(txtSede.Text.Trim()))
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
                else if (DtpFundacion.Value > DateTime.Now.Date)
                {
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjtribnocreatepu, Idiomas.EnglishMessage.msjtribnocreateputitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjtribnocreatepu , Idiomas.MensajesEspanol.msjtribnocreateputitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (DtpFundacion.Value <= date2)
                {
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjtribnoexistpu, Idiomas.EnglishMessage.msjtribnocreateputitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjtribnoexistpu, Idiomas.MensajesEspanol.msjtribnocreateputitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (PBtribunal.Image == null)
                {
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjtribuimgpu, Idiomas.EnglishMessage.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjtribuimgpu, Idiomas.MensajesEspanol.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    EnvioDatosTribunal();
                    FrmPrimerUsuario frmpuser = new FrmPrimerUsuario();
                    frmpuser.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjadminpu, Idiomas.EnglishMessage.msjadminputitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjadminpu, Idiomas.MensajesEspanol.msjadminputitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------

        private void txtpais_MouseEnter(object sender, EventArgs e)
        {
            lblPais.ForeColor = Color.DarkBlue;
        }

        private void txtpais_MouseLeave(object sender, EventArgs e)
        {
            lblPais.ForeColor = Color.White;
        }

        private void txtTipo_MouseEnter(object sender, EventArgs e)
        {
            lblTipo.ForeColor = Color.DarkBlue;
        }

        private void txtTipo_MouseLeave(object sender, EventArgs e)
        {
            lblTipo.ForeColor = Color.White;
        }

        private void DtpFundacion_MouseEnter(object sender, EventArgs e)
        {
            lblFecha.ForeColor = Color.DarkBlue;
        }

        private void DtpFundacion_MouseLeave(object sender, EventArgs e)
        {
            lblFecha.ForeColor = Color.White;
        }

        private void txtJurisdiccion_MouseEnter(object sender, EventArgs e)
        {
            lblJurisdiccion.ForeColor = Color.DarkBlue;
        }

        private void txtJurisdiccion_MouseLeave(object sender, EventArgs e)
        {
            lblJurisdiccion.ForeColor = Color.White;
        }

        private void txtComposicion_MouseEnter(object sender, EventArgs e)
        {
            lblComposicion.ForeColor = Color.DarkBlue;
        }

        private void txtComposicion_MouseLeave(object sender, EventArgs e)
        {
            lblComposicion.ForeColor = Color.White;
        }

        private void txtSede_MouseEnter(object sender, EventArgs e)
        {
            lblSede.ForeColor = Color.DarkBlue;
        }

        private void txtSede_MouseLeave(object sender, EventArgs e)
        {
            lblSede.ForeColor = Color.White;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtpais_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloLetras(e);
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloLetras(e);
        }

        private void txtJurisdiccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloLetras(e);
        }

        private void txtComposicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloLetras(e);
        }

        private void txtSede_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloLetras(e);
        }

        private void FrmPrimerUso_Load(object sender, EventArgs e)
        {
            VerificarIdioma();
            OcultarControlesCorreo();
            ReacomodarLayout();
        }
    }
}
