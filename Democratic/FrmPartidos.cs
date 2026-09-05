using System;
using System.Drawing;
using System.IO;//Para Cargar imagen(permiten leer y escribir en archivos y flujos de datos)
using System.Drawing.Imaging;//Para Cargar imagen
using System.Windows.Forms;
using Controlador;
using MySql.Data.MySqlClient;
using System.Data;

namespace Democratic
{
    public partial class FrmPartidos : Form
    {
        public FrmPartidos()
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
                    lblNombreP.ForeColor = Color.White;
                    lblEstadoP.ForeColor = Color.White;
                    lblCantidadVotos.ForeColor = Color.White;
                    lblBuscarP.ForeColor = Color.White;
                    lblRecomendación.ForeColor = Color.White;
                    BtnMinimizar.ForeColor = Color.White;
                    BtnAgregarPartido.BackColor = Celeste;
                    BtnActualizarPartido.BackColor = Celeste;
                    BtnLimpiarPartidos.BackColor = Celeste;
                    BtnEliminarPartido.BackColor = Rosa;
                    PanelPartido.BackColor = Morado;
                    toolStrip1.BackColor = Morado;
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
                    lblNombreP.Text = Idiomas.English.lblNombrep;
                    lblEstadoP.Text = Idiomas.English.lblestadopartido;
                    lblCantidadVotos.Text = Idiomas.English.lblCantidadVotos;
                    lblBuscarP.Text = Idiomas.English.lblBuscarP;
                    BtnAgregarPartido.Text = Idiomas.English.BtnAgregarPartido;
                    BtnActualizarPartido.Text = Idiomas.English.BtnActualizarPartido;
                    BtnLimpiarPartidos.Text = Idiomas.English.BtnLimpiarPartidos;
                    BtnRefrescarPartidos.Text = Idiomas.English.BtnRefrescarM;
                    BtnEliminarPartido.Text = Idiomas.English.BtnEliminarPartido;
                    BtnCargarImageP.Text = Idiomas.English.btncargarimagen;
                    lblRecomendación.Text = Idiomas.English.lblRecomendación;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void CargarEstadoPartido()
        {
            CmbEstadoP.DataSource = PartidoController.CargarEstadoPartido_Controller();
            CmbEstadoP.ValueMember = "id_Estado_Partido";
            CmbEstadoP.DisplayMember = "Estado_Partido";
        }

        void CargarListasP()
        {
            try
            {
                CargarEstadoPartido();

                DgvPartidos.DataSource = PartidoController.CargarPartido_Controller();
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjErrorListP, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjErrorListP, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void EnvioDatosP()
        {
            MemoryStream ms = new MemoryStream();
            PbPartido.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            string imagenPartido = Convert.ToBase64String(aByte);

            PartidoController agregar = new PartidoController();
            agregar.image = imagenPartido;
            agregar.nombrep = TxtNombreP.Text;
            agregar.Cantidadvotosp = Convert.ToInt16(TxtCantidadVotosP.Text);
            agregar.Estado_Partido = Convert.ToInt16(CmbEstadoP.SelectedValue);
            if (agregar.EnviarDatosPartido_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjInsertP, Idiomas.EnglishMessage.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjInsertP, Idiomas.MensajesEspanol.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCamposP();
            }
        }

        void LimpiarCamposP()
        {
            TxtCantidadVotosP.Clear();
            TxtIdP.Clear();
            TxtNombreP.Clear();
            BtnAgregarPartido.Enabled = true;
            BtnActualizarPartido.Enabled = false;
            BtnEliminarPartido.Enabled = false;
        }

        //Metodo para que al iniciar este desabilitado la opción de Actualizar y Borrar
        void HabilitarUpdDel()
        {
            BtnActualizarPartido.Enabled = true;
            BtnEliminarPartido.Enabled = true;
        }

        private void FrmPartidos_Load(object sender, EventArgs e)
        {
            VerificarMode();
            VerificarIdioma();
            CargarListasP();
            BtnActualizarPartido.Enabled = false;
            BtnEliminarPartido.Enabled = false;
        }

        private void DgvPartidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnAgregarPartido.Enabled = false;
            HabilitarUpdDel();

            //objeto de la clase MiembrosController
            PartidoController objselect = new PartidoController();
            //Almanecera el numero de la fila que demos click
            int posicion;
            //Esta linea de código sirve para capturar el número de la fila sobre la que se hace click
            posicion = DgvPartidos.CurrentRow.Index;
            //Asignamos lo que esta en el DataGrid en cada uno de los controles, utilizamos el principio teórico de Arrays dibimensionales donde tenemos [columnas, filas]
            TxtIdP.Text = DgvPartidos[0, posicion].Value.ToString();


            MySqlConnection conexion = MainController.ConnectController();
            string query = "SELECT imagen FROM tb_grupo_opciones WHERE id_grupo_opciones = ?param1";
            MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion);
            cmdselect.Parameters.Add(new MySqlParameter("param1", TxtIdP.Text));
            MySqlDataReader Reader = cmdselect.ExecuteReader();
            while (Reader.Read())
            {
                byte[] imagenP = Convert.FromBase64String(Reader.GetString(0));
                MemoryStream ms = new MemoryStream(imagenP);
                PbPartido.Image = Image.FromStream(ms);
            }

            TxtNombreP.Text = DgvPartidos[2, posicion].Value.ToString();
            TxtCantidadVotosP.Text = DgvPartidos[3, posicion].Value.ToString();
            //Llenamos el combobox según el ID contenido en el DataGridView
            //Guardar en una variable de tipo entero el id contenido en el DataGridView
            string Estado_Partido = DgvPartidos[4, posicion].Value.ToString();
            //Creamos un nuevo método que permita consultar el estado del grupo de opciones según el ID contenido en la celda.
            CmbEstadoP.DataSource = objselect.CargarEstadoVotosInnerJoin_Controller(Estado_Partido);
            CmbEstadoP.ValueMember = "id_Estado_Partido";
            CmbEstadoP.DisplayMember = "Estado_Partido";
        }

