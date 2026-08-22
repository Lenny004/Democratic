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
    public partial class FrmDetalleMiembro : Form
    {
        public FrmDetalleMiembro()
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
                    lblDetalleM.ForeColor = Color.White;
                    lblM.ForeColor = Color.White;
                    lblJRV.ForeColor = Color.White;
                    lblBuscarD.ForeColor = Color.White;
                    lblDui.ForeColor = Color.White;
                    BtnMinimizar.ForeColor = Color.White;
                    BtnAgregarDetalleM.BackColor = Celeste;
                    BtnActualizarDetalleM.BackColor = Celeste;
                    BtnLimpiarDetallesM.BackColor = Celeste;
                    BtnEliminarDetalleM.BackColor = Rosa;
                    PanelDM.BackColor = Morado;
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
                    BtnAgregarDetalleM.Text = Idiomas.English.BtnAgregarDetalleM;
                    BtnActualizarDetalleM.Text = Idiomas.English.BtnActualizarDetalleM;
                    BtnLimpiarDetallesM.Text = Idiomas.English.BtnLimpiarPartidos;
                    BtnRefrescarDetalleM.Text = Idiomas.English.BtnRefrescarM;
                    lblDetalleM.Text = Idiomas.English.lblDetalleM;
                    lblM.Text = Idiomas.English.lblM;
                    lblJRV.Text = Idiomas.English.lblJRVdm;
                    lblDui.Text = Idiomas.English.lbldui;
                    lblBuscarD.Text = Idiomas.English.lblBuscarDM;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        void CargarMiembroU()
        {
            CmbMiembros.DataSource = UsuariosController.CargarMiembrosU_Controller();
            CmbMiembros.ValueMember = "id_Miembro";
            CmbMiembros.DisplayMember = "Nombre_Miembro";
        }

        void CargarJRV()
        {
            CmbJRV.DataSource = DetalleMiembrosController.CargarDetalleMiembrosJRV_Controller();
            CmbJRV.ValueMember = "id_JRV";
            CmbJRV.DisplayMember = "Correlativo_JRV";
        }

        void CargarListaDetalleM()
        {
            try
            {
                CargarMiembroU();
                CargarJRV();
                
                DgvDetalleMiembros.DataSource = DetalleMiembrosController.CargarTablaDetallesMiembro_Controller();
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjlistas, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjlistas, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void EnvioDatosDM()
        {
            DetalleMiembrosController agregar = new DetalleMiembrosController();
            agregar.Detalle_de_Miembros = txtDetalle.Text;
            agregar.id_Miembro = Convert.ToInt16(CmbMiembros.SelectedValue);
            agregar.id_JRV = Convert.ToInt16(CmbJRV.SelectedValue);
            if (agregar.EnviarDatosDetalleMiembro_Controller() == false)
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
        }

        void LimpiarCamposDM()
        {
            TxtIdDetalle.Clear();
            txtDetalle.Clear();
            BtnAgregarDetalleM.Enabled = true;
            BtnActualizarDetalleM.Enabled = false;
            BtnEliminarDetalleM.Enabled = false;
        }

        void HabilitarUpdDel()
        {
            BtnActualizarDetalleM.Enabled = true;
            BtnEliminarDetalleM.Enabled = true;
        }

        void ActualizarDatosDM()
        {
            DetalleMiembrosController objactualizar = new DetalleMiembrosController();
            objactualizar.id_Detalle = Convert.ToInt16(TxtIdDetalle.Text);
            objactualizar.Detalle_de_Miembros = txtDetalle.Text;
            objactualizar.id_Miembro = Convert.ToInt16(CmbMiembros.SelectedValue);
            objactualizar.id_JRV = Convert.ToInt16(CmbJRV.SelectedValue);
            if (objactualizar.ActualizarDetalleMiembros_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjdetallenoupdated, Idiomas.EnglishMessage.msjnoactualizadotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjdetallenoupdated, Idiomas.MensajesEspanol.msjnoactualizadotitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCamposDM();
            }
        }

        void EliminarDatos()
        {
            DetalleMiembrosController objdel = new DetalleMiembrosController();
            objdel.id_Detalle = Convert.ToInt16(TxtIdDetalle.Text);
            int valor = objdel.EliminarDetalleMiembro_Controller();
            switch (valor)
            {
                case -1:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjDatabaseP, Idiomas.EnglishMessage.msjDatabasePTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjDatabaseP, Idiomas.MensajesEspanol.msjDatabasePTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 1:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjdetallemeliminado, Idiomas.EnglishMessage.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjdetallemeliminado, Idiomas.MensajesEspanol.msjDeteledPTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 2:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjdetallemnoeliminado, Idiomas.EnglishMessage.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjdetallemnoeliminado, Idiomas.MensajesEspanol.msjEmployedPTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                default:
                    break;
            }
        }

        void ObtenerDatosM()
        {
            List<string> datos = RegistroController.BuscarDUI_Controller();
            CmbMiembros.Text = datos[1];
        }

        void ExistenciaMiembro()
        {
            AtributosRegister.DUI = MSKdui.Text;
            bool existe = RegistroController.Existencia_Controller();
            if (existe == true)
            {
                ObtenerDatosM();
            }
            else
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjduipuser, Idiomas.EnglishMessage.msjduipusertitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjduipuser, Idiomas.MensajesEspanol.msjduipusertitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FrmDetalleMiembro_Load(object sender, EventArgs e)
        {
            VerificarMode();
            VerificarIdioma();
            CargarListaDetalleM();
            BtnActualizarDetalleM.Enabled = false;
            BtnEliminarDetalleM.Enabled = false;
        }

        private void DgvDetalleMiembros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnAgregarDetalleM.Enabled = false;
            HabilitarUpdDel();

            DetalleMiembrosController objselect = new DetalleMiembrosController();
            int posicion;
            posicion = DgvDetalleMiembros.CurrentRow.Index;

            TxtIdDetalle.Text = DgvDetalleMiembros[0, posicion].Value.ToString();
            txtDetalle.Text = DgvDetalleMiembros[1, posicion].Value.ToString();

            string Participante = DgvDetalleMiembros[2, posicion].Value.ToString();
            //Consulta el participante según el ID contenido en la celda.
            CmbMiembros.DataSource = objselect.CargarDetalleMiembroMiembroInnerJoin_Controller(Participante);
            CmbMiembros.ValueMember = "id_Miembro";
            CmbMiembros.DisplayMember = "Estado_Usuario";

            string Mesa = DgvDetalleMiembros[3, posicion].Value.ToString();
            CmbJRV.DataSource = objselect.CargarDetalleMiembroJRVInnerJoin_Controller(Mesa);
            CmbJRV.ValueMember = "id_JRV";
            CmbJRV.DisplayMember = "Correlativo_JRV";
        }

        private void BtnAgregarDetalleM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDetalle.Text.Trim()))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjdetallemdatosfaltan, Idiomas.EnglishMessage.msjfaltadataputitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjdetallemdatosfaltan, Idiomas.MensajesEspanol.msjfaltadataputitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnvioDatosDM();
                BtnActualizarDetalleM.Enabled = false;
                BtnEliminarDetalleM.Enabled = false;
                LimpiarCamposDM();
            }
        }

        private void BtnActualizarDetalleM_Click(object sender, EventArgs e)
        {
            ActualizarDatosDM();
            CargarListaDetalleM();
        }

        private void BtnLimpiarDetallesM_Click(object sender, EventArgs e)
        {
            LimpiarCamposDM();
        }

        private void BtnRefrescarDetalleM_Click(object sender, EventArgs e)
        {
            CargarListaDetalleM();
        }

        private void BtnEliminarDetalleM_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estás seguro de querer eliminar a: " + txtDetalle.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                EliminarDatos();
                CargarListaDetalleM();
                LimpiarCamposDM();
            }
        }

        private void CmbMiembros_Click(object sender, EventArgs e)
        {
            CargarMiembroU();
        }

        private void CmbJRV_Click(object sender, EventArgs e)
        {
            CargarJRV();
        }

        private void txtDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloLetras(e);
        }

        private void PbLUPA_Click(object sender, EventArgs e)
        {
            ExistenciaMiembro();
        }

        private void DgvDetalleMiembros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (VarSession.Color)
            {
                case 1:
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Oscuro;
                    e.CellStyle.SelectionBackColor = Color.Cyan;
                    e.CellStyle.SelectionForeColor = Color.Black;
                    DgvDetalleMiembros.BackgroundColor = Medio;
                    DgvDetalleMiembros.HeaderBgColor = Rosa;
                    DgvDetalleMiembros.HeaderForeColor = Color.White;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
