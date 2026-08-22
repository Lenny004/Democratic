namespace Democratic
{
    partial class FrmNotiVoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotiVoto));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnOK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblingresado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.BtnOK);
            this.bunifuGradientPanel1.Controls.Add(this.lblinfo);
            this.bunifuGradientPanel1.Controls.Add(this.lblingresado);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(100)))), ((int)(((byte)(132)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(105)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(100)))), ((int)(((byte)(132)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(105)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(398, 343);
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
            this.BtnOK.Location = new System.Drawing.Point(132, 296);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(189)))));
            this.BtnOK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.BtnOK.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnOK.selected = false;
            this.BtnOK.Size = new System.Drawing.Size(108, 33);
            this.BtnOK.TabIndex = 5;
            this.BtnOK.Text = "Continuar";
            this.BtnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnOK.Textcolor = System.Drawing.Color.White;
            this.BtnOK.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblinfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.White;
            this.lblinfo.Location = new System.Drawing.Point(22, 238);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(69, 20);
            this.lblinfo.TabIndex = 2;
            this.lblinfo.Text = "Tu voto se registró correctamente en el sistema";
            // 
            // lblingresado
            // 
            this.lblingresado.AutoSize = true;
            this.lblingresado.BackColor = System.Drawing.Color.Transparent;
            this.lblingresado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingresado.ForeColor = System.Drawing.Color.White;
            this.lblingresado.Location = new System.Drawing.Point(107, 195);
            this.lblingresado.Name = "lblingresado";
            this.lblingresado.Size = new System.Drawing.Size(103, 23);
            this.lblingresado.TabIndex = 1;
            this.lblingresado.Text = "Voto registrado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Democratic.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(111, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmNotiVoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 367);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNotiVoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNotiVoto";
            this.Load += new System.EventHandler(this.FrmNotiVoto_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblingresado;
        private Bunifu.Framework.UI.BunifuFlatButton BtnOK;
    }
}