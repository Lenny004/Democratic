namespace Democratic
{
    partial class FrmJRV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txtIdJRV = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.BtnRefrescarJRV = new System.Windows.Forms.Button();
            this.BtnActualizarJRV = new System.Windows.Forms.Button();
            this.BtnLimpiarJRV = new System.Windows.Forms.Button();
            this.BtnIngresarJRV = new System.Windows.Forms.Button();
            this.DataGridJRV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridJRV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 648);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEliminar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.txtIdJRV);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.BtnRefrescarJRV);
            this.groupBox1.Controls.Add(this.BtnActualizarJRV);
            this.groupBox1.Controls.Add(this.BtnLimpiarJRV);
            this.groupBox1.Controls.Add(this.BtnIngresarJRV);
            this.groupBox1.Controls.Add(this.DataGridJRV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 624);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(521, 256);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(188, 47);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar JRV";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Estado de la JRV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Centro de Votación:";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(217, 126);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Correlativo de la JRV: ";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(214, 50);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(194, 24);
            this.comboBox3.TabIndex = 26;
            // 
            // txtIdJRV
            // 
            this.txtIdJRV.Enabled = false;
            this.txtIdJRV.Location = new System.Drawing.Point(15, 268);
            this.txtIdJRV.Name = "txtIdJRV";
            this.txtIdJRV.ReadOnly = true;
            this.txtIdJRV.Size = new System.Drawing.Size(30, 23);
            this.txtIdJRV.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 50);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 23);
            this.textBox5.TabIndex = 14;
            // 
            // BtnRefrescarJRV
            // 
            this.BtnRefrescarJRV.Location = new System.Drawing.Point(521, 205);
            this.BtnRefrescarJRV.Name = "BtnRefrescarJRV";
            this.BtnRefrescarJRV.Size = new System.Drawing.Size(188, 47);
            this.BtnRefrescarJRV.TabIndex = 9;
            this.BtnRefrescarJRV.Text = "Refrescar Grid";
            this.BtnRefrescarJRV.UseVisualStyleBackColor = true;
            // 
            // BtnActualizarJRV
            // 
            this.BtnActualizarJRV.Location = new System.Drawing.Point(521, 103);
            this.BtnActualizarJRV.Name = "BtnActualizarJRV";
            this.BtnActualizarJRV.Size = new System.Drawing.Size(188, 47);
            this.BtnActualizarJRV.TabIndex = 8;
            this.BtnActualizarJRV.Text = "Actualizar JRV";
            this.BtnActualizarJRV.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiarJRV
            // 
            this.BtnLimpiarJRV.Location = new System.Drawing.Point(521, 154);
            this.BtnLimpiarJRV.Name = "BtnLimpiarJRV";
            this.BtnLimpiarJRV.Size = new System.Drawing.Size(188, 47);
            this.BtnLimpiarJRV.TabIndex = 7;
            this.BtnLimpiarJRV.Text = "Limpiar Campos";
            this.BtnLimpiarJRV.UseVisualStyleBackColor = true;
            // 
            // BtnIngresarJRV
            // 
            this.BtnIngresarJRV.Location = new System.Drawing.Point(521, 50);
            this.BtnIngresarJRV.Name = "BtnIngresarJRV";
            this.BtnIngresarJRV.Size = new System.Drawing.Size(188, 47);
            this.BtnIngresarJRV.TabIndex = 6;
            this.BtnIngresarJRV.Text = "Ingresar JRV";
            this.BtnIngresarJRV.UseVisualStyleBackColor = true;
            // 
            // DataGridJRV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridJRV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridJRV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridJRV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridJRV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridJRV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridJRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridJRV.DoubleBuffered = true;
            this.DataGridJRV.EnableHeadersVisualStyles = false;
            this.DataGridJRV.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DataGridJRV.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DataGridJRV.Location = new System.Drawing.Point(15, 335);
            this.DataGridJRV.Name = "DataGridJRV";
            this.DataGridJRV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridJRV.Size = new System.Drawing.Size(743, 275);
            this.DataGridJRV.TabIndex = 0;
            // 
            // FrmJRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmJRV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmJRVCV";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridJRV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdJRV;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnRefrescarJRV;
        private System.Windows.Forms.Button BtnActualizarJRV;
        private System.Windows.Forms.Button BtnLimpiarJRV;
        private System.Windows.Forms.Button BtnIngresarJRV;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridJRV;
    }
}