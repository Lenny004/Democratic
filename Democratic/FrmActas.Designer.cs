namespace Democratic
{
    partial class FrmActas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.PanelActas = new System.Windows.Forms.Panel();
            this.GrpActas = new System.Windows.Forms.GroupBox();
            this.Pblupa = new System.Windows.Forms.PictureBox();
            this.txtJRV = new System.Windows.Forms.TextBox();
            this.lblidjrv = new System.Windows.Forms.Label();
            this.lblJRV = new System.Windows.Forms.Label();
            this.lblCBoletas = new System.Windows.Forms.Label();
            this.CmbJRV = new System.Windows.Forms.ComboBox();
            this.txtCantidadBoletas = new System.Windows.Forms.TextBox();
            this.TxtIdActa = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.BtnEliminarActa = new System.Windows.Forms.Button();
            this.BtnRefrescarActas = new System.Windows.Forms.Button();
            this.BtnLimpiarActa = new System.Windows.Forms.Button();
            this.BtnActualizarActa = new System.Windows.Forms.Button();
            this.BtnAgregarActa = new System.Windows.Forms.Button();
            this.PictureLupa = new System.Windows.Forms.PictureBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.DgvActas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.toolStrip1.SuspendLayout();
            this.PanelActas.SuspendLayout();
            this.GrpActas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pblupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMinimizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
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
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // PanelActas
            // 
            this.PanelActas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.PanelActas.Controls.Add(this.GrpActas);
            this.PanelActas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelActas.Location = new System.Drawing.Point(0, 25);
            this.PanelActas.Name = "PanelActas";
            this.PanelActas.Size = new System.Drawing.Size(800, 598);
            this.PanelActas.TabIndex = 1;
            // 
            // GrpActas
            // 
            this.GrpActas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpActas.BackColor = System.Drawing.Color.Transparent;
            this.GrpActas.Controls.Add(this.Pblupa);
            this.GrpActas.Controls.Add(this.txtJRV);
            this.GrpActas.Controls.Add(this.lblidjrv);
            this.GrpActas.Controls.Add(this.lblJRV);
            this.GrpActas.Controls.Add(this.lblCBoletas);
            this.GrpActas.Controls.Add(this.CmbJRV);
            this.GrpActas.Controls.Add(this.txtCantidadBoletas);
            this.GrpActas.Controls.Add(this.TxtIdActa);
            this.GrpActas.Controls.Add(this.txtBusqueda);
            this.GrpActas.Controls.Add(this.BtnEliminarActa);
            this.GrpActas.Controls.Add(this.BtnRefrescarActas);
            this.GrpActas.Controls.Add(this.BtnLimpiarActa);
            this.GrpActas.Controls.Add(this.BtnActualizarActa);
            this.GrpActas.Controls.Add(this.BtnAgregarActa);
            this.GrpActas.Controls.Add(this.PictureLupa);
            this.GrpActas.Controls.Add(this.lblBuscar);
            this.GrpActas.Controls.Add(this.DgvActas);
            this.GrpActas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpActas.Location = new System.Drawing.Point(12, 16);
            this.GrpActas.Name = "GrpActas";
            this.GrpActas.Size = new System.Drawing.Size(776, 570);
            this.GrpActas.TabIndex = 0;
            this.GrpActas.TabStop = false;
            this.GrpActas.Text = "Registros de escrutinio";
            // 
            // Pblupa
            // 
            this.Pblupa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pblupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pblupa.Image = global::Democratic.Properties.Resources.search_48px;
            this.Pblupa.Location = new System.Drawing.Point(146, 190);
            this.Pblupa.Name = "Pblupa";
            this.Pblupa.Size = new System.Drawing.Size(27, 23);
            this.Pblupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pblupa.TabIndex = 51;
            this.Pblupa.TabStop = false;
            this.Pblupa.Click += new System.EventHandler(this.Pblupa_Click);
            // 
            // txtJRV
            // 
            this.txtJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtJRV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJRV.Location = new System.Drawing.Point(26, 190);
            this.txtJRV.Name = "txtJRV";
            this.txtJRV.Size = new System.Drawing.Size(120, 23);
            this.txtJRV.TabIndex = 52;
            // 
            // lblidjrv
            // 
            this.lblidjrv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblidjrv.AutoSize = true;
            this.lblidjrv.BackColor = System.Drawing.Color.Transparent;
            this.lblidjrv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidjrv.ForeColor = System.Drawing.Color.Black;
            this.lblidjrv.Location = new System.Drawing.Point(23, 149);
            this.lblidjrv.Name = "lblidjrv";
            this.lblidjrv.Size = new System.Drawing.Size(142, 34);
            this.lblidjrv.TabIndex = 50;
            this.lblidjrv.Text = "Ingrese el correlativo\r\nde la mesa:";
            // 
            // lblJRV
            // 
            this.lblJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJRV.AutoSize = true;
            this.lblJRV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJRV.Location = new System.Drawing.Point(23, 93);
            this.lblJRV.Name = "lblJRV";
            this.lblJRV.Size = new System.Drawing.Size(182, 17);
            this.lblJRV.TabIndex = 42;
            this.lblJRV.Text = "Mesa de votación:";
            // 
            // lblCBoletas
            // 
            this.lblCBoletas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCBoletas.AutoSize = true;
            this.lblCBoletas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBoletas.Location = new System.Drawing.Point(23, 19);
            this.lblCBoletas.Name = "lblCBoletas";
            this.lblCBoletas.Size = new System.Drawing.Size(146, 17);
            this.lblCBoletas.TabIndex = 41;
            this.lblCBoletas.Text = "Cantidad de votos:";
            // 
            // CmbJRV
            // 
            this.CmbJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbJRV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbJRV.Enabled = false;
            this.CmbJRV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbJRV.FormattingEnabled = true;
            this.CmbJRV.Location = new System.Drawing.Point(26, 113);
            this.CmbJRV.Name = "CmbJRV";
            this.CmbJRV.Size = new System.Drawing.Size(180, 25);
            this.CmbJRV.TabIndex = 40;
            this.CmbJRV.Click += new System.EventHandler(this.CmbJRV_Click);
            // 
            // txtCantidadBoletas
            // 
            this.txtCantidadBoletas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantidadBoletas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadBoletas.Location = new System.Drawing.Point(26, 43);
            this.txtCantidadBoletas.Name = "txtCantidadBoletas";
            this.txtCantidadBoletas.Size = new System.Drawing.Size(180, 23);
            this.txtCantidadBoletas.TabIndex = 39;
            this.txtCantidadBoletas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadBoletas_KeyPress);
            // 
            // TxtIdActa
            // 
            this.TxtIdActa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtIdActa.Enabled = false;
            this.TxtIdActa.Location = new System.Drawing.Point(354, 190);
            this.TxtIdActa.Name = "TxtIdActa";
            this.TxtIdActa.ReadOnly = true;
            this.TxtIdActa.Size = new System.Drawing.Size(38, 23);
            this.TxtIdActa.TabIndex = 38;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqueda.BackColor = System.Drawing.Color.LightGray;
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(419, 41);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(167, 23);
            this.txtBusqueda.TabIndex = 37;
            // 
            // BtnEliminarActa
            // 
            this.BtnEliminarActa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminarActa.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarActa.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminarActa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEliminarActa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminarActa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarActa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarActa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEliminarActa.Location = new System.Drawing.Point(595, 173);
            this.BtnEliminarActa.Name = "BtnEliminarActa";
            this.BtnEliminarActa.Size = new System.Drawing.Size(167, 40);
            this.BtnEliminarActa.TabIndex = 34;
            this.BtnEliminarActa.Text = "Eliminar registro";
            this.BtnEliminarActa.UseVisualStyleBackColor = false;
            this.BtnEliminarActa.Click += new System.EventHandler(this.BtnEliminarActa_Click);
            // 
            // BtnRefrescarActas
            // 
            this.BtnRefrescarActas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRefrescarActas.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRefrescarActas.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefrescarActas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRefrescarActas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnRefrescarActas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescarActas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefrescarActas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefrescarActas.Location = new System.Drawing.Point(595, 127);
            this.BtnRefrescarActas.Name = "BtnRefrescarActas";
            this.BtnRefrescarActas.Size = new System.Drawing.Size(167, 40);
            this.BtnRefrescarActas.TabIndex = 33;
            this.BtnRefrescarActas.Text = "Refrescar";
            this.BtnRefrescarActas.UseVisualStyleBackColor = false;
            this.BtnRefrescarActas.Click += new System.EventHandler(this.BtnRefrescarActas_Click);
            // 
            // BtnLimpiarActa
            // 
            this.BtnLimpiarActa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLimpiarActa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnLimpiarActa.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLimpiarActa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiarActa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnLimpiarActa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiarActa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarActa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarActa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLimpiarActa.Location = new System.Drawing.Point(419, 173);
            this.BtnLimpiarActa.Name = "BtnLimpiarActa";
            this.BtnLimpiarActa.Size = new System.Drawing.Size(167, 40);
            this.BtnLimpiarActa.TabIndex = 32;
            this.BtnLimpiarActa.Text = "Limpiar Campos";
            this.BtnLimpiarActa.UseVisualStyleBackColor = false;
            this.BtnLimpiarActa.Click += new System.EventHandler(this.BtnLimpiarActa_Click);
            // 
            // BtnActualizarActa
            // 
            this.BtnActualizarActa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizarActa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnActualizarActa.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarActa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnActualizarActa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnActualizarActa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizarActa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarActa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarActa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualizarActa.Location = new System.Drawing.Point(419, 127);
            this.BtnActualizarActa.Name = "BtnActualizarActa";
            this.BtnActualizarActa.Size = new System.Drawing.Size(167, 40);
            this.BtnActualizarActa.TabIndex = 31;
            this.BtnActualizarActa.Text = "Actualizar registro";
            this.BtnActualizarActa.UseVisualStyleBackColor = false;
            this.BtnActualizarActa.Click += new System.EventHandler(this.BtnActualizarActa_Click);
            // 
            // BtnAgregarActa
            // 
            this.BtnAgregarActa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgregarActa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnAgregarActa.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregarActa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarActa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnAgregarActa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregarActa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarActa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarActa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregarActa.Location = new System.Drawing.Point(419, 81);
            this.BtnAgregarActa.Name = "BtnAgregarActa";
            this.BtnAgregarActa.Size = new System.Drawing.Size(167, 40);
            this.BtnAgregarActa.TabIndex = 30;
            this.BtnAgregarActa.Text = "Agregar registro";
            this.BtnAgregarActa.UseVisualStyleBackColor = false;
            this.BtnAgregarActa.Click += new System.EventHandler(this.BtnAgregarActa_Click);
            // 
            // PictureLupa
            // 
            this.PictureLupa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureLupa.Image = global::Democratic.Properties.Resources.search_48px;
            this.PictureLupa.Location = new System.Drawing.Point(584, 41);
            this.PictureLupa.Name = "PictureLupa";
            this.PictureLupa.Size = new System.Drawing.Size(27, 23);
            this.PictureLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLupa.TabIndex = 36;
            this.PictureLupa.TabStop = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(416, 19);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(84, 17);
            this.lblBuscar.TabIndex = 35;
            this.lblBuscar.Text = "Buscar registro";
            // 
            // DgvActas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvActas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvActas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvActas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvActas.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DgvActas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvActas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvActas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvActas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvActas.DoubleBuffered = true;
            this.DgvActas.EnableHeadersVisualStyles = false;
            this.DgvActas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            this.DgvActas.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DgvActas.Location = new System.Drawing.Point(6, 238);
            this.DgvActas.Name = "DgvActas";
            this.DgvActas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvActas.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvActas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvActas.Size = new System.Drawing.Size(764, 309);
            this.DgvActas.TabIndex = 29;
            this.DgvActas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvActas_CellClick);
            this.DgvActas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvActas_CellFormatting);
            // 
            // FrmActas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.PanelActas);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmActas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros de escrutinio";
            this.Load += new System.EventHandler(this.FrmActas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelActas.ResumeLayout(false);
            this.GrpActas.ResumeLayout(false);
            this.GrpActas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pblupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.Panel PanelActas;
        private System.Windows.Forms.GroupBox GrpActas;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvActas;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button BtnEliminarActa;
        private System.Windows.Forms.Button BtnRefrescarActas;
        private System.Windows.Forms.Button BtnLimpiarActa;
        private System.Windows.Forms.Button BtnActualizarActa;
        private System.Windows.Forms.Button BtnAgregarActa;
        private System.Windows.Forms.PictureBox PictureLupa;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblJRV;
        private System.Windows.Forms.Label lblCBoletas;
        private System.Windows.Forms.ComboBox CmbJRV;
        private System.Windows.Forms.TextBox txtCantidadBoletas;
        private System.Windows.Forms.TextBox TxtIdActa;
        private System.Windows.Forms.TextBox txtJRV;
        private System.Windows.Forms.PictureBox Pblupa;
        private System.Windows.Forms.Label lblidjrv;
    }
}