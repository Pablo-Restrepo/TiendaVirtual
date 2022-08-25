namespace TiendaVirtual.Ventanas
{
    partial class vtnFavoritos
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
            this.flowLayoutGuardados = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutGuardados
            // 
            this.flowLayoutGuardados.AutoSize = true;
            this.flowLayoutGuardados.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutGuardados.Location = new System.Drawing.Point(20, 56);
            this.flowLayoutGuardados.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutGuardados.Name = "flowLayoutGuardados";
            this.flowLayoutGuardados.Size = new System.Drawing.Size(901, 535);
            this.flowLayoutGuardados.TabIndex = 21;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Montserrat ExtraBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(187, 47);
            this.lblInfo.TabIndex = 22;
            this.lblInfo.Text = "Favoritos";
            // 
            // vtnFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(921, 600);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.flowLayoutGuardados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(921, 600);
            this.Name = "vtnFavoritos";
            this.Text = "vtnFavoritos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutGuardados;
        private System.Windows.Forms.Label lblInfo;
    }
}