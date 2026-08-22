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

namespace Democratic
{
    public partial class FrmCV : Form
    {
        public FrmCV()
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
                    PanelCV.BackColor = Morado;
                    toolStrip1.BackColor = Morado;
                    lblCV.ForeColor = Color.White;
                    lblCantidadJRV.ForeColor = Color.White;
                    lblMunicipio.ForeColor = Color.White;
                    lblestado.ForeColor = Color.White;
                    lblCantidadBoleta.ForeColor = Color.White;
                    lblTribunal.ForeColor = Color.White;
                    lblBuscar.ForeColor = Color.White;
                    BtnMinimizar.ForeColor = Color.White;
                    BtnIngresarCV.BackColor = Celeste;
                    BtnActualizarCV.BackColor = Celeste;
                    BtnLimpiarCV.BackColor = Celeste;
                    BtnEliminarCV.BackColor = Rosa;
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
                    BtnIngresarCV.Text = Idiomas.English.BtnIngresarCV;
                    BtnActualizarCV.Text = Idiomas.English.BtnActualizarCV;
                    BtnLimpiarCV.Text = Idiomas.English.BtnLimpiarPartidos;
                    BtnRefrescarCV.Text = Idiomas.English.BtnRefrescarM;
                    BtnEliminarCV.Text = Idiomas.English.BtnEliminarCV;
                    lblCV.Text = Idiomas.English.lblCV;
                    lblCantidadJRV.Text = Idiomas.English.lblCantidadJRV;
                    lblMunicipio.Text = Idiomas.English.lblMunicipio;
                    lblestado.Text = Idiomas.English.lblestado;
                    lblCantidadBoleta.Text = Idiomas.English.lblCantidadBoleta;
                    lblTribunal.Text = Idiomas.English.lblTribunal;
                    lblBuscar.Text = Idiomas.English.lblBuscarCV;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void CargarEstadoCentro()
        {
            CmbEstadoCV.DataSource = CentroVotacionController.CargarEstadoCV_Controller();
            CmbEstadoCV.DisplayMember = "Nombre_Estado_CentroVotación";
            CmbEstadoCV.ValueMember = "id_Estado_CentroVotación";
        }
        void CargarMunicipio()
        {
            CmbMunicipio.DataSource = CentroVotacionController.CargarMunicipio_Controller();
            CmbMunicipio.DisplayMember = "Nombre_Municipio";
            CmbMunicipio.ValueMember = "id_Municipio";
        }

        void CargarActas()
        {
            CmbActa.DataSource = CentroVotacionController.CargarActas_Controller();
            CmbActa.DisplayMember = "Cantidad_Boletas";
            CmbActa.ValueMember = "id_Acta";
        }

        void CargarTribunal()
        {
            CmbTribunal.DataSource = CentroVotacionController.CargarTribunal_Controller();
            CmbTribunal.DisplayMember = "Tipo";
            CmbTribunal.ValueMember = "id_Tribunal";
        }

