namespace Democratic
{
    partial class FrmPadron
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
            this.ToolP = new System.Windows.Forms.ToolStrip();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.lblDemocratic = new System.Windows.Forms.ToolStripLabel();
            this.lblPadron = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCV = new System.Windows.Forms.Label();
            this.lblCentroV = new System.Windows.Forms.Label();
            this.BtnAcceder = new System.Windows.Forms.Button();
            this.lblDui = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.PBPersona = new System.Windows.Forms.PictureBox();
            this.JrvCorrelativo = new System.Windows.Forms.Label();
            this.lbljrv = new System.Windows.Forms.Label();
            this.ToolP.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolP
            // 
            this.ToolP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.ToolP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrar,
            this.BtnMinimizar,
            this.lblDemocratic,
            this.lblPadron});
            this.ToolP.Location = new System.Drawing.Point(0, 0);
            this.ToolP.Name = "ToolP";
            this.ToolP.Size = new System.Drawing.Size(800, 25);
            this.ToolP.TabIndex = 0;
            this.ToolP.Text = "toolStrip1";
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
            // BtnMinimizar
            // 
            this.BtnMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMinimizar.Image = global::Democratic.Properties.Resources.expand_arrow_64px1;
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(23, 22);
            this.BtnMinimizar.Text = "Minimizar";
            // 
            // lblDemocratic
            // 
            this.lblDemocratic.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemocratic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDemocratic.Image = global::Democratic.Properties.Resources.logo1;
            this.lblDemocratic.Name = "lblDemocratic";
            this.lblDemocratic.Size = new System.Drawing.Size(107, 22);
            this.lblDemocratic.Text = "Democratic |";
            // 
            // lblPadron
            // 
            this.lblPadron.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadron.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPadron.Name = "lblPadron";
            this.lblPadron.Size = new System.Drawing.Size(50, 22);
            this.lblPadron.Text = "Participante";
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
            this.panel2.Controls.Add(this.lblCV);
            this.panel2.Controls.Add(this.lblCentroV);
            this.panel2.Controls.Add(this.BtnAcceder);
            this.panel2.Controls.Add(this.lblDui);
            this.panel2.Controls.Add(this.lblApellido);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.PBPersona);
            this.panel2.Controls.Add(this.JrvCorrelativo);
            this.panel2.Controls.Add(this.lbljrv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 572);
            this.panel2.TabIndex = 2;
            // 
            // lblCV
            // 
            this.lblCV.AutoSize = true;
            this.lblCV.BackColor = System.Drawing.Color.Transparent;
            this.lblCV.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV.Location = new System.Drawing.Point(52, 80);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(36, 33);
            this.lblCV.TabIndex = 12;
            this.lblCV.Text = "...";
            // 
            // lblCentroV
            // 
            this.lblCentroV.AutoSize = true;
            this.lblCentroV.BackColor = System.Drawing.Color.Transparent;
            this.lblCentroV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentroV.Location = new System.Drawing.Point(52, 31);
            this.lblCentroV.Name = "lblCentroV";
            this.lblCentroV.Size = new System.Drawing.Size(273, 31);
            this.lblCentroV.TabIndex = 11;
            this.lblCentroV.Text = "Sede de votación:";
            // 
            // BtnAcceder
            // 
            this.BtnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcceder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcceder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAcceder.Location = new System.Drawing.Point(314, 444);
            this.BtnAcceder.Name = "BtnAcceder";
            this.BtnAcceder.Size = new System.Drawing.Size(140, 39);
            this.BtnAcceder.TabIndex = 10;
            this.BtnAcceder.Text = "Continuar";
            this.BtnAcceder.UseVisualStyleBackColor = false;
            this.BtnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click);
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.BackColor = System.Drawing.Color.Transparent;
            this.lblDui.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDui.Location = new System.Drawing.Point(52, 367);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(96, 33);
            this.lblDui.TabIndex = 5;
            this.lblDui.Text = "Identificador";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(52, 294);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(125, 33);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(52, 233);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(123, 33);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // PBPersona
            // 
            this.PBPersona.BackColor = System.Drawing.Color.Transparent;
            this.PBPersona.Location = new System.Drawing.Point(502, 118);
            this.PBPersona.Name = "PBPersona";
            this.PBPersona.Size = new System.Drawing.Size(243, 273);
            this.PBPersona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPersona.TabIndex = 2;
            this.PBPersona.TabStop = false;
            // 
            // JrvCorrelativo
            // 
            this.JrvCorrelativo.AutoSize = true;
            this.JrvCorrelativo.BackColor = System.Drawing.Color.Transparent;
            this.JrvCorrelativo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JrvCorrelativo.Location = new System.Drawing.Point(52, 175);
            this.JrvCorrelativo.Name = "JrvCorrelativo";
            this.JrvCorrelativo.Size = new System.Drawing.Size(36, 33);
            this.JrvCorrelativo.TabIndex = 1;
            this.JrvCorrelativo.Text = "...";
            // 
            // lbljrv
            // 
            this.lbljrv.AutoSize = true;
            this.lbljrv.BackColor = System.Drawing.Color.Transparent;
            this.lbljrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljrv.Location = new System.Drawing.Point(52, 133);
            this.lbljrv.Name = "lbljrv";
            this.lbljrv.Size = new System.Drawing.Size(207, 31);
            this.lbljrv.TabIndex = 0;
            this.lbljrv.Text = "Mesa de votación:";
            // 
            // FrmPadron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolP);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPadron";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Participante";
            this.Load += new System.EventHandler(this.FrmPadron_Load);
            this.ToolP.ResumeLayout(false);
            this.ToolP.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.ToolStripLabel lblDemocratic;
        private System.Windows.Forms.ToolStripLabel lblPadron;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox PBPersona;
        private System.Windows.Forms.Label JrvCorrelativo;
        private System.Windows.Forms.Label lbljrv;
        private System.Windows.Forms.Button BtnAcceder;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.Label lblCentroV;
    }
}