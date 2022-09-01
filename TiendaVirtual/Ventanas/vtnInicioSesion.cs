using AppGestionConsorcio.datos;
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
    public partial class vtnInicioSesion : Form
    {
        private clsUsuario usuario = new clsUsuario();
        public vtnInicioSesion()
        {
            InitializeComponent();
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Usuario")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Usuario";
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Contraseña")
            {
                textBox1.Text = "";
                textBox1.PasswordChar = '*';
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.PasswordChar = '\0';
                textBox1.Text = "Contraseña";
            }
        }

        private void lnlInfo2_Click(object sender, EventArgs e)
        {
            txtUsuario.Visible = true;
            txtNombreR.Visible = true;
            txtContraseniaR.Visible = true;
            txtRectificarContra.Visible = true;
            label2.Visible = true;
            dateTimePicker1.Visible = true;
            btnRegistrarse.Visible = true;
            lblIniciarS.Visible = true;
            pictureBox3.Visible = true;

            txtNombre.Visible = false;
            textBox1.Visible = false;
            pictureBox2.Visible = false;
            btnIniciar.Visible = false;
            btnRegistrar.Visible = false;
        }

        private void lblIniciarS_Click(object sender, EventArgs e)
        {
            txtNombre.Visible = true;
            textBox1.Visible = true;
            pictureBox2.Visible = true;
            btnIniciar.Visible = true;
            btnRegistrar.Visible = true;

            pictureBox3.Visible = false;
            txtUsuario.Visible = false;
            txtNombreR.Visible = false;
            txtContraseniaR.Visible = false;
            txtRectificarContra.Visible = false;
            label2.Visible = false;
            dateTimePicker1.Visible = false;
            btnRegistrarse.Visible = false;
            lblIniciarS.Visible = false;
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtNombreR_Click(object sender, EventArgs e)
        {
            if (txtNombreR.Text == "Nombre")
            {
                txtNombreR.Text = "";
            }
        }

        private void txtNombreR_Leave(object sender, EventArgs e)
        {
            if (txtNombreR.Text == "")
            {
                txtNombreR.Text = "Nombre";
            }
        }

        private void txtContraseniaR_Click(object sender, EventArgs e)
        {
            if (txtContraseniaR.Text == "Contraseña")
            {
                txtContraseniaR.Text = "";
                txtContraseniaR.PasswordChar = '*';
            }
        }

        private void txtContraseniaR_Leave(object sender, EventArgs e)
        {
            if (txtContraseniaR.Text == "")
            {
                txtContraseniaR.PasswordChar = '\0';
                txtContraseniaR.Text = "Contraseña";
            }
        }

        private void txtRectificarContra_Click(object sender, EventArgs e)
        {
            if (txtRectificarContra.Text == "Rectificar Contraseña")
            {
                txtRectificarContra.Text = "";
                txtRectificarContra.PasswordChar = '*';
            }
        }

        private void txtRectificarContra_Leave(object sender, EventArgs e)
        {
            if (txtRectificarContra.Text == "")
            {
                txtRectificarContra.PasswordChar = '\0';
                txtRectificarContra.Text = "Rectificar Contraseña";
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" | txtContraseniaR.Text != "" | txtRectificarContra.Text != "" | txtNombreR.Text != "" | dateTimePicker1.Text != "")
            {
                if (txtContraseniaR.Text == txtRectificarContra.Text)
                {
                    if (!usuario.usuarioYaExiste(txtUsuario.Text))
                    {
                        usuario.registrarUsuario(txtUsuario.Text, txtContraseniaR.Text, txtNombreR.Text, dateTimePicker1.Text);
                        MessageBox.Show("Registrado!", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Visible = true;
                        textBox1.Visible = true;
                        pictureBox2.Visible = true;
                        btnIniciar.Visible = true;
                        btnRegistrar.Visible = true;

                        pictureBox3.Visible = false;
                        txtUsuario.Visible = false;
                        txtNombreR.Visible = false;
                        txtContraseniaR.Visible = false;
                        txtRectificarContra.Visible = false;
                        label2.Visible = false;
                        dateTimePicker1.Visible = false;
                        btnRegistrarse.Visible = false;
                        lblIniciarS.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("El Usuario ya existe! Use otro.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas son distintas. Rectificar", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios. Rectificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            if (usuario.iniciarSesionUsuario(txtNombre.Text, textBox1.Text))
            {
                Cache.User = txtNombre.Text;
                usuario = usuario.consultarDatosUser();
                Cache.PerFoto = usuario.UsuFoto;
                Form aux = new Form1();
                this.Hide();
                aux.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos. Rectificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
