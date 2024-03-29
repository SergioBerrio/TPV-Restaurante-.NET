﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV
{
    public partial class FormUsuario : Form
    {
        private String nombre;

        public FormUsuario(String nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }

        private void btnConsumirProductos_Click(object sender, EventArgs e)
        {
            FormConsumirProductos formConsumirRpoductos = new FormConsumirProductos();
            formConsumirRpoductos.Show();
            this.Hide();
        }

        private void btnHacerReservas_Click(object sender, EventArgs e)
        {
            FormHacerReservas formHacerReservas = new FormHacerReservas(nombre);
            formHacerReservas.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has cerrado sesión", "Cerrar sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void cerrarAplicacion(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
