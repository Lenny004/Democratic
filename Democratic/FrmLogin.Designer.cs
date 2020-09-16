namespace Democratic
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.ToolS1 = new System.Windows.Forms.ToolStrip();
            this.lblInicio = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Control1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Control2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Control3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPrimerUsuario = new System.Windows.Forms.Button();
            this.PicturePrimerUsuario = new System.Windows.Forms.PictureBox();
            this.Separador2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Separador1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.BtnPrimerUso = new System.Windows.Forms.Button();
            this.PicturePrimerUso = new System.Windows.Forms.PictureBox();
            this.lblOlvidar = new System.Windows.Forms.LinkLabel();
            this.BtnAcceder = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblRegistrar = new System.Windows.Forms.LinkLabel();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDemocraticLogin = new System.Windows.Forms.ToolStripLabel();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.ToolS1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePrimerUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePrimerUso)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolS1
            // 
            this.ToolS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.ToolS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDemocraticLogin,
            this.lblInicio,
            this.BtnCerrar,
            this.BtnMinimizar});
            this.ToolS1.Location = new System.Drawing.Point(0, 0);
            this.ToolS1.Name = "ToolS1";
            this.ToolS1.Size = new System.Drawing.Size(800, 25);
            this.ToolS1.TabIndex = 0;
            this.ToolS1.Text = "toolStrip1";
            // 
            // lblInicio
            // 
            this.lblInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(89, 22);
            this.lblInicio.Text = "Inicio de Sesión";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 3);
            this.panel2.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Control1
            // 
            this.Control1.Fixed = true;
            this.Control1.Horizontal = true;
            this.Control1.TargetControl = this.panel1;
            this.Control1.Vertical = true;
            // 
            // Control2
            // 
            this.Control2.Fixed = true;
            this.Control2.Horizontal = true;
            this.Control2.TargetControl = null;
            this.Control2.Vertical = true;
            // 
            // Control3
            // 
            this.Control3.Fixed = true;
            this.Control3.Horizontal = true;
            this.Control3.TargetControl = this.ToolS1;
            this.Control3.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.BtnPrimerUsuario);
            this.panel1.Controls.Add(this.PicturePrimerUsuario);
            this.panel1.Controls.Add(this.Separador2);
            this.panel1.Controls.Add(this.Separador1);
            this.panel1.Controls.Add(this.BtnPrimerUso);
            this.panel1.Controls.Add(this.PicturePrimerUso);
            this.panel1.Controls.Add(this.lblOlvidar);
            this.panel1.Controls.Add(this.BtnAcceder);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.lblRegistrar);
            this.panel1.Controls.Add(this.lblCuenta);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 575);
            this.panel1.TabIndex = 1;
            // 
            // BtnPrimerUsuario
            // 
            this.BtnPrimerUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPrimerUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnPrimerUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnPrimerUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnPrimerUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrimerUsuario.Location = new System.Drawing.Point(316, 386);
            this.BtnPrimerUsuario.Name = "BtnPrimerUsuario";
            this.BtnPrimerUsuario.Size = new System.Drawing.Size(171, 47);
            this.BtnPrimerUsuario.TabIndex = 18;
            this.BtnPrimerUsuario.Text = "Crear Primer Usuario";
            this.BtnPrimerUsuario.UseVisualStyleBackColor = false;
            this.BtnPrimerUsuario.Visible = false;
            this.BtnPrimerUsuario.Click += new System.EventHandler(this.BtnPrimerUsuario_Click);
            // 
            // PicturePrimerUsuario
            // 
            this.PicturePrimerUsuario.Image = global::Democratic.Properties.Resources.USUARIO;
            this.PicturePrimerUsuario.Location = new System.Drawing.Point(230, 74);
            this.PicturePrimerUsuario.Name = "PicturePrimerUsuario";
            this.PicturePrimerUsuario.Size = new System.Drawing.Size(350, 270);
            this.PicturePrimerUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturePrimerUsuario.TabIndex = 17;
            this.PicturePrimerUsuario.TabStop = false;
            this.PicturePrimerUsuario.Visible = false;
            this.PicturePrimerUsuario.Click += new System.EventHandler(this.PicturePrimerUsuario_Click);
            // 
            // Separador2
            // 
            this.Separador2.BackColor = System.Drawing.Color.Transparent;
            this.Separador2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separador2.LineThickness = 1;
            this.Separador2.Location = new System.Drawing.Point(474, 292);
            this.Separador2.Margin = new System.Windows.Forms.Padding(5);
            this.Separador2.Name = "Separador2";
            this.Separador2.Size = new System.Drawing.Size(297, 5);
            this.Separador2.TabIndex = 16;
            this.Separador2.Transparency = 255;
            this.Separador2.Vertical = false;
            // 
            // Separador1
            // 
            this.Separador1.BackColor = System.Drawing.Color.Transparent;
            this.Separador1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separador1.LineThickness = 1;
            this.Separador1.Location = new System.Drawing.Point(472, 195);
            this.Separador1.Margin = new System.Windows.Forms.Padding(4);
            this.Separador1.Name = "Separador1";
            this.Separador1.Size = new System.Drawing.Size(297, 5);
            this.Separador1.TabIndex = 15;
            this.Separador1.Transparency = 255;
            this.Separador1.Vertical = false;
            // 
            // BtnPrimerUso
            // 
            this.BtnPrimerUso.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPrimerUso.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnPrimerUso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnPrimerUso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnPrimerUso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrimerUso.Location = new System.Drawing.Point(316, 386);
            this.BtnPrimerUso.Name = "BtnPrimerUso";
            this.BtnPrimerUso.Size = new System.Drawing.Size(171, 47);
            this.BtnPrimerUso.TabIndex = 14;
            this.BtnPrimerUso.Text = "Crear Tribunal";
            this.BtnPrimerUso.UseVisualStyleBackColor = false;
            this.BtnPrimerUso.Visible = false;
            this.BtnPrimerUso.Click += new System.EventHandler(this.BtnPrimerUso_Click);
            // 
            // PicturePrimerUso
            // 
            this.PicturePrimerUso.Image = global::Democratic.Properties.Resources.tribunal;
            this.PicturePrimerUso.Location = new System.Drawing.Point(230, 74);
            this.PicturePrimerUso.Name = "PicturePrimerUso";
            this.PicturePrimerUso.Size = new System.Drawing.Size(350, 270);
            this.PicturePrimerUso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturePrimerUso.TabIndex = 12;
            this.PicturePrimerUso.TabStop = false;
            this.PicturePrimerUso.Visible = false;
            this.PicturePrimerUso.Click += new System.EventHandler(this.PicturePrimerUso_Click);
            // 
            // lblOlvidar
            // 
            this.lblOlvidar.AutoSize = true;
            this.lblOlvidar.BackColor = System.Drawing.Color.Transparent;
            this.lblOlvidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvidar.Location = new System.Drawing.Point(538, 427);
            this.lblOlvidar.Name = "lblOlvidar";
            this.lblOlvidar.Size = new System.Drawing.Size(162, 16);
            this.lblOlvidar.TabIndex = 10;
            this.lblOlvidar.TabStop = true;
            this.lblOlvidar.Text = "¿Olvidaste tu contraseña?";
            // 
            // BtnAcceder
            // 
            this.BtnAcceder.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcceder.Location = new System.Drawing.Point(565, 320);
            this.BtnAcceder.Name = "BtnAcceder";
            this.BtnAcceder.Size = new System.Drawing.Size(112, 33);
            this.BtnAcceder.TabIndex = 9;
            this.BtnAcceder.Text = "Iniciar Sesión";
            this.BtnAcceder.UseVisualStyleBackColor = false;
            this.BtnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(158)))), ((int)(((byte)(155)))));
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Location = new System.Drawing.Point(484, 270);
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(277, 27);
            this.txtClave.TabIndex = 2;
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar.Location = new System.Drawing.Point(667, 386);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(66, 15);
            this.lblRegistrar.TabIndex = 6;
            this.lblRegistrar.TabStop = true;
            this.lblRegistrar.Text = "Registrate!";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.Location = new System.Drawing.Point(470, 386);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(195, 15);
            this.lblCuenta.TabIndex = 5;
            this.lblCuenta.Text = "¿No has creado cuenta? Entonces";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(124)))), ((int)(((byte)(141)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(484, 173);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(277, 24);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.ForeColor = System.Drawing.Color.Black;
            this.lblPass.Location = new System.Drawing.Point(470, 234);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(85, 17);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Contraseña:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUser.Location = new System.Drawing.Point(481, 141);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 17);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuario:";
            // 
            // lblDemocraticLogin
            // 
            this.lblDemocraticLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDemocraticLogin.Image = global::Democratic.Properties.Resources.logo1;
            this.lblDemocraticLogin.Name = "lblDemocraticLogin";
            this.lblDemocraticLogin.Size = new System.Drawing.Size(90, 22);
            this.lblDemocraticLogin.Text = "Democratic |";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCerrar.Image = global::Democratic.Properties.Resources.delete_64px;
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
            this.BtnMinimizar.Image = global::Democratic.Properties.Resources.expand_arrow_64px;
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(23, 22);
            this.BtnMinimizar.Text = "Minimizar";
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolS1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ToolS1.ResumeLayout(false);
            this.ToolS1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePrimerUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePrimerUso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolS1;
        private System.Windows.Forms.ToolStripLabel lblInicio;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.LinkLabel lblRegistrar;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Button BtnAcceder;
        private System.Windows.Forms.LinkLabel lblOlvidar;
        private System.Windows.Forms.PictureBox PicturePrimerUso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnPrimerUso;
        private Bunifu.Framework.UI.BunifuSeparator Separador1;
        private Bunifu.Framework.UI.BunifuSeparator Separador2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl Control1;
        private Bunifu.Framework.UI.BunifuDragControl Control2;
        private Bunifu.Framework.UI.BunifuDragControl Control3;
        private System.Windows.Forms.ToolStripLabel lblDemocraticLogin;
        private System.Windows.Forms.PictureBox PicturePrimerUsuario;
        private System.Windows.Forms.Button BtnPrimerUsuario;
    }
}