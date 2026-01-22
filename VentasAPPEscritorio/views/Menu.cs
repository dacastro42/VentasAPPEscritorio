using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasAPPEscritorio.models;

namespace VentasAPPEscritorio.views
{
    public partial class Menu : Form
    {
        private Vendedor _vendedor;
        public Menu(Vendedor vendedor)
        {
            InitializeComponent();
            _vendedor= vendedor;
            lblBienvenida.Text = $"Hola, {_vendedor.Nombre1V} {_vendedor.Apellido1V}";
        }

        private void VentaBtn_Click(object sender, EventArgs e)
        {
            var frmVentas = new UC_Ventas(_vendedor);
            frmVentas.Show();
            //this.Hide();
        }
    }
}
