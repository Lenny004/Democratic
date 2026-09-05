using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Democratic
{
    public partial class FrmVotar : Form
    {
        private const int TotalOpciones = 9;

        public string DtToday = DateTime.Now.ToString("yyyy-MM-dd");
        public string DtNow = DateTime.Now.ToString("hh:mm:ss");
        public int estadov = 1;
        public int estadoB = 1;
        public int idCentroV = VarSession.idCentroV;
        public int idjrv;
        public int Randomjrv = VarSession.idJRV;
        public int Boleta;

        private PictureBox[] _pbOpciones;
        private PictureBox[] _pbGrupos;
        private Button[] _btnVotar;
        private TextBox[] _txtIdGrupo;

        public FrmVotar()
        {
            InitializeComponent();
            InicializarControlesOpcion();
        }

        private void InicializarControlesOpcion()
        {
            _pbOpciones = new[]
            {
                PbVotar1, PbVotar2, PbVotar3, PbVotar4, PbVotar5,
                PbVotar6, PbVotar7, PbVotar8, PbVotar9
            };
            _pbGrupos = new[]
            {
                PBP1, PBP2, PBP3, PBP4, PBP5,
                PBP6, PBP7, PBP8, PBP9
            };
            _btnVotar = new[]
            {
                BtnVotar1, BtnVotar2, BtnVotar3, BtnVotar4, BtnVotar5,
                BtnVotar6, BtnVotar7, BtnVotar8, BtnVotar9
            };
            _txtIdGrupo = new[]
            {
                TxtID1, TxtID2, TxtID3, TxtID4, TxtID5,
                TxtID6, TxtID7, TxtID8, TxtID9
            };
        }

        private void VerificarMode()
        {
            UiTheme.ApplyGrayPanel(panel1, toolStrip1, BtnMinimizar);
        }

        private void CargarImagenOpcion(int idOpcion, PictureBox destino)
        {
            byte[] imagen = ModelCandidato.RecuperarImagenOpcion(idOpcion);
            if (imagen == null)
            {
                return;
            }

            using (MemoryStream ms = new MemoryStream(imagen))
            {
                destino.Image = Image.FromStream(ms);
            }
        }

        private void CargarImagenGrupo(int idGrupo, PictureBox destino)
        {
            byte[] imagen = ModelPartido.RecuperarImagenOrganizacion(idGrupo);
            if (imagen == null)
            {
                return;
            }

            using (MemoryStream ms = new MemoryStream(imagen))
            {
                destino.Image = Image.FromStream(ms);
            }
        }

        private void CargarOpcion(int indice)
        {
            int idOpcion = indice + 1;
            CargarImagenOpcion(idOpcion, _pbOpciones[indice]);

            List<string> datos = VotoController.BuscarIdGrupoPorOpcion_Controller(idOpcion);
            if (datos == null || datos.Count == 0)
            {
                return;
            }

            _txtIdGrupo[indice].Text = datos[0];
            CargarImagenGrupo(Convert.ToInt32(datos[0]), _pbGrupos[indice]);
        }

        private void CargarTodasLasOpciones()
        {
            for (int i = 0; i < TotalOpciones; i++)
            {
                CargarOpcion(i);
            }
        }

        private void FrmVotar_Load(object sender, EventArgs e)
        {
            VerificarMode();
            int Estado = 3;
            int Estado2 = 2;
            if (Estado == VarSession.EstadoUsuario || Estado2 == VarSession.EstadoUsuario)
            {
                InhabilitarVotacion();
            }

            try
            {
                CargarTodasLasOpciones();
            }
            catch (Exception)
            {
                MostrarMensajeOpcionesFaltantes();
            }
        }

        private void MostrarMensajeOpcionesFaltantes()
        {
            if (VarSession.idioma == 1)
            {
                MessageBox.Show(
                    "Voting option images are missing",
                    Idiomas.EnglishMessage.msjE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(
                    "Faltan imágenes de las opciones de votación",
                    Idiomas.MensajesEspanol.msjE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void InhabilitarVotacion()
        {
            for (int i = 0; i < TotalOpciones; i++)
            {
                _pbOpciones[i].Enabled = false;
                _pbGrupos[i].Enabled = false;
                _btnVotar[i].Enabled = false;
            }
        }

        private void ActualizarEstadoU()
        {
            int Estado = 3;
            AtributosLogin.EstadoU = Estado;
            AtributosLogin.usuario = VarSession.usuario;
            if (LoginController.ActualizarEstado_Controller())
            {
                MessageBox.Show(
                    "Su estado ha sido actualizado tras emitir su voto",
                    "Estado actualizado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void EnviarVoto(int indice)
        {
            VotoController agregarBoleta = new VotoController();
            agregarBoleta.FechaV = Convert.ToString(DtToday);
            agregarBoleta.idEstadoBoleta = estadoB;
            agregarBoleta.JRV = Randomjrv;
            if (!agregarBoleta.RegistrarBoleta_Controller())
            {
                MostrarMensajeBoletaOcupada();
                return;
            }

            List<string> datosBoleta = VotoController.ObtenerBoleta_Controller();
            Boleta = Convert.ToInt16(datosBoleta[0]);

            int idGrupo = Convert.ToInt16(_txtIdGrupo[indice].Text);

            VotoController agregarVoto = new VotoController();
            agregarVoto.Partido = idGrupo;
            agregarVoto.Boleta = Boleta;
            agregarVoto.EstadoVoto = estadov;
            agregarVoto.FechaV = Convert.ToString(DtToday);
            agregarVoto.HoraV = Convert.ToString(DtNow);
            if (!agregarVoto.RegistrarVoto_Controller())
            {
                MostrarMensajeVotoInvalido();
                return;
            }

            ActualizarEstadoU();
            FrmNotiVoto.Frmnotivoto();
            InhabilitarVotacion();
        }

        private void MostrarMensajeBoletaOcupada()
        {
            if (VarSession.idioma == 1)
            {
                MessageBox.Show(Idiomas.EnglishMessage.msjocubol, Idiomas.EnglishMessage.msjE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(Idiomas.MensajesEspanol.msjocubol, Idiomas.MensajesEspanol.msjE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarMensajeVotoInvalido()
        {
            if (VarSession.idioma == 1)
            {
                MessageBox.Show(Idiomas.EnglishMessage.msjvtin, Idiomas.EnglishMessage.msjE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(Idiomas.MensajesEspanol.msjvtin, Idiomas.MensajesEspanol.msjE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarGrupo(int indice)
        {
            _pbGrupos[indice].Visible = true;
        }

        private void OcultarGrupo(int indice)
        {
            _pbGrupos[indice].Visible = false;
        }

        private void BtnVotar1_Click(object sender, EventArgs e) { EnviarVoto(0); }
        private void BtnVotar2_Click(object sender, EventArgs e) { EnviarVoto(1); }
        private void BtnVotar3_Click(object sender, EventArgs e) { EnviarVoto(2); }
        private void BtnVotar4_Click(object sender, EventArgs e) { EnviarVoto(3); }
        private void BtnVotar5_Click(object sender, EventArgs e) { EnviarVoto(4); }
        private void BtnVotar6_Click(object sender, EventArgs e) { EnviarVoto(5); }
        private void BtnVotar7_Click(object sender, EventArgs e) { EnviarVoto(6); }
        private void BtnVotar8_Click(object sender, EventArgs e) { EnviarVoto(7); }
        private void BtnVotar9_Click(object sender, EventArgs e) { EnviarVoto(8); }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PbVotar1_MouseEnter(object sender, EventArgs e) { MostrarGrupo(0); }
        private void PbVotar2_MouseEnter(object sender, EventArgs e) { MostrarGrupo(1); }
        private void PbVotar3_MouseEnter(object sender, EventArgs e) { MostrarGrupo(2); }
        private void PbVotar4_MouseEnter(object sender, EventArgs e) { MostrarGrupo(3); }
        private void PbVotar5_MouseEnter(object sender, EventArgs e) { MostrarGrupo(4); }
        private void PbVotar6_MouseEnter(object sender, EventArgs e) { MostrarGrupo(5); }
        private void PbVotar7_MouseEnter(object sender, EventArgs e) { MostrarGrupo(6); }
        private void PbVotar8_MouseEnter(object sender, EventArgs e) { MostrarGrupo(7); }
        private void PbVotar9_MouseEnter(object sender, EventArgs e) { MostrarGrupo(8); }

        private void PBP1_MouseLeave(object sender, EventArgs e) { OcultarGrupo(0); }
        private void PBP2_MouseLeave(object sender, EventArgs e) { OcultarGrupo(1); }
        private void PBP3_MouseLeave(object sender, EventArgs e) { OcultarGrupo(2); }
        private void PBP4_MouseLeave(object sender, EventArgs e) { OcultarGrupo(3); }
        private void PBP5_MouseLeave(object sender, EventArgs e) { OcultarGrupo(4); }
        private void PBP6_MouseLeave(object sender, EventArgs e) { OcultarGrupo(5); }
        private void PBP7_MouseLeave(object sender, EventArgs e) { OcultarGrupo(6); }
        private void PBP8_MouseLeave(object sender, EventArgs e) { OcultarGrupo(7); }
        private void PBP9_MouseLeave(object sender, EventArgs e) { OcultarGrupo(8); }
    }
}





