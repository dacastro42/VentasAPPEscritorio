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
        private readonly VendedorController vendedorController = new VendedorController();
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

        private void button3_Click(object sender, EventArgs e)
        {
            int anio = monthCalendar1.SelectionStart.Year;
            int mes = monthCalendar1.SelectionStart.Month;

            var dt = reportesController.TotalMes(mes, anio);
            var frm = new FrmReportes($"Total del mes {mes}/{anio}", dt);
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvVendedores.CurrentRow == null) return;

            int vendedorId = Convert.ToInt32(dgvVendedores.CurrentRow.Cells["IdV"].Value);
            string nombre = dgvVendedores.CurrentRow.Cells["Vendedor"].Value.ToString();

            var dt = reportesController.VentasPorVendedor(vendedorId);

            var frm = new FrmReportes($"Ventas de {nombre}", dt);
            frm.ShowDialog();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            dgvVendedores.DataSource = vendedorController.ListarVendedores();
            dgvVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendedores.MultiSelect = false;
            dgvVendedores.ReadOnly = true;
            dgvVendedores.AllowUserToAddRows = false;
            dgvVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dt = reportesController.CarroMasVendido();
            var frm = new FrmReportes("Carro más vendido", dt);
            frm.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DateTime desde = monthCalendar2.SelectionStart;
            DateTime hasta = monthCalendar3.SelectionStart;

            var dt = reportesController.VentasPorRangoFechas(desde, hasta);

            var frm = new FrmReportes(
                $"Ventas desde {desde:dd/MM/yyyy} hasta {hasta:dd/MM/yyyy}",
                dt
            );

            frm.ShowDialog();
        }
    }
}
