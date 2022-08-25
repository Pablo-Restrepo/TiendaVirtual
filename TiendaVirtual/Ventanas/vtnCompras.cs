using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaVirtual.Logica;

namespace TiendaVirtual.Ventanas
{
    public partial class vtnCompras : Form
    {
        private Label title = new Label();
        private Panel p = new Panel();
        private Label costo = new Label();
        private Label cantidad = new Label();
        private Label fecha = new Label();
        private MemoryStream ms = new MemoryStream();
        private PictureBox pb;
        private List<clsCompra> datosCompra = new List<clsCompra>();
        private clsCompra compra = new clsCompra();
        public vtnCompras()
        {
            InitializeComponent();
            datosProductos();
            generarBloques();
        }
        private void generarBloques()
        {
            int ancho, alto;
            ancho = (flowLayoutCompras.Width / 4);
            alto = (flowLayoutCompras.Height / 2 + 30);

            for (int i = 0; i < datosCompra.Count; i++)
            {
                p = new Panel();
                pb = new PictureBox();
                title = new Label();
                costo = new Label();
                fecha = new Label();
                cantidad = new Label();

                p.TabIndex = i;
                p.Margin = new Padding(0, 25, 25, 0);
                p.Size = new Size(ancho, alto);
                byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\marco.png");
                ms = new MemoryStream(imagen);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Stretch;

                pb.TabIndex = i;
                pb.Size = new Size(ancho - 40, alto - 110);
                pb.Location = new Point(20, 20);
                ms = new MemoryStream(datosCompra[i].prodFoto);
                pb.BackgroundImage = Image.FromStream(ms);
                pb.BackgroundImageLayout = ImageLayout.Zoom;
                pb.BackColor = Color.White;

                title.Text = datosCompra[i].ProNombre.ToString();
                title.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.ForeColor = Color.White;
                title.TabIndex = i;
                title.AutoSize = true;

                costo.Text = "Total : $" + datosCompra[i].ComTotal.ToString();
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costo.TabIndex = i;
                costo.ForeColor = Color.White;
                costo.AutoSize = true;

                fecha.Text = "Fecha: " + datosCompra[i].ComFecha.ToString();
                fecha.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                fecha.ForeColor = Color.White;
                fecha.TabIndex = i;
                fecha.AutoSize = true;

                cantidad.Text = "Cantidad: " + datosCompra[i].ComCantidad.ToString();
                cantidad.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cantidad.ForeColor = Color.White;
                cantidad.TabIndex = i;
                cantidad.AutoSize = true;

                title.Location = new Point(15, 210);
                costo.Location = new Point(15, 230);
                fecha.Location = new Point(15, 250);
                cantidad.Location = new Point(15, 270);

                p.Controls.Add(pb);
                p.Controls.Add(title);
                p.Controls.Add(costo);
                p.Controls.Add(fecha);
                p.Controls.Add(cantidad);

                flowLayoutCompras.Controls.Add(p);
            }
        }
        private void datosProductos()
        {
            datosCompra= compra.consultarCompras();
        }
    }
}
