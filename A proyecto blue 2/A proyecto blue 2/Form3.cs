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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnINgresarLogin_Click(object sender, EventArgs e)
        {
            TextReader mundo = new StreamReader(txtUsuarioRegister.Text + ".txt");

            if (mundo.ReadLine() == txtContraseñaRegister.Text)
            {
                MessageBox.Show("Se Encontro Su Cuneta.");
                this.Hide();
                Form xdd = new Caja();
                xdd.Show();
            }
            else
            {
                MessageBox.Show("no encontro");
            }
        }

        private void txtUsuarioRegister_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioRegister.Text == " Usuario")
            {
                txtUsuarioRegister.Text = "";
            }
        }

        private void txtUsuarioRegister_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioRegister.Text == "")
            {
                txtUsuarioRegister.Text = " Usuario";
            }
        }

        private void txtContraseñaRegister_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaRegister.Text == " Contraseña")
            {
                txtContraseñaRegister.Text = "";
            }
            txtContraseñaRegister.UseSystemPasswordChar = true;
        }

        private void txtContraseñaRegister_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaRegister.Text == "")
            {
                txtContraseñaRegister.Text = " Contraseña";
            }
            txtContraseñaRegister.UseSystemPasswordChar = false;
        }

        private void btnAtrasLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Dos = new Form1();
            Dos.Show();
        }
    }
}
