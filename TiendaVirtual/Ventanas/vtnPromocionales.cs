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
    public partial class vtnPromocionales : Form
    {
        private string FotoLocation;
        private MemoryStream ms = new MemoryStream();
        private Panel p = new Panel();
        private clsPromocional promocional = new clsPromocional();
        private List<clsPromocional> promocionales = new List<clsPromocional>();
        public vtnPromocionales()
        {
            InitializeComponent();
            misPromocionales();
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

        private void pbSubirFoto_Click(object sender, EventArgs e)
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
            int resultado = 0;
            byte[] MaqFoto = null;
            if (FotoLocation != null)
            {
                FileStream fileStream = new FileStream(FotoLocation, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fileStream);
                MaqFoto = new byte[fileStream.Length];
                MaqFoto = reader.ReadBytes((int)MaqFoto.Length);
            }
            try
            {
                if (MaqFoto != null | txtNombre.Text != "")
                {
                    resultado = promocional.crearPromocional(txtNombre.Text, MaqFoto);
                    misPromocionales();
                }
                else
                {
                    MessageBox.Show("Suba una imagen o hay un espacio vacio", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (resultado > 0)
            {
                MessageBox.Show("Promocional Creado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error! Promocional NO Creado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void misPromocionales()
        {
            flowLayoutProm.Controls.Clear();
            promocionales = promocional.tusPromocionales();
            int ancho, alto;
            ancho = (350);
            alto = (140);

            for (int i = 0; i < promocionales.Count; i++)
            {
                p = new Panel();

                p.TabIndex = i;
                p.Margin = new Padding(0, 25, 25, 0);
                p.Size = new Size(ancho, alto);
                ms = new MemoryStream(promocionales[i].PromFoto);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Zoom;
                p.BackColor = Color.Black;

                flowLayoutProm.Controls.Add(p);
            }
        }
    }
}
