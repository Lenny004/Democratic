namespace Democratic
{
    partial class FrmDetalleActa
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.PanelDA = new System.Windows.Forms.Panel();
            this.GrpDetalle = new System.Windows.Forms.GroupBox();
            this.DgvDetalleActa = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TxtIdDetalleA = new System.Windows.Forms.TextBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblActa = new System.Windows.Forms.Label();
            this.CmbPartido = new System.Windows.Forms.ComboBox();
            this.CmbActa = new System.Windows.Forms.ComboBox();
            this.PictureLupa = new System.Windows.Forms.PictureBox();
            this.txtBusquedaD = new System.Windows.Forms.TextBox();
            this.lblBuscarDa = new System.Windows.Forms.Label();
            this.lblCantidadV = new System.Windows.Forms.Label();
            this.BtnEliminarDetalleA = new System.Windows.Forms.Button();
            this.BtnRefrescarDetalleA = new System.Windows.Forms.Button();
            this.BtnLimpiarDetallesA = new System.Windows.Forms.Button();
            this.BtnActualizarDetalleA = new System.Windows.Forms.Button();
            this.BtnAgregarDetalleA = new System.Windows.Forms.Button();
            this.txtCantidadV = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.PanelDA.SuspendLayout();
            this.GrpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleActa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).BeginInit();
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
            // 
            // PanelDA
            // 
            this.PanelDA.Controls.Add(this.GrpDetalle);
            this.PanelDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDA.Location = new System.Drawing.Point(0, 25);
            this.PanelDA.Name = "PanelDA";
            this.PanelDA.Size = new System.Drawing.Size(800, 598);
            this.PanelDA.TabIndex = 1;
            // 
            // GrpDetalle
            // 
            this.GrpDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpDetalle.Controls.Add(this.DgvDetalleActa);
            this.GrpDetalle.Controls.Add(this.TxtIdDetalleA);
            this.GrpDetalle.Controls.Add(this.lblPartido);
            this.GrpDetalle.Controls.Add(this.lblActa);
            this.GrpDetalle.Controls.Add(this.CmbPartido);
            this.GrpDetalle.Controls.Add(this.CmbActa);
            this.GrpDetalle.Controls.Add(this.PictureLupa);
            this.GrpDetalle.Controls.Add(this.txtBusquedaD);
            this.GrpDetalle.Controls.Add(this.lblBuscarDa);
            this.GrpDetalle.Controls.Add(this.lblCantidadV);
            this.GrpDetalle.Controls.Add(this.BtnEliminarDetalleA);
            this.GrpDetalle.Controls.Add(this.BtnRefrescarDetalleA);
            this.GrpDetalle.Controls.Add(this.BtnLimpiarDetallesA);
            this.GrpDetalle.Controls.Add(this.BtnActualizarDetalleA);
            this.GrpDetalle.Controls.Add(this.BtnAgregarDetalleA);
            this.GrpDetalle.Controls.Add(this.txtCantidadV);
            this.GrpDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDetalle.Location = new System.Drawing.Point(8, -3);
            this.GrpDetalle.Name = "GrpDetalle";
            this.GrpDetalle.Size = new System.Drawing.Size(776, 589);
            this.GrpDetalle.TabIndex = 1;
            this.GrpDetalle.TabStop = false;
            this.GrpDetalle.Text = "Detalle por grupo/opción";
            // 
            // DgvDetalleActa
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDetalleActa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDetalleActa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDetalleActa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDetalleActa.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DgvDetalleActa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDetalleActa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDetalleActa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDetalleActa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDetalleActa.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDetalleActa.DoubleBuffered = true;
            this.DgvDetalleActa.EnableHeadersVisualStyles = false;
            this.DgvDetalleActa.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            this.DgvDetalleActa.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DgvDetalleActa.Location = new System.Drawing.Point(12, 282);
            this.DgvDetalleActa.Name = "DgvDetalleActa";
            this.DgvDetalleActa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDetalleActa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDetalleActa.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDetalleActa.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvDetalleActa.Size = new System.Drawing.Size(758, 286);
            this.DgvDetalleActa.TabIndex = 59;
            this.DgvDetalleActa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalleActa_CellClick_1);
            this.DgvDetalleActa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvDetalleActa_CellFormatting);
            // 
            // TxtIdDetalleA
            // 
            this.TxtIdDetalleA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtIdDetalleA.Enabled = false;
            this.TxtIdDetalleA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdDetalleA.Location = new System.Drawing.Point(335, 218);
            this.TxtIdDetalleA.Name = "TxtIdDetalleA";
            this.TxtIdDetalleA.ReadOnly = true;
            this.TxtIdDetalleA.Size = new System.Drawing.Size(42, 23);
            this.TxtIdDetalleA.TabIndex = 58;
            // 
            // lblPartido
            // 
            this.lblPartido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPartido.AutoSize = true;
            this.lblPartido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartido.Location = new System.Drawing.Point(18, 185);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(59, 17);
            this.lblPartido.TabIndex = 57;
            this.lblPartido.Text = "Grupo de opciones:";
            // 
            // lblActa
            // 
            this.lblActa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblActa.AutoSize = true;
            this.lblActa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActa.Location = new System.Drawing.Point(18, 111);
            this.lblActa.Name = "lblActa";
            this.lblActa.Size = new System.Drawing.Size(125, 17);
            this.lblActa.TabIndex = 56;
            this.lblActa.Text = "Registro de escrutinio:";
            // 
            // CmbPartido
            // 
            this.CmbPartido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPartido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPartido.FormattingEnabled = true;
            this.CmbPartido.Location = new System.Drawing.Point(21, 218);
            this.CmbPartido.Name = "CmbPartido";
            this.CmbPartido.Size = new System.Drawing.Size(167, 25);
            this.CmbPartido.TabIndex = 55;
            this.CmbPartido.Click += new System.EventHandler(this.CmbPartido_Click);
            // 
            // CmbActa
            // 
            this.CmbActa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbActa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbActa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbActa.FormattingEnabled = true;
            this.CmbActa.Location = new System.Drawing.Point(21, 131);
            this.CmbActa.Name = "CmbActa";
            this.CmbActa.Size = new System.Drawing.Size(167, 25);
            this.CmbActa.TabIndex = 54;
            this.CmbActa.Click += new System.EventHandler(this.CmbActa_Click);
            // 
            // PictureLupa
            // 
            this.PictureLupa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureLupa.Image = global::Democratic.Properties.Resources.search_48px;
            this.PictureLupa.Location = new System.Drawing.Point(631, 64);
            this.PictureLupa.Name = "PictureLupa";
            this.PictureLupa.Size = new System.Drawing.Size(30, 28);
            this.PictureLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLupa.TabIndex = 52;
            this.PictureLupa.TabStop = false;
            // 
            // txtBusquedaD
            // 
            this.txtBusquedaD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusquedaD.BackColor = System.Drawing.Color.LightGray;
            this.txtBusquedaD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaD.Location = new System.Drawing.Point(409, 64);
            this.txtBusquedaD.Multiline = true;
            this.txtBusquedaD.Name = "txtBusquedaD";
            this.txtBusquedaD.Size = new System.Drawing.Size(226, 28);
            this.txtBusquedaD.TabIndex = 53;
            // 
            // lblBuscarDa
            // 
            this.lblBuscarDa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBuscarDa.AutoSize = true;
            this.lblBuscarDa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarDa.Location = new System.Drawing.Point(406, 31);
            this.lblBuscarDa.Name = "lblBuscarDa";
            this.lblBuscarDa.Size = new System.Drawing.Size(159, 17);
            this.lblBuscarDa.TabIndex = 51;
            this.lblBuscarDa.Text = "Buscar detalle:";
            // 
            // lblCantidadV
            // 
            this.lblCantidadV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCantidadV.AutoSize = true;
            this.lblCantidadV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadV.Location = new System.Drawing.Point(18, 31);
            this.lblCantidadV.Name = "lblCantidadV";
            this.lblCantidadV.Size = new System.Drawing.Size(116, 17);
            this.lblCantidadV.TabIndex = 44;
            this.lblCantidadV.Text = "Cantidad de votos:";
            // 
            // BtnEliminarDetalleA
            // 
            this.BtnEliminarDetalleA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminarDetalleA.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarDetalleA.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminarDetalleA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEliminarDetalleA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminarDetalleA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarDetalleA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarDetalleA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEliminarDetalleA.Location = new System.Drawing.Point(592, 218);
            this.BtnEliminarDetalleA.Name = "BtnEliminarDetalleA";
            this.BtnEliminarDetalleA.Size = new System.Drawing.Size(167, 45);
            this.BtnEliminarDetalleA.TabIndex = 43;
            this.BtnEliminarDetalleA.Text = "Eliminar detalle";
            this.BtnEliminarDetalleA.UseVisualStyleBackColor = false;
            this.BtnEliminarDetalleA.Click += new System.EventHandler(this.BtnEliminarDetalleA_Click);
            // 
            // BtnRefrescarDetalleA
            // 
            this.BtnRefrescarDetalleA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRefrescarDetalleA.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRefrescarDetalleA.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefrescarDetalleA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRefrescarDetalleA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnRefrescarDetalleA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescarDetalleA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefrescarDetalleA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefrescarDetalleA.Location = new System.Drawing.Point(592, 167);
            this.BtnRefrescarDetalleA.Name = "BtnRefrescarDetalleA";
            this.BtnRefrescarDetalleA.Size = new System.Drawing.Size(167, 45);
            this.BtnRefrescarDetalleA.TabIndex = 42;
            this.BtnRefrescarDetalleA.Text = "Refrescar";
            this.BtnRefrescarDetalleA.UseVisualStyleBackColor = false;
            this.BtnRefrescarDetalleA.Click += new System.EventHandler(this.BtnRefrescarDetalleA_Click);
            // 
            // BtnLimpiarDetallesA
            // 
            this.BtnLimpiarDetallesA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLimpiarDetallesA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnLimpiarDetallesA.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLimpiarDetallesA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiarDetallesA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnLimpiarDetallesA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiarDetallesA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarDetallesA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarDetallesA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLimpiarDetallesA.Location = new System.Drawing.Point(409, 218);
            this.BtnLimpiarDetallesA.Name = "BtnLimpiarDetallesA";
            this.BtnLimpiarDetallesA.Size = new System.Drawing.Size(167, 45);
            this.BtnLimpiarDetallesA.TabIndex = 41;
            this.BtnLimpiarDetallesA.Text = "Limpiar Campos";
            this.BtnLimpiarDetallesA.UseVisualStyleBackColor = false;
            this.BtnLimpiarDetallesA.Click += new System.EventHandler(this.BtnLimpiarDetallesA_Click);
            // 
            // BtnActualizarDetalleA
            // 
            this.BtnActualizarDetalleA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizarDetalleA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnActualizarDetalleA.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarDetalleA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnActualizarDetalleA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnActualizarDetalleA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizarDetalleA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarDetalleA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarDetalleA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualizarDetalleA.Location = new System.Drawing.Point(409, 167);
            this.BtnActualizarDetalleA.Name = "BtnActualizarDetalleA";
            this.BtnActualizarDetalleA.Size = new System.Drawing.Size(167, 45);
            this.BtnActualizarDetalleA.TabIndex = 40;
            this.BtnActualizarDetalleA.Text = "Actualizar detalle";
            this.BtnActualizarDetalleA.UseVisualStyleBackColor = false;
            this.BtnActualizarDetalleA.Click += new System.EventHandler(this.BtnActualizarDetalleA_Click);
            // 
            // BtnAgregarDetalleA
            // 
            this.BtnAgregarDetalleA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgregarDetalleA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnAgregarDetalleA.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregarDetalleA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarDetalleA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnAgregarDetalleA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregarDetalleA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarDetalleA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarDetalleA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregarDetalleA.Location = new System.Drawing.Point(409, 116);
            this.BtnAgregarDetalleA.Name = "BtnAgregarDetalleA";
            this.BtnAgregarDetalleA.Size = new System.Drawing.Size(167, 45);
            this.BtnAgregarDetalleA.TabIndex = 39;
            this.BtnAgregarDetalleA.Text = "Agregar detalle";
            this.BtnAgregarDetalleA.UseVisualStyleBackColor = false;
            this.BtnAgregarDetalleA.Click += new System.EventHandler(this.BtnAgregarDetalleA_Click);
            // 
            // txtCantidadV
            // 
            this.txtCantidadV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantidadV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadV.Location = new System.Drawing.Point(21, 64);
            this.txtCantidadV.Multiline = true;
            this.txtCantidadV.Name = "txtCantidadV";
            this.txtCantidadV.Size = new System.Drawing.Size(240, 28);
            this.txtCantidadV.TabIndex = 0;
            this.txtCantidadV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadV_KeyPress);
            // 
            // FrmDetalleActa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.PanelDA);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetalleActa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle por grupo/opción";
            this.Load += new System.EventHandler(this.FrmDetalleActa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelDA.ResumeLayout(false);
            this.GrpDetalle.ResumeLayout(false);
            this.GrpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleActa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.Panel PanelDA;
        private System.Windows.Forms.GroupBox GrpDetalle;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblActa;
        private System.Windows.Forms.ComboBox CmbPartido;
        private System.Windows.Forms.ComboBox CmbActa;
        private System.Windows.Forms.PictureBox PictureLupa;
        private System.Windows.Forms.TextBox txtBusquedaD;
        private System.Windows.Forms.Label lblBuscarDa;
        private System.Windows.Forms.Label lblCantidadV;
        private System.Windows.Forms.Button BtnEliminarDetalleA;
        private System.Windows.Forms.Button BtnRefrescarDetalleA;
        private System.Windows.Forms.Button BtnLimpiarDetallesA;
        private System.Windows.Forms.Button BtnActualizarDetalleA;
        private System.Windows.Forms.Button BtnAgregarDetalleA;
        private System.Windows.Forms.TextBox txtCantidadV;
        private System.Windows.Forms.TextBox TxtIdDetalleA;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvDetalleActa;
    }
}