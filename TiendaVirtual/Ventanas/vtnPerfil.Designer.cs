namespace TiendaVirtual.Ventanas
{
    partial class vtnPerfil
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.pbSubirFoto = new System.Windows.Forms.PictureBox();
            this.pbFotoPerfil = new TiendaVirtual.Styles.RoundedButton();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtContraActual = new System.Windows.Forms.TextBox();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.txtNuevaContra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRecContra = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEditarNomb = new System.Windows.Forms.Label();
            this.lblEditarFecha = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCambiarNombre = new System.Windows.Forms.Button();
            this.btnCambiarFecha = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubirFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Montserrat ExtraBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(119, 47);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Perfil";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Montserrat ExtraBold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(13, 76);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(337, 32);
            this.lblUser.TabIndex = 35;
            this.lblUser.Text = "XXXXXXXXXXXXXXXXXXX";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Montserrat ExtraBold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(14, 131);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(337, 32);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "XXXXXXXXXXXXXXXXXXX";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Montserrat ExtraBold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.Color.White;
            this.lblFechaNac.Location = new System.Drawing.Point(14, 185);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(337, 32);
            this.lblFechaNac.TabIndex = 37;
            this.lblFechaNac.Text = "XXXXXXXXXXXXXXXXXXX";
            // 
            // pbSubirFoto
            // 
            this.pbSubirFoto.BackgroundImage = global::TiendaVirtual.Properties.Resources.subirFoto;
            this.pbSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSubirFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSubirFoto.Location = new System.Drawing.Point(247, 425);
            this.pbSubirFoto.Name = "pbSubirFoto";
            this.pbSubirFoto.Size = new System.Drawing.Size(116, 32);
            this.pbSubirFoto.TabIndex = 39;
            this.pbSubirFoto.TabStop = false;
            this.pbSubirFoto.Click += new System.EventHandler(this.pbSubirFoto_Click);
            // 
            // pbFotoPerfil
            // 
            this.pbFotoPerfil.BackColor = System.Drawing.Color.Black;
            this.pbFotoPerfil.BackgroundImage = global::TiendaVirtual.Properties.Resources.fotoPerfil;
            this.pbFotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFotoPerfil.FlatAppearance.BorderSize = 0;
            this.pbFotoPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pbFotoPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pbFotoPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbFotoPerfil.Location = new System.Drawing.Point(19, 246);
            this.pbFotoPerfil.Name = "pbFotoPerfil";
            this.pbFotoPerfil.Size = new System.Drawing.Size(211, 211);
            this.pbFotoPerfil.TabIndex = 38;
            this.pbFotoPerfil.UseVisualStyleBackColor = false;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Montserrat ExtraBold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.White;
            this.lblContra.Location = new System.Drawing.Point(567, 76);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(259, 32);
            this.lblContra.TabIndex = 40;
            this.lblContra.Text = "Cambiar contraseña";
            // 
            // txtContraActual
            // 
            this.txtContraActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.txtContraActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraActual.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraActual.ForeColor = System.Drawing.Color.White;
            this.txtContraActual.Location = new System.Drawing.Point(589, 131);
            this.txtContraActual.Margin = new System.Windows.Forms.Padding(0);
            this.txtContraActual.Multiline = true;
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.Size = new System.Drawing.Size(292, 23);
            this.txtContraActual.TabIndex = 42;
            this.txtContraActual.Text = "Contraseña Actual";
            this.txtContraActual.Click += new System.EventHandler(this.txtContraActual_Click);
            this.txtContraActual.Leave += new System.EventHandler(this.txtContraActual_Leave);
            // 
            // pbFondo
            // 
            this.pbFondo.BackgroundImage = global::TiendaVirtual.Properties.Resources.labelFondo;
            this.pbFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFondo.Location = new System.Drawing.Point(572, 123);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(324, 40);
            this.pbFondo.TabIndex = 41;
            this.pbFondo.TabStop = false;
            // 
            // txtNuevaContra
            // 
            this.txtNuevaContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.txtNuevaContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevaContra.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContra.ForeColor = System.Drawing.Color.White;
            this.txtNuevaContra.Location = new System.Drawing.Point(589, 185);
            this.txtNuevaContra.Margin = new System.Windows.Forms.Padding(0);
            this.txtNuevaContra.Multiline = true;
            this.txtNuevaContra.Name = "txtNuevaContra";
            this.txtNuevaContra.Size = new System.Drawing.Size(292, 23);
            this.txtNuevaContra.TabIndex = 44;
            this.txtNuevaContra.Text = "Nueva Contraseña";
            this.txtNuevaContra.Click += new System.EventHandler(this.txtNuevaContra_Click);
            this.txtNuevaContra.Leave += new System.EventHandler(this.txtNuevaContra_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TiendaVirtual.Properties.Resources.labelFondo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(572, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 40);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // txtRecContra
            // 
            this.txtRecContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.txtRecContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecContra.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecContra.ForeColor = System.Drawing.Color.White;
            this.txtRecContra.Location = new System.Drawing.Point(589, 238);
            this.txtRecContra.Margin = new System.Windows.Forms.Padding(0);
            this.txtRecContra.Multiline = true;
            this.txtRecContra.Name = "txtRecContra";
            this.txtRecContra.Size = new System.Drawing.Size(292, 23);
            this.txtRecContra.TabIndex = 46;
            this.txtRecContra.Text = "Rectificar Contraseña";
            this.txtRecContra.Click += new System.EventHandler(this.txtRecContra_Click);
            this.txtRecContra.Leave += new System.EventHandler(this.txtRecContra_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TiendaVirtual.Properties.Resources.labelFondo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(572, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(324, 40);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TiendaVirtual.Properties.Resources.conten2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(786, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 47;
            this.button1.Text = "Cambiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEditarNomb
            // 
            this.lblEditarNomb.AutoSize = true;
            this.lblEditarNomb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditarNomb.Font = new System.Drawing.Font("Montserrat ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarNomb.ForeColor = System.Drawing.Color.Blue;
            this.lblEditarNomb.Location = new System.Drawing.Point(454, 136);
            this.lblEditarNomb.Name = "lblEditarNomb";
            this.lblEditarNomb.Size = new System.Drawing.Size(72, 26);
            this.lblEditarNomb.TabIndex = 48;
            this.lblEditarNomb.Text = "Editar";
            this.lblEditarNomb.Click += new System.EventHandler(this.lblEditarNomb_Click);
            // 
            // lblEditarFecha
            // 
            this.lblEditarFecha.AutoSize = true;
            this.lblEditarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditarFecha.Font = new System.Drawing.Font("Montserrat ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarFecha.ForeColor = System.Drawing.Color.Blue;
            this.lblEditarFecha.Location = new System.Drawing.Point(454, 190);
            this.lblEditarFecha.Name = "lblEditarFecha";
            this.lblEditarFecha.Size = new System.Drawing.Size(72, 26);
            this.lblEditarFecha.TabIndex = 49;
            this.lblEditarFecha.Text = "Editar";
            this.lblEditarFecha.Click += new System.EventHandler(this.lblEditarFecha_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(36, 136);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(292, 23);
            this.txtNombre.TabIndex = 51;
            this.txtNombre.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TiendaVirtual.Properties.Resources.labelFondo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(19, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(324, 40);
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // btnCambiarNombre
            // 
            this.btnCambiarNombre.BackgroundImage = global::TiendaVirtual.Properties.Resources.conten2;
            this.btnCambiarNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCambiarNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarNombre.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCambiarNombre.FlatAppearance.BorderSize = 0;
            this.btnCambiarNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCambiarNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCambiarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarNombre.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarNombre.ForeColor = System.Drawing.Color.Transparent;
            this.btnCambiarNombre.Location = new System.Drawing.Point(352, 131);
            this.btnCambiarNombre.Margin = new System.Windows.Forms.Padding(0);
            this.btnCambiarNombre.Name = "btnCambiarNombre";
            this.btnCambiarNombre.Size = new System.Drawing.Size(112, 35);
            this.btnCambiarNombre.TabIndex = 52;
            this.btnCambiarNombre.Text = "Cambiar";
            this.btnCambiarNombre.UseVisualStyleBackColor = true;
            this.btnCambiarNombre.Visible = false;
            this.btnCambiarNombre.Click += new System.EventHandler(this.btnCambiarNombre_Click);
            // 
            // btnCambiarFecha
            // 
            this.btnCambiarFecha.BackgroundImage = global::TiendaVirtual.Properties.Resources.conten2;
            this.btnCambiarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCambiarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarFecha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCambiarFecha.FlatAppearance.BorderSize = 0;
            this.btnCambiarFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCambiarFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCambiarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarFecha.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarFecha.ForeColor = System.Drawing.Color.Transparent;
            this.btnCambiarFecha.Location = new System.Drawing.Point(352, 187);
            this.btnCambiarFecha.Margin = new System.Windows.Forms.Padding(0);
            this.btnCambiarFecha.Name = "btnCambiarFecha";
            this.btnCambiarFecha.Size = new System.Drawing.Size(112, 35);
            this.btnCambiarFecha.TabIndex = 53;
            this.btnCambiarFecha.Text = "Cambiar";
            this.btnCambiarFecha.UseVisualStyleBackColor = true;
            this.btnCambiarFecha.Visible = false;
            this.btnCambiarFecha.Click += new System.EventHandler(this.btnCambiarFecha_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.CalendarFont = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtFecha.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(38, 190);
            this.dtFecha.MaxDate = new System.DateTime(2022, 8, 22, 0, 0, 0, 0);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(129, 27);
            this.dtFecha.TabIndex = 54;
            this.dtFecha.Value = new System.DateTime(2022, 8, 22, 0, 0, 0, 0);
            this.dtFecha.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::TiendaVirtual.Properties.Resources.labelFondo;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(20, 184);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(324, 40);
            this.pictureBox4.TabIndex = 55;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // vtnPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(921, 600);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnCambiarFecha);
            this.Controls.Add(this.btnCambiarNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblEditarFecha);
            this.Controls.Add(this.lblEditarNomb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRecContra);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtNuevaContra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContraActual);
            this.Controls.Add(this.pbFondo);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.pbSubirFoto);
            this.Controls.Add(this.pbFotoPerfil);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(921, 600);
            this.Name = "vtnPerfil";
            this.Text = "vtnPromocionales";
            ((System.ComponentModel.ISupportInitialize)(this.pbSubirFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNac;
        private Styles.RoundedButton pbFotoPerfil;
        private System.Windows.Forms.PictureBox pbSubirFoto;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtContraActual;
        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.TextBox txtNuevaContra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRecContra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEditarNomb;
        private System.Windows.Forms.Label lblEditarFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCambiarNombre;
        private System.Windows.Forms.Button btnCambiarFecha;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}