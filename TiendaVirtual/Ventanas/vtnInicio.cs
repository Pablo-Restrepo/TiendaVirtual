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
    public partial class vtnInicio : Form
    {
        private Boolean bandera = true;
        private Boolean bandera2 = true;
        private Label title = new Label();
        private Panel p = new Panel();
        private Label costo = new Label();
        private MemoryStream ms = new MemoryStream();
        private List<clsPromocional> datosPromocionales = new List<clsPromocional>();
        private List<Image> imgList = new List<Image>();
        private int imagen = -1;
        private PictureBox pb;
        private PictureBox like;
        private List<clsProducto> datosProducto = new List<clsProducto>();
        private List<clsProducto> datosProducto1 = new List<clsProducto>();
        private List<clsProducto> datosProducto2 = new List<clsProducto>();
        private List<clsProducto> datosProducto3 = new List<clsProducto>();
        private clsProducto producto = new clsProducto();
        private clsPromocional promocional = new clsPromocional();
        private ArrayList guardados = new ArrayList();
        public IForm contrato { get; set; }
        public vtnInicio()
        {
            InitializeComponent();
            datosProductos();
            prodGuardados();
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
                pbProMasGuar.Visible = true;
                pbVendedores.Visible = true;
            }
            if (this.Width >= 1250 && this.Width < 1600 && bandera)
            {
                
                bandera2 = true;
                pbVendedores.Visible = true;
                pbProMasGuar.Visible = false;
            }
            if (this.Width < 1250 && !bandera)
            {
                bandera = true;
                bandera2 = true;
                pbVendedores.Visible = false;
                pbProMasGuar.Visible = false;
            }
            else if (this.Width < 1250 && !bandera2)
            {
                bandera = true;
                bandera2 = true;
                pbVendedores.Visible = false;
                pbProMasGuar.Visible = false;
            }
        }
        private void generarBloques()
        {
            int ancho, alto;
            ancho = (197);
            alto = (260);
            flowLayoutInicio.Controls.Clear();
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

                title.Location = new Point(15, 185);
                costo.Location = new Point(15, 210);

                p.Controls.Add(like);
                p.Controls.Add(pb);
                p.Controls.Add(title);
                p.Controls.Add(costo);
                
                flowLayoutInicio.Controls.Add(p);
                p.Click += new EventHandler(cliquearPanel);
                pb.Click += new EventHandler(cliquearPb);
                title.Click += new EventHandler(cliquearLabel);
                costo.Click += new EventHandler(cliquearLabel);
                like.Click += new EventHandler(guardar);
            }
        }
        private void generarBloques2()
        {
            int ancho, alto;
            ancho = (pbProdMasComp.Width / 4 + 10);
            alto = (pbProdMasComp.Height / 2 - 15);

            datosProducto1 = producto.masCompradoProducto();

            for (int i = 0; i < datosProducto1.Count; i++)
            {
                p = new Panel();
                costo = new Label();

                p.TabIndex = i;
                p.Margin = new Padding(13, 110, 0, 0);
                p.Size = new Size(ancho, alto);
                p.Cursor = Cursors.Hand;
                ms = new MemoryStream(datosProducto1[i].prodFoto);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Zoom;
                p.BackColor = Color.White;

                costo.Text = "$" + datosProducto1[i].ProPrecio.ToString();
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costo.TabIndex = i;
                costo.BackColor = Color.Red;
                costo.ForeColor = Color.White;

                costo.Location = new Point(0, 67);
                p.Controls.Add(costo);

                pbProdMasComp.Controls.Add(p);
                p.Click += new EventHandler(cliquearPanel1);
                costo.Click += new EventHandler(cliquearLabel1);
            }

            datosProducto2 = producto.masGuardosProducto();

            for (int i = 0; i < datosProducto2.Count; i++)
            {
                p = new Panel();
                costo = new Label();

                p.TabIndex = i;
                p.Margin = new Padding(13, 110, 0, 0);
                p.Size = new Size(ancho, alto);
                p.Cursor = Cursors.Hand;
                ms = new MemoryStream(datosProducto2[i].prodFoto);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Zoom;
                p.BackColor = Color.White;

                costo.Text = "$" + datosProducto2[i].ProPrecio.ToString();
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costo.TabIndex = i;
                costo.BackColor = Color.Red;
                costo.ForeColor = Color.White;

                costo.Location = new Point(0, 67);
                p.Controls.Add(costo);

                pbProMasGuar.Controls.Add(p);
                p.Click += new EventHandler(cliquearPanel2);
                costo.Click += new EventHandler(cliquearLabel2);
            }

            datosProducto3 = producto.masBaratoProducto();

            for (int i = 0; i < datosProducto3.Count; i++)
            {
                p = new Panel();
                costo = new Label();

                p.TabIndex = i;
                p.Margin = new Padding(13, 110, 0, 0);
                p.Size = new Size(ancho, alto);
                p.Cursor = Cursors.Hand;
                ms = new MemoryStream(datosProducto3[i].prodFoto);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Zoom;
                p.BackColor = Color.White;

                costo.Text = "$" + datosProducto3[i].ProPrecio.ToString();
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costo.TabIndex = i;
                costo.BackColor = Color.Red;
                costo.ForeColor = Color.White;

                costo.Location = new Point(0, 67);
                p.Controls.Add(costo);

                pbVendedores.Controls.Add(p);
                p.Click += new EventHandler(cliquearPanel);
                costo.Click += new EventHandler(cliquearLabel);
            }
        }
        private void cliquearPanel(object sender, EventArgs e)
        {
            p = new Panel();
            p = (Panel)sender;
            contrato.Ejecutar(agregarDatosVtnProd(p.TabIndex));
        }
        private void cliquearPanel1(object sender, EventArgs e)
        {
            p = new Panel();
            p = (Panel)sender;
            contrato.Ejecutar(agregarDatosVtnProd1(p.TabIndex));
        }
        private void cliquearPanel2(object sender, EventArgs e)
        {
            p = new Panel();
            p = (Panel)sender;
            contrato.Ejecutar(agregarDatosVtnProd2(p.TabIndex));
        }
        private void cliquearLabel(object sender, EventArgs e)
        {
            title = new Label();
            title = (Label)sender;
            contrato.Ejecutar(agregarDatosVtnProd(title.TabIndex));
        }
        private void cliquearLabel1(object sender, EventArgs e)
        {
            title = new Label();
            title = (Label)sender;
            contrato.Ejecutar(agregarDatosVtnProd1(title.TabIndex));
        }
        private void cliquearLabel2(object sender, EventArgs e)
        {
            title = new Label();
            title = (Label)sender;
            contrato.Ejecutar(agregarDatosVtnProd2(title.TabIndex));
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
        private vtnProducto agregarDatosVtnProd1(int TabIndex)
        {
            vtnProducto aux = new vtnProducto();
            ms = new MemoryStream(datosProducto1[TabIndex].prodFoto);
            aux.lblNombreProd.Text = datosProducto1[TabIndex].ProNombre.ToString();
            aux.lblPrecio.Text = "Precio:  $" + datosProducto1[TabIndex].ProPrecio.ToString();
            aux.lblDescrip.Text = datosProducto1[TabIndex].ProDescripcion.ToString();
            aux.pbImagenProd.BackgroundImage = Image.FromStream(ms);
            aux.idproducto = datosProducto1[TabIndex].ProId;
            aux.total = datosProducto1[TabIndex].ProPrecio;
            aux.aux = datosProducto1[TabIndex].ProPrecio;
            if (estaGuardado(datosProducto1[TabIndex].ProId))
            {
                aux.pbLike.BackgroundImage = Properties.Resources.like;
            }
            else
            {
                aux.pbLike.BackgroundImage = Properties.Resources.nolike;
            }
            return aux;
        }
        private vtnProducto agregarDatosVtnProd2(int TabIndex)
        {
            vtnProducto aux = new vtnProducto();
            ms = new MemoryStream(datosProducto2[TabIndex].prodFoto);
            aux.lblNombreProd.Text = datosProducto2[TabIndex].ProNombre.ToString();
            aux.lblPrecio.Text = "Precio:  $" + datosProducto2[TabIndex].ProPrecio.ToString();
            aux.lblDescrip.Text = datosProducto2[TabIndex].ProDescripcion.ToString();
            aux.pbImagenProd.BackgroundImage = Image.FromStream(ms);
            aux.idproducto = datosProducto2[TabIndex].ProId;
            aux.total = datosProducto2[TabIndex].ProPrecio;
            aux.aux = datosProducto2[TabIndex].ProPrecio;
            if (estaGuardado(datosProducto2[TabIndex].ProId))
            {
                aux.pbLike.BackgroundImage = Properties.Resources.like;
            }
            else
            {
                aux.pbLike.BackgroundImage = Properties.Resources.nolike;
            }
            return aux;
        }
        private void panelPromo()
        {
            var timer = new System.Timers.Timer(TimeSpan.FromMinutes(3000).TotalMinutes);
            timer.Elapsed += (sender, e) =>
            {
                
                imagen++;
                if (imagen == imgList.Count) imagen = 0;
                pbPromo.BackgroundImage = imgList[imagen];
            };
            timer.Start();
        }
        private void guardarImagenesPromo()
        {
            datosPromocionales = promocional.consultarPromocionales();
            for (int i = 0; i < datosPromocionales.Count; i++)
            {
                ms = new MemoryStream(datosPromocionales[i].PromFoto);
                imgList.Add(Image.FromStream(ms));
            }
        }
        private void datosProductos()
        {
            datosProducto = producto.consultarProductos();
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

        private void btnTodo_Click(object sender, EventArgs e)
        {
            btnTodo.BackgroundImage = Properties.Resources.conten2;
            btnDeporte.BackgroundImage = Properties.Resources.conten;
            btnHogar.BackgroundImage = Properties.Resources.conten;
            btnTecnologia.BackgroundImage = Properties.Resources.conten;

            datosProductos();
            generarBloques();
        }

        private void btnHogar_Click(object sender, EventArgs e)
        {
            btnTodo.BackgroundImage = Properties.Resources.conten;
            btnDeporte.BackgroundImage = Properties.Resources.conten;
            btnHogar.BackgroundImage = Properties.Resources.conten2;
            btnTecnologia.BackgroundImage = Properties.Resources.conten;

            datosProducto = producto.hogarProducto();
            generarBloques();
        }

        private void btnTecnologia_Click(object sender, EventArgs e)
        {
            btnTodo.BackgroundImage = Properties.Resources.conten;
            btnDeporte.BackgroundImage = Properties.Resources.conten;
            btnHogar.BackgroundImage = Properties.Resources.conten;
            btnTecnologia.BackgroundImage = Properties.Resources.conten2;
            datosProducto = producto.tecnologiaProducto();
            generarBloques();
        }

        private void btnDeporte_Click(object sender, EventArgs e)
        {
            btnTodo.BackgroundImage = Properties.Resources.conten;
            btnDeporte.BackgroundImage = Properties.Resources.conten2;
            btnHogar.BackgroundImage = Properties.Resources.conten;
            btnTecnologia.BackgroundImage = Properties.Resources.conten;
            datosProducto = producto.deporteProducto();
            generarBloques();
        }
    }
}
