namespace Democratic
{
    partial class FrmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.lblDemocratic = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ControlPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelRegistrar = new System.Windows.Forms.Panel();
            this.TxtIDM = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.PBTribunalRegistrar = new System.Windows.Forms.PictureBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.TxtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.DtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.MskDui = new System.Windows.Forms.MaskedTextBox();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDui = new System.Windows.Forms.Label();
            this.lblDirec = new System.Windows.Forms.Label();
            this.lblCump = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ControlToolStrip = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.PanelRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTribunalRegistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrar,
            this.BtnMinimizar,
            this.lblDemocratic,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click_1);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMinimizar.Image = global::Democratic.Properties.Resources.expand_arrow_64px;
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(23, 22);
            this.BtnMinimizar.Text = "toolStripButton2";
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // lblDemocratic
            // 
            this.lblDemocratic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDemocratic.Name = "lblDemocratic";
            this.lblDemocratic.Size = new System.Drawing.Size(74, 22);
            this.lblDemocratic.Text = "Democratic |";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel1.Text = "Registrarse";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Fixed = true;
            this.ControlPanel.Horizontal = true;
            this.ControlPanel.TargetControl = this.PanelRegistrar;
            this.ControlPanel.Vertical = true;
            // 
            // PanelRegistrar
            // 
            this.PanelRegistrar.BackgroundImage = global::Democratic.Properties.Resources._1920x1080_png_wallpaper_;
            this.PanelRegistrar.Controls.Add(this.pictureBox1);
            this.PanelRegistrar.Controls.Add(this.TxtIDM);
            this.PanelRegistrar.Controls.Add(this.TxtTelefono);
            this.PanelRegistrar.Controls.Add(this.BtnBuscar);
            this.PanelRegistrar.Controls.Add(this.PBTribunalRegistrar);
            this.PanelRegistrar.Controls.Add(this.BtnRegistrar);
            this.PanelRegistrar.Controls.Add(this.TxtCorreoElectronico);
            this.PanelRegistrar.Controls.Add(this.DtpNacimiento);
            this.PanelRegistrar.Controls.Add(this.MskDui);
            this.PanelRegistrar.Controls.Add(this.txtDirección);
            this.PanelRegistrar.Controls.Add(this.txtapellido);
            this.PanelRegistrar.Controls.Add(this.txtnombre);
            this.PanelRegistrar.Controls.Add(this.lblNume);
            this.PanelRegistrar.Controls.Add(this.lblCorreo);
            this.PanelRegistrar.Controls.Add(this.lblDui);
            this.PanelRegistrar.Controls.Add(this.lblDirec);
            this.PanelRegistrar.Controls.Add(this.lblCump);
            this.PanelRegistrar.Controls.Add(this.lblApe);
            this.PanelRegistrar.Controls.Add(this.lblnom);
            this.PanelRegistrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRegistrar.Location = new System.Drawing.Point(0, 25);
            this.PanelRegistrar.Name = "PanelRegistrar";
            this.PanelRegistrar.Size = new System.Drawing.Size(800, 575);
            this.PanelRegistrar.TabIndex = 1;
            // 
            // TxtIDM
            // 
            this.TxtIDM.Location = new System.Drawing.Point(36, 92);
            this.TxtIDM.Name = "TxtIDM";
            this.TxtIDM.Size = new System.Drawing.Size(32, 23);
            this.TxtIDM.TabIndex = 13;
            this.TxtIDM.Visible = false;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Enabled = false;
            this.TxtTelefono.Location = new System.Drawing.Point(36, 423);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(153, 23);
            this.TxtTelefono.TabIndex = 12;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(229, 49);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(153, 34);
            this.BtnBuscar.TabIndex = 10;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // PBTribunalRegistrar
            // 
            this.PBTribunalRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.PBTribunalRegistrar.Location = new System.Drawing.Point(473, 70);
            this.PBTribunalRegistrar.Name = "PBTribunalRegistrar";
            this.PBTribunalRegistrar.Size = new System.Drawing.Size(315, 334);
            this.PBTribunalRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBTribunalRegistrar.TabIndex = 9;
            this.PBTribunalRegistrar.TabStop = false;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Location = new System.Drawing.Point(316, 486);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(168, 40);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // TxtCorreoElectronico
            // 
            this.TxtCorreoElectronico.Location = new System.Drawing.Point(36, 346);
            this.TxtCorreoElectronico.Multiline = true;
            this.TxtCorreoElectronico.Name = "TxtCorreoElectronico";
            this.TxtCorreoElectronico.Size = new System.Drawing.Size(199, 25);
            this.TxtCorreoElectronico.TabIndex = 2;
            this.TxtCorreoElectronico.MouseEnter += new System.EventHandler(this.TxtCorreoElectronico_MouseEnter);
            this.TxtCorreoElectronico.MouseLeave += new System.EventHandler(this.TxtCorreoElectronico_MouseLeave);
            // 
            // DtpNacimiento
            // 
            this.DtpNacimiento.CustomFormat = "yyyy-MM-dd";
            this.DtpNacimiento.Enabled = false;
            this.DtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpNacimiento.Location = new System.Drawing.Point(36, 221);
            this.DtpNacimiento.MaxDate = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.DtpNacimiento.Name = "DtpNacimiento";
            this.DtpNacimiento.Size = new System.Drawing.Size(153, 23);
            this.DtpNacimiento.TabIndex = 0;
            this.DtpNacimiento.Value = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            // 
            // MskDui
            // 
            this.MskDui.Location = new System.Drawing.Point(36, 55);
            this.MskDui.Mask = "00000000-0";
            this.MskDui.Name = "MskDui";
            this.MskDui.Size = new System.Drawing.Size(140, 23);
            this.MskDui.TabIndex = 1;
            this.MskDui.MouseEnter += new System.EventHandler(this.MskDui_MouseEnter);
            this.MskDui.MouseLeave += new System.EventHandler(this.MskDui_MouseLeave);
            // 
            // txtDirección
            // 
            this.txtDirección.Enabled = false;
            this.txtDirección.Location = new System.Drawing.Point(229, 221);
            this.txtDirección.Multiline = true;
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.ReadOnly = true;
            this.txtDirección.Size = new System.Drawing.Size(213, 88);
            this.txtDirección.TabIndex = 3;
            // 
            // txtapellido
            // 
            this.txtapellido.Enabled = false;
            this.txtapellido.Location = new System.Drawing.Point(229, 148);
            this.txtapellido.Multiline = true;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.ReadOnly = true;
            this.txtapellido.Size = new System.Drawing.Size(153, 25);
            this.txtapellido.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(36, 138);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(153, 25);
            this.txtnombre.TabIndex = 1;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.Color.Transparent;
            this.lblNume.ForeColor = System.Drawing.Color.White;
            this.lblNume.Location = new System.Drawing.Point(33, 387);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(137, 17);
            this.lblNume.TabIndex = 7;
            this.lblNume.Text = "Número de teléfono:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(33, 315);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(383, 17);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo electronico: (Necesario para enviarle la contraseña)";
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.BackColor = System.Drawing.Color.Transparent;
            this.lblDui.ForeColor = System.Drawing.Color.White;
            this.lblDui.Location = new System.Drawing.Point(33, 26);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(35, 17);
            this.lblDui.TabIndex = 4;
            this.lblDui.Text = "Documento de identidad:";
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.BackColor = System.Drawing.Color.Transparent;
            this.lblDirec.ForeColor = System.Drawing.Color.White;
            this.lblDirec.Location = new System.Drawing.Point(226, 188);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(71, 17);
            this.lblDirec.TabIndex = 3;
            this.lblDirec.Text = "Dirección:";
            // 
            // lblCump
            // 
            this.lblCump.AutoSize = true;
            this.lblCump.BackColor = System.Drawing.Color.Transparent;
            this.lblCump.ForeColor = System.Drawing.Color.White;
            this.lblCump.Location = new System.Drawing.Point(33, 188);
            this.lblCump.Name = "lblCump";
            this.lblCump.Size = new System.Drawing.Size(143, 17);
            this.lblCump.TabIndex = 2;
            this.lblCump.Text = "Fecha de nacimiento:";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.BackColor = System.Drawing.Color.Transparent;
            this.lblApe.ForeColor = System.Drawing.Color.White;
            this.lblApe.Location = new System.Drawing.Point(226, 118);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(69, 17);
            this.lblApe.TabIndex = 1;
            this.lblApe.Text = "Apellidos:";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.BackColor = System.Drawing.Color.Transparent;
            this.lblnom.ForeColor = System.Drawing.Color.White;
            this.lblnom.Location = new System.Drawing.Point(33, 118);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(69, 17);
            this.lblnom.TabIndex = 0;
            this.lblnom.Text = "Nombres:";
            this.lblnom.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 3);
            this.panel2.TabIndex = 2;
            // 
            // ControlToolStrip
            // 
            this.ControlToolStrip.Fixed = true;
            this.ControlToolStrip.Horizontal = true;
            this.ControlToolStrip.TargetControl = this.toolStrip1;
            this.ControlToolStrip.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Democratic.Properties.Resources.back_to_60px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelRegistrar);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "|";
            this.Load += new System.EventHandler(this.FrmRegistrar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelRegistrar.ResumeLayout(false);
            this.PanelRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTribunalRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel PanelRegistrar;
        private System.Windows.Forms.TextBox TxtCorreoElectronico;
        private System.Windows.Forms.DateTimePicker DtpNacimiento;
        private System.Windows.Forms.MaskedTextBox MskDui;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.Label lblCump;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.PictureBox PBTribunalRegistrar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ToolStripLabel lblDemocratic;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl ControlPanel;
        private Bunifu.Framework.UI.BunifuDragControl ControlToolStrip;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox TxtIDM;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}