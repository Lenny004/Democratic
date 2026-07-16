namespace Democratic
{
    partial class FrmReportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónTool = new System.Windows.Forms.ToolStripMenuItem();
            this.salirTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolVerAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolReq = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolError = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDemocratic = new System.Windows.Forms.ToolStripLabel();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMaximizar = new System.Windows.Forms.ToolStripButton();
            this.BtnNormal = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPrimerUsuario = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.TxtNombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblCaptura = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.BtnImagen = new System.Windows.Forms.Button();
            this.TxtDes = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtAsunto = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtEmail = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lblreport = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDemocratic,
            this.BtnCerrar,
            this.BtnMaximizar,
            this.BtnNormal,
            this.BtnMinimizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 3);
            this.panel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(93)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolSistema,
            this.ToolMenu,
            this.ToolAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolSistema
            // 
            this.ToolSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónTool,
            this.salirTool});
            this.ToolSistema.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolSistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolSistema.Name = "ToolSistema";
            this.ToolSistema.Size = new System.Drawing.Size(67, 21);
            this.ToolSistema.Text = "Sistema";
            // 
            // cerrarSesiónTool
            // 
            this.cerrarSesiónTool.Name = "cerrarSesiónTool";
            this.cerrarSesiónTool.Size = new System.Drawing.Size(154, 22);
            this.cerrarSesiónTool.Text = "Cerrar Sesión";
            this.cerrarSesiónTool.Click += new System.EventHandler(this.cerrarSesiónTool_Click);
            // 
            // salirTool
            // 
            this.salirTool.Name = "salirTool";
            this.salirTool.Size = new System.Drawing.Size(154, 22);
            this.salirTool.Text = "Salir";
            this.salirTool.Click += new System.EventHandler(this.salirTool_Click);
            // 
            // ToolMenu
            // 
            this.ToolMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolMenu.Name = "ToolMenu";
            this.ToolMenu.Size = new System.Drawing.Size(108, 21);
            this.ToolMenu.Text = "Menú principal";
            this.ToolMenu.Click += new System.EventHandler(this.ToolMenu_Click);
            // 
            // ToolAyuda
            // 
            this.ToolAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolVerAyuda,
            this.ToolReq,
            this.ToolAcerca,
            this.ToolError});
            this.ToolAyuda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolAyuda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolAyuda.Name = "ToolAyuda";
            this.ToolAyuda.Size = new System.Drawing.Size(58, 21);
            this.ToolAyuda.Text = "Ayuda";
            // 
            // ToolVerAyuda
            // 
            this.ToolVerAyuda.Name = "ToolVerAyuda";
            this.ToolVerAyuda.Size = new System.Drawing.Size(293, 22);
            this.ToolVerAyuda.Text = "Ver Ayuda";
            this.ToolVerAyuda.Click += new System.EventHandler(this.ToolVerAyuda_Click);
            // 
            // ToolReq
            // 
            this.ToolReq.Name = "ToolReq";
            this.ToolReq.Size = new System.Drawing.Size(293, 22);
            this.ToolReq.Text = "Requerimientos técnicos del sistema";
            // 
            // ToolAcerca
            // 
            this.ToolAcerca.Name = "ToolAcerca";
            this.ToolAcerca.Size = new System.Drawing.Size(293, 22);
            this.ToolAcerca.Text = "Acerca del Programa";
            this.ToolAcerca.Click += new System.EventHandler(this.acercaDelProgramaToolStripMenuItem_Click);
            // 
            // ToolError
            // 
            this.ToolError.Name = "ToolError";
            this.ToolError.Size = new System.Drawing.Size(293, 22);
            this.ToolError.Text = "Reportar error";
            // 
            // lblDemocratic
            // 
            this.lblDemocratic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDemocratic.Image = global::Democratic.Properties.Resources.logo1;
            this.lblDemocratic.Name = "lblDemocratic";
            this.lblDemocratic.Size = new System.Drawing.Size(84, 22);
            this.lblDemocratic.Text = "Democratic";
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
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMaximizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMaximizar.Image = global::Democratic.Properties.Resources.expand_48px1;
            this.BtnMaximizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(23, 22);
            this.BtnMaximizar.Text = "BtnMaximizar";
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnNormal
            // 
            this.BtnNormal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNormal.Image = global::Democratic.Properties.Resources.normal_screen_64px1;
            this.BtnNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(23, 22);
            this.BtnNormal.Text = "Normal";
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
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
            // panel2
            // 
            this.panel2.BackgroundImage = global::Democratic.Properties.Resources.Acerca_de;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnPrimerUsuario);
            this.panel2.Controls.Add(this.lbl3);
            this.panel2.Controls.Add(this.lbl2);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.TxtNombre);
            this.panel2.Controls.Add(this.lblinfo);
            this.panel2.Controls.Add(this.lblCaptura);
            this.panel2.Controls.Add(this.lblAsunto);
            this.panel2.Controls.Add(this.lblDescrip);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.BtnImagen);
            this.panel2.Controls.Add(this.TxtDes);
            this.panel2.Controls.Add(this.TxtAsunto);
            this.panel2.Controls.Add(this.TxtEmail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Lblreport);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 649);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(530, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "*";
            // 
            // BtnPrimerUsuario
            // 
            this.BtnPrimerUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnPrimerUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrimerUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnPrimerUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnPrimerUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnPrimerUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrimerUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrimerUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnPrimerUsuario.Location = new System.Drawing.Point(378, 502);
            this.BtnPrimerUsuario.Name = "BtnPrimerUsuario";
            this.BtnPrimerUsuario.Size = new System.Drawing.Size(146, 42);
            this.BtnPrimerUsuario.TabIndex = 6;
            this.BtnPrimerUsuario.Text = "Enviar";
            this.BtnPrimerUsuario.UseVisualStyleBackColor = false;
            this.BtnPrimerUsuario.Click += new System.EventHandler(this.BtnPrimerUsuario_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Red;
            this.lbl3.Location = new System.Drawing.Point(428, 205);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(15, 20);
            this.lbl3.TabIndex = 16;
            this.lbl3.Text = "*";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Red;
            this.lbl2.Location = new System.Drawing.Point(428, 127);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(15, 20);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "*";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(435, 51);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(15, 20);
            this.lbl1.TabIndex = 14;
            this.lbl1.Text = "*";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(375, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 16);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtNombre.Location = new System.Drawing.Point(378, 78);
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(290, 28);
            this.TxtNombre.TabIndex = 1;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblinfo.ForeColor = System.Drawing.Color.Black;
            this.lblinfo.Location = new System.Drawing.Point(531, 447);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(199, 17);
            this.lblinfo.TabIndex = 11;
            this.lblinfo.Text = "Ningún Archivo Seleccionado";
            // 
            // lblCaptura
            // 
            this.lblCaptura.AutoSize = true;
            this.lblCaptura.BackColor = System.Drawing.Color.Transparent;
            this.lblCaptura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCaptura.Location = new System.Drawing.Point(378, 414);
            this.lblCaptura.Name = "lblCaptura";
            this.lblCaptura.Size = new System.Drawing.Size(202, 16);
            this.lblCaptura.TabIndex = 10;
            this.lblCaptura.Text = "Adjuntar Captura de Pantalla";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.BackColor = System.Drawing.Color.Transparent;
            this.lblAsunto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsunto.Location = new System.Drawing.Point(375, 205);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(56, 16);
            this.lblAsunto.TabIndex = 9;
            this.lblAsunto.Text = "Asunto:";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.BackColor = System.Drawing.Color.Transparent;
            this.lblDescrip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescrip.Location = new System.Drawing.Point(375, 285);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(149, 16);
            this.lblDescrip.TabIndex = 8;
            this.lblDescrip.Text = "Descripción del error:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(375, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 16);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail:";
            // 
            // BtnImagen
            // 
            this.BtnImagen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImagen.Location = new System.Drawing.Point(381, 442);
            this.BtnImagen.Name = "BtnImagen";
            this.BtnImagen.Size = new System.Drawing.Size(134, 29);
            this.BtnImagen.TabIndex = 5;
            this.BtnImagen.Text = "Seleccionar Archivo";
            this.BtnImagen.UseVisualStyleBackColor = true;
            this.BtnImagen.Click += new System.EventHandler(this.BtnImagen_Click);
            // 
            // TxtDes
            // 
            this.TxtDes.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtDes.ForeColor = System.Drawing.Color.Black;
            this.TxtDes.Location = new System.Drawing.Point(378, 317);
            this.TxtDes.Multiline = true;
            this.TxtDes.Name = "TxtDes";
            this.TxtDes.Size = new System.Drawing.Size(597, 84);
            this.TxtDes.TabIndex = 4;
            // 
            // TxtAsunto
            // 
            this.TxtAsunto.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtAsunto.ForeColor = System.Drawing.Color.Black;
            this.TxtAsunto.Location = new System.Drawing.Point(378, 237);
            this.TxtAsunto.Multiline = true;
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Size = new System.Drawing.Size(290, 28);
            this.TxtAsunto.TabIndex = 3;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtEmail.Location = new System.Drawing.Point(378, 161);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(290, 28);
            this.TxtEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(26, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Indicanos con el máximo detalle como\r\nreproducir el error";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lblreport
            // 
            this.Lblreport.AutoSize = true;
            this.Lblreport.BackColor = System.Drawing.Color.Transparent;
            this.Lblreport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblreport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lblreport.Location = new System.Drawing.Point(95, 338);
            this.Lblreport.Name = "Lblreport";
            this.Lblreport.Size = new System.Drawing.Size(163, 23);
            this.Lblreport.TabIndex = 1;
            this.Lblreport.Text = "Reportar un error";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Democratic.Properties.Resources.Reporte;
            this.pictureBox1.Image = global::Democratic.Properties.Resources.Reporte;
            this.pictureBox1.Location = new System.Drawing.Point(44, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtNombre;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblCaptura;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button BtnImagen;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtDes;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtAsunto;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lblreport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button BtnPrimerUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolSistema;
        private System.Windows.Forms.ToolStripMenuItem ToolMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolAyuda;
        private System.Windows.Forms.ToolStripLabel lblDemocratic;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnMaximizar;
        private System.Windows.Forms.ToolStripButton BtnNormal;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónTool;
        private System.Windows.Forms.ToolStripMenuItem salirTool;
        private System.Windows.Forms.ToolStripMenuItem ToolVerAyuda;
        private System.Windows.Forms.ToolStripMenuItem ToolReq;
        private System.Windows.Forms.ToolStripMenuItem ToolAcerca;
        private System.Windows.Forms.ToolStripMenuItem ToolError;
    }
}