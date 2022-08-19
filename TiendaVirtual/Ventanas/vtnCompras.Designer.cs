namespace TiendaVirtual.Ventanas
{
    partial class vtnCompras
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
            this.flowLayoutCompras = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutCompras
            // 
            this.flowLayoutCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutCompras.AutoSize = true;
            this.flowLayoutCompras.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutCompras.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutCompras.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutCompras.Name = "flowLayoutCompras";
            this.flowLayoutCompras.Size = new System.Drawing.Size(921, 600);
            this.flowLayoutCompras.TabIndex = 20;
            // 
            // vtnCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(921, 600);
            this.Controls.Add(this.flowLayoutCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(921, 600);
            this.Name = "vtnCompras";
            this.Text = "vtnCompras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutCompras;
    }
}