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
                MessageBox.Show("Error al cargar al menos una de las cuatro listas, consulte con su administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            agregar.Centro_Votación = Convert.ToInt16(CmbCV.SelectedValue);
            if (agregar.EnviarDatosUser_Controller() == false)
            {
                MessageBox.Show("Usuario no pudo ser ingresado", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            objactualizar.Centro_Votación = Convert.ToInt16(CmbCV.SelectedValue);
            if (objactualizar.ActualizarDatos_Controller() == false)
            {
                MessageBox.Show("Usuario no pudo ser actualizado", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            CargarListas();
            BtnActualizarU.Enabled = false;
            BtnEliminarU.Enabled = false;
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
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
            CmbTipoU.DisplayMember = "Estado_Usuario";

            //Llenamos el combobox según el ID contenido en el DataGridView
            //Guardar en una variable de tipo entero el id contenido en el DataGridView
            string Centro_Votación = DgvUsuarios[6, posicion].Value.ToString();
            //Creamos un nuevo método que permita consultar el Centro de Votación del usuario según el ID contenido en la celda.
            CmbCV.DataSource = objselect.CargarCentroVotacionInnerJoin_Controller(Centro_Votación);
            CmbCV.ValueMember = "id_Centro_Votación";
            CmbCV.DisplayMember = "Estado_Usuario";

            //Llenamos el combobox según el ID contenido en el DataGridView
            //Guardar en una variable de tipo entero el id contenido en el DataGridView
            string Miembro = DgvUsuarios[7, posicion].Value.ToString();
            //Creamos un nuevo método que permita consultar el Miembro del usuario según el ID contenido en la celda.
            CmbMiembro.DataSource = objselect.CargarMiembrosInnerJoin_Controller(Miembro);
            CmbMiembro.ValueMember = "id_Miembro";
            CmbMiembro.DisplayMember = "Estado_Usuario";
        }

        void EliminarUsuario()
        {
            UsuariosController objdelete = new UsuariosController();
            objdelete.idusuario = Convert.ToInt16(txtId.Text);
            int valor = objdelete.EliminarUsuario_Controller();

            switch (valor)
            {
                case -1:
                    MessageBox.Show("Ocurrió un error al establecer conexión con la base de datos, verifique su acceso a internet o que los servicios del servidor estén activos.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    MessageBox.Show("Usuario eliminado", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Usuario no pudo ser eleiminado debido a que existen datos dependientes.", "Proceso Interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUsuario.Text))
            {
                MessageBox.Show("Campo de usuario necesario", "Datos faltantes del usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(string.IsNullOrWhiteSpace(TxtClave.Text)){
                MessageBox.Show("Campo de clave necesario", "Datos faltantes del usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            DialogResult dr = MessageBox.Show("¿Estas seguro de querer eliminar a: " + TxtUsuario.Text + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                EliminarUsuario();
                CargarListas();
                LimpiarCampos();
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
    }
}