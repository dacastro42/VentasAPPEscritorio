using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasAPPEscritorio.controllers;

namespace VentasAPPEscritorio.views
{
    public partial class UC_Login : Form
    {

        private readonly VendedorController vendedorController = new VendedorController();

        public UC_Login()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var vendedor = vendedorController.Login(txtMail.Text, txtPass.Text);

            if (vendedor == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                return;
            }

            var menu = new Menu(vendedor);
            menu.Show();
            this.Hide();
        }
    }
}