        void ActualizarDatosP()
        {

            PartidoController objactualizar = new PartidoController();
            objactualizar.idPartido = Convert.ToInt16(TxtIdP.Text);
            objactualizar.nombrep = TxtNombreP.Text;

            MemoryStream ms = new MemoryStream();
            PbPartido.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            string imagenCandidato = Convert.ToBase64String(aByte);
            objactualizar.image = imagenCandidato;
            objactualizar.Cantidadvotosp = Convert.ToInt16(TxtCantidadVotosP.Text);
            objactualizar.Estado_Partido = Convert.ToInt16(CmbEstadoP.SelectedValue);

            if (objactualizar.ActualizarDatosPartido_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjUpdP, Idiomas.EnglishMessage.msjnoactualizadotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjUpdP, Idiomas.MensajesEspanol.msjnoactualizadotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCamposP();
            }
        }

        void EliminarDatosP()
        {
            PartidoController objdel = new PartidoController();
            objdel.idPartido = Convert.ToInt16(TxtIdP.Text);
            int valor = objdel.EliminarPartido_Controller();

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
                        MessageBox.Show(Idiomas.EnglishMessage.msjDeletedP, Idiomas.EnglishMessage.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjDeletedP, Idiomas.MensajesEspanol.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 2:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjEmployedP, Idiomas.EnglishMessage.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjEmployedP, Idiomas.MensajesEspanol.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                default:
                    break;
            }
        }

        private void BtnActualizarPartido_Click(object sender, EventArgs e)
        {
            ActualizarDatosP();
            CargarListasP();
        }

        private void BtnAgregarPartido_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombreP.Text.Trim())||
                string.IsNullOrWhiteSpace(TxtCantidadVotosP.Text.Trim()))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjFieldsP, Idiomas.EnglishMessage.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjFieldsP, Idiomas.MensajesEspanol.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (PbPartido.Image == null)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjImageP, Idiomas.EnglishMessage.msjImagePTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjImageP, Idiomas.MensajesEspanol.msjImagePTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnvioDatosP();
                CargarListasP();
                BtnActualizarPartido.Enabled = false;
                BtnEliminarPartido.Enabled = false;
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
                PbPartido.Image = Image.FromFile(OFDSeleccionarImage.FileName);
            }
        }

        private void BtnLimpiarPartidos_Click(object sender, EventArgs e)
        {
            LimpiarCamposP();
        }

        private void CmbEstadoP_MouseClick(object sender, MouseEventArgs e)
        {
            CargarEstadoPartido();
        }

        private void BtnEliminarPartido_Click(object sender, EventArgs e)
        {
            if (VarSession.idioma == 1)
            {
                DialogResult dr = MessageBox.Show(Idiomas.EnglishMessage.msjcadidatoselimited + TxtNombreP.Text + " ?", Idiomas.EnglishMessage.msjConfirmationPTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    EliminarDatosP();
                    CargarListasP();
                    LimpiarCamposP();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show(Idiomas.MensajesEspanol.msjConfirmationP + TxtNombreP.Text + " ?", Idiomas.MensajesEspanol.msjextraño2, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    EliminarDatosP();
                    CargarListasP();
                    LimpiarCamposP();
                }
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TxtNombreP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloLetras(e);
        }

        private void TxtCantidadVotosP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloNumeros(e);
        }

        private void DgvPartidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (VarSession.Color)
            {
                case 1:
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Oscuro;
                    e.CellStyle.SelectionBackColor = Color.Cyan;
                    e.CellStyle.SelectionForeColor = Color.Black;
                    DgvPartidos.BackgroundColor = Medio;
                    DgvPartidos.HeaderBgColor = Rosa;
                    DgvPartidos.HeaderForeColor = Color.White;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
