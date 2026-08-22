namespace Democratic
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.PanelUser = new System.Windows.Forms.Panel();
            this.GrpUsuario = new System.Windows.Forms.GroupBox();
            this.PbLUPA = new System.Windows.Forms.PictureBox();
            this.MSKdui = new System.Windows.Forms.MaskedTextBox();
            this.lblDui = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.CmbMiembro = new System.Windows.Forms.ComboBox();
            this.BtnEliminarU = new System.Windows.Forms.Button();
            this.BtnRefrescarU = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.BtnLimpiarU = new System.Windows.Forms.Button();
            this.BtnActualizarU = new System.Windows.Forms.Button();
            this.lblMiembro = new System.Windows.Forms.Label();
            this.BtnAgregarUsuario = new System.Windows.Forms.Button();
            this.lblCV = new System.Windows.Forms.Label();
            this.PictureLupa = new System.Windows.Forms.PictureBox();
            this.CmbCV = new System.Windows.Forms.ComboBox();
            this.lblBuscar2 = new System.Windows.Forms.Label();
            this.CmbTipoU = new System.Windows.Forms.ComboBox();
            this.lblTipoU = new System.Windows.Forms.Label();
            this.lblEstadoU = new System.Windows.Forms.Label();
            this.CmbEstadoU = new System.Windows.Forms.ComboBox();
            this.CmbIntentos = new System.Windows.Forms.ComboBox();
            this.lblIntento = new System.Windows.Forms.Label();
            this.CheckPass = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblMostrar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.lblkey = new System.Windows.Forms.Label();
            this.DgvUsuarios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.lblUser3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.PanelUser.SuspendLayout();
            this.GrpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLUPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
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
            this.BtnMinimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMinimizar.Image = global::Democratic.Properties.Resources.expand_arrow_64px;
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(148, 22);
            this.BtnMinimizar.Text = "Minimizar Formulario";
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // PanelUser
            // 
            this.PanelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.PanelUser.Controls.Add(this.GrpUsuario);
            this.PanelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelUser.Location = new System.Drawing.Point(0, 25);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(800, 623);
            this.PanelUser.TabIndex = 1;
            // 
            // GrpUsuario
            // 
            this.GrpUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpUsuario.Controls.Add(this.PbLUPA);
            this.GrpUsuario.Controls.Add(this.MSKdui);
            this.GrpUsuario.Controls.Add(this.lblDui);
            this.GrpUsuario.Controls.Add(this.txtBusqueda);
            this.GrpUsuario.Controls.Add(this.CmbMiembro);
            this.GrpUsuario.Controls.Add(this.BtnEliminarU);
            this.GrpUsuario.Controls.Add(this.BtnRefrescarU);
            this.GrpUsuario.Controls.Add(this.txtId);
            this.GrpUsuario.Controls.Add(this.BtnLimpiarU);
            this.GrpUsuario.Controls.Add(this.BtnActualizarU);
            this.GrpUsuario.Controls.Add(this.lblMiembro);
            this.GrpUsuario.Controls.Add(this.BtnAgregarUsuario);
            this.GrpUsuario.Controls.Add(this.lblCV);
            this.GrpUsuario.Controls.Add(this.PictureLupa);
            this.GrpUsuario.Controls.Add(this.CmbCV);
            this.GrpUsuario.Controls.Add(this.lblBuscar2);
            this.GrpUsuario.Controls.Add(this.CmbTipoU);
            this.GrpUsuario.Controls.Add(this.lblTipoU);
            this.GrpUsuario.Controls.Add(this.lblEstadoU);
            this.GrpUsuario.Controls.Add(this.CmbEstadoU);
            this.GrpUsuario.Controls.Add(this.CmbIntentos);
            this.GrpUsuario.Controls.Add(this.lblIntento);
            this.GrpUsuario.Controls.Add(this.CheckPass);
            this.GrpUsuario.Controls.Add(this.lblMostrar);
            this.GrpUsuario.Controls.Add(this.TxtClave);
            this.GrpUsuario.Controls.Add(this.lblkey);
            this.GrpUsuario.Controls.Add(this.DgvUsuarios);
            this.GrpUsuario.Controls.Add(this.TxtUsuario);
            this.GrpUsuario.Controls.Add(this.lblUser3);
            this.GrpUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpUsuario.Location = new System.Drawing.Point(12, 13);
            this.GrpUsuario.Name = "GrpUsuario";
            this.GrpUsuario.Padding = new System.Windows.Forms.Padding(0);
            this.GrpUsuario.Size = new System.Drawing.Size(776, 598);
            this.GrpUsuario.TabIndex = 0;
            this.GrpUsuario.TabStop = false;
            this.GrpUsuario.Text = "Usuarios del sistema";
            // 
            // PbLUPA
            // 
            this.PbLUPA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PbLUPA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbLUPA.Image = global::Democratic.Properties.Resources.search_48px;
            this.PbLUPA.Location = new System.Drawing.Point(158, 194);
            this.PbLUPA.Name = "PbLUPA";
            this.PbLUPA.Size = new System.Drawing.Size(27, 23);
            this.PbLUPA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLUPA.TabIndex = 51;
            this.PbLUPA.TabStop = false;
            this.PbLUPA.Click += new System.EventHandler(this.PbLUPA_Click);
            // 
            // MSKdui
            // 
            this.MSKdui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MSKdui.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSKdui.Location = new System.Drawing.Point(18, 194);
            this.MSKdui.Mask = "00000000-0";
            this.MSKdui.Name = "MSKdui";
            this.MSKdui.Size = new System.Drawing.Size(140, 23);
            this.MSKdui.TabIndex = 49;
            // 
            // lblDui
            // 
            this.lblDui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDui.AutoSize = true;
            this.lblDui.BackColor = System.Drawing.Color.Transparent;
            this.lblDui.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDui.ForeColor = System.Drawing.Color.Black;
            this.lblDui.Location = new System.Drawing.Point(15, 174);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(184, 17);
            this.lblDui.TabIndex = 50;
            this.lblDui.Text = "Ingrese el DUI del participante:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqueda.BackColor = System.Drawing.Color.LightGray;
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(417, 45);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(167, 23);
            this.txtBusqueda.TabIndex = 26;
            // 
            // CmbMiembro
            // 
            this.CmbMiembro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbMiembro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMiembro.Enabled = false;
            this.CmbMiembro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMiembro.FormattingEnabled = true;
            this.CmbMiembro.Location = new System.Drawing.Point(218, 195);
            this.CmbMiembro.Name = "CmbMiembro";
            this.CmbMiembro.Size = new System.Drawing.Size(167, 25);
            this.CmbMiembro.TabIndex = 6;
            this.CmbMiembro.Click += new System.EventHandler(this.CmbMiembro_Click);
            // 
            // BtnEliminarU
            // 
            this.BtnEliminarU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminarU.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarU.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEliminarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEliminarU.Location = new System.Drawing.Point(593, 179);
            this.BtnEliminarU.Name = "BtnEliminarU";
            this.BtnEliminarU.Size = new System.Drawing.Size(167, 40);
            this.BtnEliminarU.TabIndex = 12;
            this.BtnEliminarU.Text = "Eliminar Usuario";
            this.BtnEliminarU.UseVisualStyleBackColor = false;
            this.BtnEliminarU.Click += new System.EventHandler(this.BtnEliminarU_Click);
            // 
            // BtnRefrescarU
            // 
            this.BtnRefrescarU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRefrescarU.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRefrescarU.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefrescarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRefrescarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnRefrescarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescarU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefrescarU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefrescarU.Location = new System.Drawing.Point(593, 118);
            this.BtnRefrescarU.Name = "BtnRefrescarU";
            this.BtnRefrescarU.Size = new System.Drawing.Size(167, 40);
            this.BtnRefrescarU.TabIndex = 11;
            this.BtnRefrescarU.Text = "Refrescar";
            this.BtnRefrescarU.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(327, 229);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(58, 23);
            this.txtId.TabIndex = 17;
            // 
            // BtnLimpiarU
            // 
            this.BtnLimpiarU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLimpiarU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnLimpiarU.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLimpiarU.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnLimpiarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLimpiarU.Location = new System.Drawing.Point(417, 242);
            this.BtnLimpiarU.Name = "BtnLimpiarU";
            this.BtnLimpiarU.Size = new System.Drawing.Size(167, 40);
            this.BtnLimpiarU.TabIndex = 10;
            this.BtnLimpiarU.Text = "Limpiar Campos";
            this.BtnLimpiarU.UseVisualStyleBackColor = false;
            this.BtnLimpiarU.Click += new System.EventHandler(this.BtnLimpiarU_Click);
            // 
            // BtnActualizarU
            // 
            this.BtnActualizarU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizarU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnActualizarU.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarU.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnActualizarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnActualizarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualizarU.Location = new System.Drawing.Point(417, 179);
            this.BtnActualizarU.Name = "BtnActualizarU";
            this.BtnActualizarU.Size = new System.Drawing.Size(167, 40);
            this.BtnActualizarU.TabIndex = 9;
            this.BtnActualizarU.Text = "Actualizar usuario";
            this.BtnActualizarU.UseVisualStyleBackColor = false;
            this.BtnActualizarU.Click += new System.EventHandler(this.BtnActualizarU_Click);
            // 
            // lblMiembro
            // 
            this.lblMiembro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMiembro.AutoSize = true;
            this.lblMiembro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiembro.Location = new System.Drawing.Point(215, 174);
            this.lblMiembro.Name = "lblMiembro";
            this.lblMiembro.Size = new System.Drawing.Size(69, 17);
            this.lblMiembro.TabIndex = 15;
            this.lblMiembro.Text = "Participante:";
            // 
            // BtnAgregarUsuario
            // 
            this.BtnAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnAgregarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregarUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnAgregarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregarUsuario.Location = new System.Drawing.Point(417, 118);
            this.BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            this.BtnAgregarUsuario.Size = new System.Drawing.Size(167, 40);
            this.BtnAgregarUsuario.TabIndex = 8;
            this.BtnAgregarUsuario.Text = "Agregar Usuario";
            this.BtnAgregarUsuario.UseVisualStyleBackColor = false;
            this.BtnAgregarUsuario.Click += new System.EventHandler(this.BtnAgregarUsuario_Click);
            // 
            // lblCV
            // 
            this.lblCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCV.AutoSize = true;
            this.lblCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV.Location = new System.Drawing.Point(111, 227);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(141, 17);
            this.lblCV.TabIndex = 14;
            this.lblCV.Text = "Sede de votación:";
            // 
            // PictureLupa
            // 
            this.PictureLupa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureLupa.Image = global::Democratic.Properties.Resources.search_48px;
            this.PictureLupa.Location = new System.Drawing.Point(582, 45);
            this.PictureLupa.Name = "PictureLupa";
            this.PictureLupa.Padding = new System.Windows.Forms.Padding(3);
            this.PictureLupa.Size = new System.Drawing.Size(27, 23);
            this.PictureLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLupa.TabIndex = 25;
            this.PictureLupa.TabStop = false;
            // 
            // CmbCV
            // 
            this.CmbCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCV.FormattingEnabled = true;
            this.CmbCV.Location = new System.Drawing.Point(114, 258);
            this.CmbCV.Name = "CmbCV";
            this.CmbCV.Size = new System.Drawing.Size(271, 25);
            this.CmbCV.TabIndex = 7;
            this.CmbCV.Click += new System.EventHandler(this.CmbCV_Click);
            // 
            // lblBuscar2
            // 
            this.lblBuscar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBuscar2.AutoSize = true;
            this.lblBuscar2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar2.Location = new System.Drawing.Point(414, 23);
            this.lblBuscar2.Name = "lblBuscar2";
            this.lblBuscar2.Size = new System.Drawing.Size(108, 17);
            this.lblBuscar2.TabIndex = 24;
            this.lblBuscar2.Text = "Buscar usuarios:";
            // 
            // CmbTipoU
            // 
            this.CmbTipoU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbTipoU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoU.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoU.FormattingEnabled = true;
            this.CmbTipoU.Location = new System.Drawing.Point(218, 105);
            this.CmbTipoU.Name = "CmbTipoU";
            this.CmbTipoU.Size = new System.Drawing.Size(167, 25);
            this.CmbTipoU.TabIndex = 5;
            this.CmbTipoU.Click += new System.EventHandler(this.CmbTipoU_Click);
            // 
            // lblTipoU
            // 
            this.lblTipoU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoU.AutoSize = true;
            this.lblTipoU.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoU.Location = new System.Drawing.Point(215, 84);
            this.lblTipoU.Name = "lblTipoU";
            this.lblTipoU.Size = new System.Drawing.Size(109, 17);
            this.lblTipoU.TabIndex = 11;
            this.lblTipoU.Text = "Rol (Supervisor/Auditor):";
            // 
            // lblEstadoU
            // 
            this.lblEstadoU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstadoU.AutoSize = true;
            this.lblEstadoU.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoU.Location = new System.Drawing.Point(215, 16);
            this.lblEstadoU.Name = "lblEstadoU";
            this.lblEstadoU.Size = new System.Drawing.Size(130, 17);
            this.lblEstadoU.TabIndex = 10;
            this.lblEstadoU.Text = "Estado del usuario:";
            // 
            // CmbEstadoU
            // 
            this.CmbEstadoU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbEstadoU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoU.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstadoU.FormattingEnabled = true;
            this.CmbEstadoU.Location = new System.Drawing.Point(218, 44);
            this.CmbEstadoU.Name = "CmbEstadoU";
            this.CmbEstadoU.Size = new System.Drawing.Size(167, 25);
            this.CmbEstadoU.TabIndex = 4;
            this.CmbEstadoU.Click += new System.EventHandler(this.CmbEstadoU_Click);
            // 
            // CmbIntentos
            // 
            this.CmbIntentos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbIntentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIntentos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbIntentos.FormattingEnabled = true;
            this.CmbIntentos.Location = new System.Drawing.Point(18, 258);
            this.CmbIntentos.Name = "CmbIntentos";
            this.CmbIntentos.Size = new System.Drawing.Size(58, 25);
            this.CmbIntentos.TabIndex = 3;
            // 
            // lblIntento
            // 
            this.lblIntento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIntento.AutoSize = true;
            this.lblIntento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntento.Location = new System.Drawing.Point(15, 227);
            this.lblIntento.Name = "lblIntento";
            this.lblIntento.Size = new System.Drawing.Size(58, 17);
            this.lblIntento.TabIndex = 7;
            this.lblIntento.Text = "Intento:";
            // 
            // CheckPass
            // 
            this.CheckPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckPass.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckPass.Checked = false;
            this.CheckPass.CheckedOnColor = System.Drawing.Color.Aqua;
            this.CheckPass.ForeColor = System.Drawing.Color.White;
            this.CheckPass.Location = new System.Drawing.Point(18, 136);
            this.CheckPass.Margin = new System.Windows.Forms.Padding(4);
            this.CheckPass.Name = "CheckPass";
            this.CheckPass.Size = new System.Drawing.Size(20, 20);
            this.CheckPass.TabIndex = 5;
            this.CheckPass.OnChange += new System.EventHandler(this.CheckPass_OnChange);
            // 
            // lblMostrar
            // 
            this.lblMostrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.Image = global::Democratic.Properties.Resources.eye_20px;
            this.lblMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMostrar.Location = new System.Drawing.Point(45, 136);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(79, 17);
            this.lblMostrar.TabIndex = 6;
            this.lblMostrar.Text = "      Mostrar";
            // 
            // TxtClave
            // 
            this.TxtClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.Location = new System.Drawing.Point(18, 104);
            this.TxtClave.Multiline = true;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(167, 25);
            this.TxtClave.TabIndex = 2;
            this.TxtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClave_KeyPress);
            // 
            // lblkey
            // 
            this.lblkey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblkey.AutoSize = true;
            this.lblkey.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkey.Location = new System.Drawing.Point(15, 84);
            this.lblkey.Name = "lblkey";
            this.lblkey.Size = new System.Drawing.Size(51, 17);
            this.lblkey.TabIndex = 3;
            this.lblkey.Text = "Clave:";
            // 
            // DgvUsuarios
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvUsuarios.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.DoubleBuffered = true;
            this.DgvUsuarios.EnableHeadersVisualStyles = false;
            this.DgvUsuarios.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.DgvUsuarios.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            this.DgvUsuarios.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DgvUsuarios.Location = new System.Drawing.Point(3, 303);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvUsuarios.Size = new System.Drawing.Size(770, 281);
            this.DgvUsuarios.TabIndex = 2;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellClick);
            this.DgvUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvUsuarios_CellFormatting);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(18, 43);
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(167, 25);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            // 
            // lblUser3
            // 
            this.lblUser3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUser3.AutoSize = true;
            this.lblUser3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser3.Location = new System.Drawing.Point(15, 16);
            this.lblUser3.Name = "lblUser3";
            this.lblUser3.Size = new System.Drawing.Size(58, 17);
            this.lblUser3.TabIndex = 0;
            this.lblUser3.Text = "Usuario:";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.PanelUser);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 623);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelUser.ResumeLayout(false);
            this.GrpUsuario.ResumeLayout(false);
            this.GrpUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLUPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel PanelUser;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.GroupBox GrpUsuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label lblUser3;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label lblkey;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvUsuarios;
        private Bunifu.Framework.UI.BunifuCheckbox CheckPass;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMostrar;
        private System.Windows.Forms.ComboBox CmbIntentos;
        private System.Windows.Forms.Label lblIntento;
        private System.Windows.Forms.ComboBox CmbCV;
        private System.Windows.Forms.ComboBox CmbTipoU;
        private System.Windows.Forms.Label lblTipoU;
        private System.Windows.Forms.Label lblEstadoU;
        private System.Windows.Forms.ComboBox CmbEstadoU;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblMiembro;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.Button BtnRefrescarU;
        private System.Windows.Forms.Button BtnLimpiarU;
        private System.Windows.Forms.Button BtnActualizarU;
        private System.Windows.Forms.Button BtnAgregarUsuario;
        private System.Windows.Forms.PictureBox PictureLupa;
        private System.Windows.Forms.Label lblBuscar2;
        private System.Windows.Forms.Button BtnEliminarU;
        private System.Windows.Forms.ComboBox CmbMiembro;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.PictureBox PbLUPA;
        private System.Windows.Forms.MaskedTextBox MSKdui;
        private System.Windows.Forms.Label lblDui;
    }
}