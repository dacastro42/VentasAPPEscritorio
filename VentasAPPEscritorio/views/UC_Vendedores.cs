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
using VentasAPPEscritorio.models;

namespace VentasAPPEscritorio.views
{
    public partial class UC_Vendedores : Form
    {
        private VendedorController _controller;
        public UC_Vendedores()
        {
            InitializeComponent();
            _controller = new VendedorController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mapeamos los datos de los TextBox al Modelo
            var vendedor = new Vendedor
            {
                Nombre1V = txtNombre1.Text,
                Nombre2V = txtNombre2.Text,
                Apellido1V = txtApellido1.Text,
                Apellido2V = txtApellido2.Text,
                EmailV = txtEmail.Text,
                TelefonoV = txtTelefono.Text,
                PasswordV = txtPassword.Text,
                Rol = "VENDEDOR",
                FechaRegistro = System.DateTime.Now
            };
            // Llamamos al controlador
            if (_controller.GuardarVendedor(vendedor))
            {
                LimpiarCampos();
                MessageBox.Show("Se realiza el insert");
            }
            else
            {
                MessageBox.Show("no se realiza el insert");
            }
        }
        private void LimpiarCampos()
        {
            txtNombre1.Clear(); txtNombre2.Clear();
            txtApellido1.Clear(); txtApellido2.Clear();
            txtEmail.Clear(); txtTelefono.Clear(); txtPassword.Clear();
        }
    }
}
