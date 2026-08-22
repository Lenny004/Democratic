namespace Democratic
{
    partial class Acercade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acercade));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LblDemocratic = new System.Windows.Forms.ToolStripLabel();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMaximizar = new System.Windows.Forms.ToolStripButton();
            this.BtnNormal = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolVerayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolReq = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolError = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbinfo2 = new System.Windows.Forms.Label();
            this.lblinfo1 = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
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
            this.LblDemocratic,
            this.BtnCerrar,
            this.BtnMaximizar,
            this.BtnNormal,
            this.BtnMinimizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LblDemocratic
            // 
            this.LblDemocratic.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDemocratic.ForeColor = System.Drawing.Color.White;
            this.LblDemocratic.Image = global::Democratic.Properties.Resources.logo1;
            this.LblDemocratic.Name = "LblDemocratic";
            this.LblDemocratic.Size = new System.Drawing.Size(96, 22);
            this.LblDemocratic.Text = "Democratic";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCerrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Image = global::Democratic.Properties.Resources.delete_64px1;
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 22);
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMaximizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMaximizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMaximizar.Image = global::Democratic.Properties.Resources.expand_48px1;
            this.BtnMaximizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(23, 22);
            this.BtnMaximizar.Text = "Maximizar";
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnNormal
            // 
            this.BtnNormal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNormal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnMinimizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.Image = global::Democratic.Properties.Resources.expand_arrow_64px1;
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(23, 22);
            this.BtnMinimizar.Text = "Minimizar";
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 4);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(93)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolSistema,
            this.ToolMenu,
            this.ToolAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 29);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1000, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolSistema
            // 
            this.ToolSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CerrarToolStrip,
            this.SalirToolStrip});
            this.ToolSistema.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolSistema.ForeColor = System.Drawing.Color.White;
            this.ToolSistema.Name = "ToolSistema";
            this.ToolSistema.Size = new System.Drawing.Size(67, 21);
            this.ToolSistema.Text = "Sistema";
            // 
            // CerrarToolStrip
            // 
            this.CerrarToolStrip.Name = "CerrarToolStrip";
            this.CerrarToolStrip.Size = new System.Drawing.Size(154, 22);
            this.CerrarToolStrip.Text = "Cerrar Sesión";
            this.CerrarToolStrip.Click += new System.EventHandler(this.CerrarToolStrip_Click_1);
            // 
            // SalirToolStrip
            // 
            this.SalirToolStrip.Name = "SalirToolStrip";
            this.SalirToolStrip.Size = new System.Drawing.Size(154, 22);
            this.SalirToolStrip.Text = "Salir";
            this.SalirToolStrip.Click += new System.EventHandler(this.SalirToolStrip_Click_1);
            // 
            // ToolMenu
            // 
            this.ToolMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolMenu.Name = "ToolMenu";
            this.ToolMenu.Size = new System.Drawing.Size(107, 21);
            this.ToolMenu.Text = "Menú Principal";
            this.ToolMenu.Click += new System.EventHandler(this.menúPrincipalToolStripMenuItem_Click);
            // 
            // ToolAyuda
            // 
            this.ToolAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolVerayuda,
            this.ToolReq,
            this.ToolAcerca,
            this.ToolError});
            this.ToolAyuda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolAyuda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolAyuda.Name = "ToolAyuda";
            this.ToolAyuda.Size = new System.Drawing.Size(58, 21);
            this.ToolAyuda.Text = "Ayuda";
            // 
            // ToolVerayuda
            // 
            this.ToolVerayuda.Name = "ToolVerayuda";
            this.ToolVerayuda.Size = new System.Drawing.Size(293, 22);
            this.ToolVerayuda.Text = "Ver Ayuda";
            this.ToolVerayuda.Click += new System.EventHandler(this.ToolVerayuda_Click);
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
            this.ToolAcerca.Text = "Acerca del programa";
            // 
            // ToolError
            // 
            this.ToolError.Name = "ToolError";
            this.ToolError.Size = new System.Drawing.Size(293, 22);
            this.ToolError.Text = "Reportar error";
            this.ToolError.Click += new System.EventHandler(this.ToolError_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Democratic.Properties.Resources.Acerca_de;
            this.panel2.Controls.Add(this.lbinfo2);
            this.panel2.Controls.Add(this.lblinfo1);
            this.panel2.Controls.Add(this.lblTema);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 646);
            this.panel2.TabIndex = 4;
            // 
            // lbinfo2
            // 
            this.lbinfo2.AutoSize = true;
            this.lbinfo2.BackColor = System.Drawing.Color.Transparent;
            this.lbinfo2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfo2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbinfo2.Location = new System.Drawing.Point(41, 420);
            this.lbinfo2.Name = "lbinfo2";
            this.lbinfo2.Size = new System.Drawing.Size(632, 138);
            this.lbinfo2.TabIndex = 3;
            this.lbinfo2.Text = "El programa fue desarrollado por los siguientes programadores:\r\n\r\n- Eduardo Ernes" +
    "to Vargas Hernández \r\n- Gabriela Susana Méndez Barrera\r\n- Lenny Adrián Elías Sán" +
    "chez\r\n- Mónica Abigail Mejía Martinez";
            // 
            // lblinfo1
            // 
            this.lblinfo1.AutoSize = true;
            this.lblinfo1.BackColor = System.Drawing.Color.Transparent;
            this.lblinfo1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblinfo1.Location = new System.Drawing.Point(41, 101);
            this.lblinfo1.Name = "lblinfo1";
            this.lblinfo1.Size = new System.Drawing.Size(631, 230);
            this.lblinfo1.TabIndex = 2;
            this.lblinfo1.Text = resources.GetString("lblinfo1.Text");
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.BackColor = System.Drawing.Color.Transparent;
            this.lblTema.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTema.Location = new System.Drawing.Point(40, 43);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(299, 32);
            this.lblTema.TabIndex = 1;
            this.lblTema.Text = "¿Qué es Democratic?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Democratic.Properties.Resources.logo1;
            this.pictureBox1.Image = global::Democratic.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(707, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Acercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Acercade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acercade";
            this.Load += new System.EventHandler(this.Acercade_Load);
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

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel LblDemocratic;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnMaximizar;
        private System.Windows.Forms.ToolStripButton BtnNormal;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolSistema;
        private System.Windows.Forms.ToolStripMenuItem CerrarToolStrip;
        private System.Windows.Forms.ToolStripMenuItem SalirToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolAyuda;
        private System.Windows.Forms.ToolStripMenuItem ToolVerayuda;
        private System.Windows.Forms.ToolStripMenuItem ToolReq;
        private System.Windows.Forms.ToolStripMenuItem ToolAcerca;
        private System.Windows.Forms.ToolStripMenuItem ToolError;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ToolMenu;
        private System.Windows.Forms.Label lblinfo1;
        private System.Windows.Forms.Label lbinfo2;
    }
}