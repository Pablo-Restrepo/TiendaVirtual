namespace TiendaVirtual.Ventanas
{
    partial class vtnPromocionales
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.pbSubirFoto = new System.Windows.Forms.PictureBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.pbPublicar = new System.Windows.Forms.PictureBox();
            this.lnlInfo2 = new System.Windows.Forms.Label();
            this.flowLayoutProm = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubirFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPublicar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Montserrat ExtraBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(292, 47);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Promocionales";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(39, 81);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(365, 23);
            this.txtNombre.TabIndex = 23;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // pbFondo
            // 
            this.pbFondo.BackgroundImage = global::TiendaVirtual.Properties.Resources.labelFondo;
            this.pbFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFondo.Location = new System.Drawing.Point(22, 73);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(397, 40);
            this.pbFondo.TabIndex = 22;
            this.pbFondo.TabStop = false;
            // 
            // pbSubirFoto
            // 
            this.pbSubirFoto.BackgroundImage = global::TiendaVirtual.Properties.Resources.subirFoto;
            this.pbSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSubirFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSubirFoto.Location = new System.Drawing.Point(304, 132);
            this.pbSubirFoto.Name = "pbSubirFoto";
            this.pbSubirFoto.Size = new System.Drawing.Size(116, 32);
            this.pbSubirFoto.TabIndex = 32;
            this.pbSubirFoto.TabStop = false;
            this.pbSubirFoto.Click += new System.EventHandler(this.pbSubirFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.Black;
            this.pbFoto.BackgroundImage = global::TiendaVirtual.Properties.Resources._default;
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFoto.Location = new System.Drawing.Point(22, 132);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(260, 260);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 31;
            this.pbFoto.TabStop = false;
            // 
            // pbPublicar
            // 
            this.pbPublicar.BackgroundImage = global::TiendaVirtual.Properties.Resources.publicar;
            this.pbPublicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPublicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPublicar.Location = new System.Drawing.Point(304, 352);
            this.pbPublicar.Name = "pbPublicar";
            this.pbPublicar.Size = new System.Drawing.Size(138, 40);
            this.pbPublicar.TabIndex = 33;
            this.pbPublicar.TabStop = false;
            this.pbPublicar.Click += new System.EventHandler(this.pbPublicar_Click);
            // 
            // lnlInfo2
            // 
            this.lnlInfo2.AutoSize = true;
            this.lnlInfo2.Font = new System.Drawing.Font("Montserrat ExtraBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlInfo2.ForeColor = System.Drawing.Color.White;
            this.lnlInfo2.Location = new System.Drawing.Point(15, 412);
            this.lnlInfo2.Name = "lnlInfo2";
            this.lnlInfo2.Size = new System.Drawing.Size(465, 37);
            this.lnlInfo2.TabIndex = 34;
            this.lnlInfo2.Text = "Tus Promocionales Publicados:";
            // 
            // flowLayoutProm
            // 
            this.flowLayoutProm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutProm.AutoSize = true;
            this.flowLayoutProm.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutProm.Location = new System.Drawing.Point(22, 458);
            this.flowLayoutProm.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutProm.Name = "flowLayoutProm";
            this.flowLayoutProm.Size = new System.Drawing.Size(890, 142);
            this.flowLayoutProm.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Imagen preferencial panoramica*";
            // 
            // vtnPromocionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(921, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutProm);
            this.Controls.Add(this.lnlInfo2);
            this.Controls.Add(this.pbPublicar);
            this.Controls.Add(this.pbSubirFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pbFondo);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(921, 600);
            this.Name = "vtnPromocionales";
            this.Text = "vtnPromocionales";
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubirFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPublicar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.PictureBox pbSubirFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.PictureBox pbPublicar;
        private System.Windows.Forms.Label lnlInfo2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutProm;
        private System.Windows.Forms.Label label1;
    }
}