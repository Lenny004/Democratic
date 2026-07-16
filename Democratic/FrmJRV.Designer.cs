namespace Democratic
{
    partial class FrmJRV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJRV));
            this.PanelJRV = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvJRV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.BtnEliminarJRV = new System.Windows.Forms.Button();
            this.BtnRefrescarJRV = new System.Windows.Forms.Button();
            this.BtnLimpiarJRV = new System.Windows.Forms.Button();
            this.BtnActualizarJRV = new System.Windows.Forms.Button();
            this.BtnIngresarJRV = new System.Windows.Forms.Button();
            this.PictureLupa = new System.Windows.Forms.PictureBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.LblEstadoJRV = new System.Windows.Forms.Label();
            this.LblCV = new System.Windows.Forms.Label();
            this.CmbEstadoJRV = new System.Windows.Forms.ComboBox();
            this.lblcorrelativo = new System.Windows.Forms.Label();
            this.CmbCentroV = new System.Windows.Forms.ComboBox();
            this.txtIdJRV = new System.Windows.Forms.TextBox();
            this.TxtCorrelativo = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.PanelJRV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJRV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelJRV
            // 
            this.PanelJRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.PanelJRV.Controls.Add(this.groupBox1);
            this.PanelJRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelJRV.Location = new System.Drawing.Point(0, 0);
            this.PanelJRV.Name = "PanelJRV";
            this.PanelJRV.Size = new System.Drawing.Size(800, 623);
            this.PanelJRV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DgvJRV);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.BtnEliminarJRV);
            this.groupBox1.Controls.Add(this.BtnRefrescarJRV);
            this.groupBox1.Controls.Add(this.BtnLimpiarJRV);
            this.groupBox1.Controls.Add(this.BtnActualizarJRV);
            this.groupBox1.Controls.Add(this.BtnIngresarJRV);
            this.groupBox1.Controls.Add(this.PictureLupa);
            this.groupBox1.Controls.Add(this.lblBuscar);
            this.groupBox1.Controls.Add(this.LblEstadoJRV);
            this.groupBox1.Controls.Add(this.LblCV);
            this.groupBox1.Controls.Add(this.CmbEstadoJRV);
            this.groupBox1.Controls.Add(this.lblcorrelativo);
            this.groupBox1.Controls.Add(this.CmbCentroV);
            this.groupBox1.Controls.Add(this.txtIdJRV);
            this.groupBox1.Controls.Add(this.TxtCorrelativo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 583);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesas de votación";
            // 
            // DgvJRV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvJRV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvJRV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvJRV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvJRV.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DgvJRV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvJRV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvJRV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvJRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJRV.DoubleBuffered = true;
            this.DgvJRV.EnableHeadersVisualStyles = false;
            this.DgvJRV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            this.DgvJRV.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DgvJRV.Location = new System.Drawing.Point(6, 281);
            this.DgvJRV.Name = "DgvJRV";
            this.DgvJRV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvJRV.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvJRV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvJRV.Size = new System.Drawing.Size(764, 283);
            this.DgvJRV.TabIndex = 36;
            this.DgvJRV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJRV_CellClick);
            this.DgvJRV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvJRV_CellFormatting);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqueda.BackColor = System.Drawing.Color.LightGray;
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(414, 50);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(167, 23);
            this.txtBusqueda.TabIndex = 35;
            // 
            // BtnEliminarJRV
            // 
            this.BtnEliminarJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminarJRV.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarJRV.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminarJRV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEliminarJRV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminarJRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarJRV.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.BtnEliminarJRV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEliminarJRV.Location = new System.Drawing.Point(591, 222);
            this.BtnEliminarJRV.Name = "BtnEliminarJRV";
            this.BtnEliminarJRV.Size = new System.Drawing.Size(167, 40);
            this.BtnEliminarJRV.TabIndex = 32;
            this.BtnEliminarJRV.Text = "Eliminar mesa";
            this.BtnEliminarJRV.UseVisualStyleBackColor = false;
            this.BtnEliminarJRV.Click += new System.EventHandler(this.BtnEliminarJRV_Click);
            // 
            // BtnRefrescarJRV
            // 
            this.BtnRefrescarJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRefrescarJRV.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRefrescarJRV.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefrescarJRV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRefrescarJRV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnRefrescarJRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescarJRV.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.BtnRefrescarJRV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefrescarJRV.Location = new System.Drawing.Point(591, 162);
            this.BtnRefrescarJRV.Name = "BtnRefrescarJRV";
            this.BtnRefrescarJRV.Size = new System.Drawing.Size(167, 40);
            this.BtnRefrescarJRV.TabIndex = 31;
            this.BtnRefrescarJRV.Text = "Refrescar";
            this.BtnRefrescarJRV.UseVisualStyleBackColor = false;
            this.BtnRefrescarJRV.Click += new System.EventHandler(this.BtnRefrescarJRV_Click);
            // 
            // BtnLimpiarJRV
            // 
            this.BtnLimpiarJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLimpiarJRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnLimpiarJRV.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLimpiarJRV.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiarJRV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnLimpiarJRV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiarJRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarJRV.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.BtnLimpiarJRV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLimpiarJRV.Location = new System.Drawing.Point(414, 222);
            this.BtnLimpiarJRV.Name = "BtnLimpiarJRV";
            this.BtnLimpiarJRV.Size = new System.Drawing.Size(167, 40);
            this.BtnLimpiarJRV.TabIndex = 30;
            this.BtnLimpiarJRV.Text = "Limpiar Campos";
            this.BtnLimpiarJRV.UseVisualStyleBackColor = false;
            this.BtnLimpiarJRV.Click += new System.EventHandler(this.BtnLimpiarJRV_Click);
            // 
            // BtnActualizarJRV
            // 
            this.BtnActualizarJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizarJRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnActualizarJRV.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarJRV.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnActualizarJRV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnActualizarJRV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizarJRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarJRV.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.BtnActualizarJRV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualizarJRV.Location = new System.Drawing.Point(414, 162);
            this.BtnActualizarJRV.Name = "BtnActualizarJRV";
            this.BtnActualizarJRV.Size = new System.Drawing.Size(167, 40);
            this.BtnActualizarJRV.TabIndex = 29;
            this.BtnActualizarJRV.Text = "Actualizar mesa\r\n";
            this.BtnActualizarJRV.UseVisualStyleBackColor = false;
            this.BtnActualizarJRV.Click += new System.EventHandler(this.BtnActualizarJRV_Click);
            // 
            // BtnIngresarJRV
            // 
            this.BtnIngresarJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnIngresarJRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnIngresarJRV.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnIngresarJRV.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnIngresarJRV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnIngresarJRV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnIngresarJRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresarJRV.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.BtnIngresarJRV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnIngresarJRV.Location = new System.Drawing.Point(414, 105);
            this.BtnIngresarJRV.Name = "BtnIngresarJRV";
            this.BtnIngresarJRV.Size = new System.Drawing.Size(167, 40);
            this.BtnIngresarJRV.TabIndex = 28;
            this.BtnIngresarJRV.Text = "Agregar mesa\r\n";
            this.BtnIngresarJRV.UseVisualStyleBackColor = false;
            this.BtnIngresarJRV.Click += new System.EventHandler(this.BtnIngresarJRV_Click_1);
            // 
            // PictureLupa
            // 
            this.PictureLupa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureLupa.Image = global::Democratic.Properties.Resources.search_48px;
            this.PictureLupa.Location = new System.Drawing.Point(579, 50);
            this.PictureLupa.Name = "PictureLupa";
            this.PictureLupa.Size = new System.Drawing.Size(27, 23);
            this.PictureLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLupa.TabIndex = 34;
            this.PictureLupa.TabStop = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(411, 22);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(227, 17);
            this.lblBuscar.TabIndex = 33;
            this.lblBuscar.Text = "Buscar mesa de votación:";
            // 
            // LblEstadoJRV
            // 
            this.LblEstadoJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblEstadoJRV.AutoSize = true;
            this.LblEstadoJRV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstadoJRV.Location = new System.Drawing.Point(15, 166);
            this.LblEstadoJRV.Name = "LblEstadoJRV";
            this.LblEstadoJRV.Size = new System.Drawing.Size(120, 17);
            this.LblEstadoJRV.TabIndex = 24;
            this.LblEstadoJRV.Text = "Estado de la mesa:";
            // 
            // LblCV
            // 
            this.LblCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblCV.AutoSize = true;
            this.LblCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCV.Location = new System.Drawing.Point(15, 94);
            this.LblCV.Name = "LblCV";
            this.LblCV.Size = new System.Drawing.Size(142, 17);
            this.LblCV.TabIndex = 24;
            this.LblCV.Text = "Sede de votación:";
            // 
            // CmbEstadoJRV
            // 
            this.CmbEstadoJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbEstadoJRV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoJRV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstadoJRV.FormattingEnabled = true;
            this.CmbEstadoJRV.Location = new System.Drawing.Point(15, 198);
            this.CmbEstadoJRV.Name = "CmbEstadoJRV";
            this.CmbEstadoJRV.Size = new System.Drawing.Size(218, 25);
            this.CmbEstadoJRV.TabIndex = 27;
            this.CmbEstadoJRV.Click += new System.EventHandler(this.CmbEstadoJRV_Click);
            // 
            // lblcorrelativo
            // 
            this.lblcorrelativo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcorrelativo.AutoSize = true;
            this.lblcorrelativo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorrelativo.Location = new System.Drawing.Point(15, 22);
            this.lblcorrelativo.Name = "lblcorrelativo";
            this.lblcorrelativo.Size = new System.Drawing.Size(153, 17);
            this.lblcorrelativo.TabIndex = 25;
            this.lblcorrelativo.Text = "Correlativo de la mesa: ";
            // 
            // CmbCentroV
            // 
            this.CmbCentroV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbCentroV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCentroV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCentroV.FormattingEnabled = true;
            this.CmbCentroV.Location = new System.Drawing.Point(15, 122);
            this.CmbCentroV.Name = "CmbCentroV";
            this.CmbCentroV.Size = new System.Drawing.Size(344, 25);
            this.CmbCentroV.TabIndex = 26;
            this.CmbCentroV.Click += new System.EventHandler(this.CmbCentroV_Click);
            // 
            // txtIdJRV
            // 
            this.txtIdJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdJRV.Enabled = false;
            this.txtIdJRV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdJRV.Location = new System.Drawing.Point(15, 239);
            this.txtIdJRV.Name = "txtIdJRV";
            this.txtIdJRV.ReadOnly = true;
            this.txtIdJRV.Size = new System.Drawing.Size(30, 23);
            this.txtIdJRV.TabIndex = 24;
            // 
            // TxtCorrelativo
            // 
            this.TxtCorrelativo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtCorrelativo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorrelativo.Location = new System.Drawing.Point(15, 50);
            this.TxtCorrelativo.Name = "TxtCorrelativo";
            this.TxtCorrelativo.Size = new System.Drawing.Size(344, 23);
            this.TxtCorrelativo.TabIndex = 14;
            this.TxtCorrelativo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCorrelativo_KeyPress);
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
            this.BtnMinimizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.Image = global::Democratic.Properties.Resources.expand_arrow_64px1;
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(148, 22);
            this.BtnMinimizar.Text = "Minimizar Formulario";
            // 
            // FrmJRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PanelJRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmJRV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesas de votación";
            this.Load += new System.EventHandler(this.FrmJRV_Load);
            this.PanelJRV.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJRV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelJRV;
        private System.Windows.Forms.Label LblCV;
        private System.Windows.Forms.Label LblEstadoJRV;
        private System.Windows.Forms.ComboBox CmbEstadoJRV;
        private System.Windows.Forms.ComboBox CmbCentroV;
        private System.Windows.Forms.Label lblcorrelativo;
        private System.Windows.Forms.TextBox txtIdJRV;
        private System.Windows.Forms.TextBox TxtCorrelativo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button BtnEliminarJRV;
        private System.Windows.Forms.Button BtnRefrescarJRV;
        private System.Windows.Forms.Button BtnLimpiarJRV;
        private System.Windows.Forms.Button BtnActualizarJRV;
        private System.Windows.Forms.Button BtnIngresarJRV;
        private System.Windows.Forms.PictureBox PictureLupa;
        private System.Windows.Forms.Label lblBuscar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvJRV;
    }
}