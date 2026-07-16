namespace Democratic
{
    partial class FrmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfo));
            this.Esclarecer = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.Elipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnOK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbltext2 = new System.Windows.Forms.Label();
            this.lbltext1 = new System.Windows.Forms.Label();
            this.lblinfo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Esclarecer
            // 
            this.Esclarecer.Delay = 1;
            // 
            // Elipse1
            // 
            this.Elipse1.ElipseRadius = 6;
            this.Elipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.BtnOK);
            this.bunifuGradientPanel1.Controls.Add(this.lbltext2);
            this.bunifuGradientPanel1.Controls.Add(this.lbltext1);
            this.bunifuGradientPanel1.Controls.Add(this.lblinfo);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(100)))), ((int)(((byte)(132)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(105)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(100)))), ((int)(((byte)(132)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(105)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(580, 398);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // BtnOK
            // 
            this.BtnOK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(31)))), ((int)(((byte)(111)))));
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(189)))));
            this.BtnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOK.BorderRadius = 0;
            this.BtnOK.ButtonText = "Continuar";
            this.BtnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOK.DisabledColor = System.Drawing.Color.Gray;
            this.BtnOK.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnOK.Iconimage = null;
            this.BtnOK.Iconimage_right = null;
            this.BtnOK.Iconimage_right_Selected = null;
            this.BtnOK.Iconimage_Selected = null;
            this.BtnOK.IconMarginLeft = 0;
            this.BtnOK.IconMarginRight = 0;
            this.BtnOK.IconRightVisible = true;
            this.BtnOK.IconRightZoom = 0D;
            this.BtnOK.IconVisible = true;
            this.BtnOK.IconZoom = 90D;
            this.BtnOK.IsTab = false;
            this.BtnOK.Location = new System.Drawing.Point(197, 345);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(189)))));
            this.BtnOK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.BtnOK.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnOK.selected = false;
            this.BtnOK.Size = new System.Drawing.Size(166, 43);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "Continuar";
            this.BtnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnOK.Textcolor = System.Drawing.Color.White;
            this.BtnOK.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lbltext2
            // 
            this.lbltext2.AutoSize = true;
            this.lbltext2.BackColor = System.Drawing.Color.Transparent;
            this.lbltext2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext2.ForeColor = System.Drawing.Color.White;
            this.lbltext2.Location = new System.Drawing.Point(14, 241);
            this.lbltext2.Name = "lbltext2";
            this.lbltext2.Size = new System.Drawing.Size(551, 84);
            this.lbltext2.TabIndex = 3;
            this.lbltext2.Text = resources.GetString("lbltext2.Text");
            // 
            // lbltext1
            // 
            this.lbltext1.AutoSize = true;
            this.lbltext1.BackColor = System.Drawing.Color.Transparent;
            this.lbltext1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext1.ForeColor = System.Drawing.Color.White;
            this.lbltext1.Location = new System.Drawing.Point(315, 53);
            this.lbltext1.Name = "lbltext1";
            this.lbltext1.Size = new System.Drawing.Size(253, 168);
            this.lbltext1.TabIndex = 2;
            this.lbltext1.Text = resources.GetString("lbltext1.Text");
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblinfo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.White;
            this.lblinfo.Location = new System.Drawing.Point(191, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(172, 32);
            this.lblinfo.TabIndex = 1;
            this.lblinfo.Text = "Información";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Democratic.Properties.Resources.DUI;
            this.pictureBox1.Image = global::Democratic.Properties.Resources.DUI;
            this.pictureBox1.Location = new System.Drawing.Point(18, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 432);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInfo";
            this.Load += new System.EventHandler(this.FrmInfo_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFormFadeTransition Esclarecer;
        private Bunifu.Framework.UI.BunifuElipse Elipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblinfo;
        private System.Windows.Forms.Label lbltext2;
        private System.Windows.Forms.Label lbltext1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnOK;
    }
}