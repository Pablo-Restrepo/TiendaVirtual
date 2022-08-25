namespace TiendaVirtual.Ventanas
{
    partial class vtnVentas
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lnlInfo2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPro = new System.Windows.Forms.FlowLayoutPanel();
            this.pbSubirFoto = new System.Windows.Forms.PictureBox();
            this.pbPublicar = new System.Windows.Forms.PictureBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubirFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPublicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Montserrat ExtraBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(386, 47);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Vender un Producto";
            // 
            // lnlInfo2
            // 
            this.lnlInfo2.AutoSize = true;
            this.lnlInfo2.Font = new System.Drawing.Font("Montserrat ExtraBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlInfo2.ForeColor = System.Drawing.Color.White;
            this.lnlInfo2.Location = new System.Drawing.Point(11, 486);
            this.lnlInfo2.Name = "lnlInfo2";
            this.lnlInfo2.Size = new System.Drawing.Size(399, 37);
            this.lnlInfo2.TabIndex = 7;
            this.lnlInfo2.Text = "Tus Productos Publicados:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(35, 82);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(365, 23);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(35, 134);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrecio.MaxLength = 7;
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(365, 23);
            this.txtPrecio.TabIndex = 23;
            this.txtPrecio.Text = "Precio";
            this.txtPrecio.Click += new System.EventHandler(this.txtPrecio_Click);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.txtDescrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescrip.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrip.ForeColor = System.Drawing.Color.White;
            this.txtDescrip.Location = new System.Drawing.Point(35, 234);
            this.txtDescrip.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescrip.MaxLength = 500;
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(365, 169);
            this.txtDescrip.TabIndex = 27;
            this.txtDescrip.Text = "Descripcion (Max. 500)";
            this.txtDescrip.Click += new System.EventHandler(this.txtDescrip_Click);
            this.txtDescrip.Leave += new System.EventHandler(this.txtDescrip_Leave);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.ForeColor = System.Drawing.Color.White;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Tecnologia",
            "Deporte",
            "Eventos",
            "Ropa",
            "Muebles",
            "Maletas",
            "Herramientas",
            "Joyeria y Accesorios",
            "Relojes",
            "Bienes Virtuales",
            "Hogar y Jardin",
            "Oficina y Escuela",
            "Juguetes",
            "Seguridad",
            "Vehiculos",
            "Comida",
            "Electrodomesticos",
            "Ordenadores",
            "Luces e Iluminacion",
            "Belleza",
            "Telefonos",
            "Componentes Electronicos",
            "Calzado",
            "Otro"});
            this.cmbCategoria.Location = new System.Drawing.Point(146, 181);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(251, 30);
            this.cmbCategoria.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Categoria";
            // 
            // flowLayoutPro
            // 
            this.flowLayoutPro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPro.AutoSize = true;
            this.flowLayoutPro.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPro.Location = new System.Drawing.Point(18, 538);
            this.flowLayoutPro.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPro.Name = "flowLayoutPro";
            this.flowLayoutPro.Size = new System.Drawing.Size(909, 42);
            this.flowLayoutPro.TabIndex = 36;
            // 
            // pbSubirFoto
            // 
            this.pbSubirFoto.BackgroundImage = global::TiendaVirtual.Properties.Resources.subirFoto;
            this.pbSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSubirFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSubirFoto.Location = new System.Drawing.Point(697, 349);
            this.pbSubirFoto.Name = "pbSubirFoto";
            this.pbSubirFoto.Size = new System.Drawing.Size(116, 32);
            this.pbSubirFoto.TabIndex = 30;
            this.pbSubirFoto.TabStop = false;
            this.pbSubirFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // pbPublicar
            // 
            this.pbPublicar.BackgroundImage = global::TiendaVirtual.Properties.Resources.publicar;
            this.pbPublicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPublicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPublicar.Location = new System.Drawing.Point(18, 433);
            this.pbPublicar.Name = "pbPublicar";
            this.pbPublicar.Size = new System.Drawing.Size(138, 40);
            this.pbPublicar.TabIndex = 29;
            this.pbPublicar.TabStop = false;
            this.pbPublicar.Click += new System.EventHandler(this.pbPublicar_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.Black;
            this.pbFoto.BackgroundImage = global::TiendaVirtual.Properties.Resources._default;
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFoto.Location = new System.Drawing.Point(553, 74);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(260, 260);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 28;
            this.pbFoto.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TiendaVirtual.Properties.Resources.cot;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(18, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(397, 189);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TiendaVirtual.Properties.Resources.labelFondo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(18, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(397, 40);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TiendaVirtual.Properties.Resources.labelFondo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(18, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 40);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pbFondo
            // 
            this.pbFondo.BackgroundImage = global::TiendaVirtual.Properties.Resources.labelFondo;
            this.pbFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFondo.Location = new System.Drawing.Point(18, 74);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(397, 40);
            this.pbFondo.TabIndex = 8;
            this.pbFondo.TabStop = false;
            // 
            // vtnVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(921, 600);
            this.Controls.Add(this.flowLayoutPro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.pbSubirFoto);
            this.Controls.Add(this.pbPublicar);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pbFondo);
            this.Controls.Add(this.lnlInfo2);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(921, 600);
            this.Name = "vtnVentas";
            this.Text = "vtnVentas";
            ((System.ComponentModel.ISupportInitialize)(this.pbSubirFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPublicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lnlInfo2;
        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.PictureBox pbPublicar;
        private System.Windows.Forms.PictureBox pbSubirFoto;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPro;
    }
}