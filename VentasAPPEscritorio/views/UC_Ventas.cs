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
    public partial class UC_Ventas : Form
    {
        private readonly CarroController carroController = new CarroController();

        public UC_Ventas()
        {
            InitializeComponent();
            this.Load += UC_Ventas_Load;
        }
        private void UC_Ventas_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarCarros();
        }
        private void ConfigurarGrid()
        {
            dgvCarros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarros.MultiSelect = false;
            dgvCarros.ReadOnly = true;
            dgvCarros.AllowUserToAddRows = false;
            dgvCarros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarCarros()
        {
            var dt = carroController.ListarCarros();
            dgvCarros.DataSource = dt;

            // Mejorar visual
            if (dgvCarros.Columns["IdC"] != null) dgvCarros.Columns["IdC"].Visible = false;
            if (dgvCarros.Columns["Anio"] != null) dgvCarros.Columns["Anio"].HeaderText = "Año";
            if (dgvCarros.Columns["PrecioC"] != null) dgvCarros.Columns["PrecioC"].HeaderText = "Precio";
        }
    }
}
