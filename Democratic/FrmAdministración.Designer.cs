namespace Democratic
{
    partial class FrmAdministración
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrpPrimerU = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.GrpTribunal = new System.Windows.Forms.GroupBox();
            this.DgvCV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BtnRefrescarM = new System.Windows.Forms.Button();
            this.BtnTruncateC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpInicio = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GrpPrimerU.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.GrpTribunal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCV)).BeginInit();
            this.GrpInicio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpPrimerU
            // 
            this.GrpPrimerU.Controls.Add(this.groupBox2);
            this.GrpPrimerU.Controls.Add(this.groupBox1);
            this.GrpPrimerU.Controls.Add(this.GrpInicio);
            this.GrpPrimerU.Controls.Add(this.BtnTruncateC);
            this.GrpPrimerU.Controls.Add(this.BtnRefrescarM);
            this.GrpPrimerU.Location = new System.Drawing.Point(12, 38);
            this.GrpPrimerU.Name = "GrpPrimerU";
            this.GrpPrimerU.Size = new System.Drawing.Size(776, 202);
            this.GrpPrimerU.TabIndex = 0;
            this.GrpPrimerU.TabStop = false;
            this.GrpPrimerU.Text = "Configuración Votación:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMinimizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMinimizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.Image = global::Democratic.Properties.Resources.expand_arrow_64px1;
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(160, 22);
            this.BtnMinimizar.Text = "Minimizar Formulario";
            // 
            // GrpTribunal
            // 
            this.GrpTribunal.Controls.Add(this.DgvCV);
            this.GrpTribunal.Location = new System.Drawing.Point(12, 246);
            this.GrpTribunal.Name = "GrpTribunal";
            this.GrpTribunal.Size = new System.Drawing.Size(776, 328);
            this.GrpTribunal.TabIndex = 1;
            this.GrpTribunal.TabStop = false;
            this.GrpTribunal.Text = "Configuración de la organización";
            // 
            // DgvCV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCV.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DgvCV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCV.DoubleBuffered = true;
            this.DgvCV.EnableHeadersVisualStyles = false;
            this.DgvCV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            this.DgvCV.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DgvCV.Location = new System.Drawing.Point(6, 247);
            this.DgvCV.Name = "DgvCV";
            this.DgvCV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvCV.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCV.Size = new System.Drawing.Size(764, 75);
            this.DgvCV.TabIndex = 38;
            // 
            // BtnRefrescarM
            // 
            this.BtnRefrescarM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRefrescarM.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRefrescarM.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefrescarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnRefrescarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnRefrescarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescarM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefrescarM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefrescarM.Location = new System.Drawing.Point(21, 46);
            this.BtnRefrescarM.Name = "BtnRefrescarM";
            this.BtnRefrescarM.Size = new System.Drawing.Size(174, 40);
            this.BtnRefrescarM.TabIndex = 16;
            this.BtnRefrescarM.Text = "Iniciar Votación";
            this.BtnRefrescarM.UseVisualStyleBackColor = false;
            // 
            // BtnTruncateC
            // 
            this.BtnTruncateC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnTruncateC.BackColor = System.Drawing.Color.Crimson;
            this.BtnTruncateC.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTruncateC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnTruncateC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.BtnTruncateC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTruncateC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTruncateC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnTruncateC.Location = new System.Drawing.Point(21, 110);
            this.BtnTruncateC.Name = "BtnTruncateC";
            this.BtnTruncateC.Size = new System.Drawing.Size(174, 44);
            this.BtnTruncateC.TabIndex = 55;
            this.BtnTruncateC.Text = "Detener Votación";
            this.BtnTruncateC.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Hora de inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Hora de finalización:";
            // 
            // GrpInicio
            // 
            this.GrpInicio.BackColor = System.Drawing.Color.Transparent;
            this.GrpInicio.Controls.Add(this.label3);
            this.GrpInicio.Controls.Add(this.label1);
            this.GrpInicio.Location = new System.Drawing.Point(222, 13);
            this.GrpInicio.Name = "GrpInicio";
            this.GrpInicio.Size = new System.Drawing.Size(179, 171);
            this.GrpInicio.TabIndex = 58;
            this.GrpInicio.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(591, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 171);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "label4";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(407, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 171);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Tiempo restante:";
            // 
            // FrmAdministración
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.GrpTribunal);
            this.Controls.Add(this.GrpPrimerU);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdministración";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministración";
            this.GrpPrimerU.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GrpTribunal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCV)).EndInit();
            this.GrpInicio.ResumeLayout(false);
            this.GrpInicio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpPrimerU;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.GroupBox GrpTribunal;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvCV;
        private System.Windows.Forms.Button BtnRefrescarM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTruncateC;
    }
}