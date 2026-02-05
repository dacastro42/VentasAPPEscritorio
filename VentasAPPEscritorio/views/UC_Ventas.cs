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
    public partial class UC_Ventas : Form
    {
        private readonly CarroController carroController = new CarroController();


        private readonly BindingSource bsCarrito = new BindingSource();
        private readonly List<VentaDetalle> carrito = new List<VentaDetalle>();

        private readonly VentaController ventaController = new VentaController();

        private int idVendedorLlega = 1; //es el id del vendedor, por ahora quemado. 
        public UC_Ventas(Vendedor vendedor)
        {
            InitializeComponent();
            this.Load += UC_Ventas_Load;
            idVendedorLlega = vendedor.IdV;
            //btnAgregar.Click += btnAgregar_Click;
            //btnQuitar.Click += btnQuitar_Click;
            //btnConfirmarVenta.Click += btnConfirmarVenta_Click;
        }
        private void UC_Ventas_Load(object sender, EventArgs e)
        {
            ConfigurarGrids();
            InicializarCarritoGrid();
            CargarCarros();
            RecalcularTotales();

            var ctrl = this.Controls.Find("nudCantidad", true).FirstOrDefault();
            if (ctrl is NumericUpDown nud)
            {
                nud.Minimum = 1;
                nud.Value = 1;
            }
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

        private void LoadV(object sender, EventArgs e)
        {
            //ConfigurarGrids();
            //InicializarCarritoGrid();
            //CargarCarros();
            //RecalcularTotales();
        }

        private void ConfigurarGrids()
        {
            // Carros disponibles
            dgvCarros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarros.MultiSelect = false;
            dgvCarros.ReadOnly = true;
            dgvCarros.AllowUserToAddRows = false;
            dgvCarros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Carrito
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.MultiSelect = false;
            dgvCarrito.ReadOnly = true;
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void InicializarCarritoGrid()
        {
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.Columns.Clear();

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Carro",
                HeaderText = "Carro",
                ReadOnly = true
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cant.",
                ReadOnly = true
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecioUnitario",
                HeaderText = "Precio",
                ReadOnly = true
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                ReadOnly = true
            });

            bsCarrito.DataSource = carrito;
            dgvCarrito.DataSource = bsCarrito;

            dgvCarrito.CellFormatting += dgvCarrito_CellFormatting;
        }
        private void dgvCarrito_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCarrito.Columns[e.ColumnIndex].Name == "Carro")
            {
                var item = dgvCarrito.Rows[e.RowIndex].DataBoundItem as VentaDetalle;
                if (item?.Carro != null)
                {
                    e.Value = $"{item.Carro.Marca} {item.Carro.Modelo} {item.Carro.Anio}";
                    e.FormattingApplied = true;
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvCarros.CurrentRow == null) return;

            int carroId = Convert.ToInt32(dgvCarros.CurrentRow.Cells["IdC"].Value);
            string marca = dgvCarros.CurrentRow.Cells["Marca"].Value.ToString();
            string modelo = dgvCarros.CurrentRow.Cells["Modelo"].Value.ToString();
            int anio = Convert.ToInt32(dgvCarros.CurrentRow.Cells["Anio"].Value);
            decimal precio = Convert.ToDecimal(dgvCarros.CurrentRow.Cells["PrecioC"].Value);

            // Cantidad: si tienes nudCantidad, úsalo. Si no, queda 1.
            int cantidad = 1;
            if (this.Controls.Find("nudCantidad", true).FirstOrDefault() is NumericUpDown nud)
            {
                cantidad = (int)nud.Value;
                if (cantidad <= 0) cantidad = 1;
            }

            // Buscar si ya existe ese carro en el carrito
            var existente = carrito.FirstOrDefault(x => x.CarroId == carroId);

            if (existente != null)
            {
                existente.Cantidad += cantidad;
                existente.Subtotal = existente.Cantidad * existente.PrecioUnitario;
            }
            else
            {
                carrito.Add(new VentaDetalle
                {
                    CarroId = carroId,
                    Cantidad = cantidad,
                    PrecioUnitario = precio,
                    Subtotal = cantidad * precio,

                    // Propiedad de navegación (opcional pero útil en memoria)
                    Carro = new Carro
                    {
                        IdC = carroId,
                        Marca = marca,
                        Modelo = modelo,
                        Anio = anio,
                        PrecioC = precio
                    }
                });
            }

            bsCarrito.ResetBindings(false);
            //AjustarColumnasCarrito();
            RecalcularTotales();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow?.DataBoundItem is VentaDetalle item)
            {
                carrito.Remove(item);
                bsCarrito.ResetBindings(false);
                RecalcularTotales();
            }
        }

        private void AjustarColumnasCarrito()
        {
            if (dgvCarrito.Columns["IdVentaDetalle"] != null) dgvCarrito.Columns["IdVentaDetalle"].Visible = false;
            if (dgvCarrito.Columns["VentaId"] != null) dgvCarrito.Columns["VentaId"].Visible = false;

            // Mostrar / renombrar
            if (dgvCarrito.Columns["CarroId"] != null) dgvCarrito.Columns["CarroId"].HeaderText = "ID Carro";
            if (dgvCarrito.Columns["Cantidad"] != null) dgvCarrito.Columns["Cantidad"].HeaderText = "Cant.";
            if (dgvCarrito.Columns["PrecioUnitario"] != null) dgvCarrito.Columns["PrecioUnitario"].HeaderText = "Precio";
            if (dgvCarrito.Columns["Subtotal"] != null) dgvCarrito.Columns["Subtotal"].HeaderText = "Subtotal";

            // Carro (navegación) normalmente NO se muestra en el grid
            if (dgvCarrito.Columns["Carro"] != null) dgvCarrito.Columns["Carro"].Visible = false;
        }

        private void RecalcularTotales()
        {
            decimal subtotal = carrito.Sum(x => x.Subtotal);
            decimal iva = Math.Round(subtotal * 0.19m, 2);
            decimal total = subtotal + iva;

            // Si tus labels se llaman distinto, ajusta
            lblSubtotal.Text = subtotal.ToString("C0");
            lblTotal.Text = total.ToString("C0");
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (carrito.Count == 0)
                {
                    MessageBox.Show("No hay carros agregados para vender.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int ventaId = ventaController.ConfirmarVenta(idVendedorLlega, carrito);

                MessageBox.Show($" Venta confirmada. ID Venta: {ventaId}", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar UI / carrito
                carrito.Clear();
                bsCarrito.ResetBindings(false);
                RecalcularTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al confirmar venta:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCarros_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvCarros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int carroId = Convert.ToInt32(dgvCarros.Rows[e.RowIndex].Cells["IdC"].Value);

            string nombreCarro = "";
            if (dgvCarros.Columns.Contains("Marca") && dgvCarros.Columns.Contains("Modelo") && dgvCarros.Columns.Contains("Anio"))
            {
                var row = dgvCarros.Rows[e.RowIndex];
                nombreCarro = $"{row.Cells["Marca"].Value} {row.Cells["Modelo"].Value} {row.Cells["Anio"].Value}";
            }
            Console.Write("datos sonnn :  " + carroId + " " + nombreCarro);
            //Console.WriteLine("datos sonnn :  " + carroId +" "+ nombreCarro);// Console.WriteLine("la ruta es :  " + rutaCompleta);
            var frm = new FrmCarroMultimedia(carroId, nombreCarro);
            frm.ShowDialog(); // modal, no rompe flujo de ventas
        }
    }
}
