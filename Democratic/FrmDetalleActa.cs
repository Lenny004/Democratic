using System;
using System.Windows.Forms;
using Controlador;
using System.Drawing;

namespace Democratic
{
    public partial class FrmDetalleActa : Form
    {
        public FrmDetalleActa()
        {
            InitializeComponent();
        }
        void VerificarMode()
        {
            UiTheme.ApplyCrudPanel(
                PanelDA,
                toolStrip1,
                new Control[] { lblActa, lblCantidadV, lblBuscarDa, lblPartido },
                BtnAgregarDetalleA,
                BtnActualizarDetalleA,
                BtnLimpiarDetallesA,
                BtnMinimizar,
                BtnEliminarDetalleA);
        }

        void VerificarIdioma()
        {
            switch (VarSession.idioma)
            {
                case 1:
                    BtnAgregarDetalleA.Text = Idiomas.English.BtnAgregarDetalleA;
                    BtnActualizarDetalleA.Text = Idiomas.English.BtnActualizarDetalleA;
                    BtnLimpiarDetallesA.Text = Idiomas.English.BtnLimpiarPartidos;
                    BtnRefrescarDetalleA.Text = Idiomas.English.BtnRefrescarM;
                    BtnEliminarDetalleA.Text = Idiomas.English.BtnEliminarDetalleA;
                    lblActa.Text = Idiomas.English.lblcantidad;
                    lblCantidadV.Text = Idiomas.English.lblCantidadV;
                    lblBuscarDa.Text = Idiomas.English.lblBuscarDa;
                    lblPartido.Text = Idiomas.English.lblPartido;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void CargarActa()
        {
            CmbActa.DataSource = DetalleActaController.CargarActaController();
            CmbActa.DisplayMember = "Cantidad_Boletas";
            CmbActa.ValueMember = "id_Acta";
        }

        void CargarPartido()
        {
            CmbPartido.DataSource = DetalleActaController.CargarPartidoController();
            CmbPartido.DisplayMember = "Nombre_Partido";
            CmbPartido.ValueMember = "id_Partido";
        }

        void CargarListasDetalleActa()
        {
            try
            {
                CargarActa();
                CargarPartido();

                DgvDetalleActa.DataSource = DetalleActaController.CargarDetalleActaController();
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

        void LimpiarCampos()
        {
            TxtIdDetalleA.Clear();
            txtCantidadV.Clear();
            BtnAgregarDetalleA.Enabled = true;
            BtnActualizarDetalleA.Enabled = false;
            BtnEliminarDetalleA.Enabled = false;
        }

        //Metodo para que al iniciar este desabilitado la opción de Actualizar y Borrar
        void HabilitarUpdDel()
        {
            BtnActualizarDetalleA.Enabled = true;
            BtnEliminarDetalleA.Enabled = true;
        }

        void EnviarDatosDetalleA()
        {
            DetalleActaController agregar = new DetalleActaController();
            agregar.cantidadvotos = Convert.ToInt16(txtCantidadV.Text);
            agregar.acta = Convert.ToInt16(CmbActa.SelectedValue);
            agregar.partido = Convert.ToInt16(CmbPartido.SelectedValue);
            if (agregar.EnviarDatosDA_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjdetalleactanoingresada, Idiomas.EnglishMessage.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjdetalleactanoingresada, Idiomas.MensajesEspanol.msjinserterror, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCampos();
            }
        }

        void ActualizarDetalleActa()
        {
            DetalleActaController actualizar = new DetalleActaController();
            actualizar.idDetalleacta = Convert.ToInt16(TxtIdDetalleA.Text);
            actualizar.cantidadvotos = Convert.ToInt16(txtCantidadV.Text);
            actualizar.acta = Convert.ToInt16(CmbActa.SelectedValue);
            actualizar.partido = Convert.ToInt16(CmbPartido.SelectedValue);
            if (actualizar.ActualizarDatosController() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjdetallenoupdated, Idiomas.EnglishMessage.msjadvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjdetallenoupdated, Idiomas.MensajesEspanol.msjadvertencia, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCampos();
            }
        }

        void EliminarDetalleacta()
        {
            DetalleActaController eliminar = new DetalleActaController();
            eliminar.idDetalleacta = Convert.ToInt16(TxtIdDetalleA.Text);
            int valor = eliminar.EliminarInquilino_Controller();

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
                        MessageBox.Show(Idiomas.EnglishMessage.msjregistronoeliminado, Idiomas.EnglishMessage.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjregistronoeliminado, Idiomas.MensajesEspanol.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                default:
                    break;
            }
        }

        private void FrmDetalleActa_Load(object sender, EventArgs e)
        {
            VerificarMode();
            VerificarIdioma();
            CargarListasDetalleActa();
        }

        private void BtnAgregarDetalleA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCantidadV.Text.Trim()))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjdetalleactanodatos, Idiomas.EnglishMessage.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjdetalleactanodatos, Idiomas.MensajesEspanol.msjvaciotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnviarDatosDetalleA();
            }
        }

        private void CmbActa_Click(object sender, EventArgs e)
        {
            CargarActa();
        }

        private void CmbPartido_Click(object sender, EventArgs e)
        {
            CargarPartido();
        }

        private void BtnActualizarDetalleA_Click(object sender, EventArgs e)
        {
            ActualizarDetalleActa();
            CargarListasDetalleActa();
        }

        private void BtnLimpiarDetallesA_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnRefrescarDetalleA_Click(object sender, EventArgs e)
        {
            CargarListasDetalleActa();
        }

        private void BtnEliminarDetalleA_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estás seguro de eliminar este detalle?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                EliminarDetalleacta();
                CargarListasDetalleActa();
            }
        }

        private void DgvDetalleActa_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BtnAgregarDetalleA.Enabled = false;
            HabilitarUpdDel();

            DetalleActaController objselect = new DetalleActaController();
            int posicion;
            posicion = DgvDetalleActa.CurrentRow.Index;

            TxtIdDetalleA.Text = DgvDetalleActa[0, posicion].Value.ToString();
            txtCantidadV.Text = DgvDetalleActa[1, posicion].Value.ToString();

            string acta = DgvDetalleActa[2, posicion].Value.ToString();
            CmbActa.DataSource = objselect.CargarActaInnerJoin_Controller(acta);
            CmbActa.DisplayMember = "Cantidad_Boletas";
            CmbActa.ValueMember = "id_Acta";

            string partido = DgvDetalleActa[3, posicion].Value.ToString();
            CmbPartido.DataSource = objselect.CargarPartidoInnerJoin_Controller(partido);
            CmbPartido.DisplayMember = "Nombre_Partido";
            CmbPartido.ValueMember = "id_Partido";
        }

        private void txtCantidadV_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloNumeros(e);
        }

        private void DgvDetalleActa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            UiTheme.FormatGridCell(e, DgvDetalleActa);
        }
    }
}
