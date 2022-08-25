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
    public partial class vtnPerfil : Form
    {
        private string FotoLocation;
        private MemoryStream ms = new MemoryStream();
        private clsUsuario userinfo = new clsUsuario();
        public IForm contrato { get; set; }
        public vtnPerfil()
        {
            InitializeComponent();
            datos();
        }
        public void datos()
        {
            userinfo = userinfo.consultarDatosUser();
            lblUser.Text = "Usuario: " + userinfo.UsuUsername;
            lblNombre.Text = "Nombre: " + userinfo.UsuNombre;
            lblFechaNac.Text = "Fecha Nacimiento: " + userinfo.UsuFechaNac;
            if (userinfo.UsuFoto != null)
            {
                ms = new MemoryStream(userinfo.UsuFoto);
                pbFotoPerfil.BackgroundImage = Image.FromStream(ms);
            }
        }

        private void pbSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FotoLocation = ofd.FileName.ToString();
                    pbFotoPerfil.BackgroundImage = Image.FromFile(FotoLocation);
                    byte[] imagen = File.ReadAllBytes(FotoLocation);
                    userinfo.cambiarFoto(imagen);
                    Cache.PerFoto = imagen;
                    contrato.actualizar();
                    MessageBox.Show("Foto Cambiada!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato de archivo incorrecto", ex.Message);
            }
        }

        private void txtContraActual_Click(object sender, EventArgs e)
        {
            if (txtContraActual.Text == "Contraseña Actual")
            {
                txtContraActual.Text = "";
                txtContraActual.PasswordChar = '*';
            }
        }

        private void txtContraActual_Leave(object sender, EventArgs e)
        {
            if (txtContraActual.Text == "")
            {
                txtContraActual.PasswordChar = '\0';
                txtContraActual.Text = "Contraseña Actual";
            }
        }

        private void txtNuevaContra_Click(object sender, EventArgs e)
        {
            if (txtNuevaContra.Text == "Nueva Contraseña")
            {
                txtNuevaContra.Text = "";
                txtNuevaContra.PasswordChar = '*';
            }
        }

        private void txtNuevaContra_Leave(object sender, EventArgs e)
        {
            if (txtNuevaContra.Text == "")
            {
                txtNuevaContra.PasswordChar = '\0';
                txtNuevaContra.Text = "Nueva Contraseña";
            }
        }

        private void txtRecContra_Click(object sender, EventArgs e)
        {
            if (txtRecContra.Text == "Rectificar Contraseña")
            {
                txtRecContra.Text = "";
                txtRecContra.PasswordChar = '*';
            }
        }

        private void txtRecContra_Leave(object sender, EventArgs e)
        {
            if (txtRecContra.Text == "")
            {
                txtRecContra.PasswordChar = '\0';
                txtRecContra.Text = "Rectificar Contraseña";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNuevaContra.Text == txtRecContra.Text)
            {
                if (userinfo.confirmarContrasenia(txtContraActual.Text))
                {
                    userinfo.cambiarContrasenia(txtNuevaContra.Text);
                    MessageBox.Show("Contraseña cambiada!");
                }
                else
                {
                    MessageBox.Show("La contraseña actual es incorrecta. Rectificar");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales. Rectificar");
            }
        }

        private void lblEditarNomb_Click(object sender, EventArgs e)
        {
            txtNombre.Visible = true;
            pictureBox3.Visible = true;
            btnCambiarNombre.Visible = true;
            lblNombre.Visible = false;
            lblEditarNomb.Visible = false;
        }

        private void btnCambiarNombre_Click(object sender, EventArgs e)
        {
            userinfo.cambiarNombre(txtNombre.Text);
            MessageBox.Show("Nombre Cambiado!");
            lblNombre.Text = "Nombre: " + txtNombre.Text;
            txtNombre.Visible = false;
            pictureBox3.Visible = false;
            btnCambiarNombre.Visible = false;
            lblNombre.Visible = true;
            lblEditarNomb.Visible = true;
        }

        private void lblEditarFecha_Click(object sender, EventArgs e)
        {
            dtFecha.Visible = true;
            pictureBox4.Visible = true;
            btnCambiarFecha.Visible = true;
            lblFechaNac.Visible = false;
            lblEditarFecha.Visible = false;
        }

        private void btnCambiarFecha_Click(object sender, EventArgs e)
        {
            userinfo.cambiarFechaNaci(dtFecha.Text);
            MessageBox.Show("Fecha Cambiada!");
            lblFechaNac.Text = "Fecha Nacimiento: " + dtFecha.Text;
            pictureBox4.Visible = false;
            dtFecha.Visible = false;
            btnCambiarFecha.Visible = false;
            lblFechaNac.Visible = true;
            lblEditarFecha.Visible = true;
        }
    }
}
