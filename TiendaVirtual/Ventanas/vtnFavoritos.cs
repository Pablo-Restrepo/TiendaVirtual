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
    public partial class vtnFavoritos : Form
    {
        private Label title = new Label();
        private Panel p = new Panel();
        private Label costo = new Label();
        private MemoryStream ms = new MemoryStream();
        private PictureBox pb;
        private PictureBox like;
        private List<clsProducto> datosProducto = new List<clsProducto>();
        private clsProducto producto = new clsProducto();
        private ArrayList guardados = new ArrayList();
        public IForm contrato { get; set; }
        public vtnFavoritos()
        {
            InitializeComponent();
            datosProductos();
            prodGuardados();
            generarBloques();
        }
        private void datosProductos()
        {
            datosProducto = producto.consultarProductosGuardados();
        }
        private void generarBloques()
        {
            int ancho, alto;
            ancho = (flowLayoutGuardados.Width / 4);
            alto = (flowLayoutGuardados.Height / 2);

            for (int i = 0; i < datosProducto.Count; i++)
            {
                p = new Panel();
                pb = new PictureBox();
                like = new PictureBox();
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

                like.TabIndex = i;
                like.Size = new Size(35, 35);
                like.Location = new Point(150, 15);
                if (estaGuardado(datosProducto[i].ProId))
                {
                    like.BackgroundImage = Properties.Resources.like;
                }
                else
                {
                    like.BackgroundImage = Properties.Resources.nolike;
                }
                like.BackgroundImageLayout = ImageLayout.Zoom;
                like.BackColor = Color.Transparent;

                pb.TabIndex = i;
                pb.Size = new Size(ancho - 40, alto - 110);
                pb.Location = new Point(20, 20);
                ms = new MemoryStream(datosProducto[i].prodFoto);
                pb.BackgroundImage = Image.FromStream(ms);
                pb.BackgroundImageLayout = ImageLayout.Zoom;
                pb.BackColor = Color.White;
                pb.Cursor = Cursors.Hand;

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

                title.Location = new Point(15, 210);
                costo.Location = new Point(15, 230);

                p.Controls.Add(like);
                p.Controls.Add(pb);
                p.Controls.Add(title);
                p.Controls.Add(costo);

                flowLayoutGuardados.Controls.Add(p);
                p.Click += new EventHandler(cliquearPanel);
                pb.Click += new EventHandler(cliquearPb);
                title.Click += new EventHandler(cliquearLabel);
                costo.Click += new EventHandler(cliquearLabel);
                like.Click += new EventHandler(guardar);
            }
        }
        private void cliquearPanel(object sender, EventArgs e)
        {
            p = new Panel();
            p = (Panel)sender;
            contrato.Ejecutar(agregarDatosVtnProd(p.TabIndex));
        }
        private void cliquearLabel(object sender, EventArgs e)
        {
            title = new Label();
            title = (Label)sender;
            contrato.Ejecutar(agregarDatosVtnProd(title.TabIndex));
        }
        private void cliquearPb(object sender, EventArgs e)
        {
            pb = new PictureBox();
            pb = (PictureBox)sender;
            contrato.Ejecutar(agregarDatosVtnProd(pb.TabIndex));
        }
        private void guardar(object sender, EventArgs e)
        {
            like = new PictureBox();
            like = (PictureBox)sender;
            if (estaGuardado(datosProducto[like.TabIndex].ProId))
            {
                like.BackgroundImage = Properties.Resources.nolike;
                producto.eliminarGuardarProducto(datosProducto[like.TabIndex].ProId);
            }
            else
            {
                producto.guardarProducto(datosProducto[like.TabIndex].ProId);
                like.BackgroundImage = Properties.Resources.like;
            }
        }
        private vtnProducto agregarDatosVtnProd(int TabIndex)
        {
            vtnProducto aux = new vtnProducto();
            ms = new MemoryStream(datosProducto[TabIndex].prodFoto);
            aux.lblNombreProd.Text = datosProducto[TabIndex].ProNombre.ToString();
            aux.lblPrecio.Text = "Precio:  $" + datosProducto[TabIndex].ProPrecio.ToString();
            aux.lblDescrip.Text = datosProducto[TabIndex].ProDescripcion.ToString();
            aux.pbImagenProd.BackgroundImage = Image.FromStream(ms);
            aux.idproducto = datosProducto[TabIndex].ProId;
            aux.total = datosProducto[TabIndex].ProPrecio;
            aux.aux = datosProducto[TabIndex].ProPrecio;
            return aux;
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
        private void prodGuardados()
        {
            guardados = producto.consultarGuardados();
        }
    }
}
