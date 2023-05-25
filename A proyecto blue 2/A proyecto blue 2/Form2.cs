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

namespace A_proyecto_blue_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) 
        {
            TextWriter RegistrarUsario = new StreamWriter(@"C:\Users\soned\Videos\programas VS\A proyecto blue 2\A proyecto blue 2\bin\Debug\" + txtUsuarioRegister.Text + ".txt", true);
            RegistrarUsario.WriteLine(txtContraseñaRegister.Text);
            RegistrarUsario.Close();
            MessageBox.Show("Cuenta Creada.");
            txtUsuarioRegister.Clear();
            txtContraseñaRegister.Clear();
            this.Hide();
            Form Tres = new Form3();
            Tres.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Dos = new Form1();
            Dos.Show();
        }

        private void txtUsuarioRegister_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioRegister.Text == " Usuario Nuevo")
            {
                txtUsuarioRegister.Text = "";
            }
        }

        private void txtUsuarioRegister_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioRegister.Text == "")
            {
                txtUsuarioRegister.Text = " Usuario Nuevo";
            }
        }

        private void txtContraseñaRegister_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaRegister.Text == " Contraseña Nueva")
            {
                txtContraseñaRegister.Text = "";
            }
            txtContraseñaRegister.UseSystemPasswordChar = true;
        }

        private void txtContraseñaRegister_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaRegister.Text == "")
            {
                txtContraseñaRegister.Text = " Contraseña Nueva";
            }
            txtContraseñaRegister.UseSystemPasswordChar = false;
        }
    }
}
