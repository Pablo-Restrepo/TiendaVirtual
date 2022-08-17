using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaVirtual.Logica;
using TiendaVirtual.Ventanas;

namespace TiendaVirtual
{
    public partial class Form1 : Form, Interface1
    {
        private Boolean bandera = true;
        private Boolean bandera2 = true;
        private Form fH;
        public Form1()
        {
            InitializeComponent();
            vtnInicio aux = new vtnInicio();
            aux.contrato = this;
            abrirFormHija(aux);
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
            vtnInicio aux = new vtnInicio();
            aux.contrato = this;
            abrirFormHija(aux);
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {
            vtnInicio aux = new vtnInicio();
            aux.contrato = this;
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
    }
}
