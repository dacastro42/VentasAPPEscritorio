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
    public partial class FrmReportes : Form
    {
        public FrmReportes(string titulo, DataTable data)
        {
            InitializeComponent();
            this.Text = titulo;
            lblTitulo.Text = titulo;      // si tienes un label
            dgvReporte.DataSource = data; // si tienes un DataGridView
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ExportadorExcel.ExportarDataGridView(dgvReporte);
        }
    }
}