        void CargarListasCV()
        {
            try
            {
                CargarEstadoCentro();
                CargarMunicipio();
                CargarActas();
                CargarTribunal();

                DgvCV.DataSource = CentroVotacionController.CargarCV_Controller();
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjlistasnocargadas, Idiomas.EnglishMessage.msjadminpu, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjlistasnocargadas, Idiomas.MensajesEspanol.msjadminpu, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Metodo para que al iniciar este desabilitado la opción de Actualizar y Borrar
        void HabilitarUpdDel()
        {
            BtnActualizarCV.Enabled = true;
            BtnEliminarCV.Enabled = true;
        }

        void EnvioDatosCV()
        {
            CentroVotacionController agregar = new CentroVotacionController();
            agregar.NombreCentroVotacion = txtNombreCV.Text;
            agregar.Acta = Convert.ToInt16(CmbActa.SelectedValue);
            agregar.CantidadJRV = Convert.ToInt16(TxtCantidadJRV.Text);
            agregar.EstadoCentroVotacion = Convert.ToInt16(CmbEstadoCV.SelectedValue);
            agregar.Municipio = Convert.ToInt16(CmbMunicipio.SelectedValue);
            agregar.Tribunal = Convert.ToInt16(CmbTribunal.SelectedValue);
            if (agregar.EnviarDatosCV_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjcvnoregistrado, Idiomas.EnglishMessage.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjcvnoregistrado, Idiomas.MensajesEspanol.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCamposVC();
            }
        }

        void ActualizarCV()
        {
            CentroVotacionController updatecv = new CentroVotacionController();
            updatecv.idCentro_Votacion = Convert.ToInt16(txtIdCV.Text);
            updatecv.NombreCentroVotacion = txtNombreCV.Text;
            updatecv.Acta = Convert.ToInt16(CmbActa.SelectedValue);
            updatecv.CantidadJRV = Convert.ToInt16(TxtCantidadJRV.Text);
            updatecv.EstadoCentroVotacion = Convert.ToInt16(CmbEstadoCV.SelectedValue);
            updatecv.Municipio = Convert.ToInt16(CmbMunicipio.SelectedValue);
            updatecv.Tribunal = Convert.ToInt16(CmbTribunal.SelectedValue);
            if (updatecv.ActualizarDatosCV_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjcvnoactualizado, Idiomas.EnglishMessage.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjcvnoactualizado, Idiomas.MensajesEspanol.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCamposVC();
            }
        }

        void LimpiarCamposVC()
        {
            txtNombreCV.Clear();
            TxtCantidadJRV.Clear();
            txtIdCV.Clear();
            CargarEstadoCentro();
            CargarMunicipio();
            CargarActas();
            BtnIngresarCV.Enabled = true;
            BtnActualizarCV.Enabled = false;
            BtnEliminarCV.Enabled = false;
        }

        private void FrmCV_Load(object sender, EventArgs e)
        {
            VerificarMode();
            VerificarIdioma();
            CargarListasCV();
            BtnActualizarCV.Enabled = false;
            BtnEliminarCV.Enabled = false;
        }

        private void DgvCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnIngresarCV.Enabled = false;
            HabilitarUpdDel();

            CentroVotacionController objselect = new CentroVotacionController();
            int posicion;
            posicion = DgvCV.CurrentRow.Index;

            txtIdCV.Text = DgvCV[0, posicion].Value.ToString();
            txtNombreCV.Text = DgvCV[1, posicion].Value.ToString();

            string Acta = DgvCV[2, posicion].Value.ToString();
            CmbActa.DataSource = objselect.CargarActaInnerJoin_Controller(Acta);
            CmbActa.DisplayMember = "Cantidad_Boletas";
            CmbActa.ValueMember = "id_Acta";

            TxtCantidadJRV.Text = DgvCV[3, posicion].Value.ToString();

            string EstadoCentroVotacion = DgvCV[4, posicion].Value.ToString();
            CmbEstadoCV.DataSource = objselect.CargarEstadoCVInnerJoin_Controller(EstadoCentroVotacion);
            CmbEstadoCV.DisplayMember = "Nombre_Estado_CentroVotación";
            CmbEstadoCV.ValueMember = "id_Estado_CentroVotación";

            string Municipio = DgvCV[5, posicion].Value.ToString();
            CmbMunicipio.DataSource = objselect.CargarMunicipioInnerJoin_Controller(Municipio);
            CmbMunicipio.DisplayMember = "Nombre_Municipio";
            CmbMunicipio.ValueMember = "id_Municipio";

            string Tribunal = DgvCV[6, posicion].Value.ToString();
            CmbTribunal.DataSource = objselect.CargarTribunalInnerJoin_Controller(Tribunal);
            CmbTribunal.DisplayMember = "Tipo";
            CmbTribunal.ValueMember = "id_Tribunal";
        }

        void Eliminarcv()
        {
            CentroVotacionController deletecv = new CentroVotacionController();
            deletecv.idCentro_Votacion = Convert.ToInt16(txtIdCV.Text);
            int valor = deletecv.EliminarCV_controller();

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
                        MessageBox.Show(Idiomas.EnglishMessage.msjcveliminado, Idiomas.EnglishMessage.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjcveliminado, Idiomas.MensajesEspanol.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case 2:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjcvnoeliminado, Idiomas.EnglishMessage.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjcvnoeliminado, Idiomas.MensajesEspanol.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    break;
            }
        }

        private void BtnIngresarCV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCV.Text)||
                string.IsNullOrWhiteSpace(TxtCantidadJRV.Text))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjcvnecesario, Idiomas.EnglishMessage.msjcvdatosfaltan, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjcvnecesario, Idiomas.MensajesEspanol.msjcvdatosfaltan, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnvioDatosCV();
            }
        }

        private void BtnLimpiarCV_Click(object sender, EventArgs e)
        {
            LimpiarCamposVC();
        }

        private void BtnActualizarCV_Click(object sender, EventArgs e)
        {
            ActualizarCV();
            CargarListasCV();
        }

        private void BtnRefrescarCV_Click(object sender, EventArgs e)
        {
            CargarListasCV();
        }

        private void BtnEliminarCV_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estás seguro de querer eliminar la sede de votación: " + txtNombreCV.Text + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Eliminarcv();
                CargarListasCV();
                LimpiarCamposVC();
            }
        }

        private void CmbMunicipio_Click(object sender, EventArgs e)
        {
            CargarMunicipio();
        }

        private void CmbEstadoCV_Click(object sender, EventArgs e)
        {
            CargarEstadoCentro();
        }

        private void CmbActa_Click(object sender, EventArgs e)
        {
            CargarActas();
        }

        private void CmbTribunal_Click(object sender, EventArgs e)
        {
            CargarTribunal();
        }

        private void txtNombreCV_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloLetras(e);
        }

        private void TxtCantidadJRV_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloNumeros(e);
        }

        private void DgvCV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (VarSession.Color)
            {
                case 1:
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Oscuro;
                    e.CellStyle.SelectionBackColor = Color.Cyan;
                    e.CellStyle.SelectionForeColor = Color.Black;
                    DgvCV.BackgroundColor = Medio;
                    DgvCV.HeaderBgColor = Rosa;
                    DgvCV.HeaderForeColor = Color.White;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
