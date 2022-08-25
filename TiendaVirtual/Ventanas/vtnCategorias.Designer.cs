namespace TiendaVirtual.Ventanas
{
    partial class vtnCategorias
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
            this.flowLayoutCategorias = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutInicio = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Montserrat ExtraBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(215, 47);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Categorias";
            // 
            // flowLayoutCategorias
            // 
            this.flowLayoutCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutCategorias.AutoScroll = true;
            this.flowLayoutCategorias.AutoSize = true;
            this.flowLayoutCategorias.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutCategorias.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutCategorias.Location = new System.Drawing.Point(20, 66);
            this.flowLayoutCategorias.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutCategorias.Name = "flowLayoutCategorias";
            this.flowLayoutCategorias.Size = new System.Drawing.Size(186, 525);
            this.flowLayoutCategorias.TabIndex = 19;
            // 
            // flowLayoutInicio
            // 
            this.flowLayoutInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutInicio.AutoSize = true;
            this.flowLayoutInicio.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutInicio.Location = new System.Drawing.Point(226, 66);
            this.flowLayoutInicio.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutInicio.Name = "flowLayoutInicio";
            this.flowLayoutInicio.Size = new System.Drawing.Size(696, 525);
            this.flowLayoutInicio.TabIndex = 20;
            // 
            // vtnCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(921, 600);
            this.Controls.Add(this.flowLayoutInicio);
            this.Controls.Add(this.flowLayoutCategorias);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(921, 600);
            this.Name = "vtnCategorias";
            this.Text = "vtnCategorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCategorias;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutInicio;
    }
}