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
using TiendaVirtual.Ventanas;

namespace TiendaVirtual
{
    public partial class Form1 : Form, IForm
    {
        private Boolean bandera = true;
        private Boolean bandera2 = true;
        private MemoryStream ms = new MemoryStream();
        private Form fH;
        private Panel p = new Panel();
        private Label title = new Label();
        private Label costo = new Label();
        private PictureBox pb;
        private PictureBox like;
        private clsNotificacion notificacion = new clsNotificacion();
        private List<clsNotificacion> datosNotificacion = new List<clsNotificacion>();
        private clsProducto producto = new clsProducto();
        private List<clsProducto> datosProducto = new List<clsProducto>();
        private ArrayList guardados = new ArrayList();
        public IForm contrato { get; set; }
        public Form1()
        {
            InitializeComponent();
            vtnInicio aux = new vtnInicio
            {
                contrato = this
            };
            abrirFormHija(aux);
            infoUser();
            generarNotifi();
        }

        private void infoUser()
        {
            lblUser.Text = Cache.User;
            if (Cache.PerFoto != null)
            {
                ms = new MemoryStream(Cache.PerFoto);
                pbPerfil.BackgroundImage = Image.FromStream(ms);
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            txtBuscar.Text = "Buscar Productos...";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            EndResponsive();
        }
        private void EndResponsive()
        {
            if (this.Width >= 1300 && bandera2)
            {
                panelMenu.Size = new Size(290, panelMenu.Height);
                pbMenu.BackgroundImage = Properties.Resources.menuAmplio;
                lblInicio.Visible = true;
                lblCategorias.Visible = true;
                lblCompras.Visible = true;
                lblEstadisticas.Visible = true;
                lblFavoritos.Visible = true;
                lblInformacion.Visible = true;
                lblPromocionales.Visible = true;
                lblSalir.Visible = true;
                lblVentas.Visible = true;
                btnInicio.Location = new Point(50, 53);
                btnCompras.Location = new Point(50, 128);
                btnFavoritos.Location = new Point(50, 182);
                btnCategorias.Location = new Point(50, 238);
                btnVentas.Location = new Point(50, 294);
                btnEstadisticas.Location = new Point(50, 350);
                btnPromocionales.Location = new Point(50, 406);
                btnInformacion.Location = new Point (50 , btnInformacion.Location.Y - 20);
                btnSalir.Location = new Point(50, btnSalir.Location.Y - 20);
                pbLinea.Location = new Point(50, 106);
                pbLinea2.Location = new Point(50, pbLinea2.Location.Y - 20);
                pbLinea.Size = new Size(197, 1);
                pbLinea2.Size = new Size(197, 1);
                bandera = true;
                bandera2 = false;
            }
            if (this.Width < 1300 && bandera)
            {
                panelMenu.Size = new Size(86, panelMenu.Height);
                pbMenu.BackgroundImage = Properties.Resources.aaaas;
                lblInicio.Visible = false;
                lblCategorias.Visible = false;
                lblCompras.Visible = false;
                lblEstadisticas.Visible = false;
                lblFavoritos.Visible = false;
                lblInformacion.Visible = false;
                lblPromocionales.Visible = false;
                lblSalir.Visible = false;
                lblVentas.Visible = false;
                btnInicio.Location = new Point(26, 37);
                btnCompras.Location = new Point(26, 114);
                btnFavoritos.Location = new Point(26, 170);
                btnCategorias.Location = new Point(26, 225);
                btnVentas.Location = new Point(26, 279);
                btnEstadisticas.Location = new Point(26, 332);
                btnPromocionales.Location = new Point(26, 385);
                pbLinea.Location = new Point(25, 93);
                if (bandera2)
                {
                    btnInformacion.Location = new Point(26, btnInformacion.Location.Y);
                    btnSalir.Location = new Point(25, btnSalir.Location.Y);
                }
                else
                {
                    btnInformacion.Location = new Point(26, btnInformacion.Location.Y + 20);
                    btnSalir.Location = new Point(25, btnSalir.Location.Y + 20);
                    pbLinea2.Location = new Point(24, pbLinea2.Location.Y + 20);
                    pbLinea.Size = new Size(38, 1);
                    pbLinea2.Size = new Size(38, 1);
                }
                bandera = false;
                bandera2 = true;
            }
        }
        public void abrirFormHija(object formHija)
        {
            if (this.panelCentral.Controls.Count > 0)
            {
                this.panelCentral.Controls.Clear();
                this.panelCentral.Controls.Add(flowLayoutNotifi);
            }
            if (fH != null)
            {
                fH.Dispose();
            }
            fH = formHija as Form;
            fH.TopLevel = false;
            fH.Dock = DockStyle.Fill;
            this.panelCentral.Controls.Add(fH);
            this.panelCentral.Tag = fH;
            fH.Show();
        }
        public void Ejecutar(object formHija)
        {
            abrirFormHija(formHija);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            vtnInicio aux = new vtnInicio
            {
                contrato = this
            };
            abrirFormHija(aux);
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {
            vtnInicio aux = new vtnInicio
            {
                contrato = this
            };
            abrirFormHija(aux);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnCompras());
        }

        private void lblCompras_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnCompras());
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            vtnFavoritos aux = new vtnFavoritos
            {
                contrato = this
            };
            abrirFormHija(aux);
        }

