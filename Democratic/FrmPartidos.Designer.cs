namespace Democratic
{
    partial class FrmPartidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grp = new System.Windows.Forms.GroupBox();
            this.lblRecomendación = new System.Windows.Forms.Label();
            this.PictureLupa = new System.Windows.Forms.PictureBox();
            this.txtBusquedaP = new System.Windows.Forms.TextBox();
            this.PbPartido = new System.Windows.Forms.PictureBox();
            this.TxtIdP = new System.Windows.Forms.TextBox();
            this.TxtCantidadVotosP = new System.Windows.Forms.TextBox();
            this.lblCantidadVotos = new System.Windows.Forms.Label();
            this.lblEstadoP = new System.Windows.Forms.Label();
            this.lblBuscarP = new System.Windows.Forms.Label();
            this.BtnCargarImageP = new System.Windows.Forms.Button();
            this.TxtNombreP = new System.Windows.Forms.TextBox();
            this.DgvPartidos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BtnEliminarPartido = new System.Windows.Forms.Button();
            this.BtnRefrescarPartidos = new System.Windows.Forms.Button();
            this.BtnLimpiarPartidos = new System.Windows.Forms.Button();
            this.BtnActualizarPartido = new System.Windows.Forms.Button();
            this.BtnAgregarPartido = new System.Windows.Forms.Button();
            this.CmbEstadoP = new System.Windows.Forms.ComboBox();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.OFDSeleccionarImage = new System.Windows.Forms.OpenFileDialog();
            this.PanelPartido = new System.Windows.Forms.Panel();
            this.Grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPartido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPartidos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.PanelPartido.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp
            // 
            this.Grp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grp.Controls.Add(this.lblRecomendación);
            this.Grp.Controls.Add(this.PictureLupa);
            this.Grp.Controls.Add(this.txtBusquedaP);
            this.Grp.Controls.Add(this.PbPartido);
            this.Grp.Controls.Add(this.TxtIdP);
            this.Grp.Controls.Add(this.TxtCantidadVotosP);
            this.Grp.Controls.Add(this.lblCantidadVotos);
            this.Grp.Controls.Add(this.lblEstadoP);
            this.Grp.Controls.Add(this.lblBuscarP);
            this.Grp.Controls.Add(this.BtnCargarImageP);
            this.Grp.Controls.Add(this.TxtNombreP);
            this.Grp.Controls.Add(this.DgvPartidos);
            this.Grp.Controls.Add(this.BtnEliminarPartido);
            this.Grp.Controls.Add(this.BtnRefrescarPartidos);
            this.Grp.Controls.Add(this.BtnLimpiarPartidos);
            this.Grp.Controls.Add(this.BtnActualizarPartido);
            this.Grp.Controls.Add(this.BtnAgregarPartido);
            this.Grp.Controls.Add(this.CmbEstadoP);
            this.Grp.Controls.Add(this.lblNombreP);
            this.Grp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp.Location = new System.Drawing.Point(12, 10);
            this.Grp.Name = "Grp";
            this.Grp.Size = new System.Drawing.Size(776, 576);
            this.Grp.TabIndex = 0;
            this.Grp.TabStop = false;
            this.Grp.Text = "Grupos de opciones";
            // 
            // lblRecomendación
            // 
            this.lblRecomendación.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRecomendación.AutoSize = true;
            this.lblRecomendación.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecomendación.ForeColor = System.Drawing.Color.Crimson;
            this.lblRecomendación.Location = new System.Drawing.Point(232, 176);
            this.lblRecomendación.Name = "lblRecomendación";
            this.lblRecomendación.Size = new System.Drawing.Size(132, 13);
            this.lblRecomendación.TabIndex = 51;
            this.lblRecomendación.Text = "Recomendacion de 170x195";
            // 
            // PictureLupa
            // 
            this.PictureLupa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureLupa.Image = global::Democratic.Properties.Resources.search_48px;
            this.PictureLupa.Location = new System.Drawing.Point(623, 54);
            this.PictureLupa.Name = "PictureLupa";
            this.PictureLupa.Size = new System.Drawing.Size(30, 28);
            this.PictureLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLupa.TabIndex = 45;
            this.PictureLupa.TabStop = false;
            // 
            // txtBusquedaP
            // 
            this.txtBusquedaP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusquedaP.BackColor = System.Drawing.Color.LightGray;
            this.txtBusquedaP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaP.Location = new System.Drawing.Point(401, 54);
            this.txtBusquedaP.Multiline = true;
            this.txtBusquedaP.Name = "txtBusquedaP";
            this.txtBusquedaP.Size = new System.Drawing.Size(226, 28);
            this.txtBusquedaP.TabIndex = 50;
            // 
            // PbPartido
            // 
            this.PbPartido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PbPartido.Location = new System.Drawing.Point(230, 22);
            this.PbPartido.Name = "PbPartido";
            this.PbPartido.Size = new System.Drawing.Size(143, 151);
            this.PbPartido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbPartido.TabIndex = 41;
            this.PbPartido.TabStop = false;
            // 
            // TxtIdP
            // 
            this.TxtIdP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtIdP.Enabled = false;
            this.TxtIdP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdP.Location = new System.Drawing.Point(20, 239);
            this.TxtIdP.Name = "TxtIdP";
            this.TxtIdP.Size = new System.Drawing.Size(39, 23);
            this.TxtIdP.TabIndex = 49;
            // 
            // TxtCantidadVotosP
            // 
            this.TxtCantidadVotosP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtCantidadVotosP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadVotosP.Location = new System.Drawing.Point(20, 186);
            this.TxtCantidadVotosP.Name = "TxtCantidadVotosP";
            this.TxtCantidadVotosP.Size = new System.Drawing.Size(167, 23);
            this.TxtCantidadVotosP.TabIndex = 48;
            this.TxtCantidadVotosP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadVotosP_KeyPress);
            // 
            // lblCantidadVotos
            // 
            this.lblCantidadVotos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCantidadVotos.AutoSize = true;
            this.lblCantidadVotos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVotos.Location = new System.Drawing.Point(17, 164);
            this.lblCantidadVotos.Name = "lblCantidadVotos";
            this.lblCantidadVotos.Size = new System.Drawing.Size(137, 17);
            this.lblCantidadVotos.TabIndex = 47;
            this.lblCantidadVotos.Text = "Cantidad de Votos:";
            // 
            // lblEstadoP
            // 
            this.lblEstadoP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstadoP.AutoSize = true;
            this.lblEstadoP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoP.Location = new System.Drawing.Point(17, 98);
            this.lblEstadoP.Name = "lblEstadoP";
            this.lblEstadoP.Size = new System.Drawing.Size(131, 17);
            this.lblEstadoP.TabIndex = 46;
            this.lblEstadoP.Text = "Estado del Grupo:";
            // 
            // lblBuscarP
            // 
            this.lblBuscarP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBuscarP.AutoSize = true;
            this.lblBuscarP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarP.Location = new System.Drawing.Point(398, 30);
            this.lblBuscarP.Name = "lblBuscarP";
            this.lblBuscarP.Size = new System.Drawing.Size(104, 17);
            this.lblBuscarP.TabIndex = 44;
            this.lblBuscarP.Text = "Buscar Grupo:";
            // 
            // BtnCargarImageP
            // 
            this.BtnCargarImageP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCargarImageP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnCargarImageP.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCargarImageP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnCargarImageP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BtnCargarImageP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarImageP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarImageP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCargarImageP.Location = new System.Drawing.Point(240, 204);
            this.BtnCargarImageP.Name = "BtnCargarImageP";
            this.BtnCargarImageP.Size = new System.Drawing.Size(120, 35);
            this.BtnCargarImageP.TabIndex = 42;
            this.BtnCargarImageP.Text = "Cargar Imagen";
            this.BtnCargarImageP.UseVisualStyleBackColor = false;
            this.BtnCargarImageP.Click += new System.EventHandler(this.BtnCargarImageP_Click);
            // 
            // TxtNombreP
            // 
            this.TxtNombreP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNombreP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreP.Location = new System.Drawing.Point(20, 54);
            this.TxtNombreP.Name = "TxtNombreP";
            this.TxtNombreP.Size = new System.Drawing.Size(167, 23);
            this.TxtNombreP.TabIndex = 40;
            this.TxtNombreP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreP_KeyPress);
            // 
            // DgvPartidos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvPartidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPartidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPartidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPartidos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DgvPartidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPartidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPartidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPartidos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPartidos.DoubleBuffered = true;
            this.DgvPartidos.EnableHeadersVisualStyles = false;
            this.DgvPartidos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(119)))));
            this.DgvPartidos.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DgvPartidos.Location = new System.Drawing.Point(6, 281);
            this.DgvPartidos.Name = "DgvPartidos";
            this.DgvPartidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPartidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvPartidos.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvPartidos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvPartidos.Size = new System.Drawing.Size(764, 281);
            this.DgvPartidos.TabIndex = 39;
            this.DgvPartidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPartidos_CellClick);
            this.DgvPartidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvPartidos_CellFormatting);
            // 
            // BtnEliminarPartido
            // 
            this.BtnEliminarPartido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminarPartido.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarPartido.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminarPartido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEliminarPartido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarPartido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarPartido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEliminarPartido.Location = new System.Drawing.Point(585, 167);
            this.BtnEliminarPartido.Name = "BtnEliminarPartido";
            this.BtnEliminarPartido.Size = new System.Drawing.Size(167, 40);
            this.BtnEliminarPartido.TabIndex = 38;
            this.BtnEliminarPartido.Text = "Eliminar Grupo";
            this.BtnEliminarPartido.UseVisualStyleBackColor = false;
            this.BtnEliminarPartido.Click += new System.EventHandler(this.BtnEliminarPartido_Click);
            // 
            // BtnRefrescarPartidos
            // 
            this.BtnRefrescarPartidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRefrescarPartidos.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRefrescarPartidos.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefrescarPartidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnRefrescarPartidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnRefrescarPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescarPartidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefrescarPartidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRefrescarPartidos.Location = new System.Drawing.Point(585, 109);
            this.BtnRefrescarPartidos.Name = "BtnRefrescarPartidos";
            this.BtnRefrescarPartidos.Size = new System.Drawing.Size(167, 40);
            this.BtnRefrescarPartidos.TabIndex = 37;
            this.BtnRefrescarPartidos.Text = "Refrescar";
            this.BtnRefrescarPartidos.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiarPartidos
            // 
            this.BtnLimpiarPartidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLimpiarPartidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnLimpiarPartidos.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLimpiarPartidos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiarPartidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnLimpiarPartidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiarPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarPartidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarPartidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLimpiarPartidos.Location = new System.Drawing.Point(401, 222);
            this.BtnLimpiarPartidos.Name = "BtnLimpiarPartidos";
            this.BtnLimpiarPartidos.Size = new System.Drawing.Size(167, 40);
            this.BtnLimpiarPartidos.TabIndex = 36;
            this.BtnLimpiarPartidos.Text = "Limpiar Campos";
            this.BtnLimpiarPartidos.UseVisualStyleBackColor = false;
            this.BtnLimpiarPartidos.Click += new System.EventHandler(this.BtnLimpiarPartidos_Click);
            // 
            // BtnActualizarPartido
            // 
            this.BtnActualizarPartido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizarPartido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnActualizarPartido.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarPartido.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnActualizarPartido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnActualizarPartido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarPartido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarPartido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualizarPartido.Location = new System.Drawing.Point(401, 167);
            this.BtnActualizarPartido.Name = "BtnActualizarPartido";
            this.BtnActualizarPartido.Size = new System.Drawing.Size(167, 40);
            this.BtnActualizarPartido.TabIndex = 35;
            this.BtnActualizarPartido.Text = "Actualizar Grupo";
            this.BtnActualizarPartido.UseVisualStyleBackColor = false;
            this.BtnActualizarPartido.Click += new System.EventHandler(this.BtnActualizarPartido_Click);
            // 
            // BtnAgregarPartido
            // 
            this.BtnAgregarPartido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgregarPartido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(191)))));
            this.BtnAgregarPartido.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregarPartido.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarPartido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(126)))));
            this.BtnAgregarPartido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarPartido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarPartido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregarPartido.Location = new System.Drawing.Point(401, 109);
            this.BtnAgregarPartido.Name = "BtnAgregarPartido";
            this.BtnAgregarPartido.Size = new System.Drawing.Size(167, 40);
            this.BtnAgregarPartido.TabIndex = 34;
            this.BtnAgregarPartido.Text = "Agregar Grupo";
            this.BtnAgregarPartido.UseVisualStyleBackColor = false;
            this.BtnAgregarPartido.Click += new System.EventHandler(this.BtnAgregarPartido_Click);
            // 
            // CmbEstadoP
            // 
            this.CmbEstadoP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbEstadoP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstadoP.FormattingEnabled = true;
            this.CmbEstadoP.Location = new System.Drawing.Point(20, 118);
            this.CmbEstadoP.Name = "CmbEstadoP";
            this.CmbEstadoP.Size = new System.Drawing.Size(167, 25);
            this.CmbEstadoP.TabIndex = 1;
            this.CmbEstadoP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmbEstadoP_MouseClick);
            // 
            // lblNombreP
            // 
            this.lblNombreP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreP.Location = new System.Drawing.Point(17, 30);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(144, 17);
            this.lblNombreP.TabIndex = 0;
            this.lblNombreP.Text = "Nombre del Grupo: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMinimizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMinimizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.Image = global::Democratic.Properties.Resources.expand_arrow_64px;
            this.BtnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(148, 22);
            this.BtnMinimizar.Text = "Minimizar Formulario";
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // OFDSeleccionarImage
            // 
            this.OFDSeleccionarImage.FileName = "openFileDialog1";
            // 
            // PanelPartido
            // 
            this.PanelPartido.Controls.Add(this.Grp);
            this.PanelPartido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPartido.Location = new System.Drawing.Point(0, 25);
            this.PanelPartido.Name = "PanelPartido";
            this.PanelPartido.Size = new System.Drawing.Size(800, 598);
            this.PanelPartido.TabIndex = 2;
            // 
            // FrmPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.PanelPartido);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPartidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos de opciones";
            this.Load += new System.EventHandler(this.FrmPartidos_Load);
            this.Grp.ResumeLayout(false);
            this.Grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPartido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPartidos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelPartido.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnMinimizar;
        private System.Windows.Forms.ComboBox CmbEstadoP;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Button BtnEliminarPartido;
        private System.Windows.Forms.Button BtnRefrescarPartidos;
        private System.Windows.Forms.Button BtnLimpiarPartidos;
        private System.Windows.Forms.Button BtnActualizarPartido;
        private System.Windows.Forms.Button BtnAgregarPartido;
        private System.Windows.Forms.Button BtnCargarImageP;
        private System.Windows.Forms.PictureBox PbPartido;
        private System.Windows.Forms.TextBox TxtNombreP;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DgvPartidos;
        private System.Windows.Forms.TextBox TxtIdP;
        private System.Windows.Forms.TextBox TxtCantidadVotosP;
        private System.Windows.Forms.Label lblCantidadVotos;
        private System.Windows.Forms.Label lblEstadoP;
        private System.Windows.Forms.PictureBox PictureLupa;
        private System.Windows.Forms.Label lblBuscarP;
        private System.Windows.Forms.OpenFileDialog OFDSeleccionarImage;
        private System.Windows.Forms.TextBox txtBusquedaP;
        private System.Windows.Forms.Label lblRecomendación;
        private System.Windows.Forms.Panel PanelPartido;
    }
}