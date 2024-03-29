﻿using System.Windows.Forms;

namespace TiendaVirtual
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pbLinea2 = new System.Windows.Forms.PictureBox();
            this.pbLinea = new System.Windows.Forms.PictureBox();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSalir = new System.Windows.Forms.Label();
            this.btnPromocionales = new System.Windows.Forms.Button();
            this.lblPromocionales = new System.Windows.Forms.Label();
            this.btnVentas = new System.Windows.Forms.Button();
            this.lblVentas = new System.Windows.Forms.Label();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.btnFavoritos = new System.Windows.Forms.Button();
            this.lblFavoritos = new System.Windows.Forms.Label();
            this.btnCompras = new System.Windows.Forms.Button();
            this.lblCompras = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pbNotifi = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.flowLayoutNotifi = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbPerfil = new TiendaVirtual.Styles.RoundedButton2();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotifi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.pbLinea2);
            this.panelMenu.Controls.Add(this.pbLinea);
            this.panelMenu.Controls.Add(this.btnInformacion);
            this.panelMenu.Controls.Add(this.lblInformacion);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.lblSalir);
            this.panelMenu.Controls.Add(this.btnPromocionales);
            this.panelMenu.Controls.Add(this.lblPromocionales);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.lblVentas);
            this.panelMenu.Controls.Add(this.btnCategorias);
            this.panelMenu.Controls.Add(this.lblCategorias);
            this.panelMenu.Controls.Add(this.btnFavoritos);
            this.panelMenu.Controls.Add(this.lblFavoritos);
            this.panelMenu.Controls.Add(this.btnCompras);
            this.panelMenu.Controls.Add(this.lblCompras);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.lblInicio);
            this.panelMenu.Controls.Add(this.pbMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(86, 691);
            this.panelMenu.TabIndex = 0;
            // 
            // pbLinea2
            // 
            this.pbLinea2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLinea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.pbLinea2.BackgroundImage = global::TiendaVirtual.Properties.Resources.Linea;
            this.pbLinea2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLinea2.Location = new System.Drawing.Point(24, 595);
            this.pbLinea2.Name = "pbLinea2";
            this.pbLinea2.Size = new System.Drawing.Size(38, 1);
            this.pbLinea2.TabIndex = 24;
            this.pbLinea2.TabStop = false;
            // 
            // pbLinea
            // 
            this.pbLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.pbLinea.BackgroundImage = global::TiendaVirtual.Properties.Resources.Linea;
            this.pbLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLinea.Location = new System.Drawing.Point(25, 93);
            this.pbLinea.Name = "pbLinea";
            this.pbLinea.Size = new System.Drawing.Size(38, 1);
            this.pbLinea.TabIndex = 0;
            this.pbLinea.TabStop = false;
            // 
            // btnInformacion
            // 
            this.btnInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInformacion.BackgroundImage = global::TiendaVirtual.Properties.Resources.info;
            this.btnInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Location = new System.Drawing.Point(26, 540);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(36, 35);
            this.btnInformacion.TabIndex = 23;
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.lblInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInformacion.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.White;
            this.lblInformacion.Location = new System.Drawing.Point(65, 524);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(90, 26);
            this.lblInformacion.TabIndex = 22;
            this.lblInformacion.Text = "        Info";
            this.lblInformacion.Visible = false;
            this.lblInformacion.Click += new System.EventHandler(this.lblInformacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackgroundImage = global::TiendaVirtual.Properties.Resources.Salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(25, 616);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(37, 35);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSalir.AutoSize = true;
            this.lblSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.lblSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalir.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.Color.White;
            this.lblSalir.Location = new System.Drawing.Point(65, 601);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(96, 26);
            this.lblSalir.TabIndex = 20;
            this.lblSalir.Text = "        Salir";
            this.lblSalir.Visible = false;
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // btnPromocionales
            // 
            this.btnPromocionales.BackgroundImage = global::TiendaVirtual.Properties.Resources.promocionales;
            this.btnPromocionales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPromocionales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromocionales.FlatAppearance.BorderSize = 0;
            this.btnPromocionales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPromocionales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPromocionales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromocionales.Location = new System.Drawing.Point(26, 331);
            this.btnPromocionales.Name = "btnPromocionales";
            this.btnPromocionales.Size = new System.Drawing.Size(36, 35);
            this.btnPromocionales.TabIndex = 19;
            this.btnPromocionales.UseVisualStyleBackColor = true;
            this.btnPromocionales.Click += new System.EventHandler(this.btnPromocionales_Click);
            // 
            // lblPromocionales
            // 
            this.lblPromocionales.AutoSize = true;
            this.lblPromocionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.lblPromocionales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPromocionales.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocionales.ForeColor = System.Drawing.Color.White;
            this.lblPromocionales.Location = new System.Drawing.Point(65, 355);
            this.lblPromocionales.Name = "lblPromocionales";
            this.lblPromocionales.Size = new System.Drawing.Size(159, 26);
            this.lblPromocionales.TabIndex = 18;
            this.lblPromocionales.Text = "        Publicidad";
            this.lblPromocionales.Visible = false;
            this.lblPromocionales.Click += new System.EventHandler(this.lblPromocionales_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackgroundImage = global::TiendaVirtual.Properties.Resources.ventas;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Location = new System.Drawing.Point(26, 279);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(36, 35);
            this.btnVentas.TabIndex = 15;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.lblVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVentas.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.White;
            this.lblVentas.Location = new System.Drawing.Point(65, 298);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(120, 26);
            this.lblVentas.TabIndex = 14;
            this.lblVentas.Text = "        Ventas";
            this.lblVentas.Visible = false;
            this.lblVentas.Click += new System.EventHandler(this.lblVentas_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackgroundImage = global::TiendaVirtual.Properties.Resources.categorias;
            this.btnCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Location = new System.Drawing.Point(26, 225);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(36, 35);
            this.btnCategorias.TabIndex = 13;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.lblCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCategorias.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.ForeColor = System.Drawing.Color.White;
            this.lblCategorias.Location = new System.Drawing.Point(65, 242);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(159, 26);
            this.lblCategorias.TabIndex = 12;
            this.lblCategorias.Text = "        Categorias";
            this.lblCategorias.Visible = false;
            this.lblCategorias.Click += new System.EventHandler(this.lblCategorias_Click);
            // 
            // btnFavoritos
            // 
            this.btnFavoritos.BackgroundImage = global::TiendaVirtual.Properties.Resources.favoritos;
            this.btnFavoritos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFavoritos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavoritos.FlatAppearance.BorderSize = 0;
            this.btnFavoritos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFavoritos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFavoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavoritos.Location = new System.Drawing.Point(26, 170);
            this.btnFavoritos.Name = "btnFavoritos";
            this.btnFavoritos.Size = new System.Drawing.Size(36, 35);
            this.btnFavoritos.TabIndex = 11;
            this.btnFavoritos.UseVisualStyleBackColor = true;
            this.btnFavoritos.Click += new System.EventHandler(this.btnFavoritos_Click);
            // 
            // lblFavoritos
            // 
            this.lblFavoritos.AutoSize = true;
            this.lblFavoritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.lblFavoritos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFavoritos.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoritos.ForeColor = System.Drawing.Color.White;
            this.lblFavoritos.Location = new System.Drawing.Point(65, 187);
            this.lblFavoritos.Name = "lblFavoritos";
            this.lblFavoritos.Size = new System.Drawing.Size(143, 26);
            this.lblFavoritos.TabIndex = 10;
            this.lblFavoritos.Text = "        Favoritos";
            this.lblFavoritos.Visible = false;
            this.lblFavoritos.Click += new System.EventHandler(this.lblFavoritos_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackgroundImage = global::TiendaVirtual.Properties.Resources.Compras;
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Location = new System.Drawing.Point(26, 114);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(36, 35);
            this.btnCompras.TabIndex = 9;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.lblCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCompras.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.ForeColor = System.Drawing.Color.White;
            this.lblCompras.Location = new System.Drawing.Point(65, 131);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(140, 26);
            this.lblCompras.TabIndex = 8;
            this.lblCompras.Text = "        Compras";
            this.lblCompras.Visible = false;
            this.lblCompras.Click += new System.EventHandler(this.lblCompras_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackgroundImage = global::TiendaVirtual.Properties.Resources.icono;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Location = new System.Drawing.Point(26, 37);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(36, 35);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.lblInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInicio.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(65, 55);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(106, 26);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "        Inicio";
            this.lblInicio.Visible = false;
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMenu.BackgroundImage = global::TiendaVirtual.Properties.Resources.aaaas;
            this.pbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMenu.Location = new System.Drawing.Point(19, 27);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(50, 633);
            this.pbMenu.TabIndex = 1;
            this.pbMenu.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.pbPerfil);
            this.panelTop.Controls.Add(this.txtBuscar);
            this.panelTop.Controls.Add(this.lblUser);
            this.panelTop.Controls.Add(this.pbNotifi);
            this.panelTop.Controls.Add(this.pbBuscar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(86, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(921, 91);
            this.panelTop.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(59, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(431, 20);
            this.txtBuscar.TabIndex = 20;
            this.txtBuscar.Text = "Buscar Productos...";
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUser.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(786, 36);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 20);
            this.lblUser.TabIndex = 17;
            this.lblUser.Text = "NomUsuario";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // pbNotifi
            // 
            this.pbNotifi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNotifi.BackgroundImage = global::TiendaVirtual.Properties.Resources.notifi;
            this.pbNotifi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNotifi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNotifi.Location = new System.Drawing.Point(693, 35);
            this.pbNotifi.Name = "pbNotifi";
            this.pbNotifi.Size = new System.Drawing.Size(27, 27);
            this.pbNotifi.TabIndex = 16;
            this.pbNotifi.TabStop = false;
            this.pbNotifi.Click += new System.EventHandler(this.pbNotifi_Click);
            // 
            // pbBuscar
            // 
            this.pbBuscar.BackgroundImage = global::TiendaVirtual.Properties.Resources.buscarmorado;
            this.pbBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBuscar.Location = new System.Drawing.Point(12, 27);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(492, 38);
            this.pbBuscar.TabIndex = 1;
            this.pbBuscar.TabStop = false;
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.flowLayoutNotifi);
            this.panelCentral.Controls.Add(this.flowLayoutPanel1);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(86, 91);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(921, 600);
            this.panelCentral.TabIndex = 2;
            // 
            // flowLayoutNotifi
            // 
            this.flowLayoutNotifi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutNotifi.AutoScroll = true;
            this.flowLayoutNotifi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.flowLayoutNotifi.Location = new System.Drawing.Point(579, 2);
            this.flowLayoutNotifi.Name = "flowLayoutNotifi";
            this.flowLayoutNotifi.Size = new System.Drawing.Size(260, 344);
            this.flowLayoutNotifi.TabIndex = 22;
            this.flowLayoutNotifi.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(921, 600);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // pbPerfil
            // 
            this.pbPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPerfil.BackgroundImage = global::TiendaVirtual.Properties.Resources.fotoPerfil;
            this.pbPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPerfil.FlatAppearance.BorderSize = 0;
            this.pbPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbPerfil.Location = new System.Drawing.Point(735, 27);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(40, 40);
            this.pbPerfil.TabIndex = 21;
            this.pbPerfil.UseVisualStyleBackColor = true;
            this.pbPerfil.Click += new System.EventHandler(this.pbPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1007, 691);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1023, 730);
            this.Name = "Form1";
            this.Text = "Tienda Virtual";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotifi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pbNotifi;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Label lblCompras;
        private Button btnFavoritos;
        private Label lblFavoritos;
        private Button btnCategorias;
        private Label lblCategorias;
        private Button btnVentas;
        private Label lblVentas;
        private Button btnPromocionales;
        private Label lblPromocionales;
        private Button btnSalir;
        private Label lblSalir;
        private Button btnInformacion;
        private Label lblInformacion;
        private PictureBox pbLinea;
        private PictureBox pbLinea2;
        private Styles.RoundedButton2 pbPerfil;
        private FlowLayoutPanel flowLayoutNotifi;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

