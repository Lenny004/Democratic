namespace Democratic
{
    partial class FrmCandidatos
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Minimizar = new System.Windows.Forms.ToolStripButton();
            this.GrpCandidatos = new System.Windows.Forms.GroupBox();
            this.txtIdC = new System.Windows.Forms.TextBox();
            this.CmbEstadoC = new System.Windows.Forms.ComboBox();
            this.lblEstadoC = new System.Windows.Forms.Label();
            this.PbCandidato = new System.Windows.Forms.PictureBox();
            this.BtnCargarImageC = new System.Windows.Forms.Button();
            this.BtnEliminarCandidato = new System.Windows.Forms.Button();
            this.BtnRefrescarCandidato = new System.Windows.Forms.Button();
            this.BtnLimpiarCandidato = new System.Windows.Forms.Button();
            this.BtnActualizarCandidato = new System.Windows.Forms.Button();
            this.BtnAgregarCandidato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbPartidoC = new System.Windows.Forms.ComboBox();
            this.TxtgeneroC = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtApellidoC = new System.Windows.Forms.TextBox();
            this.lblApellidoC = new System.Windows.Forms.Label();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.DgvCandidatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.OFDSeleccionarImage = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.GrpCandidatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCandidato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Minimizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Minimizar
            // 
            this.Minimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Minimizar.Image = global::Democratic.Properties.Resources.expand_arrow_64px1;
            this.Minimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(141, 22);
            this.Minimizar.Text = "Minimizar Formulario";
            // 
            // GrpCandidatos
            // 
            this.GrpCandidatos.Controls.Add(this.txtIdC);
            this.GrpCandidatos.Controls.Add(this.CmbEstadoC);
            this.GrpCandidatos.Controls.Add(this.lblEstadoC);
            this.GrpCandidatos.Controls.Add(this.PbCandidato);
            this.GrpCandidatos.Controls.Add(this.BtnCargarImageC);
            this.GrpCandidatos.Controls.Add(this.BtnEliminarCandidato);
            this.GrpCandidatos.Controls.Add(this.BtnRefrescarCandidato);
            this.GrpCandidatos.Controls.Add(this.BtnLimpiarCandidato);
            this.GrpCandidatos.Controls.Add(this.BtnActualizarCandidato);
            this.GrpCandidatos.Controls.Add(this.BtnAgregarCandidato);
            this.GrpCandidatos.Controls.Add(this.label1);
            this.GrpCandidatos.Controls.Add(this.CmbPartidoC);
            this.GrpCandidatos.Controls.Add(this.TxtgeneroC);
            this.GrpCandidatos.Controls.Add(this.lblGenero);
            this.GrpCandidatos.Controls.Add(this.txtApellidoC);
            this.GrpCandidatos.Controls.Add(this.lblApellidoC);
            this.GrpCandidatos.Controls.Add(this.lblNombreC);
            this.GrpCandidatos.Controls.Add(this.DgvCandidatos);
            this.GrpCandidatos.Controls.Add(this.txtNombreC);
            this.GrpCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCandidatos.Location = new System.Drawing.Point(12, 28);
            this.GrpCandidatos.Name = "GrpCandidatos";
            this.GrpCandidatos.Size = new System.Drawing.Size(776, 608);
            this.GrpCandidatos.TabIndex = 1;
            this.GrpCandidatos.TabStop = false;
            // 
            // txtIdC
            // 
            this.txtIdC.Location = new System.Drawing.Point(737, 10);
            this.txtIdC.Name = "txtIdC";
            this.txtIdC.Size = new System.Drawing.Size(39, 23);
            this.txtIdC.TabIndex = 47;
            // 
            // CmbEstadoC
            // 
            this.CmbEstadoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoC.FormattingEnabled = true;
            this.CmbEstadoC.Location = new System.Drawing.Point(242, 254);
            this.CmbEstadoC.Name = "CmbEstadoC";
            this.CmbEstadoC.Size = new System.Drawing.Size(143, 24);
            this.CmbEstadoC.TabIndex = 46;
            // 
            // lblEstadoC
            // 
            this.lblEstadoC.AutoSize = true;
            this.lblEstadoC.Location = new System.Drawing.Point(239, 227);
            this.lblEstadoC.Name = "lblEstadoC";
            this.lblEstadoC.Size = new System.Drawing.Size(147, 17);
            this.lblEstadoC.TabIndex = 45;
            this.lblEstadoC.Text = "Estado del Candidato:";
            // 
            // PbCandidato
            // 
            this.PbCandidato.Location = new System.Drawing.Point(242, 25);
            this.PbCandidato.Name = "PbCandidato";
            this.PbCandidato.Size = new System.Drawing.Size(143, 151);
            this.PbCandidato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCandidato.TabIndex = 44;
            this.PbCandidato.TabStop = false;
            // 
            // BtnCargarImageC
            // 
            this.BtnCargarImageC.Location = new System.Drawing.Point(254, 182);
            this.BtnCargarImageC.Name = "BtnCargarImageC";
            this.BtnCargarImageC.Size = new System.Drawing.Size(120, 35);
            this.BtnCargarImageC.TabIndex = 43;
            this.BtnCargarImageC.Text = "Cargar Imagen";
            this.BtnCargarImageC.UseVisualStyleBackColor = true;
            this.BtnCargarImageC.Click += new System.EventHandler(this.BtnCargarImageC_Click);
            // 
            // BtnEliminarCandidato
            // 
            this.BtnEliminarCandidato.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarCandidato.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminarCandidato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEliminarCandidato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminarCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarCandidato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEliminarCandidato.Location = new System.Drawing.Point(592, 183);
            this.BtnEliminarCandidato.Name = "BtnEliminarCandidato";
            this.BtnEliminarCandidato.Size = new System.Drawing.Size(167, 40);
            this.BtnEliminarCandidato.TabIndex = 43;
            this.BtnEliminarCandidato.Text = "Eliminar Partido";
            this.BtnEliminarCandidato.UseVisualStyleBackColor = false;
            // 
            // BtnRefrescarCandidato
            // 
            this.BtnRefrescarCandidato.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRefrescarCandidato.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefrescarCandidato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRefrescarCandidato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnRefrescarCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescarCandidato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefrescarCandidato.Location = new System.Drawing.Point(592, 125);
            this.BtnRefrescarCandidato.Name = "BtnRefrescarCandidato";
            this.BtnRefrescarCandidato.Size = new System.Drawing.Size(167, 40);
            this.BtnRefrescarCandidato.TabIndex = 42;
            this.BtnRefrescarCandidato.Text = "Refrescar";
            this.BtnRefrescarCandidato.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiarCandidato
            // 
            this.BtnLimpiarCandidato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnLimpiarCandidato.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLimpiarCandidato.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiarCandidato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnLimpiarCandidato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiarCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarCandidato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLimpiarCandidato.Location = new System.Drawing.Point(408, 238);
            this.BtnLimpiarCandidato.Name = "BtnLimpiarCandidato";
            this.BtnLimpiarCandidato.Size = new System.Drawing.Size(167, 40);
            this.BtnLimpiarCandidato.TabIndex = 41;
            this.BtnLimpiarCandidato.Text = "Limpiar Campos";
            this.BtnLimpiarCandidato.UseVisualStyleBackColor = false;
            // 
            // BtnActualizarCandidato
            // 
            this.BtnActualizarCandidato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnActualizarCandidato.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarCandidato.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnActualizarCandidato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnActualizarCandidato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizarCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarCandidato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualizarCandidato.Location = new System.Drawing.Point(408, 183);
            this.BtnActualizarCandidato.Name = "BtnActualizarCandidato";
            this.BtnActualizarCandidato.Size = new System.Drawing.Size(167, 40);
            this.BtnActualizarCandidato.TabIndex = 40;
            this.BtnActualizarCandidato.Text = "Actualizar Partido";
            this.BtnActualizarCandidato.UseVisualStyleBackColor = false;
            // 
            // BtnAgregarCandidato
            // 
            this.BtnAgregarCandidato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnAgregarCandidato.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregarCandidato.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarCandidato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnAgregarCandidato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregarCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCandidato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregarCandidato.Location = new System.Drawing.Point(408, 125);
            this.BtnAgregarCandidato.Name = "BtnAgregarCandidato";
            this.BtnAgregarCandidato.Size = new System.Drawing.Size(167, 40);
            this.BtnAgregarCandidato.TabIndex = 39;
            this.BtnAgregarCandidato.Text = "Agregar Partido";
            this.BtnAgregarCandidato.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Partido Afiliado:";
            // 
            // CmbPartidoC
            // 
            this.CmbPartidoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPartidoC.FormattingEnabled = true;
            this.CmbPartidoC.Location = new System.Drawing.Point(27, 254);
            this.CmbPartidoC.Name = "CmbPartidoC";
            this.CmbPartidoC.Size = new System.Drawing.Size(182, 24);
            this.CmbPartidoC.TabIndex = 9;
            // 
            // TxtgeneroC
            // 
            this.TxtgeneroC.Location = new System.Drawing.Point(27, 177);
            this.TxtgeneroC.Multiline = true;
            this.TxtgeneroC.Name = "TxtgeneroC";
            this.TxtgeneroC.Size = new System.Drawing.Size(182, 25);
            this.TxtgeneroC.TabIndex = 8;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(24, 157);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 17);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Género: ";
            // 
            // txtApellidoC
            // 
            this.txtApellidoC.Location = new System.Drawing.Point(27, 113);
            this.txtApellidoC.Multiline = true;
            this.txtApellidoC.Name = "txtApellidoC";
            this.txtApellidoC.Size = new System.Drawing.Size(182, 25);
            this.txtApellidoC.TabIndex = 6;
            // 
            // lblApellidoC
            // 
            this.lblApellidoC.AutoSize = true;
            this.lblApellidoC.Location = new System.Drawing.Point(24, 93);
            this.lblApellidoC.Name = "lblApellidoC";
            this.lblApellidoC.Size = new System.Drawing.Size(160, 17);
            this.lblApellidoC.TabIndex = 5;
            this.lblApellidoC.Text = "Apellidos del Candidato:";
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Location = new System.Drawing.Point(24, 25);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(160, 17);
            this.lblNombreC.TabIndex = 4;
            this.lblNombreC.Text = "Nombres del Candidato:";
            // 
            // DgvCandidatos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvCandidatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvCandidatos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DgvCandidatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCandidatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCandidatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCandidatos.DoubleBuffered = true;
            this.DgvCandidatos.EnableHeadersVisualStyles = false;
            this.DgvCandidatos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            this.DgvCandidatos.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DgvCandidatos.Location = new System.Drawing.Point(6, 316);
            this.DgvCandidatos.Name = "DgvCandidatos";
            this.DgvCandidatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvCandidatos.Size = new System.Drawing.Size(764, 286);
            this.DgvCandidatos.TabIndex = 3;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(27, 45);
            this.txtNombreC.Multiline = true;
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(182, 25);
            this.txtNombreC.TabIndex = 0;
            // 
            // OFDSeleccionarImage
            // 
            this.OFDSeleccionarImage.FileName = "openFileDialog1";
            // 
            // FrmCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.GrpCandidatos);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCandidatos";
            this.Load += new System.EventHandler(this.FrmCandidatos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GrpCandidatos.ResumeLayout(false);
            this.GrpCandidatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCandidato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Minimizar;
        private System.Windows.Forms.GroupBox GrpCandidatos;
        private System.Windows.Forms.TextBox txtNombreC;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvCandidatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbPartidoC;
        private System.Windows.Forms.TextBox TxtgeneroC;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtApellidoC;
        private System.Windows.Forms.Label lblApellidoC;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.Button BtnEliminarCandidato;
        private System.Windows.Forms.Button BtnRefrescarCandidato;
        private System.Windows.Forms.Button BtnLimpiarCandidato;
        private System.Windows.Forms.Button BtnActualizarCandidato;
        private System.Windows.Forms.Button BtnAgregarCandidato;
        private System.Windows.Forms.Button BtnCargarImageC;
        private System.Windows.Forms.PictureBox PbCandidato;
        private System.Windows.Forms.TextBox txtIdC;
        private System.Windows.Forms.ComboBox CmbEstadoC;
        private System.Windows.Forms.Label lblEstadoC;
        private System.Windows.Forms.OpenFileDialog OFDSeleccionarImage;
    }
}