using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Para Cargar imagen(permiten leer y escribir en archivos y flujos de datos)
using System.Drawing.Imaging;//Para Cargar imagen
using System.Windows.Forms;
using Controlador;

namespace Democratic
{
    public partial class FrmPartidos : Form
    {
        public FrmPartidos()
        {
            InitializeComponent();
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
                MessageBox.Show("Error al cargar la lista del Estado del Partido, consulte con su administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void EnvioDatosP()
        {
            MemoryStream ms = new MemoryStream();
            PbPartido.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            PartidoController agregar = new PartidoController();
            agregar.image = ms.GetBuffer();
            agregar.nombrep = TxtNombreP.Text;
            agregar.Cantidadvotosp = Convert.ToInt16(TxtCantidadVotosP.Text);
            agregar.Estado_Partido = Convert.ToInt16(CmbEstadoP.SelectedValue);
            if (agregar.EnviarDatosPartido_Controller() == false)
            {
                MessageBox.Show("Partido no pudo ser ingresado", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            CargarListasP();
            BtnActualizarPartido.Enabled = false;
            BtnEliminarPartido.Enabled = false;
        }

        private void DgvPartidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnAgregarPartido.Enabled = false;
            HabilitarUpdDel();

            MemoryStream ms = new MemoryStream();
            PbPartido.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            //objeto de la clase MiembrosController
            PartidoController objselect = new PartidoController();
            //Almanecera el numero de la fila que demos click
            int posicion;
            //Esta linea de código sirve para capturar el número de la fila sobre la que se hace click
            posicion = DgvPartidos.CurrentRow.Index;
            //Asignamos lo que esta en el DataGrid en cada uno de los controles, utilizamos el principio teórico de Arrays dibimensionales donde tenemos [columnas, filas]
            TxtIdP.Text = DgvPartidos[0, posicion].Value.ToString();
            //PbPartido.Image = Convert.ToByte(DgvPartidos[1, posicion]);------------------------------
            TxtNombreP.Text = DgvPartidos[2, posicion].Value.ToString();
            TxtCantidadVotosP.Text = DgvPartidos[3, posicion].Value.ToString();
            //Llenamos el combobox según el ID contenido en el DataGridView
            //Guardar en una variable de tipo entero el id contenido en el DataGridView
            string Estado_Partido = DgvPartidos[4, posicion].Value.ToString();
            //Creamos un nuevo método que permita consultar el estado del partido según el ID contenido en la celda.
            CmbEstadoP.DataSource = objselect.CargarEstadoVotosInnerJoin_Controller(Estado_Partido);
            CmbEstadoP.ValueMember = "id_Estado_Partido";
            CmbEstadoP.DisplayMember = "Estado_Partido";
        }

        void ActualizarDatosP()
        {

            PartidoController objactualizar = new PartidoController();
            objactualizar.idPartido = Convert.ToInt16(TxtIdP.Text);
            //objactualizar.image = ms.GetBuffer();------------------------------------------------------
            objactualizar.nombrep = TxtNombreP.Text;
            objactualizar.Cantidadvotosp = Convert.ToInt16(TxtCantidadVotosP.Text);
            objactualizar.Estado_Partido = Convert.ToInt16(CmbEstadoP.SelectedValue);

            if (objactualizar.ActualizarDatosPartido_Controller() == false)
            {
                MessageBox.Show("Partido no pudo ser actualizado", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Ocurrio un error al establecer conexión con la base de datos, verifique su acceso a internet o que los servidores del servidor estén activos.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    MessageBox.Show("Partido eliminado", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Empleado no pudo ser eliminado debido a que existen datos dependientes", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            EnvioDatosP();
            CargarListasP();
            BtnActualizarPartido.Enabled = false;
            BtnEliminarPartido.Enabled = false;
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
            DialogResult dr = MessageBox.Show("¿Estás seguro de querer eliminar al partido: " +TxtNombreP+" ?","Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                EliminarDatosP();
                CargarListasP();
                LimpiarCamposP();
            }
        }
    }
}
