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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCandidatos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.GrpCandidatos = new System.Windows.Forms.GroupBox();
            this.DgvCandidatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BtnTruncateC = new System.Windows.Forms.Button();
            this.PictureLupa = new System.Windows.Forms.PictureBox();
            this.txtBusquedaC = new System.Windows.Forms.TextBox();
            this.lblBuscarP = new System.Windows.Forms.Label();
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
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.OFDSeleccionarImage = new System.Windows.Forms.OpenFileDialog();
            this.PanelCandidatos = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.GrpCandidatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCandidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCandidato)).BeginInit();
            this.PanelCandidatos.SuspendLayout();
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
            // GrpCandidatos
            // 
            this.GrpCandidatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpCandidatos.Controls.Add(this.DgvCandidatos);
            this.GrpCandidatos.Controls.Add(this.BtnTruncateC);
            this.GrpCandidatos.Controls.Add(this.PictureLupa);
            this.GrpCandidatos.Controls.Add(this.txtBusquedaC);
            this.GrpCandidatos.Controls.Add(this.lblBuscarP);
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
            this.GrpCandidatos.Controls.Add(this.txtNombreC);
            this.GrpCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCandidatos.Location = new System.Drawing.Point(12, 3);
            this.GrpCandidatos.Name = "GrpCandidatos";
            this.GrpCandidatos.Size = new System.Drawing.Size(776, 583);
            this.GrpCandidatos.TabIndex = 1;
            this.GrpCandidatos.TabStop = false;
            this.GrpCandidatos.Text = "Opciones de votación";
            // 
            // DgvCandidatos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvCandidatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCandidatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.DgvCandidatos.Location = new System.Drawing.Point(6, 297);
            this.DgvCandidatos.Name = "DgvCandidatos";
            this.DgvCandidatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvCandidatos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCandidatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCandidatos.Size = new System.Drawing.Size(764, 266);
            this.DgvCandidatos.TabIndex = 55;
            this.DgvCandidatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCandidatos_CellClick);
            this.DgvCandidatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvCandidatos_CellFormatting);
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
            this.BtnTruncateC.Location = new System.Drawing.Point(592, 235);
            this.BtnTruncateC.Name = "BtnTruncateC";
            this.BtnTruncateC.Size = new System.Drawing.Size(167, 44);
            this.BtnTruncateC.TabIndex = 54;
            this.BtnTruncateC.Text = "Eliminar Todas las Opciones";
            this.BtnTruncateC.UseVisualStyleBackColor = false;
            this.BtnTruncateC.Click += new System.EventHandler(this.BtnTruncateC_Click);
            // 
            // PictureLupa
            // 
            this.PictureLupa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureLupa.Image = global::Democratic.Properties.Resources.search_48px;
            this.PictureLupa.Location = new System.Drawing.Point(630, 45);
            this.PictureLupa.Name = "PictureLupa";
            this.PictureLupa.Size = new System.Drawing.Size(30, 28);
            this.PictureLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLupa.TabIndex = 52;
            this.PictureLupa.TabStop = false;
            // 
            // txtBusquedaC
            // 
            this.txtBusquedaC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusquedaC.BackColor = System.Drawing.Color.LightGray;
            this.txtBusquedaC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaC.Location = new System.Drawing.Point(408, 45);
            this.txtBusquedaC.Multiline = true;
            this.txtBusquedaC.Name = "txtBusquedaC";
            this.txtBusquedaC.Size = new System.Drawing.Size(226, 28);
            this.txtBusquedaC.TabIndex = 53;
            // 
            // lblBuscarP
            // 
            this.lblBuscarP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBuscarP.AutoSize = true;
            this.lblBuscarP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarP.Location = new System.Drawing.Point(405, 21);
            this.lblBuscarP.Name = "lblBuscarP";
            this.lblBuscarP.Size = new System.Drawing.Size(129, 17);
            this.lblBuscarP.TabIndex = 51;
            this.lblBuscarP.Text = "Buscar Opción:";
            // 
            // txtIdC
            // 
            this.txtIdC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdC.Enabled = false;
            this.txtIdC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdC.Location = new System.Drawing.Point(737, 10);
            this.txtIdC.Name = "txtIdC";
            this.txtIdC.ReadOnly = true;
            this.txtIdC.Size = new System.Drawing.Size(39, 23);
            this.txtIdC.TabIndex = 47;
            // 
            // CmbEstadoC
            // 
            this.CmbEstadoC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbEstadoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstadoC.FormattingEnabled = true;
            this.CmbEstadoC.Location = new System.Drawing.Point(242, 254);
            this.CmbEstadoC.Name = "CmbEstadoC";
            this.CmbEstadoC.Size = new System.Drawing.Size(143, 25);
            this.CmbEstadoC.TabIndex = 5;
            this.CmbEstadoC.Click += new System.EventHandler(this.CmbEstadoC_Click);
            // 
            // lblEstadoC
            // 
            this.lblEstadoC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstadoC.AutoSize = true;
            this.lblEstadoC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoC.Location = new System.Drawing.Point(239, 227);
            this.lblEstadoC.Name = "lblEstadoC";
            this.lblEstadoC.Size = new System.Drawing.Size(156, 17);
            this.lblEstadoC.TabIndex = 45;
            this.lblEstadoC.Text = "Estado de la Opción:";
            // 
            // PbCandidato
            // 
            this.PbCandidato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PbCandidato.Location = new System.Drawing.Point(242, 25);
            this.PbCandidato.Name = "PbCandidato";
            this.PbCandidato.Size = new System.Drawing.Size(143, 151);
            this.PbCandidato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCandidato.TabIndex = 44;
            this.PbCandidato.TabStop = false;
            // 
            // BtnCargarImageC
            // 
            this.BtnCargarImageC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCargarImageC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnCargarImageC.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCargarImageC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnCargarImageC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnCargarImageC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarImageC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarImageC.ForeColor = System.Drawing.Color.White;
            this.BtnCargarImageC.Location = new System.Drawing.Point(254, 182);
            this.BtnCargarImageC.Name = "BtnCargarImageC";
            this.BtnCargarImageC.Size = new System.Drawing.Size(120, 35);
            this.BtnCargarImageC.TabIndex = 43;
            this.BtnCargarImageC.Text = "Cargar Imagen";
            this.BtnCargarImageC.UseVisualStyleBackColor = false;
            this.BtnCargarImageC.Click += new System.EventHandler(this.BtnCargarImageC_Click);
            // 
            // BtnEliminarCandidato
            // 
            this.BtnEliminarCandidato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminarCandidato.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarCandidato.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminarCandidato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEliminarCandidato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminarCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarCandidato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCandidato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEliminarCandidato.Location = new System.Drawing.Point(592, 182);
            this.BtnEliminarCandidato.Name = "BtnEliminarCandidato";
            this.BtnEliminarCandidato.Size = new System.Drawing.Size(167, 40);
            this.BtnEliminarCandidato.TabIndex = 43;
            this.BtnEliminarCandidato.Text = "Eliminar Opción";
            this.BtnEliminarCandidato.UseVisualStyleBackColor = false;
            this.BtnEliminarCandidato.Click += new System.EventHandler(this.BtnEliminarCandidato_Click);
            // 
            // BtnRefrescarCandidato
            // 
            this.BtnRefrescarCandidato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRefrescarCandidato.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRefrescarCandidato.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefrescarCandidato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRefrescarCandidato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnRefrescarCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescarCandidato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefrescarCandidato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefrescarCandidato.Location = new System.Drawing.Point(592, 125);
            this.BtnRefrescarCandidato.Name = "BtnRefrescarCandidato";
            this.BtnRefrescarCandidato.Size = new System.Drawing.Size(167, 40);
            this.BtnRefrescarCandidato.TabIndex = 42;
            this.BtnRefrescarCandidato.Text = "Refrescar";
            this.BtnRefrescarCandidato.UseVisualStyleBackColor = false;
            this.BtnRefrescarCandidato.Click += new System.EventHandler(this.BtnRefrescarCandidato_Click);
            // 
            // BtnLimpiarCandidato
            // 
            this.BtnLimpiarCandidato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLimpiarCandidato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnLimpiarCandidato.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLimpiarCandidato.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiarCandidato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnLimpiarCandidato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiarCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarCandidato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarCandidato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLimpiarCandidato.Location = new System.Drawing.Point(408, 239);
            this.BtnLimpiarCandidato.Name = "BtnLimpiarCandidato";
            this.BtnLimpiarCandidato.Size = new System.Drawing.Size(167, 40);
            this.BtnLimpiarCandidato.TabIndex = 41;
            this.BtnLimpiarCandidato.Text = "Limpiar Campos";
            this.BtnLimpiarCandidato.UseVisualStyleBackColor = false;
            this.BtnLimpiarCandidato.Click += new System.EventHandler(this.BtnLimpiarCandidato_Click);
            // 
            // BtnActualizarCandidato
            // 
            this.BtnActualizarCandidato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizarCandidato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnActualizarCandidato.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarCandidato.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnActualizarCandidato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnActualizarCandidato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizarCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarCandidato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarCandidato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualizarCandidato.Location = new System.Drawing.Point(408, 182);
            this.BtnActualizarCandidato.Name = "BtnActualizarCandidato";
            this.BtnActualizarCandidato.Size = new System.Drawing.Size(167, 40);
            this.BtnActualizarCandidato.TabIndex = 40;
            this.BtnActualizarCandidato.Text = "Actualizar Opción";
            this.BtnActualizarCandidato.UseVisualStyleBackColor = false;
            this.BtnActualizarCandidato.Click += new System.EventHandler(this.BtnActualizarCandidato_Click);
            // 
            // BtnAgregarCandidato
            // 
            this.BtnAgregarCandidato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgregarCandidato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnAgregarCandidato.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregarCandidato.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarCandidato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnAgregarCandidato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregarCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCandidato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCandidato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregarCandidato.Location = new System.Drawing.Point(408, 125);
            this.BtnAgregarCandidato.Name = "BtnAgregarCandidato";
            this.BtnAgregarCandidato.Size = new System.Drawing.Size(167, 40);
            this.BtnAgregarCandidato.TabIndex = 39;
            this.BtnAgregarCandidato.Text = "Agregar Opción";
            this.BtnAgregarCandidato.UseVisualStyleBackColor = false;
            this.BtnAgregarCandidato.Click += new System.EventHandler(this.BtnAgregarCandidato_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Grupo:";
            // 
            // CmbPartidoC
            // 
            this.CmbPartidoC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbPartidoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPartidoC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPartidoC.FormattingEnabled = true;
            this.CmbPartidoC.Location = new System.Drawing.Point(27, 254);
            this.CmbPartidoC.Name = "CmbPartidoC";
            this.CmbPartidoC.Size = new System.Drawing.Size(182, 25);
            this.CmbPartidoC.TabIndex = 4;
            this.CmbPartidoC.Click += new System.EventHandler(this.CmbPartidoC_Click);
            // 
            // TxtgeneroC
            // 
            this.TxtgeneroC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtgeneroC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtgeneroC.Location = new System.Drawing.Point(27, 177);
            this.TxtgeneroC.Multiline = true;
            this.TxtgeneroC.Name = "TxtgeneroC";
            this.TxtgeneroC.Size = new System.Drawing.Size(182, 25);
            this.TxtgeneroC.TabIndex = 3;
            this.TxtgeneroC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtgeneroC_KeyPress);
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(24, 157);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 17);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Género: ";
            // 
            // txtApellidoC
            // 
            this.txtApellidoC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellidoC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoC.Location = new System.Drawing.Point(27, 113);
            this.txtApellidoC.Multiline = true;
            this.txtApellidoC.Name = "txtApellidoC";
            this.txtApellidoC.Size = new System.Drawing.Size(182, 25);
            this.txtApellidoC.TabIndex = 2;
            this.txtApellidoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoC_KeyPress);
            // 
            // lblApellidoC
            // 
            this.lblApellidoC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApellidoC.AutoSize = true;
            this.lblApellidoC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoC.Location = new System.Drawing.Point(24, 93);
            this.lblApellidoC.Name = "lblApellidoC";
            this.lblApellidoC.Size = new System.Drawing.Size(170, 17);
            this.lblApellidoC.TabIndex = 5;
            this.lblApellidoC.Text = "Apellido de la Opción:";
            // 
            // lblNombreC
            // 
            this.lblNombreC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreC.Location = new System.Drawing.Point(24, 25);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(170, 17);
            this.lblNombreC.TabIndex = 4;
            this.lblNombreC.Text = "Nombre de la Opción:";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreC.Location = new System.Drawing.Point(27, 45);
            this.txtNombreC.Multiline = true;
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(182, 25);
            this.txtNombreC.TabIndex = 1;
            this.txtNombreC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreC_KeyPress);
            // 
            // OFDSeleccionarImage
            // 
            this.OFDSeleccionarImage.FileName = "openFileDialog1";
            // 
            // PanelCandidatos
            // 
            this.PanelCandidatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.PanelCandidatos.Controls.Add(this.GrpCandidatos);
            this.PanelCandidatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCandidatos.Location = new System.Drawing.Point(0, 25);
            this.PanelCandidatos.Name = "PanelCandidatos";
            this.PanelCandidatos.Size = new System.Drawing.Size(800, 598);
            this.PanelCandidatos.TabIndex = 2;
            // 
            // FrmCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.PanelCandidatos);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones de votación";
            this.Load += new System.EventHandler(this.FrmCandidatos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GrpCandidatos.ResumeLayout(false);
            this.GrpCandidatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCandidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCandidato)).EndInit();
            this.PanelCandidatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.GroupBox GrpCandidatos;
        private System.Windows.Forms.TextBox txtNombreC;
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
        private System.Windows.Forms.PictureBox PictureLupa;
        private System.Windows.Forms.TextBox txtBusquedaC;
        private System.Windows.Forms.Label lblBuscarP;
        private System.Windows.Forms.Button BtnTruncateC;
        private System.Windows.Forms.Panel PanelCandidatos;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvCandidatos;
    }
}