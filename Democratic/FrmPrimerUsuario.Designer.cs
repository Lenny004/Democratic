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
            this.ToolSPUser = new System.Windows.Forms.ToolStrip();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.lblDemo = new System.Windows.Forms.ToolStripLabel();
            this.lblPUser = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ToolSPUser.SuspendLayout();
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
            // lblDemo
            // 
            this.lblDemo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDemo.Image = global::Democratic.Properties.Resources.logo1;
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(90, 22);
            this.lblDemo.Text = "Democratic |";
            // 
            // lblPUser
            // 
            this.lblPUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPUser.Name = "lblPUser";
            this.lblPUser.Size = new System.Drawing.Size(85, 22);
            this.lblPUser.Text = "Primer Usuario";
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 572);
            this.panel2.TabIndex = 2;
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
            this.Name = "FrmPrimerUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrimerUsuario";
            this.ToolSPUser.ResumeLayout(false);
            this.ToolSPUser.PerformLayout();
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
    }
}