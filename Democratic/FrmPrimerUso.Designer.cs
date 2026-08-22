namespace Democratic
{
    partial class FrmPrimerUso
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrimerUso));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Control1Frm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ToolSPrimerUso = new System.Windows.Forms.ToolStrip();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.lblDemo = new System.Windows.Forms.ToolStripLabel();
            this.LblPrimerU = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ControlTool = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelPu = new System.Windows.Forms.Panel();
            this.lblmenosseguras = new System.Windows.Forms.Label();
            this.lblContraRegister = new System.Windows.Forms.Label();
            this.LblContrainfo = new System.Windows.Forms.Label();
            this.TxtContraseñaRegister = new System.Windows.Forms.TextBox();
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.Lblimgmax = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.txtCorreoRegister = new System.Windows.Forms.TextBox();
            this.LblimgT = new System.Windows.Forms.Label();
            this.lblCorreoTribunalRegister = new System.Windows.Forms.Label();
            this.txtSede = new System.Windows.Forms.TextBox();
            this.lblSede = new System.Windows.Forms.Label();
            this.txtJurisdiccion = new System.Windows.Forms.TextBox();
            this.lblJurisdiccion = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.DtpFundacion = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.BtnCargarImagen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PBtribunal = new System.Windows.Forms.PictureBox();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtComposicion = new System.Windows.Forms.TextBox();
            this.lblComposicion = new System.Windows.Forms.Label();
            this.ToolSPrimerUso.SuspendLayout();
            this.PanelPu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBtribunal)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Control1Frm
            // 
            this.Control1Frm.Fixed = true;
            this.Control1Frm.Horizontal = true;
            this.Control1Frm.TargetControl = this;
            this.Control1Frm.Vertical = true;
            // 
            // ToolSPrimerUso
            // 
            this.ToolSPrimerUso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.ToolSPrimerUso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrar,
            this.BtnMinimizar,
            this.lblDemo,
            this.LblPrimerU});
            this.ToolSPrimerUso.Location = new System.Drawing.Point(0, 0);
            this.ToolSPrimerUso.Name = "ToolSPrimerUso";
            this.ToolSPrimerUso.Size = new System.Drawing.Size(800, 25);
            this.ToolSPrimerUso.TabIndex = 0;
            this.ToolSPrimerUso.Text = "toolStrip1";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCerrar.Image = global::Democratic.Properties.Resources.delete_64px1;
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 22);
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMinimizar.Image = global::Democratic.Properties.Resources.expand_arrow_64px1;
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(23, 22);
            this.BtnMinimizar.Text = "Minimizar";
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // lblDemo
            // 
            this.lblDemo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDemo.Image = global::Democratic.Properties.Resources.logo1;
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(90, 22);
            this.lblDemo.Text = "Democratic |";
            // 
            // LblPrimerU
            // 
            this.LblPrimerU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblPrimerU.Name = "LblPrimerU";
            this.LblPrimerU.Size = new System.Drawing.Size(160, 22);
            this.LblPrimerU.Text = "Configuración de organización";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 3);
            this.panel1.TabIndex = 1;
            // 
            // ControlTool
            // 
            this.ControlTool.Fixed = true;
            this.ControlTool.Horizontal = true;
            this.ControlTool.TargetControl = this.ToolSPrimerUso;
            this.ControlTool.Vertical = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelPu;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PanelPu
            // 
            this.PanelPu.BackgroundImage = global::Democratic.Properties.Resources._1920x1080_png_wallpaper_;
            this.PanelPu.Controls.Add(this.lblmenosseguras);
            this.PanelPu.Controls.Add(this.lblContraRegister);
            this.PanelPu.Controls.Add(this.LblContrainfo);
            this.PanelPu.Controls.Add(this.TxtContraseñaRegister);
            this.PanelPu.Controls.Add(this.BtnContinuar);
            this.PanelPu.Controls.Add(this.Lblimgmax);
            this.PanelPu.Controls.Add(this.lblinfo);
            this.PanelPu.Controls.Add(this.txtCorreoRegister);
            this.PanelPu.Controls.Add(this.LblimgT);
            this.PanelPu.Controls.Add(this.lblCorreoTribunalRegister);
            this.PanelPu.Controls.Add(this.txtSede);
            this.PanelPu.Controls.Add(this.lblSede);
            this.PanelPu.Controls.Add(this.txtJurisdiccion);
            this.PanelPu.Controls.Add(this.lblJurisdiccion);
            this.PanelPu.Controls.Add(this.txtTipo);
            this.PanelPu.Controls.Add(this.lblTipo);
            this.PanelPu.Controls.Add(this.DtpFundacion);
            this.PanelPu.Controls.Add(this.lblFecha);
            this.PanelPu.Controls.Add(this.BtnCargarImagen);
            this.PanelPu.Controls.Add(this.PBtribunal);
            this.PanelPu.Controls.Add(this.txtpais);
            this.PanelPu.Controls.Add(this.lblPais);
            this.PanelPu.Controls.Add(this.txtComposicion);
            this.PanelPu.Controls.Add(this.lblComposicion);
            this.PanelPu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelPu.Location = new System.Drawing.Point(0, 28);
            this.PanelPu.Name = "PanelPu";
            this.PanelPu.Size = new System.Drawing.Size(800, 572);
            this.PanelPu.TabIndex = 2;
            // 
            // lblmenosseguras
            // 
            this.lblmenosseguras.AutoSize = true;
            this.lblmenosseguras.BackColor = System.Drawing.Color.Transparent;
            this.lblmenosseguras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenosseguras.ForeColor = System.Drawing.Color.White;
            this.lblmenosseguras.Location = new System.Drawing.Point(12, 550);
            this.lblmenosseguras.Name = "lblmenosseguras";
            this.lblmenosseguras.Size = new System.Drawing.Size(406, 13);
            this.lblmenosseguras.TabIndex = 22;
            this.lblmenosseguras.Text = "Nota: El Correo electrónico debe tener activado el acceso de las apps menos segur" +
    "as";
            // 
            // lblContraRegister
            // 
            this.lblContraRegister.AutoSize = true;
            this.lblContraRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblContraRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblContraRegister.Location = new System.Drawing.Point(288, 314);
            this.lblContraRegister.Name = "lblContraRegister";
            this.lblContraRegister.Size = new System.Drawing.Size(85, 17);
            this.lblContraRegister.TabIndex = 21;
            this.lblContraRegister.Text = "Contraseña:";
            // 
            // LblContrainfo
            // 
            this.LblContrainfo.AutoSize = true;
            this.LblContrainfo.BackColor = System.Drawing.Color.Transparent;
            this.LblContrainfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrainfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblContrainfo.Location = new System.Drawing.Point(288, 375);
            this.LblContrainfo.Name = "LblContrainfo";
            this.LblContrainfo.Size = new System.Drawing.Size(186, 26);
            this.LblContrainfo.TabIndex = 20;
            this.LblContrainfo.Text = "(La contraseña proporcionada debe \r\nser la utilizada para acceder al correo)";
            // 
            // TxtContraseñaRegister
            // 
            this.TxtContraseñaRegister.Location = new System.Drawing.Point(291, 344);
            this.TxtContraseñaRegister.Multiline = true;
            this.TxtContraseñaRegister.Name = "TxtContraseñaRegister";
            this.TxtContraseñaRegister.PasswordChar = '*';
            this.TxtContraseñaRegister.Size = new System.Drawing.Size(218, 28);
            this.TxtContraseñaRegister.TabIndex = 8;
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnContinuar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.BtnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinuar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnContinuar.Location = new System.Drawing.Point(324, 449);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(147, 42);
            this.BtnContinuar.TabIndex = 10;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.UseVisualStyleBackColor = false;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // Lblimgmax
            // 
            this.Lblimgmax.AutoSize = true;
            this.Lblimgmax.BackColor = System.Drawing.Color.Transparent;
            this.Lblimgmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblimgmax.ForeColor = System.Drawing.Color.Brown;
            this.Lblimgmax.Location = new System.Drawing.Point(603, 272);
            this.Lblimgmax.Name = "Lblimgmax";
            this.Lblimgmax.Size = new System.Drawing.Size(119, 13);
            this.Lblimgmax.TabIndex = 18;
            this.Lblimgmax.Text = "Imagen de 4Mb máximo";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblinfo.Location = new System.Drawing.Point(34, 375);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(187, 26);
            this.lblinfo.TabIndex = 17;
            this.lblinfo.Text = "(El correo proporcionado será utilizado\r\npara contactar a otros usuarios.) ";
            // 
            // txtCorreoRegister
            // 
            this.txtCorreoRegister.Location = new System.Drawing.Point(37, 344);
            this.txtCorreoRegister.Multiline = true;
            this.txtCorreoRegister.Name = "txtCorreoRegister";
            this.txtCorreoRegister.Size = new System.Drawing.Size(218, 28);
            this.txtCorreoRegister.TabIndex = 7;
            this.txtCorreoRegister.MouseEnter += new System.EventHandler(this.txtCorreo_MouseEnter);
            this.txtCorreoRegister.MouseLeave += new System.EventHandler(this.txtCorreo_MouseLeave);
            // 
            // LblimgT
            // 
            this.LblimgT.AutoSize = true;
            this.LblimgT.BackColor = System.Drawing.Color.Transparent;
            this.LblimgT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblimgT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblimgT.Location = new System.Drawing.Point(592, 42);
            this.LblimgT.Name = "LblimgT";
            this.LblimgT.Size = new System.Drawing.Size(130, 16);
            this.LblimgT.TabIndex = 15;
            this.LblimgT.Text = "Imagen de la organización:";
            // 
            // lblCorreoTribunalRegister
            // 
            this.lblCorreoTribunalRegister.AutoSize = true;
            this.lblCorreoTribunalRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreoTribunalRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCorreoTribunalRegister.Location = new System.Drawing.Point(34, 314);
            this.lblCorreoTribunalRegister.Name = "lblCorreoTribunalRegister";
            this.lblCorreoTribunalRegister.Size = new System.Drawing.Size(128, 17);
            this.lblCorreoTribunalRegister.TabIndex = 14;
            this.lblCorreoTribunalRegister.Text = "Correo electrónico:";
            // 
            // txtSede
            // 
            this.txtSede.Location = new System.Drawing.Point(291, 241);
            this.txtSede.Multiline = true;
            this.txtSede.Name = "txtSede";
            this.txtSede.Size = new System.Drawing.Size(218, 28);
            this.txtSede.TabIndex = 6;
            this.txtSede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSede_KeyPress);
            this.txtSede.MouseEnter += new System.EventHandler(this.txtSede_MouseEnter);
            this.txtSede.MouseLeave += new System.EventHandler(this.txtSede_MouseLeave);
            // 
            // lblSede
            // 
            this.lblSede.AutoSize = true;
            this.lblSede.BackColor = System.Drawing.Color.Transparent;
            this.lblSede.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSede.Location = new System.Drawing.Point(288, 216);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(45, 17);
            this.lblSede.TabIndex = 12;
            this.lblSede.Text = "Sede:";
            // 
            // txtJurisdiccion
            // 
            this.txtJurisdiccion.Location = new System.Drawing.Point(291, 151);
            this.txtJurisdiccion.Multiline = true;
            this.txtJurisdiccion.Name = "txtJurisdiccion";
            this.txtJurisdiccion.Size = new System.Drawing.Size(218, 28);
            this.txtJurisdiccion.TabIndex = 4;
            this.txtJurisdiccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJurisdiccion_KeyPress);
            this.txtJurisdiccion.MouseEnter += new System.EventHandler(this.txtJurisdiccion_MouseEnter);
            this.txtJurisdiccion.MouseLeave += new System.EventHandler(this.txtJurisdiccion_MouseLeave);
            // 
            // lblJurisdiccion
            // 
            this.lblJurisdiccion.AutoSize = true;
            this.lblJurisdiccion.BackColor = System.Drawing.Color.Transparent;
            this.lblJurisdiccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblJurisdiccion.Location = new System.Drawing.Point(288, 121);
            this.lblJurisdiccion.Name = "lblJurisdiccion";
            this.lblJurisdiccion.Size = new System.Drawing.Size(86, 17);
            this.lblJurisdiccion.TabIndex = 10;
            this.lblJurisdiccion.Text = "Jurisdicción:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(37, 151);
            this.txtTipo.Multiline = true;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(218, 28);
            this.txtTipo.TabIndex = 3;
            this.txtTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipo_KeyPress);
            this.txtTipo.MouseEnter += new System.EventHandler(this.txtTipo_MouseEnter);
            this.txtTipo.MouseLeave += new System.EventHandler(this.txtTipo_MouseLeave);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTipo.Location = new System.Drawing.Point(34, 121);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(116, 17);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo de organización:";
            // 
            // DtpFundacion
            // 
            this.DtpFundacion.CustomFormat = "yyyy-MM-dd";
            this.DtpFundacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFundacion.Location = new System.Drawing.Point(291, 70);
            this.DtpFundacion.Name = "DtpFundacion";
            this.DtpFundacion.Size = new System.Drawing.Size(218, 23);
            this.DtpFundacion.TabIndex = 2;
            this.DtpFundacion.MouseEnter += new System.EventHandler(this.DtpFundacion_MouseEnter);
            this.DtpFundacion.MouseLeave += new System.EventHandler(this.DtpFundacion_MouseLeave);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFecha.Location = new System.Drawing.Point(288, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(141, 17);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de Fundación:";
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.Activecolor = System.Drawing.Color.Teal;
            this.BtnCargarImagen.BackColor = System.Drawing.Color.Teal;
            this.BtnCargarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCargarImagen.BorderRadius = 0;
            this.BtnCargarImagen.ButtonText = "Subir Imagen";
            this.BtnCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCargarImagen.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCargarImagen.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCargarImagen.Iconimage = global::Democratic.Properties.Resources.downloading_updates_100px;
            this.BtnCargarImagen.Iconimage_right = null;
            this.BtnCargarImagen.Iconimage_right_Selected = null;
            this.BtnCargarImagen.Iconimage_Selected = null;
            this.BtnCargarImagen.IconMarginLeft = 0;
            this.BtnCargarImagen.IconMarginRight = 0;
            this.BtnCargarImagen.IconRightVisible = true;
            this.BtnCargarImagen.IconRightZoom = 0D;
            this.BtnCargarImagen.IconVisible = true;
            this.BtnCargarImagen.IconZoom = 50D;
            this.BtnCargarImagen.IsTab = false;
            this.BtnCargarImagen.Location = new System.Drawing.Point(577, 295);
            this.BtnCargarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Normalcolor = System.Drawing.Color.Teal;
            this.BtnCargarImagen.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.BtnCargarImagen.OnHoverTextColor = System.Drawing.Color.Black;
            this.BtnCargarImagen.selected = false;
            this.BtnCargarImagen.Size = new System.Drawing.Size(145, 39);
            this.BtnCargarImagen.TabIndex = 9;
            this.BtnCargarImagen.Text = "Subir Imagen";
            this.BtnCargarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCargarImagen.Textcolor = System.Drawing.Color.White;
            this.BtnCargarImagen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // PBtribunal
            // 
            this.PBtribunal.BackColor = System.Drawing.Color.Transparent;
            this.PBtribunal.Location = new System.Drawing.Point(564, 78);
            this.PBtribunal.Name = "PBtribunal";
            this.PBtribunal.Size = new System.Drawing.Size(182, 191);
            this.PBtribunal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBtribunal.TabIndex = 4;
            this.PBtribunal.TabStop = false;
            // 
            // txtpais
            // 
            this.txtpais.Location = new System.Drawing.Point(37, 65);
            this.txtpais.Multiline = true;
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(218, 28);
            this.txtpais.TabIndex = 1;
            this.txtpais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpais_KeyPress);
            this.txtpais.MouseEnter += new System.EventHandler(this.txtpais_MouseEnter);
            this.txtpais.MouseLeave += new System.EventHandler(this.txtpais_MouseLeave);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.BackColor = System.Drawing.Color.Transparent;
            this.lblPais.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPais.Location = new System.Drawing.Point(34, 42);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 17);
            this.lblPais.TabIndex = 2;
            this.lblPais.Text = "Pais:";
            // 
            // txtComposicion
            // 
            this.txtComposicion.Location = new System.Drawing.Point(37, 241);
            this.txtComposicion.Multiline = true;
            this.txtComposicion.Name = "txtComposicion";
            this.txtComposicion.Size = new System.Drawing.Size(218, 50);
            this.txtComposicion.TabIndex = 5;
            this.txtComposicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComposicion_KeyPress);
            this.txtComposicion.MouseEnter += new System.EventHandler(this.txtComposicion_MouseEnter);
            this.txtComposicion.MouseLeave += new System.EventHandler(this.txtComposicion_MouseLeave);
            // 
            // lblComposicion
            // 
            this.lblComposicion.AutoSize = true;
            this.lblComposicion.BackColor = System.Drawing.Color.Transparent;
            this.lblComposicion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblComposicion.Location = new System.Drawing.Point(34, 207);
            this.lblComposicion.Name = "lblComposicion";
            this.lblComposicion.Size = new System.Drawing.Size(92, 17);
            this.lblComposicion.TabIndex = 0;
            this.lblComposicion.Text = "Nombre de la organización:";
            // 
            // FrmPrimerUso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PanelPu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolSPrimerUso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrimerUso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrimerUso";
            this.Load += new System.EventHandler(this.FrmPrimerUso_Load);
            this.ToolSPrimerUso.ResumeLayout(false);
            this.ToolSPrimerUso.PerformLayout();
            this.PanelPu.ResumeLayout(false);
            this.PanelPu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBtribunal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl Control1Frm;
        private System.Windows.Forms.ToolStrip ToolSPrimerUso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelPu;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.ToolStripLabel lblDemo;
        private System.Windows.Forms.ToolStripLabel LblPrimerU;
        private Bunifu.Framework.UI.BunifuDragControl ControlTool;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblComposicion;
        private System.Windows.Forms.PictureBox PBtribunal;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtComposicion;
        private System.Windows.Forms.Label LblimgT;
        private System.Windows.Forms.Label lblCorreoTribunalRegister;
        private System.Windows.Forms.TextBox txtSede;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.TextBox txtJurisdiccion;
        private System.Windows.Forms.Label lblJurisdiccion;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DateTimePicker DtpFundacion;
        private System.Windows.Forms.Label lblFecha;
        private Bunifu.Framework.UI.BunifuFlatButton BtnCargarImagen;
        private System.Windows.Forms.Button BtnContinuar;
        private System.Windows.Forms.Label Lblimgmax;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblContraRegister;
        private System.Windows.Forms.TextBox txtCorreoRegister;
        private System.Windows.Forms.TextBox TxtContraseñaRegister;
        private System.Windows.Forms.Label lblmenosseguras;
        private System.Windows.Forms.Label LblContrainfo;
    }
}