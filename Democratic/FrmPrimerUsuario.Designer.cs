namespace Democratic
{
    partial class FrmPrimerUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrimerUsuario));
            this.ToolSPUser = new System.Windows.Forms.ToolStrip();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.lblDemo = new System.Windows.Forms.ToolStripLabel();
            this.lblPUser = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CmbCV = new System.Windows.Forms.ComboBox();
            this.LblCentroV = new System.Windows.Forms.Label();
            this.CmbJRV = new System.Windows.Forms.ComboBox();
            this.lblcorrelativo = new System.Windows.Forms.Label();
            this.PictureLupa = new System.Windows.Forms.PictureBox();
            this.MskDui = new System.Windows.Forms.MaskedTextBox();
            this.lblDui = new System.Windows.Forms.Label();
            this.checkPass = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblCoincidencia = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.lblMiembro = new System.Windows.Forms.Label();
            this.CmbMiembro = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstadoUser = new System.Windows.Forms.Label();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.LblPassConfirm = new System.Windows.Forms.Label();
            this.CmbTipoUser = new System.Windows.Forms.ComboBox();
            this.lblTipoUser = new System.Windows.Forms.Label();
            this.txtClaveConfirm = new System.Windows.Forms.TextBox();
            this.txtClave2 = new System.Windows.Forms.TextBox();
            this.lblUser2 = new System.Windows.Forms.Label();
            this.lblproporcionado = new System.Windows.Forms.Label();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtUsuario2 = new System.Windows.Forms.TextBox();
            this.ControlPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ToolSPUser.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolSPUser
            // 
            this.ToolSPUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.ToolSPUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrar,
            this.BtnMinimizar,
            this.lblDemo,
            this.lblPUser});
            this.ToolSPUser.Location = new System.Drawing.Point(0, 0);
            this.ToolSPUser.Name = "ToolSPUser";
            this.ToolSPUser.Size = new System.Drawing.Size(800, 25);
            this.ToolSPUser.TabIndex = 0;
            this.ToolSPUser.Text = "toolStrip1";
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
            this.lblDemo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDemo.Image = global::Democratic.Properties.Resources.logo1;
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(97, 22);
            this.lblDemo.Text = "Democratic |";
            // 
            // lblPUser
            // 
            this.lblPUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPUser.Name = "lblPUser";
            this.lblPUser.Size = new System.Drawing.Size(179, 22);
            this.lblPUser.Text = "Configuración de Primer Usuario";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 3);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Democratic.Properties.Resources._1920x1080_png_wallpaper_;
            this.panel2.Controls.Add(this.CmbCV);
            this.panel2.Controls.Add(this.LblCentroV);
            this.panel2.Controls.Add(this.CmbJRV);
            this.panel2.Controls.Add(this.lblcorrelativo);
            this.panel2.Controls.Add(this.PictureLupa);
            this.panel2.Controls.Add(this.MskDui);
            this.panel2.Controls.Add(this.lblDui);
            this.panel2.Controls.Add(this.checkPass);
            this.panel2.Controls.Add(this.lblCoincidencia);
            this.panel2.Controls.Add(this.BtnIngresar);
            this.panel2.Controls.Add(this.lblMiembro);
            this.panel2.Controls.Add(this.CmbMiembro);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.CmbEstado);
            this.panel2.Controls.Add(this.lblEstadoUser);
            this.panel2.Controls.Add(this.bunifuSeparator3);
            this.panel2.Controls.Add(this.LblPassConfirm);
            this.panel2.Controls.Add(this.CmbTipoUser);
            this.panel2.Controls.Add(this.lblTipoUser);
            this.panel2.Controls.Add(this.txtClaveConfirm);
            this.panel2.Controls.Add(this.txtClave2);
            this.panel2.Controls.Add(this.lblUser2);
            this.panel2.Controls.Add(this.lblproporcionado);
            this.panel2.Controls.Add(this.lblPass2);
            this.panel2.Controls.Add(this.bunifuSeparator2);
            this.panel2.Controls.Add(this.txtUsuario2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 572);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // CmbCV
            // 
            this.CmbCV.Enabled = false;
            this.CmbCV.FormattingEnabled = true;
            this.CmbCV.Location = new System.Drawing.Point(422, 213);
            this.CmbCV.Name = "CmbCV";
            this.CmbCV.Size = new System.Drawing.Size(327, 24);
            this.CmbCV.TabIndex = 53;
            // 
            // LblCentroV
            // 
            this.LblCentroV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblCentroV.AutoSize = true;
            this.LblCentroV.BackColor = System.Drawing.Color.Transparent;
            this.LblCentroV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCentroV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblCentroV.Location = new System.Drawing.Point(419, 173);
            this.LblCentroV.Name = "LblCentroV";
            this.LblCentroV.Size = new System.Drawing.Size(142, 17);
            this.LblCentroV.TabIndex = 52;
            this.LblCentroV.Text = "Centro de votación:";
            // 
            // CmbJRV
            // 
            this.CmbJRV.Enabled = false;
            this.CmbJRV.FormattingEnabled = true;
            this.CmbJRV.Location = new System.Drawing.Point(422, 302);
            this.CmbJRV.Name = "CmbJRV";
            this.CmbJRV.Size = new System.Drawing.Size(327, 24);
            this.CmbJRV.TabIndex = 51;
            // 
            // lblcorrelativo
            // 
            this.lblcorrelativo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcorrelativo.AutoSize = true;
            this.lblcorrelativo.BackColor = System.Drawing.Color.Transparent;
            this.lblcorrelativo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorrelativo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcorrelativo.Location = new System.Drawing.Point(419, 262);
            this.lblcorrelativo.Name = "lblcorrelativo";
            this.lblcorrelativo.Size = new System.Drawing.Size(153, 17);
            this.lblcorrelativo.TabIndex = 50;
            this.lblcorrelativo.Text = "Mesa de votación:";
            // 
            // PictureLupa
            // 
            this.PictureLupa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureLupa.Image = global::Democratic.Properties.Resources.search_48px;
            this.PictureLupa.Location = new System.Drawing.Point(546, 391);
            this.PictureLupa.Name = "PictureLupa";
            this.PictureLupa.Size = new System.Drawing.Size(27, 23);
            this.PictureLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLupa.TabIndex = 48;
            this.PictureLupa.TabStop = false;
            this.PictureLupa.Click += new System.EventHandler(this.PictureLupa_Click);
            // 
            // MskDui
            // 
            this.MskDui.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskDui.Location = new System.Drawing.Point(422, 392);
            this.MskDui.Mask = "00000000-0";
            this.MskDui.Name = "MskDui";
            this.MskDui.Size = new System.Drawing.Size(128, 23);
            this.MskDui.TabIndex = 4;
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.BackColor = System.Drawing.Color.Transparent;
            this.lblDui.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDui.ForeColor = System.Drawing.Color.White;
            this.lblDui.Location = new System.Drawing.Point(419, 348);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(97, 34);
            this.lblDui.TabIndex = 47;
            this.lblDui.Text = "Ingrese el DUI \r\ndel miembro:";
            // 
            // checkPass
            // 
            this.checkPass.BackColor = System.Drawing.Color.White;
            this.checkPass.ChechedOffColor = System.Drawing.Color.White;
            this.checkPass.Checked = false;
            this.checkPass.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.checkPass.ForeColor = System.Drawing.Color.White;
            this.checkPass.Location = new System.Drawing.Point(336, 217);
            this.checkPass.Margin = new System.Windows.Forms.Padding(4);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(20, 20);
            this.checkPass.TabIndex = 45;
            this.checkPass.OnChange += new System.EventHandler(this.checkPass_OnChange);
            // 
            // lblCoincidencia
            // 
            this.lblCoincidencia.AutoSize = true;
            this.lblCoincidencia.BackColor = System.Drawing.Color.Transparent;
            this.lblCoincidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoincidencia.ForeColor = System.Drawing.Color.SeaShell;
            this.lblCoincidencia.Location = new System.Drawing.Point(197, 280);
            this.lblCoincidencia.Name = "lblCoincidencia";
            this.lblCoincidencia.Size = new System.Drawing.Size(16, 13);
            this.lblCoincidencia.TabIndex = 44;
            this.lblCoincidencia.Text = "...";
            this.lblCoincidencia.Visible = false;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnIngresar.Enabled = false;
            this.BtnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnIngresar.Location = new System.Drawing.Point(112, 429);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(147, 42);
            this.BtnIngresar.TabIndex = 5;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // lblMiembro
            // 
            this.lblMiembro.AutoSize = true;
            this.lblMiembro.BackColor = System.Drawing.Color.Transparent;
            this.lblMiembro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiembro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMiembro.Location = new System.Drawing.Point(608, 365);
            this.lblMiembro.Name = "lblMiembro";
            this.lblMiembro.Size = new System.Drawing.Size(69, 17);
            this.lblMiembro.TabIndex = 40;
            this.lblMiembro.Text = "Miembro:";
            // 
            // CmbMiembro
            // 
            this.CmbMiembro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMiembro.Enabled = false;
            this.CmbMiembro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMiembro.FormattingEnabled = true;
            this.CmbMiembro.Location = new System.Drawing.Point(608, 392);
            this.CmbMiembro.Name = "CmbMiembro";
            this.CmbMiembro.Size = new System.Drawing.Size(141, 25);
            this.CmbMiembro.TabIndex = 38;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(49, 236);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(278, 10);
            this.bunifuSeparator1.TabIndex = 28;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.Enabled = false;
            this.CmbEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(608, 110);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(141, 25);
            this.CmbEstado.TabIndex = 33;
            // 
            // lblEstadoUser
            // 
            this.lblEstadoUser.AutoSize = true;
            this.lblEstadoUser.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEstadoUser.Location = new System.Drawing.Point(605, 90);
            this.lblEstadoUser.Name = "lblEstadoUser";
            this.lblEstadoUser.Size = new System.Drawing.Size(130, 17);
            this.lblEstadoUser.TabIndex = 34;
            this.lblEstadoUser.Text = "Estado del usuario:";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(49, 136);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(278, 10);
            this.bunifuSeparator3.TabIndex = 37;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // LblPassConfirm
            // 
            this.LblPassConfirm.AutoSize = true;
            this.LblPassConfirm.BackColor = System.Drawing.Color.Transparent;
            this.LblPassConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassConfirm.ForeColor = System.Drawing.Color.White;
            this.LblPassConfirm.Location = new System.Drawing.Point(47, 276);
            this.LblPassConfirm.Name = "LblPassConfirm";
            this.LblPassConfirm.Size = new System.Drawing.Size(157, 17);
            this.LblPassConfirm.TabIndex = 35;
            this.LblPassConfirm.Text = "Confirmar Contraseña:";
            // 
            // CmbTipoUser
            // 
            this.CmbTipoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoUser.Enabled = false;
            this.CmbTipoUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoUser.FormattingEnabled = true;
            this.CmbTipoUser.Location = new System.Drawing.Point(422, 111);
            this.CmbTipoUser.Name = "CmbTipoUser";
            this.CmbTipoUser.Size = new System.Drawing.Size(141, 25);
            this.CmbTipoUser.TabIndex = 31;
            // 
            // lblTipoUser
            // 
            this.lblTipoUser.AutoSize = true;
            this.lblTipoUser.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTipoUser.Location = new System.Drawing.Point(419, 90);
            this.lblTipoUser.Name = "lblTipoUser";
            this.lblTipoUser.Size = new System.Drawing.Size(109, 17);
            this.lblTipoUser.TabIndex = 32;
            this.lblTipoUser.Text = "Tipo de usuario:";
            // 
            // txtClaveConfirm
            // 
            this.txtClaveConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(158)))), ((int)(((byte)(155)))));
            this.txtClaveConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClaveConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveConfirm.Location = new System.Drawing.Point(50, 306);
            this.txtClaveConfirm.Multiline = true;
            this.txtClaveConfirm.Name = "txtClaveConfirm";
            this.txtClaveConfirm.PasswordChar = '*';
            this.txtClaveConfirm.Size = new System.Drawing.Size(272, 24);
            this.txtClaveConfirm.TabIndex = 3;
            this.txtClaveConfirm.MouseEnter += new System.EventHandler(this.txtClaveConfirm_MouseEnter);
            this.txtClaveConfirm.MouseLeave += new System.EventHandler(this.txtClaveConfirm_MouseLeave);
            // 
            // txtClave2
            // 
            this.txtClave2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(145)))), ((int)(((byte)(141)))));
            this.txtClave2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave2.Location = new System.Drawing.Point(49, 213);
            this.txtClave2.Multiline = true;
            this.txtClave2.Name = "txtClave2";
            this.txtClave2.PasswordChar = '*';
            this.txtClave2.Size = new System.Drawing.Size(272, 24);
            this.txtClave2.TabIndex = 2;
            this.txtClave2.MouseEnter += new System.EventHandler(this.txtClave2_MouseEnter);
            this.txtClave2.MouseLeave += new System.EventHandler(this.txtClave2_MouseLeave);
            // 
            // lblUser2
            // 
            this.lblUser2.AutoSize = true;
            this.lblUser2.BackColor = System.Drawing.Color.Transparent;
            this.lblUser2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser2.ForeColor = System.Drawing.Color.White;
            this.lblUser2.Location = new System.Drawing.Point(47, 91);
            this.lblUser2.Name = "lblUser2";
            this.lblUser2.Size = new System.Drawing.Size(62, 17);
            this.lblUser2.TabIndex = 24;
            this.lblUser2.Text = "Usuario: ";
            // 
            // lblproporcionado
            // 
            this.lblproporcionado.AutoSize = true;
            this.lblproporcionado.BackColor = System.Drawing.Color.Transparent;
            this.lblproporcionado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproporcionado.ForeColor = System.Drawing.Color.White;
            this.lblproporcionado.Location = new System.Drawing.Point(109, 91);
            this.lblproporcionado.Name = "lblproporcionado";
            this.lblproporcionado.Size = new System.Drawing.Size(258, 17);
            this.lblproporcionado.TabIndex = 30;
            this.lblproporcionado.Text = "(correo proporcionado anteriormente)";
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.BackColor = System.Drawing.Color.Transparent;
            this.lblPass2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass2.ForeColor = System.Drawing.Color.White;
            this.lblPass2.Location = new System.Drawing.Point(47, 177);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(88, 17);
            this.lblPass2.TabIndex = 25;
            this.lblPass2.Text = "Contraseña:";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(50, 326);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(277, 10);
            this.bunifuSeparator2.TabIndex = 29;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // txtUsuario2
            // 
            this.txtUsuario2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(118)))), ((int)(((byte)(141)))));
            this.txtUsuario2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario2.Location = new System.Drawing.Point(50, 114);
            this.txtUsuario2.Multiline = true;
            this.txtUsuario2.Name = "txtUsuario2";
            this.txtUsuario2.Size = new System.Drawing.Size(272, 27);
            this.txtUsuario2.TabIndex = 1;
            this.txtUsuario2.MouseEnter += new System.EventHandler(this.txtUsuario2_MouseEnter);
            this.txtUsuario2.MouseLeave += new System.EventHandler(this.txtUsuario2_MouseLeave);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Fixed = true;
            this.ControlPanel.Horizontal = true;
            this.ControlPanel.TargetControl = this.panel2;
            this.ControlPanel.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.ToolSPUser;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmPrimerUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolSPUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrimerUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrimerUsuario";
            this.Load += new System.EventHandler(this.FrmPrimerUsuario_Load);
            this.ToolSPUser.ResumeLayout(false);
            this.ToolSPUser.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolSPUser;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.ToolStripLabel lblDemo;
        private System.Windows.Forms.ToolStripLabel lblPUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label lblEstadoUser;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label LblPassConfirm;
        private System.Windows.Forms.ComboBox CmbTipoUser;
        private System.Windows.Forms.Label lblTipoUser;
        private System.Windows.Forms.TextBox txtClaveConfirm;
        private System.Windows.Forms.TextBox txtClave2;
        private System.Windows.Forms.Label lblUser2;
        private System.Windows.Forms.Label lblproporcionado;
        private System.Windows.Forms.Label lblPass2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.TextBox txtUsuario2;
        private System.Windows.Forms.Label lblMiembro;
        private System.Windows.Forms.ComboBox CmbMiembro;
        private System.Windows.Forms.Button BtnIngresar;
        private Bunifu.Framework.UI.BunifuCheckbox checkPass;
        private System.Windows.Forms.Label lblCoincidencia;
        private Bunifu.Framework.UI.BunifuDragControl ControlPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.MaskedTextBox MskDui;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.PictureBox PictureLupa;
        private System.Windows.Forms.Label lblcorrelativo;
        private System.Windows.Forms.ComboBox CmbJRV;
        private System.Windows.Forms.ComboBox CmbCV;
        private System.Windows.Forms.Label LblCentroV;
    }
}