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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Control1Frm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ToolSPrimerUso = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPrimerU = new System.Windows.Forms.ToolStripLabel();
            this.ControlTool = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelPu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.lblDemo = new System.Windows.Forms.ToolStripLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ToolSPrimerUso.SuspendLayout();
            this.PanelPu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 3);
            this.panel1.TabIndex = 1;
            // 
            // LblPrimerU
            // 
            this.LblPrimerU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblPrimerU.Name = "LblPrimerU";
            this.LblPrimerU.Size = new System.Drawing.Size(65, 22);
            this.LblPrimerU.Text = "Primer Uso";
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
            this.PanelPu.Controls.Add(this.pictureBox1);
            this.PanelPu.Controls.Add(this.textBox2);
            this.PanelPu.Controls.Add(this.label2);
            this.PanelPu.Controls.Add(this.textBox1);
            this.PanelPu.Controls.Add(this.label1);
            this.PanelPu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelPu.Location = new System.Drawing.Point(0, 28);
            this.PanelPu.Name = "PanelPu";
            this.PanelPu.Size = new System.Drawing.Size(800, 572);
            this.PanelPu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Composición:";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 50);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(34, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pais:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 182);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 28);
            this.textBox2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(456, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 210);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.Name = "FrmPrimerUso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrimerUso";
            this.ToolSPrimerUso.ResumeLayout(false);
            this.ToolSPrimerUso.PerformLayout();
            this.PanelPu.ResumeLayout(false);
            this.PanelPu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}