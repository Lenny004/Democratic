namespace Democratic
{
    partial class FrmGraficos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartVotos2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GrpGrafCandidato = new System.Windows.Forms.GroupBox();
            this.ChartVotos1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartVotos3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVotos2)).BeginInit();
            this.GrpGrafCandidato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVotos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVotos3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChartVotos2
            // 
            this.ChartVotos2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChartVotos2.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ChartVotos2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartVotos2.Legends.Add(legend1);
            this.ChartVotos2.Location = new System.Drawing.Point(22, 309);
            this.ChartVotos2.Name = "ChartVotos2";
            this.ChartVotos2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartVotos2.Series.Add(series1);
            this.ChartVotos2.Size = new System.Drawing.Size(317, 241);
            this.ChartVotos2.TabIndex = 0;
            this.ChartVotos2.Text = "chart1";
            // 
            // GrpGrafCandidato
            // 
            this.GrpGrafCandidato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpGrafCandidato.BackColor = System.Drawing.Color.Transparent;
            this.GrpGrafCandidato.Controls.Add(this.ChartVotos1);
            this.GrpGrafCandidato.Controls.Add(this.ChartVotos2);
            this.GrpGrafCandidato.Controls.Add(this.ChartVotos3);
            this.GrpGrafCandidato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpGrafCandidato.Location = new System.Drawing.Point(27, 21);
            this.GrpGrafCandidato.Name = "GrpGrafCandidato";
            this.GrpGrafCandidato.Size = new System.Drawing.Size(761, 590);
            this.GrpGrafCandidato.TabIndex = 2;
            this.GrpGrafCandidato.TabStop = false;
            this.GrpGrafCandidato.Text = "Cantidad de votos por opción/grupo";
            // 
            // ChartVotos1
            // 
            this.ChartVotos1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea2.Name = "ChartArea1";
            this.ChartVotos1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartVotos1.Legends.Add(legend2);
            this.ChartVotos1.Location = new System.Drawing.Point(22, 32);
            this.ChartVotos1.Name = "ChartVotos1";
            this.ChartVotos1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartVotos1.Series.Add(series2);
            this.ChartVotos1.Size = new System.Drawing.Size(707, 237);
            this.ChartVotos1.TabIndex = 2;
            this.ChartVotos1.Text = "chart1";
            // 
            // ChartVotos3
            // 
            this.ChartVotos3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChartVotos3.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.ChartVotos3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartVotos3.Legends.Add(legend3);
            this.ChartVotos3.Location = new System.Drawing.Point(412, 342);
            this.ChartVotos3.Name = "ChartVotos3";
            this.ChartVotos3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.LabelBorderColor = System.Drawing.Color.Transparent;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartVotos3.Series.Add(series3);
            this.ChartVotos3.Size = new System.Drawing.Size(317, 208);
            this.ChartVotos3.TabIndex = 1;
            this.ChartVotos3.Text = "chart3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.GrpGrafCandidato);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 623);
            this.panel1.TabIndex = 2;
            // 
            // FrmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(600, 548);
            this.Name = "FrmGraficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados de la votación";
            this.Load += new System.EventHandler(this.FrmGraficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartVotos2)).EndInit();
            this.GrpGrafCandidato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartVotos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVotos3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVotos2;
        private System.Windows.Forms.GroupBox GrpGrafCandidato;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVotos3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVotos1;
    }
}