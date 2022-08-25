namespace TiendaVirtual.Ventanas
{
    partial class vtnInicio
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.pbProMasGuar = new System.Windows.Forms.FlowLayoutPanel();
            this.pbVendedores = new System.Windows.Forms.FlowLayoutPanel();
            this.pbProdMasComp = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnDeporte = new System.Windows.Forms.Button();
            this.btnTecnologia = new System.Windows.Forms.Button();
            this.btnHogar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutInicio = new System.Windows.Forms.FlowLayoutPanel();
            this.pbPromo = new TiendaVirtual.Styles.RoundedButton();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.pbProMasGuar);
            this.panelTop.Controls.Add(this.pbVendedores);
            this.panelTop.Controls.Add(this.pbProdMasComp);
            this.panelTop.Controls.Add(this.pbPromo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(921, 237);
            this.panelTop.TabIndex = 2;
            // 
            // pbProMasGuar
            // 
            this.pbProMasGuar.BackColor = System.Drawing.Color.Transparent;
            this.pbProMasGuar.BackgroundImage = global::TiendaVirtual.Properties.Resources.masCompra;
            this.pbProMasGuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbProMasGuar.Location = new System.Drawing.Point(1253, 12);
            this.pbProMasGuar.Name = "pbProMasGuar";
            this.pbProMasGuar.Size = new System.Drawing.Size(321, 211);
            this.pbProMasGuar.TabIndex = 18;
            this.pbProMasGuar.Visible = false;
            // 
            // pbVendedores
            // 
            this.pbVendedores.BackgroundImage = global::TiendaVirtual.Properties.Resources.vendedores;
            this.pbVendedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbVendedores.Location = new System.Drawing.Point(907, 12);
            this.pbVendedores.Name = "pbVendedores";
            this.pbVendedores.Size = new System.Drawing.Size(321, 211);
            this.pbVendedores.TabIndex = 18;
            this.pbVendedores.Visible = false;
            // 
            // pbProdMasComp
            // 
            this.pbProdMasComp.BackColor = System.Drawing.Color.Transparent;
            this.pbProdMasComp.BackgroundImage = global::TiendaVirtual.Properties.Resources.prodmascomp;
            this.pbProdMasComp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbProdMasComp.Location = new System.Drawing.Point(563, 12);
            this.pbProdMasComp.Name = "pbProdMasComp";
            this.pbProdMasComp.Size = new System.Drawing.Size(321, 211);
            this.pbProdMasComp.TabIndex = 17;
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelBottom.Controls.Add(this.btnTodo);
            this.panelBottom.Controls.Add(this.btnDeporte);
            this.panelBottom.Controls.Add(this.btnTecnologia);
            this.panelBottom.Controls.Add(this.btnHogar);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Controls.Add(this.flowLayoutInicio);
            this.panelBottom.Location = new System.Drawing.Point(0, 241);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(921, 359);
            this.panelBottom.TabIndex = 3;
            // 
            // btnTodo
            // 
            this.btnTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodo.BackgroundImage = global::TiendaVirtual.Properties.Resources.conten2;
            this.btnTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTodo.FlatAppearance.BorderSize = 0;
            this.btnTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodo.ForeColor = System.Drawing.Color.Transparent;
            this.btnTodo.Location = new System.Drawing.Point(777, 54);
            this.btnTodo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(112, 35);
            this.btnTodo.TabIndex = 16;
            this.btnTodo.Text = "Todo";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnDeporte
            // 
            this.btnDeporte.BackgroundImage = global::TiendaVirtual.Properties.Resources.conten;
            this.btnDeporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeporte.FlatAppearance.BorderSize = 0;
            this.btnDeporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeporte.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeporte.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeporte.Location = new System.Drawing.Point(272, 54);
            this.btnDeporte.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeporte.Name = "btnDeporte";
            this.btnDeporte.Size = new System.Drawing.Size(112, 35);
            this.btnDeporte.TabIndex = 15;
            this.btnDeporte.Text = "Deporte";
            this.btnDeporte.UseVisualStyleBackColor = true;
            this.btnDeporte.Click += new System.EventHandler(this.btnDeporte_Click);
            // 
            // btnTecnologia
            // 
            this.btnTecnologia.BackgroundImage = global::TiendaVirtual.Properties.Resources.conten;
            this.btnTecnologia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTecnologia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTecnologia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTecnologia.FlatAppearance.BorderSize = 0;
            this.btnTecnologia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTecnologia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTecnologia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTecnologia.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecnologia.ForeColor = System.Drawing.Color.Transparent;
            this.btnTecnologia.Location = new System.Drawing.Point(144, 54);
            this.btnTecnologia.Margin = new System.Windows.Forms.Padding(0);
            this.btnTecnologia.Name = "btnTecnologia";
            this.btnTecnologia.Size = new System.Drawing.Size(112, 35);
            this.btnTecnologia.TabIndex = 14;
            this.btnTecnologia.Text = "Tecnologia";
            this.btnTecnologia.UseVisualStyleBackColor = true;
            this.btnTecnologia.Click += new System.EventHandler(this.btnTecnologia_Click);
            // 
            // btnHogar
            // 
            this.btnHogar.BackgroundImage = global::TiendaVirtual.Properties.Resources.conten;
            this.btnHogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHogar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHogar.FlatAppearance.BorderSize = 0;
            this.btnHogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHogar.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHogar.ForeColor = System.Drawing.Color.Transparent;
            this.btnHogar.Location = new System.Drawing.Point(12, 54);
            this.btnHogar.Margin = new System.Windows.Forms.Padding(0);
            this.btnHogar.Name = "btnHogar";
            this.btnHogar.Size = new System.Drawing.Size(112, 35);
            this.btnHogar.TabIndex = 13;
            this.btnHogar.Text = "Hogar";
            this.btnHogar.UseVisualStyleBackColor = true;
            this.btnHogar.Click += new System.EventHandler(this.btnHogar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Productos de Interes";
            // 
            // flowLayoutInicio
            // 
            this.flowLayoutInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutInicio.AutoSize = true;
            this.flowLayoutInicio.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutInicio.Location = new System.Drawing.Point(12, 94);
            this.flowLayoutInicio.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutInicio.Name = "flowLayoutInicio";
            this.flowLayoutInicio.Size = new System.Drawing.Size(909, 259);
            this.flowLayoutInicio.TabIndex = 18;
            // 
            // pbPromo
            // 
            this.pbPromo.BackColor = System.Drawing.Color.Navy;
            this.pbPromo.BackgroundImage = global::TiendaVirtual.Properties.Resources.promo2;
            this.pbPromo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPromo.FlatAppearance.BorderSize = 0;
            this.pbPromo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pbPromo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pbPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbPromo.Location = new System.Drawing.Point(12, 12);
            this.pbPromo.Name = "pbPromo";
            this.pbPromo.Size = new System.Drawing.Size(526, 211);
            this.pbPromo.TabIndex = 0;
            this.pbPromo.UseVisualStyleBackColor = false;
            // 
            // vtnInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(921, 600);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vtnInicio";
            this.Text = "vtnInicio";
            this.Resize += new System.EventHandler(this.vtnInicio_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Styles.RoundedButton pbPromo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnHogar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTecnologia;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnDeporte;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutInicio;
        private System.Windows.Forms.FlowLayoutPanel pbProdMasComp;
        private System.Windows.Forms.FlowLayoutPanel pbVendedores;
        private System.Windows.Forms.FlowLayoutPanel pbProMasGuar;
    }
}