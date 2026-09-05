using System;
using System.Windows.Forms;
using Controlador;
using System.Drawing;

namespace Democratic
{
    public partial class FrmJRV : Form
    {
        public FrmJRV()
        {
            InitializeComponent();
        }

        void VerificarMode()
        {
            UiTheme.ApplyCrudPanel(
                PanelJRV,
                toolStrip1,
                new Control[] { lblcorrelativo, LblEstadoJRV, LblCV, lblBuscar },
                BtnIngresarJRV,
                BtnActualizarJRV,
                BtnLimpiarJRV,
                BtnMinimizar,
                BtnEliminarJRV);
        }

        void VerificarIdioma()
        {
            switch (VarSession.idioma)
            {
                case 1:
                    BtnIngresarJRV.Text = Idiomas.English.BtnIngresarJRV;
                    BtnActualizarJRV.Text = Idiomas.English.BtnActualizarJRV;
                    BtnLimpiarJRV.Text = Idiomas.English.BtnLimpiarPartidos;
                    BtnRefrescarJRV.Text = Idiomas.English.BtnRefrescarM;
                    BtnEliminarJRV.Text = Idiomas.English.BtnEliminarJRV;
                    lblcorrelativo.Text = Idiomas.English.lblcorrelative;
                    LblEstadoJRV.Text = Idiomas.English.lblestadovrb;
                    LblCV.Text = Idiomas.English.lblcentrovotacion;
                    lblBuscar.Text = Idiomas.English.lblBuscarjrv;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void CargarCentroVotacion()
        {
            CmbCentroV.DataSource = JRVController.CargarCentroVotacion_controller();
            CmbCentroV.DisplayMember = "Nombre_Centro_Votación";
            CmbCentroV.ValueMember = "id_Centro_Votación";
        }

        void CargarEstadoJRV()
        {
            CmbEstadoJRV.DataSource = JRVController.CargarEstadojrv_controller();
            CmbEstadoJRV.DisplayMember = "Nombre_Estado_JRV";
            CmbEstadoJRV.ValueMember = "id_Estado_JRV";
        }

        void CargarListasJRV()
        {
            try
            {
                CargarCentroVotacion();
                CargarEstadoJRV();

                DgvJRV.DataSource = JRVController.CargarJRV_controller();
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjdoslistas, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjdoslistas, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void LimpiarCamposJRV()
        {
            txtIdJRV.Clear();
            TxtCorrelativo.Clear();
            BtnIngresarJRV.Enabled = true;
            BtnActualizarJRV.Enabled = false;
            BtnEliminarJRV.Enabled = false;
        }

        //Metodo para que al iniciar este desabilitado la opción de Actualizar y Borrar
        void HabilitarUpdDel()
        {
            BtnActualizarJRV.Enabled = true;
            BtnEliminarJRV.Enabled = true;
        }

        void EnviarDatosJRV()
        {
            JRVController agregar = new JRVController();
            agregar.correlativo = TxtCorrelativo.Text;
            agregar.centrovotacion = Convert.ToInt16(CmbCentroV.SelectedValue);
            agregar.estadojrv = Convert.ToInt16(CmbEstadoJRV.SelectedValue);
            if (agregar.EnviarDatosJRV_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjJRVnoingresada, Idiomas.EnglishMessage.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjJRVnoingresada, Idiomas.MensajesEspanol.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCamposJRV();
                CargarListasJRV();
            }
        }

        private void BtnIngresarJRV_Click(object sender, EventArgs e)
        {
            EnviarDatosJRV();
        }

        private void FrmJRV_Load(object sender, EventArgs e)
        {
            VerificarMode();
            VerificarIdioma();
            CargarListasJRV();
            BtnActualizarJRV.Enabled = false;
            BtnEliminarJRV.Enabled = false;
        }

        private void DgvJRV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnIngresarJRV.Enabled = false;
            BtnActualizarJRV.Enabled = true;
            HabilitarUpdDel();

            //objeto de la clase UsuarioController
            JRVController objselect = new JRVController();
            //Almanecera el numero de la fila que demos click
            int posicion;
            //Esta linea de código srve para capturar el número de la fila sobre la que se hace click
            posicion = DgvJRV.CurrentRow.Index;
            //Asignamos lo que esta en el DataGrid en cada uno de los controles, utilizamos el principio teórico de Arrays dibimensionales donde tenemos [columnas, filas]
            txtIdJRV.Text = DgvJRV[0, posicion].Value.ToString();
            TxtCorrelativo.Text = DgvJRV[1, posicion].Value.ToString();

            //Llenamos el combobox según la sede contenida en el DataGridView
            string CentroVotacion = DgvJRV[2, posicion].Value.ToString();
            CmbCentroV.DataSource = objselect.CargarCVInnerJoin_Controller(CentroVotacion);
            CmbCentroV.DisplayMember = "Nombre_Centro_Votación";
            CmbCentroV.ValueMember = "id_Centro_Votación";

            //Llenamos el combobox según el estado de la mesa contenido en el DataGridView
            string EstadoMesa = DgvJRV[3, posicion].Value.ToString();
            CmbEstadoJRV.DataSource = objselect.CargarEstadoJRVInnerJoin_Controller(EstadoMesa);
            CmbEstadoJRV.DisplayMember = "Nombre_Estado_JRV";
            CmbEstadoJRV.ValueMember = "id_Estado_JRV";
        }

        void ActualizarJRV()
        {
            JRVController updatejrv = new JRVController();
            updatejrv.idjrv = Convert.ToInt16(txtIdJRV.Text);
            updatejrv.correlativo = TxtCorrelativo.Text;
            updatejrv.centrovotacion = Convert.ToInt16(CmbCentroV.SelectedValue);
            updatejrv.estadojrv = Convert.ToInt16(CmbEstadoJRV.SelectedValue);
            if (updatejrv.ActualizarDatosJRV_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjusuarionoactualizado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjusuarionoactualizado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                LimpiarCamposJRV();
                CargarListasJRV();
            }
        }

        void EliminarDatosJRV()
        {
            JRVController deletejrv = new JRVController();
            deletejrv.idjrv = Convert.ToInt16(txtIdJRV.Text);
            int valor = deletejrv.EliminarJRV_controller();

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
                        MessageBox.Show(Idiomas.EnglishMessage.msjregistroeliminado, Idiomas.EnglishMessage.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjregistroeliminado, Idiomas.MensajesEspanol.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case 2:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjregistronoeliminado, Idiomas.EnglishMessage.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjregistronoeliminado, Idiomas.MensajesEspanol.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    break;
            }
        }

        private void BtnIngresarJRV_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCorrelativo.Text))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjcampocorrelativo, Idiomas.EnglishMessage.msjdatosfaltantes, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjcampocorrelativo, Idiomas.MensajesEspanol.msjdatosfaltantes, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnviarDatosJRV();
                CargarListasJRV();
                BtnActualizarJRV.Enabled = false;
                BtnEliminarJRV.Enabled = false;
            }
        }

        private void BtnActualizarJRV_Click(object sender, EventArgs e)
        {
            ActualizarJRV();
            CargarListasJRV();
        }
        
        private void BtnLimpiarJRV_Click(object sender, EventArgs e)
        {
            LimpiarCamposJRV();
        }

        private void BtnRefrescarJRV_Click(object sender, EventArgs e)
        {
            CargarListasJRV();
        }

        private void BtnEliminarJRV_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estás seguro de querer eliminar esta mesa de votación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                EliminarDatosJRV();
                CargarListasJRV();
                LimpiarCamposJRV();
            }
        }

        private void CmbCentroV_Click(object sender, EventArgs e)
        {
            CargarCentroVotacion();
        }

        private void CmbEstadoJRV_Click(object sender, EventArgs e)
        {
            CargarEstadoJRV();
        }

        private void TxtCorrelativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloNumeros(e);
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
        }

        private void DgvJRV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            UiTheme.FormatGridCell(e, DgvJRV);
        }
    }
}
