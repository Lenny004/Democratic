using System;
using System.Drawing;
using System.IO;//Para Cargar imagen(permiten leer y escribir en archivos y flujos de datos)
using System.Drawing.Imaging;//Para Cargar imagen
using System.Windows.Forms;
using Controlador;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace Democratic
{
    public partial class FrmCandidatos : Form
    {
        public FrmCandidatos()
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
                    lblNombreC.ForeColor = Color.White;
                    lblApellidoC.ForeColor = Color.White;
                    lblGenero.ForeColor = Color.White;
                    label1.ForeColor = Color.White;
                    lblEstadoC.ForeColor = Color.White;
                    lblBuscarP.ForeColor = Color.White;
                    BtnMinimizar.ForeColor = Color.White;
                    BtnAgregarCandidato.BackColor = Celeste;
                    BtnActualizarCandidato.BackColor = Celeste;
                    BtnLimpiarCandidato.BackColor = Celeste;
                    BtnEliminarCandidato.BackColor = Rosa;
                    toolStrip1.BackColor = Morado;
                    PanelCandidatos.BackColor = Morado;
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
                    BtnCargarImageC.Text = Idiomas.English.BtnCargarImageC;
                    BtnAgregarCandidato.Text = Idiomas.English.BtnAgregarCandidato;
                    BtnActualizarCandidato.Text = Idiomas.English.BtnActualizarCandidato;
                    BtnEliminarCandidato.Text = Idiomas.English.BtnEliminarCandidato;
                    BtnRefrescarCandidato.Text = Idiomas.English.BtnRefrescarM;
                    BtnEliminarCandidato.Text = Idiomas.English.BtnEliminarCandidato;
                    BtnTruncateC.Text = Idiomas.English.BtnTruncateC;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    lblNombreC.Text = Idiomas.English.lblNombreC;
                    lblApellidoC.Text = Idiomas.English.lblApellidoC;
                    lblGenero.Text = Idiomas.English.lblGenero;
                    label1.Text = Idiomas.English.lblafiliado;
                    lblEstadoC.Text = Idiomas.English.lblEstadoC;
                    lblBuscarP.Text = Idiomas.English.lblBuscarC;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void CargarEstadoC()
        {
            CmbEstadoC.DataSource = CandidatosController.CargarEstadoC_Controller();
            CmbEstadoC.ValueMember = "id_Estado_Candidato";
            CmbEstadoC.DisplayMember = "Estado_Candidato";
        }

        void CargarPartidoC()
        {
            CmbPartidoC.DataSource = CandidatosController.CargarPartidoC_Controller();
            CmbPartidoC.ValueMember = "id_Partido";
            CmbPartidoC.DisplayMember = "Nombre_Partido";
        }

        void CargarListasC()
        {
            try
            {
                CargarEstadoC();
                CargarPartidoC();

                DgvCandidatos.DataSource = CandidatosController.CargarCandidato_Controller();
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjerrortreslistas, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjerrortreslistas, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Metodo para que al iniciar este desabilitado la opción de Actualizar y Borrar
        void HabilitarUpdDel()
        {
            BtnActualizarCandidato.Enabled = true;
            BtnEliminarCandidato.Enabled = true;
        }

        void LimpiarCamposC()
        {
            txtNombreC.Clear();
            txtApellidoC.Clear();
            TxtgeneroC.Clear();
            txtIdC.Clear();
            BtnAgregarCandidato.Enabled = true;
            BtnActualizarCandidato.Enabled = false;
            BtnEliminarCandidato.Enabled = false;
        }

        void EnvioDatosC()
        {
            MemoryStream ms = new MemoryStream();
            PbCandidato.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            string imagenCandidato = Convert.ToBase64String(aByte);

            CandidatosController agregar = new CandidatosController();
            agregar.Nombre_Candidato = txtNombreC.Text;
            agregar.Apellido_Candidato = txtApellidoC.Text;
            agregar.Género = TxtgeneroC.Text;
            agregar.Imagen_Candidato = imagenCandidato;
            agregar.Partido = Convert.ToInt16(CmbPartidoC.SelectedValue);
            agregar.Estado_Candidato = Convert.ToInt16(CmbEstadoC.SelectedValue);
            if (agregar.EnviarDatosCandidato_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjcandidatonoingresado, Idiomas.EnglishMessage.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjcandidatonoingresado, Idiomas.MensajesEspanol.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCamposC();
            }
        }

        private void DgvCandidatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnAgregarCandidato.Enabled = false;
            HabilitarUpdDel();

            //objeto de la clase MiembrosController
            CandidatosController objselect = new CandidatosController();
            //Almanecera el numero de la fila que demos click
            int posicion;
            //Esta linea de código sirve para capturar el número de la fila sobre la que se hace click
            posicion = DgvCandidatos.CurrentRow.Index;
            //Asignamos lo que esta en el DataGrid en cada uno de los controles, utilizamos el principio teórico de Arrays dibimensionales donde tenemos [columnas, filas]
            txtIdC.Text = DgvCandidatos[0, posicion].Value.ToString();
            txtNombreC.Text = DgvCandidatos[1, posicion].Value.ToString();
            txtApellidoC.Text = DgvCandidatos[2, posicion].Value.ToString();
            TxtgeneroC.Text = DgvCandidatos[3, posicion].Value.ToString();

            MySqlConnection conexion = MainController.ConnectController();
            string query = "SELECT imagen FROM tb_opcion WHERE id_opcion = ?param1";
            MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion);
            cmdselect.Parameters.Add(new MySqlParameter("param1", txtIdC.Text));
            MySqlDataReader Reader = cmdselect.ExecuteReader();
            while (Reader.Read())
            {
                byte[] imagenC = Convert.FromBase64String(Reader.GetString(0));
                MemoryStream ms = new MemoryStream(imagenC);
                PbCandidato.Image = Image.FromStream(ms);
            }

            //Llenamos el combobox según el ID contenido en el DataGridView
            //Guardar en una variable de tipo entero el id contenido en el DataGridView
            string Partido = DgvCandidatos[5, posicion].Value.ToString();
            //Creamos un nuevo método que permita consultar el grupo de opciones según el ID contenido en la celda.
            CmbPartidoC.DataSource = objselect.CargarPartidoCInnerJoin_Controller(Partido);
            CmbPartidoC.ValueMember = "id_Partido";
            CmbPartidoC.DisplayMember = "Nombre_Partido";

            //Llenamos el combobox según el ID contenido en el DataGridView
            //Guardar en una variable de tipo entero el id contenido en el DataGridView
            string Estado_Candidato = DgvCandidatos[6, posicion].Value.ToString();
            //Creamos un nuevo método que permita consultar el estado de la opción según el ID contenido en la celda.
            CmbEstadoC.DataSource = objselect.CargarEstadoCandidatoInnerJoin_Controller(Estado_Candidato);
            CmbEstadoC.ValueMember = "id_Estado_Candidato";
            CmbEstadoC.DisplayMember = "Estado_Candidato";
        }

        void ActualizarDatosC()
        {
            CandidatosController objactualizar = new CandidatosController();
            objactualizar.id_Candidato = Convert.ToInt16(txtIdC.Text);
            objactualizar.Nombre_Candidato = txtNombreC.Text;
            objactualizar.Apellido_Candidato = txtApellidoC.Text;
            objactualizar.Género = TxtgeneroC.Text;

            MemoryStream ms = new MemoryStream();
            PbCandidato.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            string imagenCandidato = Convert.ToBase64String(aByte);
            objactualizar.Imagen_Candidato = imagenCandidato;
            objactualizar.Partido = Convert.ToInt16(CmbPartidoC.SelectedValue);
            objactualizar.Estado_Candidato = Convert.ToInt16(CmbEstadoC.SelectedValue);

            if (objactualizar.ActualizarDatosCandidato_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjactanoupdate, Idiomas.EnglishMessage.msjnoactualizadotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjactanoupdate, Idiomas.MensajesEspanol.msjnoactualizadotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCamposC();
                CargarListasC();
            }
        }

        void EliminarCandidato()
        {
            CandidatosController objdelete = new CandidatosController();
            objdelete.id_Candidato = Convert.ToInt16(txtIdC.Text);
            int valor = objdelete.EliminarCandidato_Controller();

            switch (valor)
            {
                case -1:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjDatabaseP, Idiomas.EnglishMessage.msjDatabasePTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjDatabaseP, Idiomas.MensajesEspanol.msjDatabasePTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 1:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjcandidatoeliminado, Idiomas.EnglishMessage.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjcandidatoeliminado, Idiomas.MensajesEspanol.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 2:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjcandidatonoeliminado, Idiomas.EnglishMessage.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjcandidatonoeliminado, Idiomas.MensajesEspanol.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                default:
                    break;
            }
        }

        void TruncateTbCandidato()
        {
            CandidatosController truncate = new CandidatosController();
            if (truncate.TruncateCandidato_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjcandidatosnoeliminados, Idiomas.EnglishMessage.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjcandidatosnoeliminados, Idiomas.MensajesEspanol.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjcandidatoseliminados, Idiomas.EnglishMessage.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjcandidatoseliminados, Idiomas.MensajesEspanol.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpiarCamposC();
                CargarListasC();
            }
        }

        private void BtnCargarImageC_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFDSeleccionarImage = new OpenFileDialog();
            OFDSeleccionarImage.Filter = "Imagenes | *.jpg; *.png; *.jpeg";
            OFDSeleccionarImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            OFDSeleccionarImage.Title = "Seleccionar imagen";

            if (OFDSeleccionarImage.ShowDialog() == DialogResult.OK)
            {
                PbCandidato.Image = Image.FromFile(OFDSeleccionarImage.FileName);
            }
        }

        private void FrmCandidatos_Load(object sender, EventArgs e)
        {
            VerificarMode();
            VerificarIdioma();
            CargarListasC();
            BtnActualizarCandidato.Enabled = false;
            BtnEliminarCandidato.Enabled = false;
        }

        private void BtnAgregarCandidato_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreC.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtApellidoC.Text.Trim()) ||
                string.IsNullOrWhiteSpace(TxtgeneroC.Text.Trim()))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjcamposnecesarios, Idiomas.EnglishMessage.msjdatosfaltantescandidato, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjcamposnecesarios, Idiomas.MensajesEspanol.msjdatosfaltantescandidato, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (PbCandidato.Image == null)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjimagencandidato, Idiomas.EnglishMessage.msjimagencandidato, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjimagencandidato, Idiomas.MensajesEspanol.msjimagencandidato, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnvioDatosC();
                CargarListasC();
                BtnActualizarCandidato.Enabled = false;
                BtnEliminarCandidato.Enabled = false;
            }
        }

        private void BtnRefrescarCandidato_Click(object sender, EventArgs e)
        {
            CargarListasC();
        }

        private void BtnActualizarCandidato_Click(object sender, EventArgs e)
        {
            ActualizarDatosC();
        }

        private void BtnLimpiarCandidato_Click(object sender, EventArgs e)
        {
            LimpiarCamposC();
        }

        private void BtnEliminarCandidato_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estás seguro de querer eliminar la opción: " + txtNombreC.Text + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                EliminarCandidato();
                CargarListasC();
                LimpiarCamposC();
            }
        }

        private void BtnTruncateC_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estás seguro de eliminar todas las opciones?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                TruncateTbCandidato();
                CargarListasC();
                LimpiarCamposC();
            }
        }

        private void CmbPartidoC_Click(object sender, EventArgs e)
        {
            CargarPartidoC();
        }

        private void CmbEstadoC_Click(object sender, EventArgs e)
        {
            CargarEstadoC();
        }

        private void txtNombreC_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloLetras(e);
        }

        private void txtApellidoC_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloLetras(e);
        }

        private void TxtgeneroC_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloLetras(e);
        }

        private void DgvCandidatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (VarSession.Color)
            {
                case 1:
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Oscuro;
                    e.CellStyle.SelectionBackColor = Color.Cyan;
                    e.CellStyle.SelectionForeColor = Color.Black;
                    DgvCandidatos.BackgroundColor = Medio;
                    DgvCandidatos.HeaderBgColor = Rosa;
                    DgvCandidatos.HeaderForeColor = Color.White;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
