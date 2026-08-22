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
using System.Drawing.Imaging;

namespace Democratic
{
    public partial class FrmMiembros : Form
    {
        public FrmMiembros()
        {
            InitializeComponent();
        }
        private Color Celeste = ColorTranslator.FromHtml("#4e79a2");
        private Color Rosa = ColorTranslator.FromHtml("#BF5E6F");
        private Color Rosa2 = ColorTranslator.FromHtml("#f25c5c");
        private Color Oscuro = ColorTranslator.FromHtml("#211f2e");
        private Color Medio = ColorTranslator.FromHtml("#454356");
        private Color Morado = ColorTranslator.FromHtml("#161422");

        void VerificarMode()
        {
            switch (VarSession.Color)
            {
                case 1:
                    lblNombreMiembro.ForeColor = Color.White;
                    lblApellidoM.ForeColor = Color.White;
                    lblDuiM.ForeColor = Color.White;
                    lblFechaNM.ForeColor = Color.White;
                    lblDireccionM.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    label1.ForeColor = Color.White;
                    lblEstadoM.ForeColor = Color.White;
                    BtnMinimizar.ForeColor = Color.White;
                    BtnAgregarM.BackColor = Celeste;
                    BtnActualizarM.BackColor = Celeste;
                    BtnLimpiar.BackColor = Celeste;
                    toolStrip1.BackColor = Morado;
                    PanelMiembro.BackColor = Morado;
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
                    lblNombreMiembro.Text = Idiomas.English.lblNombreMiembro;
                    lblApellidoM.Text = Idiomas.English.lblApellidoM;
                    lblDuiM.Text = Idiomas.English.lblDuiM;
                    lblFechaNM.Text = Idiomas.English.lblFechaNM;
                    lblDireccionM.Text = Idiomas.English.lblDireccionM;
                    label3.Text = Idiomas.English.label3;
                    label2.Text = Idiomas.English.label2;
                    label1.Text = Idiomas.English.label1;
                    lblEstadoM.Text = Idiomas.English.lblEstadoM;
                    BtnAgregarM.Text = Idiomas.English.BtnAgregarM;
                    BtnActualizarM.Text = Idiomas.English.BtnActualizarM;
                    BtnLimpiar.Text = Idiomas.English.BtnLimpiar;
                    BtnRefrescarM.Text = Idiomas.English.BtnRefrescarM;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void CargarEstadoMiembro()
        {
            CmbEstadoM.DataSource = MiembrosController.CargarEstadoMiembro_Controller();
            CmbEstadoM.ValueMember = "id_Estado_Miembros";
            CmbEstadoM.DisplayMember = "Nombre_Estado_Miembros";
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

        void CargarLista()
        {
            try
            {
                CargarJRV();
                CargarCV();
                CargarEstadoMiembro();

                DgvMiembros.DataSource = MiembrosController.CargarMiembros_Controller();
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjErrorM, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjErrorM, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void EnvioDatosM()
        {
            MiembrosController agregar = new MiembrosController();
            agregar.nombre = TxtNombreM.Text;
            agregar.apellido = TxtApellidoM.Text;
            agregar.dui = MskDui.Text;
            agregar.OCR = TxtOCR.Text;

            MemoryStream ms = new MemoryStream();
            PbMiembro.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            string ImagenMiembro = Convert.ToBase64String(aByte);
            agregar.ImagenM = ImagenMiembro;

            agregar.Fecha_de_nacimiento = DateTPFNM.Text;
            agregar.dirección = TxtDireccionM.Text;
            agregar.telefono = MskTelefonoM.Text;
            agregar.JRV = Convert.ToInt16(CmbJRV.SelectedValue);
            agregar.CV = Convert.ToInt16(CmbCV.SelectedValue);
            agregar.estadomiembro = Convert.ToInt16(CmbEstadoM.SelectedValue);
            if(agregar.EnviarDatosMiembro_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjInsertM, Idiomas.EnglishMessage.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjInsertM, Idiomas.MensajesEspanol.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                CargarLista();
                LimpiarCampos();
            }
        }

        void ActualizarDatos()
        {
            MiembrosController objactualizar = new MiembrosController();
            objactualizar.id_Miembro = Convert.ToInt16(TxtIdM.Text);
            objactualizar.nombre = TxtNombreM.Text;
            objactualizar.apellido = TxtApellidoM.Text;
            objactualizar.dui = MskDui.Text;
            objactualizar.OCR = TxtOCR.Text;

            MemoryStream ms = new MemoryStream();
            PbMiembro.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            string ImagenMiembro = Convert.ToBase64String(aByte);
            objactualizar.ImagenM = ImagenMiembro;

            objactualizar.Fecha_de_nacimiento = DateTPFNM.Text;
            objactualizar.dirección = TxtDireccionM.Text;
            objactualizar.telefono = MskTelefonoM.Text;
            objactualizar.CV = Convert.ToInt16(CmbCV.SelectedValue);
            objactualizar.JRV = Convert.ToInt16(CmbJRV.SelectedValue);
            objactualizar.estadomiembro = Convert.ToInt16(CmbEstadoM.SelectedValue);
            if (objactualizar.ActualizarDatosM_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjUpdM, Idiomas.EnglishMessage.msjnoactualizadotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjUpdM, Idiomas.MensajesEspanol.msjnoactualizadotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCampos();
                CargarLista();
            }
        }

        private void DgvMiembros_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BtnAgregarM.Enabled = false;
            HabilitarUpdDel();

            //objeto de la clase MiembrosController (participantes)
            MiembrosController objselect = new MiembrosController();
            //Almanecera el numero de la fila que demos click
            int posicion;
            //Esta linea de código sirve para capturar el número de la fila sobre la que se hace click
            posicion = DgvMiembros.CurrentRow.Index;
            //Asignamos lo que esta en el DataGrid en cada uno de los controles, utilizamos el principio teórico de Arrays dibimensionales donde tenemos [columnas, filas]
            TxtIdM.Text = DgvMiembros[0, posicion].Value.ToString();
            TxtNombreM.Text = DgvMiembros[1, posicion].Value.ToString();
            TxtApellidoM.Text = DgvMiembros[2, posicion].Value.ToString();
            MskDui.Text = DgvMiembros[3, posicion].Value.ToString();
            TxtOCR.Text = DgvMiembros[4, posicion].Value.ToString();

            MySqlConnection conexion = MainController.ConnectController();
            string query = "SELECT Imagen_Miembro FROM tbmiembros WHERE id_Miembro = ?param1";
            MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion);
            cmdselect.Parameters.Add(new MySqlParameter("param1", TxtIdM.Text));
            MySqlDataReader Reader = cmdselect.ExecuteReader();
            while (Reader.Read())
            {
                byte[] imagenP = Convert.FromBase64String(Reader.GetString(0));
                MemoryStream ms = new MemoryStream(imagenP);
                PbMiembro.Image = Image.FromStream(ms);
            }

            DateTPFNM.Text = DgvMiembros[6, posicion].Value.ToString();
            TxtDireccionM.Text = DgvMiembros[7, posicion].Value.ToString();
            MskTelefonoM.Text = DgvMiembros[8, posicion].Value.ToString();

            //Llenamos el combobox según la sede del participante
            string idSede = DgvMiembros[9, posicion].Value.ToString();
            CmbEstadoM.DataSource = objselect.CargarCentroVotacionInnerJoin_Controller(idSede);
            CmbEstadoM.DisplayMember = "Nombre_Centro_Votación";
            CmbEstadoM.ValueMember = "id_Centro_Votación";

            //Llenamos el combobox según la mesa del participante
            string idMesa = DgvMiembros[10, posicion].Value.ToString();
            CmbEstadoM.DataSource = objselect.CargarJRVInnerJoin_Controller(idMesa);
            CmbEstadoM.DisplayMember = "Correlativo_JRV";
            CmbEstadoM.ValueMember = "id_JRV";

            //Llenamos el combobox según el estado del participante
            string EstadoParticipante = DgvMiembros[11, posicion].Value.ToString();
            CmbEstadoM.DataSource = objselect.CargarEstadoMiembroInnerJoin_Controller(EstadoParticipante);
            CmbEstadoM.DisplayMember = "Nombre_Estado_Miembros";
            CmbEstadoM.ValueMember = "id_Estado_Miembros";
        }

        void LimpiarCampos()
        {
            TxtNombreM.Clear();
            TxtApellidoM.Clear();
            MskDui.Clear();
            TxtDireccionM.Clear();
            TxtOCR.Clear();
            MskTelefonoM.Clear();
            BtnAgregarM.Enabled = true;
            BtnActualizarM.Enabled = false;
            
        }

        //Metodo para que al iniciar este desabilitado la opción de Actualizar y Borrar
        void HabilitarUpdDel()
        {
            BtnActualizarM.Enabled = true;
        }

        private void FrmMiembros_Load(object sender, EventArgs e)
        {
            VerificarMode();
            VerificarIdioma();
            BtnActualizarM.Enabled = false;
            CargarLista();
        }

        private void BtnAgregarM_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(2003, 01, 01);
            DateTime date2 = new DateTime(1900, 01, 01);
            if (DateTPFNM.Value >= date1)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjMenorM, Idiomas.EnglishMessage.msjtribnocreateputitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjMenorM, Idiomas.MensajesEspanol.msjtribnocreateputitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (DateTPFNM.Value <= date2)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjDiedM, Idiomas.EnglishMessage.msjtribnocreateputitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjDiedM, Idiomas.MensajesEspanol.msjtribnocreateputitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (string.IsNullOrWhiteSpace(TxtNombreM.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(TxtApellidoM.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(MskDui.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(TxtDireccionM.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(MskTelefonoM.Text.Trim()))
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
            else
            {
                EnvioDatosM();
                CargarLista();
                BtnActualizarM.Enabled = false;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnActualizarM_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void BtnRefrescarM_Click(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CmbEstadoM_Click(object sender, EventArgs e)
        {
            CargarEstadoMiembro();
        }

        private void TxtNombreM_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloLetras(e);
        }

        private void TxtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloLetras(e);
        }

        private void DgvMiembros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (VarSession.Color)
            {
                case 1:
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Oscuro;
                    e.CellStyle.SelectionBackColor = Color.Cyan;
                    e.CellStyle.SelectionForeColor = Color.Black;
                    DgvMiembros.BackgroundColor = Medio;
                    DgvMiembros.HeaderBgColor = Rosa;
                    DgvMiembros.HeaderForeColor = Color.White;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void BtnCargarImageP_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFDSeleccionarImage = new OpenFileDialog();
            OFDSeleccionarImage.Filter = "Imagenes | *.jpg; *.png; *.jpeg";
            OFDSeleccionarImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            OFDSeleccionarImage.Title = "Seleccionar imagen";

            if (OFDSeleccionarImage.ShowDialog() == DialogResult.OK)
            {
                PbMiembro.Image = Image.FromFile(OFDSeleccionarImage.FileName);
            }
        }
    }
}
