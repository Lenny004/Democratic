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
    public partial class FrmMiembros : Form
    {
        public FrmMiembros()
        {
            InitializeComponent();
        }

        void CargarEstadoMiembro()
        {
            CmbEstadoM.DataSource = MiembrosController.CargarEstadoMiembro_Controller();
            CmbEstadoM.ValueMember = "id_Estado_Miembros";
            CmbEstadoM.DisplayMember = "Nombre_Estado_Miembros";
        }

        void CargarLista()
        {
            try
            {
                CargarEstadoMiembro();

                DgvMiembros.DataSource = MiembrosController.CargarMiembros_Controller();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la lista de estado de miembros, consulte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void EnvioDatosM()
        {
            MiembrosController agregar = new MiembrosController();
            agregar.nombre = TxtNombreM.Text;
            agregar.apellido = TxtApellidoM.Text;
            agregar.dui = MskDui.Text;
            agregar.Fecha_de_nacimiento = DateTPFNM.Text;
            agregar.dirección = TxtDireccionM.Text;
            agregar.correo = TxtCorreoM.Text;
            agregar.telefono = MskTelefonoM.Text;
            agregar.estadomiembro = Convert.ToInt16(CmbEstadoM.SelectedValue);
            if(agregar.EnviarDatosMiembro_Controller() == false)
            {
                MessageBox.Show("Miembro no pudo ser ingresado", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            objactualizar.Fecha_de_nacimiento = DateTPFNM.Text;
            objactualizar.dirección = TxtDireccionM.Text;
            objactualizar.correo = TxtCorreoM.Text;
            objactualizar.telefono = MskTelefonoM.Text;
            objactualizar.estadomiembro = Convert.ToInt16(CmbEstadoM.SelectedValue);
            if (objactualizar.ActualizarDatosM_Controller() == false)
            {
                MessageBox.Show("Usuario no pudo ser actualizado", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            //objeto de la clase MiembrosController
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
            DateTPFNM.Text = DgvMiembros[4, posicion].Value.ToString();
            TxtDireccionM.Text = DgvMiembros[5, posicion].Value.ToString();
            TxtCorreoM.Text = DgvMiembros[6, posicion].Value.ToString();
            MskTelefonoM.Text = DgvMiembros[7, posicion].Value.ToString();

            //Llenamos el combobox según el ID contenido en el DataGridView
            //Guardar en una variable de tipo entero el id contenido en el DataGridView
            string Estadomiembros = DgvMiembros[8, posicion].Value.ToString();
            //Creamos un nuevo método que permita consultar el estado del miembro según el ID contenido en la celda.
            CmbEstadoM.DataSource = objselect.CargarEstadoMiembroInnerJoin_Controller(Estadomiembros);
            CmbEstadoM.DisplayMember = "Nombre_Estado_Miembros";
            CmbEstadoM.ValueMember = "id_Estado_Miembros";
        }

        void LimpiarCampos()
        {
            TxtNombreM.Clear();
            TxtApellidoM.Clear();
            MskDui.Clear();
            TxtDireccionM.Clear();
            TxtCorreoM.Clear();
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
            BtnActualizarM.Enabled = false;
            CargarLista();
        }

        private void BtnAgregarM_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(2003, 01, 01);
            DateTime date2 = new DateTime(1900, 01, 01);
            if (DateTPFNM.Value >= date1)
            {
                MessageBox.Show("Lo sentimos, el miembro que desea ingresar es menor de edad", "Fechas incongruentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DateTPFNM.Value <= date2)
            {
                MessageBox.Show("Lo sentimos, Es posible que el miembro haya fallecido", "Fechas incongruentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(TxtNombreM.Text) ||
                    string.IsNullOrWhiteSpace(TxtApellidoM.Text) ||
                    string.IsNullOrWhiteSpace(MskDui.Text) ||
                    string.IsNullOrWhiteSpace(TxtDireccionM.Text) ||
                    string.IsNullOrWhiteSpace(MskTelefonoM.Text))
            {
                MessageBox.Show("Datos faltantes de la consulta", "Campos vacios.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
