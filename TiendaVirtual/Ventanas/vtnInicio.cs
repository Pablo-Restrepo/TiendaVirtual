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
    public partial class vtnInicio : Form
    {
        private Boolean bandera = true;
        private Boolean bandera2 = true;
        private Label title = new Label();
        private Panel p = new Panel();
        private Label costo = new Label();
        private MemoryStream ms = new MemoryStream();
        private List<Image> imgList = new List<Image>();
        private int imagen = 1;
        private PictureBox pb;
        List<clsProducto> datosProducto = new List<clsProducto>();
        public Interface1 contrato { get; set; }
        public vtnInicio()
        {
            InitializeComponent();
            generarBloques();
            generarBloques2();
            guardarImagenesPromo();
            panelPromo();
            panelBottom.Size = new Size(panelBottom.Width, flowLayoutInicio.Height + 128);
        }
        private void vtnInicio_Resize(object sender, EventArgs e)
        {
            panelBottom.Size = new Size(panelBottom.Width, flowLayoutInicio.Height + 128);
            if (this.Width >= 1600 && bandera2)
            {
                bandera2 = false;
                bandera = true;
                pbProDesc.Visible = true;
                pbVendedores.Visible = true;
            }
            if (this.Width >= 1250 && this.Width < 1600 && bandera)
            {
                bandera = false;
                bandera2 = true;
                pbVendedores.Visible = true;
                pbProDesc.Visible = false;
            }
            if (this.Width < 1250 && !bandera)
            {
                bandera = true;
                bandera2 = true;
                pbVendedores.Visible = false;
                pbProDesc.Visible = false;
            }
            else if (this.Width < 1250 && !bandera2)
            {
                bandera = true;
                bandera2 = true;
                pbVendedores.Visible = false;
                pbProDesc.Visible = false;
            }
        }
        private void generarBloques()
        {
            int ancho, alto;
            ancho = (flowLayoutInicio.Width / 4 - 30);
            alto = (flowLayoutInicio.Height + 1);

            for (int i = 0; i < datosProducto.Count; i++)
            {
                p = new Panel();
                pb = new PictureBox();
                title = new Label();
                costo = new Label();

                p.TabIndex = i;
                p.Margin = new Padding(0, 25, 25, 0);
                p.Size = new Size(ancho, alto);
                byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\marco.png");
                ms = new MemoryStream(imagen);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.Cursor = Cursors.Hand;

                pb.TabIndex = i;
                pb.Size = new Size(ancho - 40, alto - 110);
                pb.Location = new Point(20, 20);
                byte[] imagen1 = File.ReadAllBytes("..\\..\\Resources\\teclado.jpg");
                ms = new MemoryStream(imagen1);
                pb.BackgroundImage = Image.FromStream(ms);
                pb.BackgroundImageLayout = ImageLayout.Stretch;
                pb.Cursor = Cursors.Hand;

                title.Text = "Teclado";
                title.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.ForeColor = Color.White;
                title.TabIndex = i;
                title.Cursor = Cursors.Hand;

                costo.Text = "$200.000";
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costo.TabIndex = i;
                costo.ForeColor = Color.White;
                costo.Cursor = Cursors.Hand;

                title.Location = new Point(15, 185);
                costo.Location = new Point(15, 210);

                p.Controls.Add(pb);
                p.Controls.Add(title);
                p.Controls.Add(costo);

                flowLayoutInicio.Controls.Add(p);
                p.Click += new EventHandler(cliquear);
                pb.Click += new EventHandler(cliquear);
                title.Click += new EventHandler(cliquear);
                costo.Click += new EventHandler(cliquear);
            }
        }
        private void generarBloques2()
        {
            int ancho, alto;
            ancho = (pbProdMasComp.Width / 4 + 10);
            alto = (pbProdMasComp.Height / 2 - 15);
            int cant = 0;

            for (int i = 0; i < 3; i++)
            {
                p = new Panel();
                costo = new Label();

                cant++;
                p.TabIndex = i;
                p.Margin = new Padding(13, 110, 0, 0);
                p.Size = new Size(ancho, alto);
                p.Cursor = Cursors.Hand;
                byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\teclado.jpg");
                ms = new MemoryStream(imagen);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Stretch;


                costo.Text = "$200.000";
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costo.TabIndex = i;
                costo.BackColor = Color.Red;
                costo.ForeColor = Color.White;

                costo.Location = new Point(0, 67);
                p.Controls.Add(costo);

                pbProdMasComp.Controls.Add(p);
                p.Click += new EventHandler(cliquear);
                costo.Click += new EventHandler(cliquear);
            }
            for (int i = 0; i < 3; i++)
            {
                p = new Panel();
                costo = new Label();

                cant++;
                p.TabIndex = i;
                p.Margin = new Padding(13, 110, 0, 0);
                p.Size = new Size(ancho, alto);
                p.Cursor = Cursors.Hand;
                byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\teclado.jpg");
                ms = new MemoryStream(imagen);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Stretch;


                costo.Text = "$200.000";
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costo.TabIndex = i;
                costo.BackColor = Color.Red;
                costo.ForeColor = Color.White;

                costo.Location = new Point(0, 67);
                p.Controls.Add(costo);

                pbVendedores.Controls.Add(p);
                p.Click += new EventHandler(cliquear);
                costo.Click += new EventHandler(cliquear);
            }
            for (int i = 0; i < 3; i++)
            {
                p = new Panel();
                costo = new Label();

                cant++;
                p.TabIndex = i;
                p.Margin = new Padding(13, 110, 0, 0);
                p.Size = new Size(ancho, alto);
                p.Cursor = Cursors.Hand;
                byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\teclado.jpg");
                ms = new MemoryStream(imagen);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Stretch;


                costo.Text = "$200.000";
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costo.TabIndex = i;
                costo.BackColor = Color.Red;
                costo.ForeColor = Color.White;

                costo.Location = new Point(0, 67);
                p.Controls.Add(costo);

                pbProDesc.Controls.Add(p);
                p.Click += new EventHandler(cliquear);
                costo.Click += new EventHandler(cliquear);
            }
        }
        private void cliquear(object sender, EventArgs e)
        {
            contrato.Ejecutar(new vtnProducto());
        }
        private void panelPromo()
        {
            pbPromo.BackgroundImage = imgList[0];
            var timer = new System.Timers.Timer(TimeSpan.FromMinutes(3000).TotalMinutes);
            timer.Elapsed += (sender, e) =>
            {
                pbPromo.BackgroundImage = imgList[imagen];
                imagen++;
                if (imagen == imgList.Count) imagen = 0;
            };
            timer.Start();
        }
        private void guardarImagenesPromo()
        {
            imgList.Add(Properties.Resources.promo);
            imgList.Add(Properties.Resources.promo2);
            imgList.Add(Properties.Resources.promo3);
            imgList.Add(Properties.Resources.promo4);
        }
    }
}
