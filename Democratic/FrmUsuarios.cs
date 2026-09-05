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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            //CmbIntentos.Items.Add("0");
            //CmbIntentos.Items.Add("1");
            //CmbIntentos.Items.Add("2");
            //CmbIntentos.Items.Add("3");

            List<Intentos> intentos = new List<Intentos>();
            intentos.Add(new Intentos() { ID = "0", Numero = "0" });
            intentos.Add(new Intentos() { ID = "1", Numero = "1" });
            intentos.Add(new Intentos() { ID = "2", Numero = "2" });
            intentos.Add(new Intentos() { ID = "3", Numero = "3" });

            CmbIntentos.DataSource = intentos;
            CmbIntentos.ValueMember = "ID";
            CmbIntentos.DisplayMember = "Numero";
        }

        void VerificarMode()
        {
            UiTheme.ApplyCrudPanel(
                PanelUser,
                toolStrip1,
                new Control[]
                {
                    lblUser3, lblEstadoU, lblkey, lblTipoU, lblDui, lblMiembro,
                    lblIntento, lblCV, lblBuscar2, lblMostrar
                },
                BtnAgregarUsuario,
                BtnActualizarU,
                BtnLimpiarU,
                BtnMinimizar,
                BtnEliminarU);
        }

        void VerificarIdioma()
        {
            switch (VarSession.idioma)
            {
                case 1:
                    BtnAgregarUsuario.Text = Idiomas.English.btnagregarusuario;
                    BtnActualizarU.Text = Idiomas.English.btnactualizarusuario;
                    BtnLimpiarU.Text = Idiomas.English.BtnLimpiarPartidos;
                    BtnRefrescarU.Text = Idiomas.English.BtnRefrescarM;
                    BtnEliminarU.Text = Idiomas.English.BtnEliminarActa;
                    lblUser3.Text = Idiomas.English.lbluser2;
                    lblEstadoU.Text = Idiomas.English.lblEstadoU;
                    lblkey.Text = Idiomas.English.lblpass;
                    lblTipoU.Text = Idiomas.English.lbltipouser;
                    lblDui.Text = Idiomas.English.lbldui;
                    lblMiembro.Text = Idiomas.English.lblmiembro;
                    lblIntento.Text = Idiomas.English.lblintentos;
                    lblCV.Text = Idiomas.English.lblcentrov;
                    lblBuscar2.Text = Idiomas.English.lblBuscar2;
                    BtnMinimizar.Text = Idiomas.English.btnminimizar;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        public class Intentos
        {
            public string ID { get; set; }
            public string Numero { get; set; }
        }

        void CargarEstadoU()
        {
            CmbEstadoU.DataSource = UsuariosController.CargarEstadoUsuario_Controller();
            CmbEstadoU.ValueMember = "id_Estado_Usuario";
            CmbEstadoU.DisplayMember = "Estado_Usuario";
        }

        void CargarTipoU()
        {
            CmbTipoU.DataSource = UsuariosController.CargarTipoUser_Controller();
            CmbTipoU.ValueMember = "id_Tipo_Usuario";
            CmbTipoU.DisplayMember = "Tipo_Usuario";
        }

        void CargarCentroVotaciónU()
        {
            CmbCV.DataSource = UsuariosController.CargarCentroVotacion_Controller();
            CmbCV.ValueMember = "id_Centro_Votación";
            CmbCV.DisplayMember = "Nombre_Centro_Votación";
        }

        void CargarMiembroU()
        {
            CmbMiembro.DataSource = UsuariosController.CargarMiembrosU_Controller();
            CmbMiembro.ValueMember = "id_Miembro";
            CmbMiembro.DisplayMember = "Nombre_Miembro";
        }

        void CargarListas()
        {
            try
            {
                CargarEstadoU();
                CargarTipoU();
                CargarCentroVotaciónU();
                CargarMiembroU();

                DgvUsuarios.DataSource = UsuariosController.CargarUsuarios_Controller();
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjerrocag, Idiomas.EnglishMessage.msjE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjerrocag, Idiomas.MensajesEspanol.msjE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void EnvioDatos()
        {
            UsuariosController agregar = new UsuariosController();
            agregar.usuario = TxtUsuario.Text;
            agregar.clave = TxtClave.Text;
            agregar.intento = Convert.ToInt16(CmbIntentos.SelectedValue);
            agregar.Estado_Usuario = Convert.ToInt16(CmbEstadoU.SelectedValue);
            agregar.Tipo_Usuario = Convert.ToInt16(CmbTipoU.SelectedValue);
            agregar.id_Miembro = Convert.ToInt16(CmbMiembro.SelectedValue);
            //agregar.id_JRV = Convert.ToInt16(cmbjr.SelectedValue);
            if (agregar.EnviarDatosUser_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjusunop, Idiomas.EnglishMessage.msjerint, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjusunop, Idiomas.MensajesEspanol.msjerint, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCampos();
                CargarListas();
            }
        }

        void ActualizarDatos()
        {
            UsuariosController objactualizar = new UsuariosController();
            objactualizar.idusuario = Convert.ToInt16(txtId.Text);
            objactualizar.usuario = TxtUsuario.Text;
            objactualizar.clave = TxtClave.Text;
            objactualizar.intento = Convert.ToInt16(CmbIntentos.SelectedValue);
            objactualizar.Estado_Usuario = Convert.ToInt16(CmbEstadoU.SelectedValue);
            objactualizar.Tipo_Usuario = Convert.ToInt16(CmbTipoU.SelectedValue);
            objactualizar.id_Miembro = Convert.ToInt16(CmbMiembro.SelectedValue);
            //objactualizar.Centro_Votación = Convert.ToInt16(CmbCV.SelectedValue);
            if (objactualizar.ActualizarDatos_Controller() == false)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjusunop2, Idiomas.EnglishMessage.msjerint, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjusunop2, Idiomas.MensajesEspanol.msjerint, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                LimpiarCampos();
                CargarListas();
            }
        }

        void LimpiarCampos()
        {
            txtId.Clear();
            TxtUsuario.Clear();
            TxtClave.Clear();
            BtnAgregarUsuario.Enabled = true;
            BtnActualizarU.Enabled = false;
            BtnEliminarU.Enabled = false;
        }

        //Metodo para que al iniciar este desabilitado la opción de Actualizar y Borrar
        void HabilitarUpdDel()
        {
            BtnActualizarU.Enabled = true;
            BtnEliminarU.Enabled = true;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            VerificarMode();
            VerificarIdioma();
            CargarListas();
            BtnActualizarU.Enabled = false;
            BtnEliminarU.Enabled = false;
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BtnAgregarUsuario.Enabled = false;
                HabilitarUpdDel();

                //objeto de la clase UsuarioController
                UsuariosController objselect = new UsuariosController();
                //Almanecera el numero de la fila que demos click
                int posicion;
                //Esta linea de código srve para capturar el número de la fila sobre la que se hace click
                posicion = DgvUsuarios.CurrentRow.Index;
                //Asignamos lo que esta en el DataGrid en cada uno de los controles, utilizamos el principio teórico de Arrays dibimensionales donde tenemos [columnas, filas]
                txtId.Text = DgvUsuarios[0, posicion].Value.ToString();
                TxtUsuario.Text = DgvUsuarios[1, posicion].Value.ToString();
                TxtClave.Text = DgvUsuarios[2, posicion].Value.ToString();

                //Guardar en una variable de tipo entero el contenido en el DataGridView
                int intento = Convert.ToInt16(DgvUsuarios[3, posicion].Value.ToString());

                //Llenamos el combobox según el ID contenido en el DataGridView
                //Guardar en una variable de tipo entero el id contenido en el DataGridView
                string Estado_usuario = DgvUsuarios[4, posicion].Value.ToString();
                //Creamos un nuevo método que permita consultar el estado del usuario según el ID contenido en la celda.
                CmbEstadoU.DataSource = objselect.CargarEstadoUsuarioInnerJoin_Controller(Estado_usuario);
                CmbEstadoU.ValueMember = "id_Estado_Usuario";
                CmbEstadoU.DisplayMember = "Estado_Usuario";

                //Llenamos el combobox según el ID contenido en el DataGridView
                //Guardar en una variable de tipo entero el id contenido en el DataGridView
                string Tipo_usuario = DgvUsuarios[5, posicion].Value.ToString();
                //Creamos un nuevo método que permita consultar el tipo de usuario según el ID contenido en la celda.
                CmbTipoU.DataSource = objselect.CargarTipoUserInnerJoin_Controller(Tipo_usuario);
                CmbTipoU.ValueMember = "id_Tipo_Usuario";
                CmbTipoU.DisplayMember = "Tipo_Usuario";

                //Llenamos el combobox según la sede del usuario
                string SedeVotacion = DgvUsuarios[6, posicion].Value.ToString();
                CmbCV.DataSource = objselect.CargarCentroVotacionInnerJoin_Controller(SedeVotacion);
                CmbCV.ValueMember = "id_Centro_Votación";
                CmbCV.DisplayMember = "Nombre_Centro_Votación";

                //Llenamos el combobox según el participante vinculado al usuario
                string Participante = DgvUsuarios[7, posicion].Value.ToString();
                CmbMiembro.DataSource = objselect.CargarMiembrosInnerJoin_Controller(Participante);
                CmbMiembro.ValueMember = "id_Miembro";
                CmbMiembro.DisplayMember = "Nombre_Miembro";
            }
            catch (Exception)
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjselec, Idiomas.EnglishMessage.msjerselecio, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjselec, Idiomas.MensajesEspanol.msjerselecio, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void EliminarUsuario()
        {
            UsuariosController objdelete = new UsuariosController();
            objdelete.idusuario = Convert.ToInt16(txtId.Text);
            int valor = objdelete.EliminarUsuario_Controller();

            switch (valor)
            {
                case -1:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjocubase, Idiomas.EnglishMessage.msjE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjocubase, Idiomas.MensajesEspanol.msjE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 1:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjeliusu, Idiomas.EnglishMessage.msjproint2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjeliusu, Idiomas.MensajesEspanol.msjproint2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 2:
                    if (VarSession.idioma == 1)
                    {
                        MessageBox.Show(Idiomas.EnglishMessage.msjdepedi, Idiomas.EnglishMessage.msjproint, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Idiomas.MensajesEspanol.msjdepedi, Idiomas.MensajesEspanol.msjproint, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    break;
            }
        }

        void ObtenerDatosM()
        {
            List<string> datos = RegistroController.BuscarDUI_Controller();
            CmbMiembro.Text = datos[1];
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
                    MessageBox.Show(Idiomas.EnglishMessage.msjduiin, Idiomas.EnglishMessage.msjduico, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjduiin, Idiomas.MensajesEspanol.msjduico, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUsuario.Text.Trim()))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjcamusu, Idiomas.EnglishMessage.msjcheyo2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjcamusu, Idiomas.MensajesEspanol.msjcheyo2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (string.IsNullOrWhiteSpace(TxtClave.Text.Trim()))
            {
                if (VarSession.idioma == 1)
                {
                    MessageBox.Show(Idiomas.EnglishMessage.msjcamusu2, Idiomas.EnglishMessage.msjcheyo2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Idiomas.MensajesEspanol.msjcamusu2, Idiomas.MensajesEspanol.msjcheyo2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else{
                EnvioDatos();
                CargarListas();
                BtnActualizarU.Enabled = false;
                BtnEliminarU.Enabled = false;
            }
        }

        private void BtnLimpiarU_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnActualizarU_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void BtnRefrescarU_Click(object sender, EventArgs e)
        {
            CargarListas();
        }

        private void BtnEliminarU_Click(object sender, EventArgs e)
        {
            if (VarSession.idioma == 1)
            {
                DialogResult dr = MessageBox.Show(Idiomas.EnglishMessage.msjextraño + TxtUsuario.Text + " ?", Idiomas.EnglishMessage.msjextraño2, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    EliminarUsuario();
                    CargarListas();
                    LimpiarCampos();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show(Idiomas.MensajesEspanol.msjextraño + TxtUsuario.Text + " ?", Idiomas.MensajesEspanol.msjextraño2, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    EliminarUsuario();
                    CargarListas();
                    LimpiarCampos();
                }
            }

        }

        //---------------------------------------------------------------------------------------------------------------------------------

        private void CheckPass_OnChange(object sender, EventArgs e)
        {

            if (CheckPass.Checked == true)
            {
                if (TxtClave.PasswordChar == '*')
                {
                    TxtClave.PasswordChar = '\0';
                }
            }
            else
            {
                TxtClave.PasswordChar = '*';
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CmbEstadoU_Click(object sender, EventArgs e)
        {
            CargarEstadoU();
        }

        private void CmbTipoU_Click(object sender, EventArgs e)
        {
            CargarTipoU();
        }

        private void CmbMiembro_Click(object sender, EventArgs e)
        {
            CargarMiembroU();
        }

        private void CmbCV_Click(object sender, EventArgs e)
        {
            CargarCentroVotaciónU();
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }

        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTexto.soloNumeros(e);
        }

        private void PbLUPA_Click(object sender, EventArgs e)
        {
            ExistenciaMiembro();
        }

        private void DgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            UiTheme.FormatGridCell(e, DgvUsuarios);
        }
    }
}