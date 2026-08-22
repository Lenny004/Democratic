namespace Democratic
{
    partial class FrmCV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCV));
            this.GRPCV = new System.Windows.Forms.GroupBox();
            this.lblTribunal = new System.Windows.Forms.Label();
            this.CmbTribunal = new System.Windows.Forms.ComboBox();
            this.BtnEliminarCV = new System.Windows.Forms.Button();
            this.BtnRefrescarCV = new System.Windows.Forms.Button();
            this.BtnLimpiarCV = new System.Windows.Forms.Button();
            this.BtnActualizarCV = new System.Windows.Forms.Button();
            this.BtnIngresarCV = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.PictureLupa = new System.Windows.Forms.PictureBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.DgvCV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.CmbActa = new System.Windows.Forms.ComboBox();
            this.txtIdCV = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.CmbMunicipio = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblCantidadBoleta = new System.Windows.Forms.Label();
            this.lblCantidadJRV = new System.Windows.Forms.Label();
            this.CmbEstadoCV = new System.Windows.Forms.ComboBox();
            this.lblCV = new System.Windows.Forms.Label();
            this.TxtCantidadJRV = new System.Windows.Forms.TextBox();
            this.txtNombreCV = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.PanelCV = new System.Windows.Forms.Panel();
            this.GRPCV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.PanelCV.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRPCV
            // 
            this.GRPCV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GRPCV.Controls.Add(this.lblTribunal);
            this.GRPCV.Controls.Add(this.CmbTribunal);
            this.GRPCV.Controls.Add(this.BtnEliminarCV);
            this.GRPCV.Controls.Add(this.BtnRefrescarCV);
            this.GRPCV.Controls.Add(this.BtnLimpiarCV);
            this.GRPCV.Controls.Add(this.BtnActualizarCV);
            this.GRPCV.Controls.Add(this.BtnIngresarCV);
            this.GRPCV.Controls.Add(this.txtBusqueda);
            this.GRPCV.Controls.Add(this.PictureLupa);
            this.GRPCV.Controls.Add(this.lblBuscar);
            this.GRPCV.Controls.Add(this.DgvCV);
            this.GRPCV.Controls.Add(this.CmbActa);
            this.GRPCV.Controls.Add(this.txtIdCV);
            this.GRPCV.Controls.Add(this.lblMunicipio);
            this.GRPCV.Controls.Add(this.CmbMunicipio);
            this.GRPCV.Controls.Add(this.lblestado);
            this.GRPCV.Controls.Add(this.lblCantidadBoleta);
            this.GRPCV.Controls.Add(this.lblCantidadJRV);
            this.GRPCV.Controls.Add(this.CmbEstadoCV);
            this.GRPCV.Controls.Add(this.lblCV);
            this.GRPCV.Controls.Add(this.TxtCantidadJRV);
            this.GRPCV.Controls.Add(this.txtNombreCV);
            this.GRPCV.Location = new System.Drawing.Point(12, 3);
            this.GRPCV.Name = "GRPCV";
            this.GRPCV.Size = new System.Drawing.Size(776, 583);
            this.GRPCV.TabIndex = 2;
            this.GRPCV.TabStop = false;
            this.GRPCV.Text = "Sedes de votación";
            // 
            // lblTribunal
            // 
            this.lblTribunal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTribunal.AutoSize = true;
            this.lblTribunal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTribunal.Location = new System.Drawing.Point(194, 221);
            this.lblTribunal.Name = "lblTribunal";
            this.lblTribunal.Size = new System.Drawing.Size(61, 17);
            this.lblTribunal.TabIndex = 47;
            this.lblTribunal.Text = "Organización:";
            // 
            // CmbTribunal
            // 
            this.CmbTribunal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbTribunal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTribunal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTribunal.FormattingEnabled = true;
            this.CmbTribunal.Location = new System.Drawing.Point(197, 244);
            this.CmbTribunal.Name = "CmbTribunal";
            this.CmbTribunal.Size = new System.Drawing.Size(145, 25);
            this.CmbTribunal.TabIndex = 46;
            this.CmbTribunal.Click += new System.EventHandler(this.CmbTribunal_Click);
            // 
            // BtnEliminarCV
            // 
            this.BtnEliminarCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminarCV.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarCV.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminarCV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEliminarCV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminarCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEliminarCV.Location = new System.Drawing.Point(589, 226);
            this.BtnEliminarCV.Name = "BtnEliminarCV";
            this.BtnEliminarCV.Size = new System.Drawing.Size(167, 40);
            this.BtnEliminarCV.TabIndex = 45;
            this.BtnEliminarCV.Text = "Eliminar sede";
            this.BtnEliminarCV.UseVisualStyleBackColor = false;
            this.BtnEliminarCV.Click += new System.EventHandler(this.BtnEliminarCV_Click);
            // 
            // BtnRefrescarCV
            // 
            this.BtnRefrescarCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRefrescarCV.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRefrescarCV.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefrescarCV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRefrescarCV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnRefrescarCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescarCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefrescarCV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefrescarCV.Location = new System.Drawing.Point(589, 166);
            this.BtnRefrescarCV.Name = "BtnRefrescarCV";
            this.BtnRefrescarCV.Size = new System.Drawing.Size(167, 40);
            this.BtnRefrescarCV.TabIndex = 44;
            this.BtnRefrescarCV.Text = "Refrescar";
            this.BtnRefrescarCV.UseVisualStyleBackColor = false;
            this.BtnRefrescarCV.Click += new System.EventHandler(this.BtnRefrescarCV_Click);
            // 
            // BtnLimpiarCV
            // 
            this.BtnLimpiarCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLimpiarCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnLimpiarCV.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLimpiarCV.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiarCV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnLimpiarCV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiarCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarCV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLimpiarCV.Location = new System.Drawing.Point(403, 226);
            this.BtnLimpiarCV.Name = "BtnLimpiarCV";
            this.BtnLimpiarCV.Size = new System.Drawing.Size(167, 40);
            this.BtnLimpiarCV.TabIndex = 43;
            this.BtnLimpiarCV.Text = "Limpiar Campos";
            this.BtnLimpiarCV.UseVisualStyleBackColor = false;
            this.BtnLimpiarCV.Click += new System.EventHandler(this.BtnLimpiarCV_Click);
            // 
            // BtnActualizarCV
            // 
            this.BtnActualizarCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizarCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnActualizarCV.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarCV.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnActualizarCV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnActualizarCV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizarCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarCV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualizarCV.Location = new System.Drawing.Point(403, 166);
            this.BtnActualizarCV.Name = "BtnActualizarCV";
            this.BtnActualizarCV.Size = new System.Drawing.Size(167, 40);
            this.BtnActualizarCV.TabIndex = 42;
            this.BtnActualizarCV.Text = "Actualizar sede";
            this.BtnActualizarCV.UseVisualStyleBackColor = false;
            this.BtnActualizarCV.Click += new System.EventHandler(this.BtnActualizarCV_Click);
            // 
            // BtnIngresarCV
            // 
            this.BtnIngresarCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnIngresarCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnIngresarCV.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnIngresarCV.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnIngresarCV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnIngresarCV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnIngresarCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresarCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresarCV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnIngresarCV.Location = new System.Drawing.Point(403, 104);
            this.BtnIngresarCV.Name = "BtnIngresarCV";
            this.BtnIngresarCV.Size = new System.Drawing.Size(167, 40);
            this.BtnIngresarCV.TabIndex = 41;
            this.BtnIngresarCV.Text = "Agregar sede\n";
            this.BtnIngresarCV.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqueda.BackColor = System.Drawing.Color.LightGray;
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(386, 43);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(167, 26);
            this.txtBusqueda.TabIndex = 40;
            // 
            // PictureLupa
            // 
            this.PictureLupa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureLupa.Image = global::Democratic.Properties.Resources.search_48px;
            this.PictureLupa.Location = new System.Drawing.Point(554, 43);
            this.PictureLupa.Name = "PictureLupa";
            this.PictureLupa.Size = new System.Drawing.Size(27, 26);
            this.PictureLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLupa.TabIndex = 39;
            this.PictureLupa.TabStop = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(383, 26);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(187, 17);
            this.lblBuscar.TabIndex = 38;
            this.lblBuscar.Text = "Buscar sede de votación:";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCV.DoubleBuffered = true;
            this.DgvCV.EnableHeadersVisualStyles = false;
            this.DgvCV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            this.DgvCV.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DgvCV.Location = new System.Drawing.Point(6, 291);
            this.DgvCV.Name = "DgvCV";
            this.DgvCV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCV.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvCV.Size = new System.Drawing.Size(764, 268);
            this.DgvCV.TabIndex = 37;
            this.DgvCV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCV_CellClick);
            this.DgvCV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvCV_CellFormatting);
            // 
            // CmbActa
            // 
            this.CmbActa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbActa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbActa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbActa.FormattingEnabled = true;
            this.CmbActa.Location = new System.Drawing.Point(197, 183);
            this.CmbActa.Name = "CmbActa";
            this.CmbActa.Size = new System.Drawing.Size(145, 25);
            this.CmbActa.TabIndex = 24;
            this.CmbActa.Click += new System.EventHandler(this.CmbActa_Click);
            // 
            // txtIdCV
            // 
            this.txtIdCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdCV.Enabled = false;
            this.txtIdCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCV.Location = new System.Drawing.Point(15, 246);
            this.txtIdCV.Name = "txtIdCV";
            this.txtIdCV.ReadOnly = true;
            this.txtIdCV.Size = new System.Drawing.Size(39, 23);
            this.txtIdCV.TabIndex = 23;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(12, 166);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(74, 17);
            this.lblMunicipio.TabIndex = 21;
            this.lblMunicipio.Text = "Municipio:";
            // 
            // CmbMunicipio
            // 
            this.CmbMunicipio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMunicipio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMunicipio.FormattingEnabled = true;
            this.CmbMunicipio.Location = new System.Drawing.Point(15, 185);
            this.CmbMunicipio.Name = "CmbMunicipio";
            this.CmbMunicipio.Size = new System.Drawing.Size(158, 25);
            this.CmbMunicipio.TabIndex = 19;
            this.CmbMunicipio.Click += new System.EventHandler(this.CmbMunicipio_Click);
            // 
            // lblestado
            // 
            this.lblestado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(194, 92);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(190, 17);
            this.lblestado.TabIndex = 20;
            this.lblestado.Text = "Estado de la sede:";
            // 
            // lblCantidadBoleta
            // 
            this.lblCantidadBoleta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCantidadBoleta.AutoSize = true;
            this.lblCantidadBoleta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadBoleta.Location = new System.Drawing.Point(194, 166);
            this.lblCantidadBoleta.Name = "lblCantidadBoleta";
            this.lblCantidadBoleta.Size = new System.Drawing.Size(146, 17);
            this.lblCantidadBoleta.TabIndex = 16;
            this.lblCantidadBoleta.Text = "Registro de escrutinio:";
            // 
            // lblCantidadJRV
            // 
            this.lblCantidadJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCantidadJRV.AutoSize = true;
            this.lblCantidadJRV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadJRV.Location = new System.Drawing.Point(12, 92);
            this.lblCantidadJRV.Name = "lblCantidadJRV";
            this.lblCantidadJRV.Size = new System.Drawing.Size(123, 17);
            this.lblCantidadJRV.TabIndex = 17;
            this.lblCantidadJRV.Text = "Cantidad de mesas:";
            // 
            // CmbEstadoCV
            // 
            this.CmbEstadoCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbEstadoCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstadoCV.FormattingEnabled = true;
            this.CmbEstadoCV.Location = new System.Drawing.Point(197, 120);
            this.CmbEstadoCV.Name = "CmbEstadoCV";
            this.CmbEstadoCV.Size = new System.Drawing.Size(145, 25);
            this.CmbEstadoCV.TabIndex = 18;
            this.CmbEstadoCV.Click += new System.EventHandler(this.CmbEstadoCV_Click);
            // 
            // lblCV
            // 
            this.lblCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCV.AutoSize = true;
            this.lblCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV.Location = new System.Drawing.Point(15, 26);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(223, 17);
            this.lblCV.TabIndex = 15;
            this.lblCV.Text = "Nombre de la sede de votación:";
            // 
            // TxtCantidadJRV
            // 
            this.TxtCantidadJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtCantidadJRV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadJRV.Location = new System.Drawing.Point(15, 120);
            this.TxtCantidadJRV.Multiline = true;
            this.TxtCantidadJRV.Name = "TxtCantidadJRV";
            this.TxtCantidadJRV.Size = new System.Drawing.Size(158, 24);
            this.TxtCantidadJRV.TabIndex = 13;
            this.TxtCantidadJRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadJRV_KeyPress);
            // 
            // txtNombreCV
            // 
            this.txtNombreCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCV.Location = new System.Drawing.Point(15, 43);
            this.txtNombreCV.Multiline = true;
            this.txtNombreCV.Name = "txtNombreCV";
            this.txtNombreCV.Size = new System.Drawing.Size(336, 26);
            this.txtNombreCV.TabIndex = 10;
            this.txtNombreCV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCV_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMinimizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
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
            // PanelCV
            // 
            this.PanelCV.Controls.Add(this.GRPCV);
            this.PanelCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCV.Location = new System.Drawing.Point(0, 25);
            this.PanelCV.Name = "PanelCV";
            this.PanelCV.Size = new System.Drawing.Size(800, 598);
            this.PanelCV.TabIndex = 4;
            // 
            // FrmCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.PanelCV);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sedes de votación";
            this.Load += new System.EventHandler(this.FrmCV_Load);
            this.GRPCV.ResumeLayout(false);
            this.GRPCV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelCV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPCV;
        private System.Windows.Forms.TextBox txtIdCV;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.ComboBox CmbMunicipio;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblCantidadBoleta;
        private System.Windows.Forms.Label lblCantidadJRV;
        private System.Windows.Forms.ComboBox CmbEstadoCV;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.TextBox TxtCantidadJRV;
        private System.Windows.Forms.TextBox txtNombreCV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.ComboBox CmbActa;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvCV;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.PictureBox PictureLupa;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button BtnEliminarCV;
        private System.Windows.Forms.Button BtnRefrescarCV;
        private System.Windows.Forms.Button BtnLimpiarCV;
        private System.Windows.Forms.Button BtnActualizarCV;
        private System.Windows.Forms.Button BtnIngresarCV;
        private System.Windows.Forms.ComboBox CmbTribunal;
        private System.Windows.Forms.Label lblTribunal;
        private System.Windows.Forms.Panel PanelCV;
    }
}