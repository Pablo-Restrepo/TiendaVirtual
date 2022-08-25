namespace TiendaVirtual.Ventanas
{
    partial class vtnProducto
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
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblMasProd = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.pbComprar = new System.Windows.Forms.PictureBox();
            this.pbImagenProd = new System.Windows.Forms.PictureBox();
            this.flowLayoutProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pbMas = new System.Windows.Forms.Button();
            this.pbMenos = new System.Windows.Forms.Button();
            this.pbLike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbComprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.ForeColor = System.Drawing.Color.White;
            this.lblNombreProd.Location = new System.Drawing.Point(451, -11);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(373, 51);
            this.lblNombreProd.TabIndex = 0;
            this.lblNombreProd.Text = "Nombre producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Montserrat ExtraBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(453, 63);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(237, 42);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio 20000";
            // 
            // lblDescrip
            // 
            this.lblDescrip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescrip.Font = new System.Drawing.Font("Montserrat ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.ForeColor = System.Drawing.Color.White;
            this.lblDescrip.Location = new System.Drawing.Point(453, 132);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(442, 228);
            this.lblDescrip.TabIndex = 3;
            this.lblDescrip.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" +
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // lblMasProd
            // 
            this.lblMasProd.AutoSize = true;
            this.lblMasProd.Font = new System.Drawing.Font("Montserrat ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasProd.ForeColor = System.Drawing.Color.White;
            this.lblMasProd.Location = new System.Drawing.Point(16, 369);
            this.lblMasProd.Name = "lblMasProd";
            this.lblMasProd.Size = new System.Drawing.Size(388, 27);
            this.lblMasProd.TabIndex = 4;
            this.lblMasProd.Text = "Productos que te pueden interesar";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Montserrat ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(569, 537);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(20, 27);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "1";
            // 
            // pbComprar
            // 
            this.pbComprar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbComprar.BackgroundImage = global::TiendaVirtual.Properties.Resources.comprarr;
            this.pbComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbComprar.Location = new System.Drawing.Point(731, 527);
            this.pbComprar.Name = "pbComprar";
            this.pbComprar.Size = new System.Drawing.Size(164, 50);
            this.pbComprar.TabIndex = 5;
            this.pbComprar.TabStop = false;
            this.pbComprar.Click += new System.EventHandler(this.pbComprar_Click);
            // 
            // pbImagenProd
            // 
            this.pbImagenProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbImagenProd.BackColor = System.Drawing.Color.White;
            this.pbImagenProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImagenProd.Location = new System.Drawing.Point(21, 3);
            this.pbImagenProd.Name = "pbImagenProd";
            this.pbImagenProd.Size = new System.Drawing.Size(409, 357);
            this.pbImagenProd.TabIndex = 1;
            this.pbImagenProd.TabStop = false;
            // 
            // flowLayoutProductos
            // 
            this.flowLayoutProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutProductos.AutoSize = true;
            this.flowLayoutProductos.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutProductos.Location = new System.Drawing.Point(21, 399);
            this.flowLayoutProductos.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutProductos.Name = "flowLayoutProductos";
            this.flowLayoutProductos.Size = new System.Drawing.Size(442, 148);
            this.flowLayoutProductos.TabIndex = 19;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Montserrat ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(449, 538);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(122, 27);
            this.lblInfo.TabIndex = 20;
            this.lblInfo.Text = "Cantidad: ";
            // 
            // pbMas
            // 
            this.pbMas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMas.BackColor = System.Drawing.Color.Transparent;
            this.pbMas.BackgroundImage = global::TiendaVirtual.Properties.Resources.mas;
            this.pbMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMas.FlatAppearance.BorderSize = 0;
            this.pbMas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pbMas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pbMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbMas.Location = new System.Drawing.Point(603, 534);
            this.pbMas.Name = "pbMas";
            this.pbMas.Size = new System.Drawing.Size(35, 35);
            this.pbMas.TabIndex = 21;
            this.pbMas.UseVisualStyleBackColor = false;
            this.pbMas.Click += new System.EventHandler(this.pbMas_Click);
            // 
            // pbMenos
            // 
            this.pbMenos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMenos.BackColor = System.Drawing.Color.Transparent;
            this.pbMenos.BackgroundImage = global::TiendaVirtual.Properties.Resources.menos;
            this.pbMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenos.FlatAppearance.BorderSize = 0;
            this.pbMenos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pbMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pbMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbMenos.Location = new System.Drawing.Point(649, 534);
            this.pbMenos.Name = "pbMenos";
            this.pbMenos.Size = new System.Drawing.Size(35, 35);
            this.pbMenos.TabIndex = 22;
            this.pbMenos.UseVisualStyleBackColor = false;
            this.pbMenos.Click += new System.EventHandler(this.pbMenos_Click);
            // 
            // pbLike
            // 
            this.pbLike.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLike.BackColor = System.Drawing.Color.Transparent;
            this.pbLike.BackgroundImage = global::TiendaVirtual.Properties.Resources.nolike;
            this.pbLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLike.FlatAppearance.BorderSize = 0;
            this.pbLike.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pbLike.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pbLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbLike.Location = new System.Drawing.Point(860, 3);
            this.pbLike.Name = "pbLike";
            this.pbLike.Size = new System.Drawing.Size(35, 35);
            this.pbLike.TabIndex = 23;
            this.pbLike.UseVisualStyleBackColor = false;
            this.pbLike.Click += new System.EventHandler(this.pbLike_Click);
            // 
            // vtnProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(921, 600);
            this.Controls.Add(this.pbLike);
            this.Controls.Add(this.pbMenos);
            this.Controls.Add(this.pbMas);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.pbComprar);
            this.Controls.Add(this.lblMasProd);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.pbImagenProd);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.flowLayoutProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(921, 600);
            this.Name = "vtnProducto";
            this.Text = "vtnProducto";
            this.Resize += new System.EventHandler(this.vtnProducto_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbComprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMasProd;
        private System.Windows.Forms.PictureBox pbComprar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutProductos;
        public System.Windows.Forms.PictureBox pbImagenProd;
        public System.Windows.Forms.Label lblNombreProd;
        public System.Windows.Forms.Label lblPrecio;
        public System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button pbMas;
        private System.Windows.Forms.Button pbMenos;
        public System.Windows.Forms.Button pbLike;
    }
}