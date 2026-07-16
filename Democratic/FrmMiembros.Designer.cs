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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelMiembro = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.GrpMiembros = new System.Windows.Forms.GroupBox();
            this.CmbCV = new System.Windows.Forms.ComboBox();
            this.lblCV = new System.Windows.Forms.Label();
            this.CmbJRV = new System.Windows.Forms.ComboBox();
            this.lblJRV = new System.Windows.Forms.Label();
            this.PbMiembro = new System.Windows.Forms.PictureBox();
            this.BtnCargarImageP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbuscador = new System.Windows.Forms.TextBox();
            this.DateTPFNM = new System.Windows.Forms.DateTimePicker();
            this.DgvMiembros = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TxtIdM = new System.Windows.Forms.TextBox();
            this.TxtOCR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTelefonoM = new System.Windows.Forms.MaskedTextBox();
            this.BtnRefrescarM = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnActualizarM = new System.Windows.Forms.Button();
            this.BtnAgregarM = new System.Windows.Forms.Button();
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
            this.PanelMiembro.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.GrpMiembros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMiembro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMiembros)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMiembro
            // 
            this.PanelMiembro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMiembro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.PanelMiembro.Controls.Add(this.toolStrip1);
            this.PanelMiembro.Controls.Add(this.GrpMiembros);
            this.PanelMiembro.Location = new System.Drawing.Point(0, 0);
            this.PanelMiembro.MaximumSize = new System.Drawing.Size(1300, 730);
            this.PanelMiembro.MinimumSize = new System.Drawing.Size(800, 600);
            this.PanelMiembro.Name = "PanelMiembro";
            this.PanelMiembro.Size = new System.Drawing.Size(800, 623);
            this.PanelMiembro.TabIndex = 0;
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
            this.BtnMinimizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.Image = global::Democratic.Properties.Resources.expand_arrow_64px;
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(148, 22);
            this.BtnMinimizar.Text = "Minimizar Formulario";
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // GrpMiembros
            // 
            this.GrpMiembros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpMiembros.BackColor = System.Drawing.Color.Transparent;
            this.GrpMiembros.Controls.Add(this.CmbCV);
            this.GrpMiembros.Controls.Add(this.lblCV);
            this.GrpMiembros.Controls.Add(this.CmbJRV);
            this.GrpMiembros.Controls.Add(this.lblJRV);
            this.GrpMiembros.Controls.Add(this.PbMiembro);
            this.GrpMiembros.Controls.Add(this.BtnCargarImageP);
            this.GrpMiembros.Controls.Add(this.pictureBox1);
            this.GrpMiembros.Controls.Add(this.txtbuscador);
            this.GrpMiembros.Controls.Add(this.DateTPFNM);
            this.GrpMiembros.Controls.Add(this.DgvMiembros);
            this.GrpMiembros.Controls.Add(this.TxtIdM);
            this.GrpMiembros.Controls.Add(this.TxtOCR);
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
            this.GrpMiembros.Size = new System.Drawing.Size(776, 583);
            this.GrpMiembros.TabIndex = 0;
            this.GrpMiembros.TabStop = false;
            this.GrpMiembros.Text = "Participantes";
            // 
            // CmbCV
            // 
            this.CmbCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCV.FormattingEnabled = true;
            this.CmbCV.Location = new System.Drawing.Point(290, 217);
            this.CmbCV.Name = "CmbCV";
            this.CmbCV.Size = new System.Drawing.Size(183, 25);
            this.CmbCV.TabIndex = 8;
            // 
            // lblCV
            // 
            this.lblCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCV.AutoSize = true;
            this.lblCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV.Location = new System.Drawing.Point(287, 197);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(141, 17);
            this.lblCV.TabIndex = 57;
            this.lblCV.Text = "Sede de votación:";
            // 
            // CmbJRV
            // 
            this.CmbJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbJRV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbJRV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbJRV.FormattingEnabled = true;
            this.CmbJRV.Location = new System.Drawing.Point(290, 273);
            this.CmbJRV.Name = "CmbJRV";
            this.CmbJRV.Size = new System.Drawing.Size(183, 25);
            this.CmbJRV.TabIndex = 9;
            // 
            // lblJRV
            // 
            this.lblJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJRV.AutoSize = true;
            this.lblJRV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJRV.Location = new System.Drawing.Point(287, 253);
            this.lblJRV.Name = "lblJRV";
            this.lblJRV.Size = new System.Drawing.Size(177, 17);
            this.lblJRV.TabIndex = 55;
            this.lblJRV.Text = "Mesa de votación:";
            // 
            // PbMiembro
            // 
            this.PbMiembro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PbMiembro.Location = new System.Drawing.Point(559, 74);
            this.PbMiembro.Name = "PbMiembro";
            this.PbMiembro.Size = new System.Drawing.Size(132, 140);
            this.PbMiembro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMiembro.TabIndex = 52;
            this.PbMiembro.TabStop = false;
            // 
            // BtnCargarImageP
            // 
            this.BtnCargarImageP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCargarImageP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnCargarImageP.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCargarImageP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnCargarImageP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnCargarImageP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarImageP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarImageP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCargarImageP.Location = new System.Drawing.Point(559, 220);
            this.BtnCargarImageP.Name = "BtnCargarImageP";
            this.BtnCargarImageP.Size = new System.Drawing.Size(132, 35);
            this.BtnCargarImageP.TabIndex = 11;
            this.BtnCargarImageP.Text = "Cargar Imagen";
            this.BtnCargarImageP.UseVisualStyleBackColor = false;
            this.BtnCargarImageP.Click += new System.EventHandler(this.BtnCargarImageP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Democratic.Properties.Resources.search_48px;
            this.pictureBox1.Location = new System.Drawing.Point(687, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtbuscador
            // 
            this.txtbuscador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbuscador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscador.Location = new System.Drawing.Point(526, 45);
            this.txtbuscador.Name = "txtbuscador";
            this.txtbuscador.Size = new System.Drawing.Size(165, 23);
            this.txtbuscador.TabIndex = 16;
            // 
            // DateTPFNM
            // 
            this.DateTPFNM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTPFNM.CustomFormat = "yyyy-MM-dd";
            this.DateTPFNM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTPFNM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTPFNM.Location = new System.Drawing.Point(27, 271);
            this.DateTPFNM.Name = "DateTPFNM";
            this.DateTPFNM.Size = new System.Drawing.Size(183, 23);
            this.DateTPFNM.TabIndex = 5;
            this.DateTPFNM.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            // 
            // DgvMiembros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvMiembros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMiembros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.DgvMiembros.Location = new System.Drawing.Point(6, 378);
            this.DgvMiembros.Name = "DgvMiembros";
            this.DgvMiembros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvMiembros.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvMiembros.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvMiembros.Size = new System.Drawing.Size(764, 187);
            this.DgvMiembros.TabIndex = 28;
            this.DgvMiembros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMiembros_CellClick_1);
            this.DgvMiembros.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvMiembros_CellFormatting);
            // 
            // TxtIdM
            // 
            this.TxtIdM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIdM.Enabled = false;
            this.TxtIdM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdM.Location = new System.Drawing.Point(742, 9);
            this.TxtIdM.Name = "TxtIdM";
            this.TxtIdM.ReadOnly = true;
            this.TxtIdM.Size = new System.Drawing.Size(34, 23);
            this.TxtIdM.TabIndex = 27;
            // 
            // TxtOCR
            // 
            this.TxtOCR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtOCR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOCR.Location = new System.Drawing.Point(27, 217);
            this.TxtOCR.Name = "TxtOCR";
            this.TxtOCR.Size = new System.Drawing.Size(225, 23);
            this.TxtOCR.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Código OCR:";
            // 
            // MskTelefonoM
            // 
            this.MskTelefonoM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MskTelefonoM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTelefonoM.Location = new System.Drawing.Point(27, 332);
            this.MskTelefonoM.Mask = "0000-0000";
            this.MskTelefonoM.Name = "MskTelefonoM";
            this.MskTelefonoM.Size = new System.Drawing.Size(180, 23);
            this.MskTelefonoM.TabIndex = 6;
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
            this.BtnRefrescarM.Location = new System.Drawing.Point(635, 323);
            this.BtnRefrescarM.Name = "BtnRefrescarM";
            this.BtnRefrescarM.Size = new System.Drawing.Size(135, 40);
            this.BtnRefrescarM.TabIndex = 15;
            this.BtnRefrescarM.Text = "Refrescar";
            this.BtnRefrescarM.UseVisualStyleBackColor = false;
            this.BtnRefrescarM.Click += new System.EventHandler(this.BtnRefrescarM_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLimpiar.Location = new System.Drawing.Point(494, 323);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(135, 40);
            this.BtnLimpiar.TabIndex = 13;
            this.BtnLimpiar.Text = "Limpiar Campos";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnActualizarM
            // 
            this.BtnActualizarM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnActualizarM.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnActualizarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnActualizarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualizarM.Location = new System.Drawing.Point(635, 267);
            this.BtnActualizarM.Name = "BtnActualizarM";
            this.BtnActualizarM.Size = new System.Drawing.Size(135, 40);
            this.BtnActualizarM.TabIndex = 14;
            this.BtnActualizarM.Text = "Actualizar participante";
            this.BtnActualizarM.UseVisualStyleBackColor = false;
            this.BtnActualizarM.Click += new System.EventHandler(this.BtnActualizarM_Click);
            // 
            // BtnAgregarM
            // 
            this.BtnAgregarM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgregarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnAgregarM.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregarM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnAgregarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregarM.Location = new System.Drawing.Point(494, 267);
            this.BtnAgregarM.Name = "BtnAgregarM";
            this.BtnAgregarM.Size = new System.Drawing.Size(135, 40);
            this.BtnAgregarM.TabIndex = 12;
            this.BtnAgregarM.Text = "Agregar participante";
            this.BtnAgregarM.UseVisualStyleBackColor = false;
            this.BtnAgregarM.Click += new System.EventHandler(this.BtnAgregarM_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar participantes por N° DUI:";
            // 
            // CmbEstadoM
            // 
            this.CmbEstadoM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbEstadoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstadoM.FormattingEnabled = true;
            this.CmbEstadoM.Location = new System.Drawing.Point(290, 330);
            this.CmbEstadoM.Name = "CmbEstadoM";
            this.CmbEstadoM.Size = new System.Drawing.Size(183, 25);
            this.CmbEstadoM.TabIndex = 10;
            this.CmbEstadoM.Click += new System.EventHandler(this.CmbEstadoM_Click);
            // 
            // lblEstadoM
            // 
            this.lblEstadoM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstadoM.AutoSize = true;
            this.lblEstadoM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoM.Location = new System.Drawing.Point(287, 310);
            this.lblEstadoM.Name = "lblEstadoM";
            this.lblEstadoM.Size = new System.Drawing.Size(141, 17);
            this.lblEstadoM.TabIndex = 14;
            this.lblEstadoM.Text = "Estado del participante:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Teléfono del participante:";
            // 
            // lblDireccionM
            // 
            this.lblDireccionM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDireccionM.AutoSize = true;
            this.lblDireccionM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionM.Location = new System.Drawing.Point(287, 30);
            this.lblDireccionM.Name = "lblDireccionM";
            this.lblDireccionM.Size = new System.Drawing.Size(160, 17);
            this.lblDireccionM.TabIndex = 11;
            this.lblDireccionM.Text = "Dirección del participante:";
            // 
            // TxtDireccionM
            // 
            this.TxtDireccionM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtDireccionM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionM.Location = new System.Drawing.Point(290, 54);
            this.TxtDireccionM.Multiline = true;
            this.TxtDireccionM.Name = "TxtDireccionM";
            this.TxtDireccionM.Size = new System.Drawing.Size(183, 123);
            this.TxtDireccionM.TabIndex = 7;
            // 
            // lblFechaNM
            // 
            this.lblFechaNM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFechaNM.AutoSize = true;
            this.lblFechaNM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNM.Location = new System.Drawing.Point(24, 250);
            this.lblFechaNM.Name = "lblFechaNM";
            this.lblFechaNM.Size = new System.Drawing.Size(152, 17);
            this.lblFechaNM.TabIndex = 9;
            this.lblFechaNM.Text = "Fecha de Nacimiento:";
            // 
            // lblDuiM
            // 
            this.lblDuiM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDuiM.AutoSize = true;
            this.lblDuiM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuiM.Location = new System.Drawing.Point(24, 132);
            this.lblDuiM.Name = "lblDuiM";
            this.lblDuiM.Size = new System.Drawing.Size(120, 17);
            this.lblDuiM.TabIndex = 6;
            this.lblDuiM.Text = "DUI del participante:";
            // 
            // MskDui
            // 
            this.MskDui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MskDui.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskDui.Location = new System.Drawing.Point(27, 154);
            this.MskDui.Mask = "00000000-0";
            this.MskDui.Name = "MskDui";
            this.MskDui.Size = new System.Drawing.Size(183, 23);
            this.MskDui.TabIndex = 3;
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoM.Location = new System.Drawing.Point(24, 74);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(152, 17);
            this.lblApellidoM.TabIndex = 4;
            this.lblApellidoM.Text = "Apellido del participante:";
            // 
            // TxtApellidoM
            // 
            this.TxtApellidoM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtApellidoM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidoM.Location = new System.Drawing.Point(27, 96);
            this.TxtApellidoM.Name = "TxtApellidoM";
            this.TxtApellidoM.Size = new System.Drawing.Size(183, 23);
            this.TxtApellidoM.TabIndex = 2;
            this.TxtApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoM_KeyPress);
            // 
            // TxtNombreM
            // 
            this.TxtNombreM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNombreM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreM.Location = new System.Drawing.Point(27, 45);
            this.TxtNombreM.Name = "TxtNombreM";
            this.TxtNombreM.Size = new System.Drawing.Size(183, 23);
            this.TxtNombreM.TabIndex = 1;
            this.TxtNombreM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreM_KeyPress);
            // 
            // lblNombreMiembro
            // 
            this.lblNombreMiembro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreMiembro.AutoSize = true;
            this.lblNombreMiembro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMiembro.Location = new System.Drawing.Point(24, 25);
            this.lblNombreMiembro.Name = "lblNombreMiembro";
            this.lblNombreMiembro.Size = new System.Drawing.Size(152, 17);
            this.lblNombreMiembro.TabIndex = 1;
            this.lblNombreMiembro.Text = "Nombre del participante:";
            // 
            // FrmMiembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.PanelMiembro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 548);
            this.Name = "FrmMiembros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Participantes";
            this.Load += new System.EventHandler(this.FrmMiembros_Load);
            this.PanelMiembro.ResumeLayout(false);
            this.PanelMiembro.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GrpMiembros.ResumeLayout(false);
            this.GrpMiembros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMiembro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMiembros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMiembro;
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
        private System.Windows.Forms.TextBox TxtOCR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIdM;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvMiembros;
        private System.Windows.Forms.DateTimePicker DateTPFNM;
        private System.Windows.Forms.TextBox txtbuscador;
        private System.Windows.Forms.PictureBox PbMiembro;
        private System.Windows.Forms.Button BtnCargarImageP;
        private System.Windows.Forms.ComboBox CmbCV;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.ComboBox CmbJRV;
        private System.Windows.Forms.Label lblJRV;
    }
}