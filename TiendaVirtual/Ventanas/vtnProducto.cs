using System;
using System.Collections;
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
    public partial class vtnProducto : Form
    {
        private Boolean bandera = true;
        private Label title = new Label();
        private Panel p = new Panel();
        private Label costo = new Label();
        private MemoryStream ms = new MemoryStream();
        private PictureBox pb;
        private List<clsProducto> datosProducto = new List<clsProducto>();
        private clsProducto producto = new clsProducto();
        private int cantidad = 1;
        private ArrayList guardados = new ArrayList();
        private Form fH;
        public IForm contrato { get; set; }
        public long idproducto { get; set; }
        public float total { get; set; }
        public float aux { get; set; }
        public vtnProducto()
        {
            InitializeComponent();
            datosProductos();
            generarBloques();
        }

        private void vtnProducto_Resize(object sender, EventArgs e)
        {
            if (this.Height >= 700 && bandera)
            {
                bandera = false;
                flowLayoutProductos.Size = new Size(this.Width, flowLayoutProductos.Height - 60);
            }
            if (this.Height < 700 && !bandera)
            {
                bandera = true;
                flowLayoutProductos.Size = new Size(this.Width - 500, flowLayoutProductos.Height + 60);
            }
        }
        private void generarBloques()
        {
            int ancho, alto;
            ancho = (131);
            alto = (173);

            for (int i = 0; i < datosProducto.Count; i++)
            {
                p = new Panel();
                pb = new PictureBox();
                title = new Label();
                costo = new Label();

                p.TabIndex = i;
                p.Margin = new Padding(0, 15, 15, 0);
                p.Size = new Size(ancho, alto);
                byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\marco.png");
                ms = new MemoryStream(imagen);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Zoom;
                p.Cursor = Cursors.Hand;

                pb.TabIndex = i;
                pb.Size = new Size(ancho - 42, alto /2);
                pb.Location = new Point(20, 20);
                ms = new MemoryStream(datosProducto[i].prodFoto);
                pb.BackgroundImage = Image.FromStream(ms);
                pb.BackgroundImageLayout = ImageLayout.Zoom;
                pb.Cursor = Cursors.Hand;
                pb.BackColor = Color.White;

                title.Text = datosProducto[i].ProNombre.ToString();
                title.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.ForeColor = Color.White;
                title.TabIndex = i;
                title.Cursor = Cursors.Hand;

                costo.Text = "$" + datosProducto[i].ProPrecio.ToString();
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costo.TabIndex = i;
                costo.ForeColor = Color.White;
                costo.Cursor = Cursors.Hand;

                title.Location = new Point(15, 120);
                costo.Location = new Point(15, 140);

                p.Controls.Add(pb);
                p.Controls.Add(title);
                p.Controls.Add(costo);

                flowLayoutProductos.Controls.Add(p);
                p.Click += new EventHandler(cliquearPanel);
                pb.Click += new EventHandler(cliquearPb);
                title.Click += new EventHandler(cliquearLabel);
                costo.Click += new EventHandler(cliquearLabel);
            }
        }
        private void cliquearPanel(object sender, EventArgs e)
        {
            p = new Panel();
            p = (Panel)sender;
            vtnProducto aux = new vtnProducto();
            ms = new MemoryStream(datosProducto[p.TabIndex].prodFoto);
            aux.lblNombreProd.Text = datosProducto[p.TabIndex].ProNombre.ToString();
            aux.lblPrecio.Text = "Precio:  $" + datosProducto[p.TabIndex].ProPrecio.ToString();
            aux.lblDescrip.Text = datosProducto[p.TabIndex].ProDescripcion.ToString();
            aux.pbImagenProd.BackgroundImage = Image.FromStream(ms);
            aux.idproducto = datosProducto[p.TabIndex].ProId;
            aux.total = datosProducto[p.TabIndex].ProPrecio;
            aux.aux = datosProducto[p.TabIndex].ProPrecio;
            if (estaGuardado(datosProducto[p.TabIndex].ProId))
            {
                aux.pbLike.BackgroundImage = Properties.Resources.like;
            }
            else
            {
                aux.pbLike.BackgroundImage = Properties.Resources.nolike;
            }
            abrirFormHija(aux);
        }
        private void cliquearLabel(object sender, EventArgs e)
        {
            title = new Label();
            title = (Label)sender;
            vtnProducto aux = new vtnProducto();
            ms = new MemoryStream(datosProducto[title.TabIndex].prodFoto);
            aux.lblNombreProd.Text = datosProducto[title.TabIndex].ProNombre.ToString();
            aux.lblPrecio.Text = "Precio:  $" + datosProducto[title.TabIndex].ProPrecio.ToString();
            aux.lblDescrip.Text = datosProducto[title.TabIndex].ProDescripcion.ToString();
            aux.pbImagenProd.BackgroundImage = Image.FromStream(ms);
            aux.idproducto = datosProducto[title.TabIndex].ProId;
            aux.total = datosProducto[title.TabIndex].ProPrecio;
            aux.aux = datosProducto[title.TabIndex].ProPrecio;
            if (estaGuardado(datosProducto[title.TabIndex].ProId))
            {
                aux.pbLike.BackgroundImage = Properties.Resources.like;
            }
            else
            {
                aux.pbLike.BackgroundImage = Properties.Resources.nolike;
            }
            abrirFormHija(aux);
        }
        private void cliquearPb(object sender, EventArgs e)
        {
            pb = new PictureBox();
            pb = (PictureBox)sender;
            vtnProducto aux = new vtnProducto();
            ms = new MemoryStream(datosProducto[pb.TabIndex].prodFoto);
            aux.lblNombreProd.Text = datosProducto[pb.TabIndex].ProNombre.ToString();
            aux.lblPrecio.Text = "Precio:  $" + datosProducto[pb.TabIndex].ProPrecio.ToString();
            aux.lblDescrip.Text = datosProducto[pb.TabIndex].ProDescripcion.ToString();
            aux.pbImagenProd.BackgroundImage = Image.FromStream(ms);
            aux.idproducto = datosProducto[pb.TabIndex].ProId;
            aux.total = datosProducto[pb.TabIndex].ProPrecio;
            aux.aux = datosProducto[pb.TabIndex].ProPrecio;
            if (estaGuardado(datosProducto[pb.TabIndex].ProId))
            {
                aux.pbLike.BackgroundImage = Properties.Resources.like;
            }
            else
            {
                aux.pbLike.BackgroundImage = Properties.Resources.nolike;
            }
            abrirFormHija(aux);
        }
        public void abrirFormHija(object formHija)
        {
            if (this.Controls.Count > 0)
            {
                this.Controls.Clear();
            }
            if (fH != null)
            {
                fH.Dispose();
            }
            fH = formHija as Form;
            fH.TopLevel = false;
            fH.Dock = DockStyle.Fill;
            this.Controls.Add(fH);
            this.Tag = fH;
            fH.Show();
        }
        private void datosProductos()
        {
            datosProducto = producto.consultarProductos();
        }

        private void pbComprar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            try
            {
                resultado = producto.comprarProducto(idproducto, total, Int32.Parse(lblCantidad.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (resultado > 0)
            {
                MessageBox.Show("Producto Comprado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Producto NO Comprado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbMenos_Click(object sender, EventArgs e)
        {
            if (cantidad >= 2)
            {
                cantidad--;
                total = total - aux;
            }
            lblCantidad.Text = cantidad.ToString();
        }

        private void pbMas_Click(object sender, EventArgs e)
        {
            cantidad++;
            total = total + aux;
            lblCantidad.Text = cantidad.ToString();
        }

        private void pbLike_Click(object sender, EventArgs e)
        {
            guardar();
        }
        private void guardar()
        {
            if (estaGuardado(idproducto))
            {
                pbLike.BackgroundImage = Properties.Resources.nolike;
                producto.eliminarGuardarProducto(datosProducto[0].ProId);
            }
            else
            {
                producto.guardarProducto(idproducto);
                pbLike.BackgroundImage = Properties.Resources.like;
            }
        }
        private void prodGuardados()
        {
            guardados = producto.consultarGuardados();
        }
        private Boolean estaGuardado(long idproducto)
        {
            prodGuardados();
            for (int i = 0; i < guardados.Count; i++)
            {
                if (long.Parse(guardados[i].ToString()) == idproducto)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
