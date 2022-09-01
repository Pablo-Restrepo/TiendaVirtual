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
    public partial class vtnVentas : Form
    {
        private string FotoLocation;
        private clsProducto producto = new clsProducto();
        private Panel p = new Panel();
        private Label title = new Label();
        private Label costo = new Label();
        private PictureBox pb;
        private PictureBox pb1;
        private PictureBox like;
        private MemoryStream ms = new MemoryStream();
        private List<clsProducto> datosProducto = new List<clsProducto>();
        private ArrayList guardados = new ArrayList();
        public IForm contrato { get; set; }
        public vtnVentas()
        {
            InitializeComponent();
            misProductos();
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
            }
        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "Precio")
            {
                txtPrecio.Text = "";
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "Precio";
            }
        }

        private void txtDescrip_Click(object sender, EventArgs e)
        {
            if (txtDescrip.Text == "Descripcion (Max. 500)")
            {
                txtDescrip.Text = "";
            }
        }

        private void txtDescrip_Leave(object sender, EventArgs e)
        {
            if (txtDescrip.Text == "")
            {
                txtDescrip.Text = "Descripcion (Max. 500)";
            }
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Archivos de texto (*.jpg)|*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FotoLocation = ofd.FileName.ToString();
                    pbFoto.ImageLocation = FotoLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato de archivo incorrecto", ex.Message);
            }
        }

        private void pbPublicar_Click(object sender, EventArgs e)
        {
            byte[] MaqFoto = null;
            if (FotoLocation != null)
            {
                FileStream fileStream = new FileStream(FotoLocation, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fileStream);
                MaqFoto = new byte[fileStream.Length];
                MaqFoto = reader.ReadBytes((int)MaqFoto.Length);
            }
            int resultado = 0;
            try
            {
                resultado = producto.crearProducto(txtNombre.Text, float.Parse(txtPrecio.Text), txtDescrip.Text, cmbCategoria.Text, MaqFoto);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (resultado > 0)
            {
                MessageBox.Show("Producto Creado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                misProductos();
            }
            else
            {
                MessageBox.Show("Error! Producto NO Creado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void misProductos()
        {
            datosProducto = producto.tusProductos();
            generarBloques();
        }
        private void generarBloques()
        {
            int ancho, alto;
            ancho = (197);
            alto = (260);
            flowLayoutPro.Controls.Clear();
            for (int i = 0; i < datosProducto.Count; i++)
            {
                p = new Panel();
                pb = new PictureBox();
                pb1 = new PictureBox();
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

                pb1.TabIndex = i;
                pb1.Size = new Size(35, 35);
                pb1.Location = new Point(110, 15);
                pb1.BackgroundImage = Properties.Resources.eliminar;
                pb1.BackgroundImageLayout = ImageLayout.Zoom;
                pb1.BackColor = Color.White;
                pb1.Cursor = Cursors.Hand;
                pb1.BackColor = Color.Transparent;

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

                title.Location = new Point(15, 185);
                costo.Location = new Point(15, 210);

                p.Controls.Add(pb1);
                p.Controls.Add(like);
                p.Controls.Add(pb);
                p.Controls.Add(title);
                p.Controls.Add(costo);

                flowLayoutPro.Controls.Add(p);
                p.Click += new EventHandler(cliquearPanel);
                pb.Click += new EventHandler(cliquearPb);
                pb1.Click += new EventHandler(eliminar);
                title.Click += new EventHandler(cliquearLabel);
                costo.Click += new EventHandler(cliquearLabel);
                like.Click += new EventHandler(guardar);
            }
        }
        private void eliminar(object sender, EventArgs e)
        {
            pb1 = new PictureBox();
            pb1 = (PictureBox)sender;
            producto.eliminarProducto(datosProducto[pb1.TabIndex].ProId);
            misProductos();
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
            if (estaGuardado(datosProducto[TabIndex].ProId))
            {
                aux.pbLike.BackgroundImage = Properties.Resources.like;
            }
            else
            {
                aux.pbLike.BackgroundImage = Properties.Resources.nolike;
            }
            return aux;
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