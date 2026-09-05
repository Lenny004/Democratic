namespace Democratic
{
    partial class FrmDetalleMiembro
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.PanelDM = new System.Windows.Forms.Panel();
            this.GrpDetalle = new System.Windows.Forms.GroupBox();
            this.CmbMiembros = new System.Windows.Forms.ComboBox();
            this.MSKdui = new System.Windows.Forms.MaskedTextBox();
            this.PbLUPA = new System.Windows.Forms.PictureBox();
            this.lblDui = new System.Windows.Forms.Label();
            this.DgvDetalleMiembros = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TxtIdDetalle = new System.Windows.Forms.TextBox();
            this.lblJRV = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.CmbJRV = new System.Windows.Forms.ComboBox();
            this.PictureLupa = new System.Windows.Forms.PictureBox();
            this.txtBusquedaD = new System.Windows.Forms.TextBox();
            this.lblBuscarD = new System.Windows.Forms.Label();
            this.lblDetalleM = new System.Windows.Forms.Label();
            this.BtnEliminarDetalleM = new System.Windows.Forms.Button();
            this.BtnRefrescarDetalleM = new System.Windows.Forms.Button();
            this.BtnLimpiarDetallesM = new System.Windows.Forms.Button();
            this.BtnActualizarDetalleM = new System.Windows.Forms.Button();
            this.BtnAgregarDetalleM = new System.Windows.Forms.Button();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.PanelDM.SuspendLayout();
            this.GrpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLUPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleMiembros)).BeginInit();
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
            // PanelDM
            // 
            this.PanelDM.Controls.Add(this.GrpDetalle);
            this.PanelDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDM.Location = new System.Drawing.Point(0, 25);
            this.PanelDM.Name = "PanelDM";
            this.PanelDM.Size = new System.Drawing.Size(800, 598);
            this.PanelDM.TabIndex = 1;
            // 
            // GrpDetalle
            // 
            this.GrpDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpDetalle.Controls.Add(this.CmbMiembros);
            this.GrpDetalle.Controls.Add(this.MSKdui);
            this.GrpDetalle.Controls.Add(this.PbLUPA);
            this.GrpDetalle.Controls.Add(this.lblDui);
            this.GrpDetalle.Controls.Add(this.DgvDetalleMiembros);
            this.GrpDetalle.Controls.Add(this.TxtIdDetalle);
            this.GrpDetalle.Controls.Add(this.lblJRV);
            this.GrpDetalle.Controls.Add(this.lblM);
            this.GrpDetalle.Controls.Add(this.CmbJRV);
            this.GrpDetalle.Controls.Add(this.PictureLupa);
            this.GrpDetalle.Controls.Add(this.txtBusquedaD);
            this.GrpDetalle.Controls.Add(this.lblBuscarD);
            this.GrpDetalle.Controls.Add(this.lblDetalleM);
            this.GrpDetalle.Controls.Add(this.BtnEliminarDetalleM);
            this.GrpDetalle.Controls.Add(this.BtnRefrescarDetalleM);
            this.GrpDetalle.Controls.Add(this.BtnLimpiarDetallesM);
            this.GrpDetalle.Controls.Add(this.BtnActualizarDetalleM);
            this.GrpDetalle.Controls.Add(this.BtnAgregarDetalleM);
            this.GrpDetalle.Controls.Add(this.txtDetalle);
            this.GrpDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDetalle.Location = new System.Drawing.Point(12, 14);
            this.GrpDetalle.Name = "GrpDetalle";
            this.GrpDetalle.Size = new System.Drawing.Size(776, 572);
            this.GrpDetalle.TabIndex = 0;
            this.GrpDetalle.TabStop = false;
            this.GrpDetalle.Text = "Detalle del participante";
            // 
            // CmbMiembros
            // 
            this.CmbMiembros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbMiembros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMiembros.Enabled = false;
            this.CmbMiembros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMiembros.FormattingEnabled = true;
            this.CmbMiembros.Location = new System.Drawing.Point(21, 164);
            this.CmbMiembros.Name = "CmbMiembros";
            this.CmbMiembros.Size = new System.Drawing.Size(167, 25);
            this.CmbMiembros.TabIndex = 64;
            // 
            // MSKdui
            // 
            this.MSKdui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MSKdui.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSKdui.Location = new System.Drawing.Point(211, 164);
            this.MSKdui.Mask = "00000000-0";
            this.MSKdui.Name = "MSKdui";
            this.MSKdui.Size = new System.Drawing.Size(140, 23);
            this.MSKdui.TabIndex = 61;
            // 
            // PbLUPA
            // 
            this.PbLUPA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PbLUPA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbLUPA.Image = global::Democratic.Properties.Resources.search_48px;
            this.PbLUPA.Location = new System.Drawing.Point(352, 164);
            this.PbLUPA.Name = "PbLUPA";
            this.PbLUPA.Size = new System.Drawing.Size(27, 23);
            this.PbLUPA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLUPA.TabIndex = 63;
            this.PbLUPA.TabStop = false;
            this.PbLUPA.Click += new System.EventHandler(this.PbLUPA_Click);
            // 
            // lblDui
            // 
            this.lblDui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDui.AutoSize = true;
            this.lblDui.BackColor = System.Drawing.Color.Transparent;
            this.lblDui.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDui.ForeColor = System.Drawing.Color.Black;
            this.lblDui.Location = new System.Drawing.Point(208, 144);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(184, 17);
            this.lblDui.TabIndex = 62;
            this.lblDui.Text = "Documento del participante:";
            // 
            // DgvDetalleMiembros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDetalleMiembros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDetalleMiembros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDetalleMiembros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDetalleMiembros.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DgvDetalleMiembros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDetalleMiembros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDetalleMiembros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDetalleMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleMiembros.DoubleBuffered = true;
            this.DgvDetalleMiembros.EnableHeadersVisualStyles = false;
            this.DgvDetalleMiembros.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            this.DgvDetalleMiembros.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DgvDetalleMiembros.Location = new System.Drawing.Point(6, 302);
            this.DgvDetalleMiembros.Name = "DgvDetalleMiembros";
            this.DgvDetalleMiembros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvDetalleMiembros.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDetalleMiembros.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDetalleMiembros.Size = new System.Drawing.Size(764, 242);
            this.DgvDetalleMiembros.TabIndex = 60;
            this.DgvDetalleMiembros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalleMiembros_CellClick);
            this.DgvDetalleMiembros.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvDetalleMiembros_CellFormatting);
            // 
            // TxtIdDetalle
            // 
            this.TxtIdDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtIdDetalle.Enabled = false;
            this.TxtIdDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdDetalle.Location = new System.Drawing.Point(351, 235);
            this.TxtIdDetalle.Name = "TxtIdDetalle";
            this.TxtIdDetalle.Size = new System.Drawing.Size(39, 23);
            this.TxtIdDetalle.TabIndex = 59;
            // 
            // lblJRV
            // 
            this.lblJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJRV.AutoSize = true;
            this.lblJRV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJRV.Location = new System.Drawing.Point(21, 214);
            this.lblJRV.Name = "lblJRV";
            this.lblJRV.Size = new System.Drawing.Size(182, 17);
            this.lblJRV.TabIndex = 57;
            this.lblJRV.Text = "Mesa de votación:";
            // 
            // lblM
            // 
            this.lblM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(21, 139);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(69, 17);
            this.lblM.TabIndex = 56;
            this.lblM.Text = "Participante:";
            // 
            // CmbJRV
            // 
            this.CmbJRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbJRV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbJRV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbJRV.FormattingEnabled = true;
            this.CmbJRV.Location = new System.Drawing.Point(21, 234);
            this.CmbJRV.Name = "CmbJRV";
            this.CmbJRV.Size = new System.Drawing.Size(167, 25);
            this.CmbJRV.TabIndex = 55;
            this.CmbJRV.Click += new System.EventHandler(this.CmbJRV_Click);
            // 
            // PictureLupa
            // 
            this.PictureLupa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureLupa.Image = global::Democratic.Properties.Resources.search_48px;
            this.PictureLupa.Location = new System.Drawing.Point(636, 53);
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
            this.txtBusquedaD.Location = new System.Drawing.Point(409, 53);
            this.txtBusquedaD.Multiline = true;
            this.txtBusquedaD.Name = "txtBusquedaD";
            this.txtBusquedaD.Size = new System.Drawing.Size(226, 28);
            this.txtBusquedaD.TabIndex = 53;
            // 
            // lblBuscarD
            // 
            this.lblBuscarD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBuscarD.AutoSize = true;
            this.lblBuscarD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarD.Location = new System.Drawing.Point(406, 20);
            this.lblBuscarD.Name = "lblBuscarD";
            this.lblBuscarD.Size = new System.Drawing.Size(104, 17);
            this.lblBuscarD.TabIndex = 51;
            this.lblBuscarD.Text = "Buscar participante:";
            // 
            // lblDetalleM
            // 
            this.lblDetalleM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDetalleM.AutoSize = true;
            this.lblDetalleM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleM.Location = new System.Drawing.Point(21, 20);
            this.lblDetalleM.Name = "lblDetalleM";
            this.lblDetalleM.Size = new System.Drawing.Size(145, 17);
            this.lblDetalleM.TabIndex = 44;
            this.lblDetalleM.Text = "Detalle del participante:";
            // 
            // BtnEliminarDetalleM
            // 
            this.BtnEliminarDetalleM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminarDetalleM.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarDetalleM.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminarDetalleM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEliminarDetalleM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminarDetalleM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarDetalleM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarDetalleM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEliminarDetalleM.Location = new System.Drawing.Point(592, 218);
            this.BtnEliminarDetalleM.Name = "BtnEliminarDetalleM";
            this.BtnEliminarDetalleM.Size = new System.Drawing.Size(167, 45);
            this.BtnEliminarDetalleM.TabIndex = 43;
            this.BtnEliminarDetalleM.Text = "Eliminar detalle";
            this.BtnEliminarDetalleM.UseVisualStyleBackColor = false;
            this.BtnEliminarDetalleM.Click += new System.EventHandler(this.BtnEliminarDetalleM_Click);
            // 
            // BtnRefrescarDetalleM
            // 
            this.BtnRefrescarDetalleM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRefrescarDetalleM.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRefrescarDetalleM.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefrescarDetalleM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRefrescarDetalleM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnRefrescarDetalleM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescarDetalleM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefrescarDetalleM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefrescarDetalleM.Location = new System.Drawing.Point(592, 167);
            this.BtnRefrescarDetalleM.Name = "BtnRefrescarDetalleM";
            this.BtnRefrescarDetalleM.Size = new System.Drawing.Size(167, 45);
            this.BtnRefrescarDetalleM.TabIndex = 42;
            this.BtnRefrescarDetalleM.Text = "Refrescar";
            this.BtnRefrescarDetalleM.UseVisualStyleBackColor = false;
            this.BtnRefrescarDetalleM.Click += new System.EventHandler(this.BtnRefrescarDetalleM_Click);
            // 
            // BtnLimpiarDetallesM
            // 
            this.BtnLimpiarDetallesM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLimpiarDetallesM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnLimpiarDetallesM.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLimpiarDetallesM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiarDetallesM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnLimpiarDetallesM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiarDetallesM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarDetallesM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarDetallesM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLimpiarDetallesM.Location = new System.Drawing.Point(409, 218);
            this.BtnLimpiarDetallesM.Name = "BtnLimpiarDetallesM";
            this.BtnLimpiarDetallesM.Size = new System.Drawing.Size(167, 45);
            this.BtnLimpiarDetallesM.TabIndex = 41;
            this.BtnLimpiarDetallesM.Text = "Limpiar Campos";
            this.BtnLimpiarDetallesM.UseVisualStyleBackColor = false;
            this.BtnLimpiarDetallesM.Click += new System.EventHandler(this.BtnLimpiarDetallesM_Click);
            // 
            // BtnActualizarDetalleM
            // 
            this.BtnActualizarDetalleM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizarDetalleM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnActualizarDetalleM.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarDetalleM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnActualizarDetalleM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnActualizarDetalleM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizarDetalleM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarDetalleM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarDetalleM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualizarDetalleM.Location = new System.Drawing.Point(409, 167);
            this.BtnActualizarDetalleM.Name = "BtnActualizarDetalleM";
            this.BtnActualizarDetalleM.Size = new System.Drawing.Size(167, 45);
            this.BtnActualizarDetalleM.TabIndex = 40;
            this.BtnActualizarDetalleM.Text = "Actualizar detalle";
            this.BtnActualizarDetalleM.UseVisualStyleBackColor = false;
            this.BtnActualizarDetalleM.Click += new System.EventHandler(this.BtnActualizarDetalleM_Click);
            // 
            // BtnAgregarDetalleM
            // 
            this.BtnAgregarDetalleM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgregarDetalleM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnAgregarDetalleM.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregarDetalleM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarDetalleM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnAgregarDetalleM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregarDetalleM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarDetalleM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarDetalleM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregarDetalleM.Location = new System.Drawing.Point(409, 116);
            this.BtnAgregarDetalleM.Name = "BtnAgregarDetalleM";
            this.BtnAgregarDetalleM.Size = new System.Drawing.Size(167, 45);
            this.BtnAgregarDetalleM.TabIndex = 39;
            this.BtnAgregarDetalleM.Text = "Agregar detalle";
            this.BtnAgregarDetalleM.UseVisualStyleBackColor = false;
            this.BtnAgregarDetalleM.Click += new System.EventHandler(this.BtnAgregarDetalleM_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(21, 53);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(369, 67);
            this.txtDetalle.TabIndex = 0;
            this.txtDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDetalle_KeyPress);
            // 
            // FrmDetalleMiembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.PanelDM);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetalleMiembro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del participante";
            this.Load += new System.EventHandler(this.FrmDetalleMiembro_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelDM.ResumeLayout(false);
            this.GrpDetalle.ResumeLayout(false);
            this.GrpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLUPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleMiembros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.Panel PanelDM;
        private System.Windows.Forms.GroupBox GrpDetalle;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button BtnEliminarDetalleM;
        private System.Windows.Forms.Button BtnRefrescarDetalleM;
        private System.Windows.Forms.Button BtnLimpiarDetallesM;
        private System.Windows.Forms.Button BtnActualizarDetalleM;
        private System.Windows.Forms.Button BtnAgregarDetalleM;
        private System.Windows.Forms.Label lblDetalleM;
        private System.Windows.Forms.PictureBox PictureLupa;
        private System.Windows.Forms.TextBox txtBusquedaD;
        private System.Windows.Forms.Label lblBuscarD;
        private System.Windows.Forms.Label lblJRV;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.ComboBox CmbJRV;
        private System.Windows.Forms.TextBox TxtIdDetalle;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvDetalleMiembros;
        private System.Windows.Forms.MaskedTextBox MSKdui;
        private System.Windows.Forms.PictureBox PbLUPA;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.ComboBox CmbMiembros;
    }
}