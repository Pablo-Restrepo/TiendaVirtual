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

namespace TiendaVirtual.Ventanas
{
    public partial class vtnInicio : Form
    {
        private Boolean bandera = true;
        public Interface1 contrato { get; set; }
        public vtnInicio()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            contrato.Ejecutar(new vtnProducto());
        }

        private void vtnInicio_Resize(object sender, EventArgs e)
        {
            /*if (this.Width >= 1600)
            {
                pbVenderores.Visible = true;
            }*/
            if (this.Width >= 1250 && bandera)
            {
                pbProDesc.Visible = true;
                pbPromo.Location = new Point(pbPromo.Location.X - 170, pbPromo.Location.Y);
                pbProdMasComp.Location = new Point(pbProdMasComp.Location.X - 170, pbProdMasComp.Location.Y);
                bandera = false;
                pbVenderores.Visible = false;
            }
            if (this.Width < 1250 && !bandera)
            {
                pbPromo.Location = new Point(pbPromo.Location.X + 170, pbPromo.Location.Y);
                pbProdMasComp.Location = new Point(pbProdMasComp.Location.X + 170, pbProdMasComp.Location.Y);
                pbProDesc.Visible = false;
                bandera = true;
            }
        }
    }
}
