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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GrpUsuario = new System.Windows.Forms.GroupBox();
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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.CmbTipoU = new System.Windows.Forms.ComboBox();
            this.lblTipoU = new System.Windows.Forms.Label();
            this.lblEstadoU = new System.Windows.Forms.Label();
            this.CmbEstadoU = new System.Windows.Forms.ComboBox();
            this.CmbIntentos = new System.Windows.Forms.ComboBox();
            this.lblIntento = new System.Windows.Forms.Label();
            this.CheckPass = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblMostrar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvUsuarios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GrpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
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
            this.BtnMinimizar.Image = global::Democratic.Properties.Resources.expand_arrow_64px;
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(141, 22);
            this.BtnMinimizar.Text = "Minimizar Formulario";
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.GrpUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 623);
            this.panel1.TabIndex = 1;
            // 
            // GrpUsuario
            // 
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
            this.GrpUsuario.Controls.Add(this.lblBuscar);
            this.GrpUsuario.Controls.Add(this.CmbTipoU);
            this.GrpUsuario.Controls.Add(this.lblTipoU);
            this.GrpUsuario.Controls.Add(this.lblEstadoU);
            this.GrpUsuario.Controls.Add(this.CmbEstadoU);
            this.GrpUsuario.Controls.Add(this.CmbIntentos);
            this.GrpUsuario.Controls.Add(this.lblIntento);
            this.GrpUsuario.Controls.Add(this.CheckPass);
            this.GrpUsuario.Controls.Add(this.lblMostrar);
            this.GrpUsuario.Controls.Add(this.TxtClave);
            this.GrpUsuario.Controls.Add(this.label1);
            this.GrpUsuario.Controls.Add(this.DgvUsuarios);
            this.GrpUsuario.Controls.Add(this.TxtUsuario);
            this.GrpUsuario.Controls.Add(this.lblUser);
            this.GrpUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpUsuario.Location = new System.Drawing.Point(12, 13);
            this.GrpUsuario.Name = "GrpUsuario";
            this.GrpUsuario.Size = new System.Drawing.Size(776, 598);
            this.GrpUsuario.TabIndex = 0;
            this.GrpUsuario.TabStop = false;
            // 
            // CmbMiembro
            // 
            this.CmbMiembro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMiembro.FormattingEnabled = true;
            this.CmbMiembro.Location = new System.Drawing.Point(218, 191);
            this.CmbMiembro.Name = "CmbMiembro";
            this.CmbMiembro.Size = new System.Drawing.Size(167, 24);
            this.CmbMiembro.TabIndex = 6;
            this.CmbMiembro.Click += new System.EventHandler(this.CmbMiembro_Click);
            // 
            // BtnEliminarU
            // 
            this.BtnEliminarU.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarU.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEliminarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEliminarU.Location = new System.Drawing.Point(593, 182);
            this.BtnEliminarU.Name = "BtnEliminarU";
            this.BtnEliminarU.Size = new System.Drawing.Size(167, 40);
            this.BtnEliminarU.TabIndex = 12;
            this.BtnEliminarU.Text = "Eliminar Usuario";
            this.BtnEliminarU.UseVisualStyleBackColor = false;
            this.BtnEliminarU.Click += new System.EventHandler(this.BtnEliminarU_Click);
            // 
            // BtnRefrescarU
            // 
            this.BtnRefrescarU.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRefrescarU.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefrescarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRefrescarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnRefrescarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescarU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefrescarU.Location = new System.Drawing.Point(593, 121);
            this.BtnRefrescarU.Name = "BtnRefrescarU";
            this.BtnRefrescarU.Size = new System.Drawing.Size(167, 40);
            this.BtnRefrescarU.TabIndex = 11;
            this.BtnRefrescarU.Text = "Refrescar";
            this.BtnRefrescarU.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(18, 194);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(58, 23);
            this.txtId.TabIndex = 17;
            // 
            // BtnLimpiarU
            // 
            this.BtnLimpiarU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnLimpiarU.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLimpiarU.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnLimpiarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLimpiarU.Location = new System.Drawing.Point(417, 245);
            this.BtnLimpiarU.Name = "BtnLimpiarU";
            this.BtnLimpiarU.Size = new System.Drawing.Size(167, 40);
            this.BtnLimpiarU.TabIndex = 10;
            this.BtnLimpiarU.Text = "Limpiar Campos";
            this.BtnLimpiarU.UseVisualStyleBackColor = false;
            this.BtnLimpiarU.Click += new System.EventHandler(this.BtnLimpiarU_Click);
            // 
            // BtnActualizarU
            // 
            this.BtnActualizarU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnActualizarU.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarU.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnActualizarU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnActualizarU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualizarU.Location = new System.Drawing.Point(417, 182);
            this.BtnActualizarU.Name = "BtnActualizarU";
            this.BtnActualizarU.Size = new System.Drawing.Size(167, 40);
            this.BtnActualizarU.TabIndex = 9;
            this.BtnActualizarU.Text = "Actualizar Miembro";
            this.BtnActualizarU.UseVisualStyleBackColor = false;
            this.BtnActualizarU.Click += new System.EventHandler(this.BtnActualizarU_Click);
            // 
            // lblMiembro
            // 
            this.lblMiembro.AutoSize = true;
            this.lblMiembro.Location = new System.Drawing.Point(215, 162);
            this.lblMiembro.Name = "lblMiembro";
            this.lblMiembro.Size = new System.Drawing.Size(66, 17);
            this.lblMiembro.TabIndex = 15;
            this.lblMiembro.Text = "Miembro:";
            // 
            // BtnAgregarUsuario
            // 
            this.BtnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnAgregarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregarUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnAgregarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregarUsuario.Location = new System.Drawing.Point(417, 121);
            this.BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            this.BtnAgregarUsuario.Size = new System.Drawing.Size(167, 40);
            this.BtnAgregarUsuario.TabIndex = 8;
            this.BtnAgregarUsuario.Text = "Agregar Usuario";
            this.BtnAgregarUsuario.UseVisualStyleBackColor = false;
            this.BtnAgregarUsuario.Click += new System.EventHandler(this.BtnAgregarUsuario_Click);
            // 
            // lblCV
            // 
            this.lblCV.AutoSize = true;
            this.lblCV.Location = new System.Drawing.Point(111, 230);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(131, 17);
            this.lblCV.TabIndex = 14;
            this.lblCV.Text = "Centro de votación:";
            // 
            // PictureLupa
            // 
            this.PictureLupa.Image = global::Democratic.Properties.Resources.search_48px;
            this.PictureLupa.Location = new System.Drawing.Point(582, 48);
            this.PictureLupa.Name = "PictureLupa";
            this.PictureLupa.Size = new System.Drawing.Size(27, 23);
            this.PictureLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLupa.TabIndex = 25;
            this.PictureLupa.TabStop = false;
            // 
            // CmbCV
            // 
            this.CmbCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCV.FormattingEnabled = true;
            this.CmbCV.Location = new System.Drawing.Point(114, 261);
            this.CmbCV.Name = "CmbCV";
            this.CmbCV.Size = new System.Drawing.Size(271, 24);
            this.CmbCV.TabIndex = 7;
            this.CmbCV.Click += new System.EventHandler(this.CmbCV_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(414, 26);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(114, 17);
            this.lblBuscar.TabIndex = 24;
            this.lblBuscar.Text = "Buscar usuarios:";
            // 
            // CmbTipoU
            // 
            this.CmbTipoU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoU.FormattingEnabled = true;
            this.CmbTipoU.Location = new System.Drawing.Point(218, 121);
            this.CmbTipoU.Name = "CmbTipoU";
            this.CmbTipoU.Size = new System.Drawing.Size(167, 24);
            this.CmbTipoU.TabIndex = 5;
            this.CmbTipoU.Click += new System.EventHandler(this.CmbTipoU_Click);
            // 
            // lblTipoU
            // 
            this.lblTipoU.AutoSize = true;
            this.lblTipoU.Location = new System.Drawing.Point(215, 98);
            this.lblTipoU.Name = "lblTipoU";
            this.lblTipoU.Size = new System.Drawing.Size(111, 17);
            this.lblTipoU.TabIndex = 11;
            this.lblTipoU.Text = "Tipo de usuario:";
            // 
            // lblEstadoU
            // 
            this.lblEstadoU.AutoSize = true;
            this.lblEstadoU.Location = new System.Drawing.Point(215, 26);
            this.lblEstadoU.Name = "lblEstadoU";
            this.lblEstadoU.Size = new System.Drawing.Size(130, 17);
            this.lblEstadoU.TabIndex = 10;
            this.lblEstadoU.Text = "Estado del usuario:";
            // 
            // CmbEstadoU
            // 
            this.CmbEstadoU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoU.FormattingEnabled = true;
            this.CmbEstadoU.Location = new System.Drawing.Point(218, 47);
            this.CmbEstadoU.Name = "CmbEstadoU";
            this.CmbEstadoU.Size = new System.Drawing.Size(167, 24);
            this.CmbEstadoU.TabIndex = 4;
            this.CmbEstadoU.Click += new System.EventHandler(this.CmbEstadoU_Click);
            // 
            // CmbIntentos
            // 
            this.CmbIntentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIntentos.FormattingEnabled = true;
            this.CmbIntentos.Location = new System.Drawing.Point(18, 261);
            this.CmbIntentos.Name = "CmbIntentos";
            this.CmbIntentos.Size = new System.Drawing.Size(58, 24);
            this.CmbIntentos.TabIndex = 3;
            // 
            // lblIntento
            // 
            this.lblIntento.AutoSize = true;
            this.lblIntento.Location = new System.Drawing.Point(15, 230);
            this.lblIntento.Name = "lblIntento";
            this.lblIntento.Size = new System.Drawing.Size(55, 17);
            this.lblIntento.TabIndex = 7;
            this.lblIntento.Text = "Intento:";
            // 
            // CheckPass
            // 
            this.CheckPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckPass.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckPass.Checked = false;
            this.CheckPass.CheckedOnColor = System.Drawing.Color.Aqua;
            this.CheckPass.ForeColor = System.Drawing.Color.White;
            this.CheckPass.Location = new System.Drawing.Point(18, 150);
            this.CheckPass.Margin = new System.Windows.Forms.Padding(4);
            this.CheckPass.Name = "CheckPass";
            this.CheckPass.Size = new System.Drawing.Size(20, 20);
            this.CheckPass.TabIndex = 5;
            this.CheckPass.OnChange += new System.EventHandler(this.CheckPass_OnChange);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Image = global::Democratic.Properties.Resources.eye_20px;
            this.lblMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMostrar.Location = new System.Drawing.Point(45, 153);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(80, 17);
            this.lblMostrar.TabIndex = 6;
            this.lblMostrar.Text = "      Mostrar";
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(18, 118);
            this.TxtClave.Multiline = true;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(167, 25);
            this.TxtClave.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clave:";
            // 
            // DgvUsuarios
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsuarios.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.DoubleBuffered = true;
            this.DgvUsuarios.EnableHeadersVisualStyles = false;
            this.DgvUsuarios.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            this.DgvUsuarios.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DgvUsuarios.Location = new System.Drawing.Point(6, 306);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvUsuarios.Size = new System.Drawing.Size(764, 286);
            this.DgvUsuarios.TabIndex = 2;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellClick);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(18, 46);
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(167, 25);
            this.TxtUsuario.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(15, 26);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.LightGray;
            this.txtBusqueda.Location = new System.Drawing.Point(417, 48);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(167, 23);
            this.txtBusqueda.TabIndex = 26;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 648);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.GrpUsuario.ResumeLayout(false);
            this.GrpUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.GroupBox GrpUsuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button BtnEliminarU;
        private System.Windows.Forms.ComboBox CmbMiembro;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}