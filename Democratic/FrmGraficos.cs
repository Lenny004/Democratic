using Controlador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Democratic
{
    public partial class FrmGraficos : Form
    {
        private readonly ArrayList _nombresGrupo = new ArrayList();
        private readonly ArrayList _cantidadVotos = new ArrayList();

        public FrmGraficos()
        {
            InitializeComponent();
        }

        private void VerificarMode()
        {
            UiTheme.ApplyCharts(panel1, GrpGrafCandidato, ChartVotos1, ChartVotos2, ChartVotos3);
        }

        private void ConfigurarTitulosGraficas()
        {
            if (VarSession.idioma == 1)
            {
                GrpGrafCandidato.Text = "Vote count by option/group";
                ChartVotos1.Titles.Clear();
                ChartVotos1.Titles.Add("Vote trend");
                ChartVotos2.Titles.Clear();
                ChartVotos2.Titles.Add("Votes per option");
                ChartVotos3.Titles.Clear();
                ChartVotos3.Titles.Add("Vote distribution");
                ChartVotos1.Series[0].Name = "Votes";
                ChartVotos2.Series[0].Name = "Votes";
                ChartVotos3.Series[0].Name = "Votes";
            }
            else
            {
                GrpGrafCandidato.Text = "Cantidad de votos por opción/grupo";
                ChartVotos1.Titles.Clear();
                ChartVotos1.Titles.Add("Tendencia de votos");
                ChartVotos2.Titles.Clear();
                ChartVotos2.Titles.Add("Votos por opción");
                ChartVotos3.Titles.Clear();
                ChartVotos3.Titles.Add("Distribución de votos");
                ChartVotos1.Series[0].Name = "Votos";
                ChartVotos2.Series[0].Name = "Votos";
                ChartVotos3.Series[0].Name = "Votos";
            }
        }

        private void CargarResultadosVotacion()
        {
            List<Tuple<string, int>> resultados = ResultadosController.ObtenerVotosPorGrupo_Controller();
            foreach (Tuple<string, int> resultado in resultados)
            {
                _nombresGrupo.Add(resultado.Item1);
                _cantidadVotos.Add(resultado.Item2);
            }

            ChartVotos1.Series[0].Points.DataBindXY(_nombresGrupo, _cantidadVotos);
            ChartVotos2.Series[0].Points.DataBindXY(_nombresGrupo, _cantidadVotos);
            ChartVotos3.Series[0].Points.DataBindXY(_nombresGrupo, _cantidadVotos);
        }

        private void FrmGraficos_Load(object sender, EventArgs e)
        {
            ConfigurarTitulosGraficas();
            VerificarMode();
            CargarResultadosVotacion();
        }
    }
}
