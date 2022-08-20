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
    public partial class vtnVentas : Form
    {
        private string FotoLocation;
        private clsProducto producto = new clsProducto();
        public vtnVentas()
        {
            InitializeComponent();
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
            if (txtDescrip.Text == "Descripcion (Max. 100)")
            {
                txtDescrip.Text = "";
            }
        }

        private void txtDescrip_Leave(object sender, EventArgs e)
        {
            if (txtDescrip.Text == "")
            {
                txtDescrip.Text = "Descripcion (Max. 100)";
            }
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FotoLocation = ofd.FileName.ToString();
                    pbFoto.ImageLocation = FotoLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato DE archivo incorrecto", ex.Message);
            }
        }

        private void pbPublicar_Click(object sender, EventArgs e)
        {
            byte[] MaqFoto = null;
            if (FotoLocation !=null)
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
            }
            else
            {
                MessageBox.Show("Error! Producto NO Creado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
