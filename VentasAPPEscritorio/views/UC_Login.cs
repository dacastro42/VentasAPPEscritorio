using Microsoft.VisualBasic.ApplicationServices;
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
            var user = vendedorController.Login(txtMail.Text, txtPass.Text);

            if (user == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                return;
            }

            //var menu = new Menu(user);
            //menu.Show();
            //this.Hide();
            if (user.Rol.Equals("ADMIN"))
            {
                var menuAdmin = new MenuAdmin(user);
                menuAdmin.Show();
            }
            else
            {
                var menuVendedor = new Menu(user);
                menuVendedor.Show();
            }

            this.Hide();
        }
    }
}