        private void lblFavoritos_Click(object sender, EventArgs e)
        {
            vtnFavoritos aux = new vtnFavoritos
            {
                contrato = this
            };
            abrirFormHija(aux);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            vtnCategorias aux = new vtnCategorias
            {
                contrato = this
            };
            abrirFormHija(aux);
        }

        private void lblCategorias_Click(object sender, EventArgs e)
        {
            vtnCategorias aux = new vtnCategorias
            {
                contrato = this
            };
            abrirFormHija(aux);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            vtnVentas aux = new vtnVentas
            {
                contrato = this
            };
            abrirFormHija(aux);
        }

        private void lblVentas_Click(object sender, EventArgs e)
        {
            vtnVentas aux = new vtnVentas
            {
                contrato = this
            };
            abrirFormHija(aux);
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnEstadisticas());
        }

        private void lblEstadisticas_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnEstadisticas());
        }

        private void btnPromocionales_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnPromocionales());
        }

        private void lblPromocionales_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnPromocionales());
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnInfo());
        }

        private void lblInformacion_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnInfo());
        }

        private void pbPerfil_Click(object sender, EventArgs e)
        {
            vtnPerfil aux = new vtnPerfil
            {
                contrato = this
            };
            abrirFormHija(aux);
        }

        public void actualizar()
        {
            infoUser();
        }

        private void pbNotifi_Click(object sender, EventArgs e)
        {
            if (flowLayoutNotifi.Visible == false)
            {
                flowLayoutNotifi.Visible = true;
                notificacion.notiVista();
                pbNotifi.BackgroundImage = Properties.Resources.notifi;
            }
            else
            {
                flowLayoutNotifi.Visible = false;
            }
        }
        private void generarNotifi()
        {
            int ancho, alto;
            ancho = (flowLayoutNotifi.Width - 18);
            alto = (80);
            int cant = 0;
            datosNotificacion = notificacion.crearNoti();
            for (int i = 0; i < datosNotificacion.Count; i++)
            {
                p = new Panel();
                title = new Label();
                costo = new Label();

                cant++;

                p.TabIndex = i;
                p.Margin = new Padding(0, 0, 0, 22);
                p.Size = new Size(ancho, alto);

                p.BackgroundImage = Properties.Resources.conten;
                p.BackgroundImageLayout = ImageLayout.Stretch;

                title.Text = datosNotificacion[i].NotiNombre;
                title.Font = new System.Drawing.Font("Montserrat SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.ForeColor = Color.White;
                title.TabIndex = i;

                costo.Text = datosNotificacion[i].NotiDescripcion;
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costo.TabIndex = i;
                costo.ForeColor = Color.White;
                costo.AutoSize = false;
                costo.Size = new Size(flowLayoutNotifi.Width - 36, 40);

                title.Location = new Point(8, 5);
                costo.Location = new Point(8, 30);

                p.Controls.Add(title);
                p.Controls.Add(costo);

                flowLayoutNotifi.Controls.Add(p);
                if (datosNotificacion[i].NotiVista == 0)
                {
                    pbNotifi.BackgroundImage = Properties.Resources.notifiActi;
                }
                else
                {
                    pbNotifi.BackgroundImage = Properties.Resources.notifi;
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            datosProducto = producto.buscarProducto(txtBuscar.Text);
            panelCentral.Controls.Clear();
            flowLayoutPanel1.Controls.Clear();
            panelCentral.Controls.Add(flowLayoutPanel1);
            generarBloques();
        }
        private void generarBloques()
        {
            int ancho, alto;
            ancho = (197);
            alto = (260);

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

                flowLayoutPanel1.Controls.Add(p);
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

        private void lblUser_Click(object sender, EventArgs e)
        {
            vtnPerfil aux = new vtnPerfil
            {
                contrato = this
            };
            abrirFormHija(aux);
        }
    }
}
