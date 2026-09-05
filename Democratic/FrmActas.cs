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
    public partial class FrmActas : Form
    {
        public FrmActas()
        {
            InitializeComponent();
        }
        void VerificarMode()
        {
            UiTheme.ApplyCrudPanel(
                PanelActas,
                toolStrip1,
                new Control[] { lblCBoletas, lblJRV, lblidjrv, lblBuscar },
                BtnAgregarActa,
                BtnActualizarActa,
                BtnLimpiarActa,
                BtnMinimizar,
                BtnEliminarActa);
        }

        void VerificarIdioma()
        {
            switch (VarSession.idioma)
            {
                case 1:
                    BtnAgregarActa.Text = Idiomas.English.BtnAgregarActa;
                    BtnActualizarActa.Text = Idiomas.English.BtnActualizarActa;
                    BtnLimpiarActa.Text = Idiomas.English.BtnLimpiarActa;
                    BtnRefrescarActas.Text = Idiomas.English.BtnRefrescarM;
                    BtnEliminarActa.Text = Idiomas.English.BtnEliminarActa;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    lblCBoletas.Text = Idiomas.English.lblCBoletas;
                    lblJRV.Text = Idiomas.English.lblJRV;
                    lblidjrv.Text = Idiomas.English.lblidjrv;
                    lblBuscar.Text = Idiomas.English.lblBuscar;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void CargarJRV()
        {
            CmbJRV.DataSource = ActasController.CargarJRV_Controller();
            CmbJRV.ValueMember = "id_JRV";
            CmbJRV.DisplayMember = "Correlativo_JRV";
        }

         void ObtenerDatosJRV()
        {
            try
            {
                List<string> datos = ActasController.BuscarJRV_Controller();
                CmbJRV.Text = datos[0];
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    FrmNoti.Noti(Idiomas.EnglishMessage.msjocubase, Idiomas.EnglishMessage.msjerrorconexion);
                }
                else
                {
                    FrmNoti.Noti(Idiomas.MensajesEspanol.msjocubase, Idiomas.MensajesEspanol.msjerrorconexion);
                }
            }
        }

        void ExistenciaJRV()
        {
            AtributosActa.CorrelativoJrv = txtJRV.Text;
            bool existe = ActasController.ExistenciaJRV_Controller();
            if (existe == true)
            {
                ObtenerDatosJRV();
            }
            else
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjJRVincorrecto, Idiomas.EnglishMessage.msjJRVincorrectoTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjJRVincorrecto, Idiomas.MensajesEspanol.msjJRVincorrectoTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void CargarLista()
        {
            try
            {
                CargarJRV();

                DgvActas.DataSource = ActasController.CargarActas_Controller();
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjJRVfailed, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjJRVfailed, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Metodo para que al iniciar este desabilitado la opción de Actualizar y Borrar
        void HabilitarUpdDel()
        {
            BtnActualizarActa.Enabled = true;
            BtnEliminarActa.Enabled = true;
        }

        void actualizarDatos()
        {
            ActasController objactualizar = new ActasController();
            objactualizar.id_Acta = Convert.ToInt16(TxtIdActa.Text);
            objactualizar.Cantidad_Boletas = txtCantidadBoletas.Text;
            objactualizar.JRV = Convert.ToInt16(CmbJRV.SelectedValue);
            if (objactualizar.ActualizarDatos_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjactanoupdate, Idiomas.EnglishMessage.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjactanoupdate, Idiomas.MensajesEspanol.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCampos();
            }
        }

        void LimpiarCampos()
        {
            TxtIdActa.Clear();
            txtCantidadBoletas.Clear();
            BtnAgregarActa.Enabled = true;
            BtnActualizarActa.Enabled = false;
            BtnEliminarActa.Enabled = false;
        }

        void EnvioDatosActa()
        {
            ActasController agregar = new ActasController();
            agregar.Cantidad_Boletas = txtCantidadBoletas.Text;
            agregar.JRV = Convert.ToInt16(CmbJRV.SelectedValue);
            if (agregar.EnviarDatosActas_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjactanoingresada, Idiomas.EnglishMessage.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjactanoingresada, Idiomas.MensajesEspanol.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void DgvActas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnAgregarActa.Enabled = false;
            HabilitarUpdDel();

            //objeto de la clase ActasController (registros de escrutinio)
            ActasController objselect = new ActasController();
            //Almanecera el numero de la fila que demos click
            int posicion;
            //Esta linea de código sirve para capturar el número de la fila sobre la que se hace click
            posicion = DgvActas.CurrentRow.Index;
            //Asignamos lo que esta en el DataGrid en cada uno de los controles, utilizamos el principio teórico de Arrays dibimensionales donde tenemos [columnas, filas]
            TxtIdActa.Text = DgvActas[0, posicion].Value.ToString();
            txtCantidadBoletas.Text = DgvActas[1, posicion].Value.ToString();

            string mesa = DgvActas[2, posicion].Value.ToString();
            CmbJRV.DataSource = objselect.CargarJRVInnerJoin_Controller(mesa);
            CmbJRV.ValueMember = "id_JRV";
            CmbJRV.DisplayMember = "Correlativo_JRV";
        }

        void EliminarActa()
        {
            ActasController objdel = new ActasController();
            objdel.id_Acta = Convert.ToInt16(TxtIdActa.Text);
            int valor = objdel.EliminarActa_Controller();
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
                        MessageBox.Show(Idiomas.EnglishMessage.msjactaeliminada, Idiomas.EnglishMessage.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjactaeliminada, Idiomas.MensajesEspanol.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 2:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjactanoeliminada, Idiomas.EnglishMessage.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjactanoeliminada, Idiomas.MensajesEspanol.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                default:
                    break;
            }
        }

        private void FrmActas_Load(object sender, EventArgs e)
        {
            VerificarMode();
            VerificarIdioma();
            CargarLista();
            BtnActualizarActa.Enabled = false;
            BtnEliminarActa.Enabled = false;
        }

        private void BtnAgregarActa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCantidadBoletas.Text))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjdatosfaltantes, Idiomas.EnglishMessage.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjdatosfaltantes, Idiomas.MensajesEspanol.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnvioDatosActa();
                CargarLista();
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnLimpiarActa_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CmbJRV_Click(object sender, EventArgs e)
        {
            CargarJRV();
        }

        private void BtnActualizarActa_Click(object sender, EventArgs e)
        {
            actualizarDatos();
            CargarLista();
        }

        private void BtnRefrescarActas_Click(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void BtnEliminarActa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(Idiomas.MensajesEspanol.msjconfirmeliminaracta, Idiomas.MensajesEspanol.msjConfirmationPTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                EliminarActa();
                CargarLista();
                LimpiarCampos();
            }
        }

        private void txtCantidadBoletas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloNumeros(e);
        }

        private void Pblupa_Click(object sender, EventArgs e)
        {
            ExistenciaJRV();
        }

        private void DgvActas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            UiTheme.FormatGridCell(e, DgvActas);
        }
    }
}
