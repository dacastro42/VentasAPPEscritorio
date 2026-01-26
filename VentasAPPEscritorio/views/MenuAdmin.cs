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
using VentasAPPEscritorio.controllers;

namespace VentasAPPEscritorio.views
{

    public partial class MenuAdmin : Form
    {
        private Vendedor _admin;
        private readonly ReportesController reportesController = new ReportesController();
        public MenuAdmin(Vendedor admin)
        {
            InitializeComponent();
            _admin = admin;
            lblBienvenida.Text = $"Admin: {_admin.Nombre1V} {_admin.Apellido1V}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = reportesController.CarroMasVendido();
            var frm = new FrmReportes("Carro más vendido", dt);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dt = reportesController.VendedorTop();
            var frm = new FrmReportes("Vendedor Top", dt);
            frm.ShowDialog();
        }
    }
}
