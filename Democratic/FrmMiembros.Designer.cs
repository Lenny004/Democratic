namespace Democratic
{
    partial class FrmMiembros
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.GrpMiembros = new System.Windows.Forms.GroupBox();
            this.DateTPFNM = new System.Windows.Forms.DateTimePicker();
            this.DgvMiembros = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TxtIdM = new System.Windows.Forms.TextBox();
            this.TxtCorreoM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTelefonoM = new System.Windows.Forms.MaskedTextBox();
            this.BtnRefrescarM = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnActualizarM = new System.Windows.Forms.Button();
            this.BtnAgregarM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbEstadoM = new System.Windows.Forms.ComboBox();
            this.lblEstadoM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDireccionM = new System.Windows.Forms.Label();
            this.TxtDireccionM = new System.Windows.Forms.TextBox();
            this.lblFechaNM = new System.Windows.Forms.Label();
            this.lblDuiM = new System.Windows.Forms.Label();
            this.MskDui = new System.Windows.Forms.MaskedTextBox();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.TxtApellidoM = new System.Windows.Forms.TextBox();
            this.TxtNombreM = new System.Windows.Forms.TextBox();
            this.lblNombreMiembro = new System.Windows.Forms.Label();
            this.txtbuscador = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.GrpMiembros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMiembros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.GrpMiembros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1300, 730);
            this.panel1.MinimumSize = new System.Drawing.Size(800, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 648);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMinimizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMinimizar.Image = global::Democratic.Properties.Resources.expand_arrow_64px;
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(141, 22);
            this.BtnMinimizar.Text = "Minimizar Formulario";
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // GrpMiembros
            // 
            this.GrpMiembros.BackColor = System.Drawing.Color.Transparent;
            this.GrpMiembros.Controls.Add(this.pictureBox1);
            this.GrpMiembros.Controls.Add(this.txtbuscador);
            this.GrpMiembros.Controls.Add(this.DateTPFNM);
            this.GrpMiembros.Controls.Add(this.DgvMiembros);
            this.GrpMiembros.Controls.Add(this.TxtIdM);
            this.GrpMiembros.Controls.Add(this.TxtCorreoM);
            this.GrpMiembros.Controls.Add(this.label3);
            this.GrpMiembros.Controls.Add(this.MskTelefonoM);
            this.GrpMiembros.Controls.Add(this.BtnRefrescarM);
            this.GrpMiembros.Controls.Add(this.BtnLimpiar);
            this.GrpMiembros.Controls.Add(this.BtnActualizarM);
            this.GrpMiembros.Controls.Add(this.BtnAgregarM);
            this.GrpMiembros.Controls.Add(this.label1);
            this.GrpMiembros.Controls.Add(this.CmbEstadoM);
            this.GrpMiembros.Controls.Add(this.lblEstadoM);
            this.GrpMiembros.Controls.Add(this.label2);
            this.GrpMiembros.Controls.Add(this.lblDireccionM);
            this.GrpMiembros.Controls.Add(this.TxtDireccionM);
            this.GrpMiembros.Controls.Add(this.lblFechaNM);
            this.GrpMiembros.Controls.Add(this.lblDuiM);
            this.GrpMiembros.Controls.Add(this.MskDui);
            this.GrpMiembros.Controls.Add(this.lblApellidoM);
            this.GrpMiembros.Controls.Add(this.TxtApellidoM);
            this.GrpMiembros.Controls.Add(this.TxtNombreM);
            this.GrpMiembros.Controls.Add(this.lblNombreMiembro);
            this.GrpMiembros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpMiembros.Location = new System.Drawing.Point(12, 28);
            this.GrpMiembros.Name = "GrpMiembros";
            this.GrpMiembros.Size = new System.Drawing.Size(776, 608);
            this.GrpMiembros.TabIndex = 0;
            this.GrpMiembros.TabStop = false;
            // 
            // DateTPFNM
            // 
            this.DateTPFNM.CustomFormat = "yyyy-MM-dd";
            this.DateTPFNM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTPFNM.Location = new System.Drawing.Point(27, 263);
            this.DateTPFNM.Name = "DateTPFNM";
            this.DateTPFNM.Size = new System.Drawing.Size(183, 23);
            this.DateTPFNM.TabIndex = 4;
            this.DateTPFNM.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            // 
            // DgvMiembros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvMiembros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMiembros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvMiembros.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DgvMiembros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvMiembros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMiembros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMiembros.DoubleBuffered = true;
            this.DgvMiembros.EnableHeadersVisualStyles = false;
            this.DgvMiembros.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            this.DgvMiembros.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DgvMiembros.Location = new System.Drawing.Point(6, 311);
            this.DgvMiembros.Name = "DgvMiembros";
            this.DgvMiembros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvMiembros.Size = new System.Drawing.Size(764, 286);
            this.DgvMiembros.TabIndex = 28;
            this.DgvMiembros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMiembros_CellClick_1);
            // 
            // TxtIdM
            // 
            this.TxtIdM.Enabled = false;
            this.TxtIdM.Location = new System.Drawing.Point(742, 9);
            this.TxtIdM.Name = "TxtIdM";
            this.TxtIdM.ReadOnly = true;
            this.TxtIdM.Size = new System.Drawing.Size(34, 23);
            this.TxtIdM.TabIndex = 27;
            // 
            // TxtCorreoM
            // 
            this.TxtCorreoM.Location = new System.Drawing.Point(278, 125);
            this.TxtCorreoM.Name = "TxtCorreoM";
            this.TxtCorreoM.Size = new System.Drawing.Size(183, 23);
            this.TxtCorreoM.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Correo del miembro:";
            // 
            // MskTelefonoM
            // 
            this.MskTelefonoM.Location = new System.Drawing.Point(281, 197);
            this.MskTelefonoM.Mask = "0000-0000";
            this.MskTelefonoM.Name = "MskTelefonoM";
            this.MskTelefonoM.Size = new System.Drawing.Size(180, 23);
            this.MskTelefonoM.TabIndex = 7;
            // 
            // BtnRefrescarM
            // 
            this.BtnRefrescarM.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRefrescarM.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefrescarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnRefrescarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnRefrescarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescarM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefrescarM.Location = new System.Drawing.Point(526, 265);
            this.BtnRefrescarM.Name = "BtnRefrescarM";
            this.BtnRefrescarM.Size = new System.Drawing.Size(213, 40);
            this.BtnRefrescarM.TabIndex = 12;
            this.BtnRefrescarM.Text = "Refrescar";
            this.BtnRefrescarM.UseVisualStyleBackColor = false;
            this.BtnRefrescarM.Click += new System.EventHandler(this.BtnRefrescarM_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLimpiar.Location = new System.Drawing.Point(526, 211);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(213, 40);
            this.BtnLimpiar.TabIndex = 11;
            this.BtnLimpiar.Text = "Limpiar Campos";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnActualizarM
            // 
            this.BtnActualizarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnActualizarM.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnActualizarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnActualizarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualizarM.Location = new System.Drawing.Point(526, 154);
            this.BtnActualizarM.Name = "BtnActualizarM";
            this.BtnActualizarM.Size = new System.Drawing.Size(213, 40);
            this.BtnActualizarM.TabIndex = 10;
            this.BtnActualizarM.Text = "Actualizar Miembro";
            this.BtnActualizarM.UseVisualStyleBackColor = false;
            this.BtnActualizarM.Click += new System.EventHandler(this.BtnActualizarM_Click);
            // 
            // BtnAgregarM
            // 
            this.BtnAgregarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnAgregarM.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregarM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnAgregarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregarM.Location = new System.Drawing.Point(526, 96);
            this.BtnAgregarM.Name = "BtnAgregarM";
            this.BtnAgregarM.Size = new System.Drawing.Size(213, 40);
            this.BtnAgregarM.TabIndex = 9;
            this.BtnAgregarM.Text = "Agregar Miembro";
            this.BtnAgregarM.UseVisualStyleBackColor = false;
            this.BtnAgregarM.Click += new System.EventHandler(this.BtnAgregarM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Democratic.Properties.Resources.search_48px;
            this.pictureBox1.Location = new System.Drawing.Point(712, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar miembros por N° DUI:";
            // 
            // CmbEstadoM
            // 
            this.CmbEstadoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoM.FormattingEnabled = true;
            this.CmbEstadoM.Location = new System.Drawing.Point(281, 265);
            this.CmbEstadoM.Name = "CmbEstadoM";
            this.CmbEstadoM.Size = new System.Drawing.Size(180, 24);
            this.CmbEstadoM.TabIndex = 8;
            this.CmbEstadoM.Click += new System.EventHandler(this.CmbEstadoM_Click);
            // 
            // lblEstadoM
            // 
            this.lblEstadoM.AutoSize = true;
            this.lblEstadoM.Location = new System.Drawing.Point(278, 234);
            this.lblEstadoM.Name = "lblEstadoM";
            this.lblEstadoM.Size = new System.Drawing.Size(137, 17);
            this.lblEstadoM.TabIndex = 14;
            this.lblEstadoM.Text = "Estado del Miembro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Télefono del miembro:";
            // 
            // lblDireccionM
            // 
            this.lblDireccionM.AutoSize = true;
            this.lblDireccionM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionM.Location = new System.Drawing.Point(275, 25);
            this.lblDireccionM.Name = "lblDireccionM";
            this.lblDireccionM.Size = new System.Drawing.Size(152, 17);
            this.lblDireccionM.TabIndex = 11;
            this.lblDireccionM.Text = "Dirección del miembro:";
            // 
            // TxtDireccionM
            // 
            this.TxtDireccionM.Location = new System.Drawing.Point(278, 56);
            this.TxtDireccionM.Multiline = true;
            this.TxtDireccionM.Name = "TxtDireccionM";
            this.TxtDireccionM.Size = new System.Drawing.Size(225, 37);
            this.TxtDireccionM.TabIndex = 5;
            // 
            // lblFechaNM
            // 
            this.lblFechaNM.AutoSize = true;
            this.lblFechaNM.Location = new System.Drawing.Point(24, 234);
            this.lblFechaNM.Name = "lblFechaNM";
            this.lblFechaNM.Size = new System.Drawing.Size(145, 17);
            this.lblFechaNM.TabIndex = 9;
            this.lblFechaNM.Text = "Fecha de Nacimiento:";
            // 
            // lblDuiM
            // 
            this.lblDuiM.AutoSize = true;
            this.lblDuiM.Location = new System.Drawing.Point(24, 168);
            this.lblDuiM.Name = "lblDuiM";
            this.lblDuiM.Size = new System.Drawing.Size(116, 17);
            this.lblDuiM.TabIndex = 6;
            this.lblDuiM.Text = "DUI del miembro:";
            // 
            // MskDui
            // 
            this.MskDui.Location = new System.Drawing.Point(27, 197);
            this.MskDui.Mask = "00000000-0";
            this.MskDui.Name = "MskDui";
            this.MskDui.Size = new System.Drawing.Size(183, 23);
            this.MskDui.TabIndex = 3;
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(24, 96);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(143, 17);
            this.lblApellidoM.TabIndex = 4;
            this.lblApellidoM.Text = "Apellido del miembro:";
            // 
            // TxtApellidoM
            // 
            this.TxtApellidoM.Location = new System.Drawing.Point(27, 125);
            this.TxtApellidoM.Name = "TxtApellidoM";
            this.TxtApellidoM.Size = new System.Drawing.Size(183, 23);
            this.TxtApellidoM.TabIndex = 2;
            // 
            // TxtNombreM
            // 
            this.TxtNombreM.Location = new System.Drawing.Point(27, 56);
            this.TxtNombreM.Name = "TxtNombreM";
            this.TxtNombreM.Size = new System.Drawing.Size(183, 23);
            this.TxtNombreM.TabIndex = 1;
            // 
            // lblNombreMiembro
            // 
            this.lblNombreMiembro.AutoSize = true;
            this.lblNombreMiembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMiembro.Location = new System.Drawing.Point(24, 25);
            this.lblNombreMiembro.Name = "lblNombreMiembro";
            this.lblNombreMiembro.Size = new System.Drawing.Size(143, 17);
            this.lblNombreMiembro.TabIndex = 1;
            this.lblNombreMiembro.Text = "Nombre del miembro:";
            // 
            // txtbuscador
            // 
            this.txtbuscador.Location = new System.Drawing.Point(526, 56);
            this.txtbuscador.Name = "txtbuscador";
            this.txtbuscador.Size = new System.Drawing.Size(190, 23);
            this.txtbuscador.TabIndex = 29;
            // 
            // FrmMiembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 548);
            this.Name = "FrmMiembros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMiembrosUser";
            this.Load += new System.EventHandler(this.FrmMiembros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GrpMiembros.ResumeLayout(false);
            this.GrpMiembros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMiembros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GrpMiembros;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.TextBox TxtApellidoM;
        private System.Windows.Forms.TextBox TxtNombreM;
        private System.Windows.Forms.Label lblNombreMiembro;
        private System.Windows.Forms.Label lblDuiM;
        private System.Windows.Forms.MaskedTextBox MskDui;
        private System.Windows.Forms.Label lblFechaNM;
        private System.Windows.Forms.ComboBox CmbEstadoM;
        private System.Windows.Forms.Label lblEstadoM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDireccionM;
        private System.Windows.Forms.TextBox TxtDireccionM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRefrescarM;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnActualizarM;
        private System.Windows.Forms.Button BtnAgregarM;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.MaskedTextBox MskTelefonoM;
        private System.Windows.Forms.TextBox TxtCorreoM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIdM;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvMiembros;
        private System.Windows.Forms.DateTimePicker DateTPFNM;
        private System.Windows.Forms.TextBox txtbuscador;
    }
}