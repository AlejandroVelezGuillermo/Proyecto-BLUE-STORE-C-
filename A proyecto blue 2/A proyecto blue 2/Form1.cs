﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_proyecto_blue_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Uno = new Form2();
            Uno.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Tres = new Form3();
            Tres.Show();
        }
    }
}
