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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            FormAlmacen formAlmacen = new FormAlmacen();
            formAlmacen.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.Show();
            this.Hide();
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
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
