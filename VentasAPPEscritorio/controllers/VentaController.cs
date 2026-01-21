using System;
using System.Collections.Generic;
using System.Linq;
using VentasAPPEscritorio.models.DAO;
using VentasAPPEscritorio.models;

namespace VentasAPPEscritorio.controllers
{
    internal class VentaController
    {
        public readonly VentaDAO ventaDAO = new VentaDAO();

        public int ConfirmarVenta(int vendedorId, List<VentaDetalle> carrito)
        {
            if (carrito == null || carrito.Count == 0)
                throw new Exception("No hay carros en el carrito.");

            decimal subtotal = carrito.Sum(x => x.Subtotal);

            decimal iva = Math.Round(subtotal * 0.19m, 2);     // 19%
            decimal total = subtotal + iva;

            var venta = new Venta
            {
                VendedorId = vendedorId,
                FechaVenta = DateTime.Now,
                TotalVenta = total,   // TOTAL con IVA
                Iva = iva             // valor IVA (no 0.19)
            };

            return ventaDAO.GuardarVentaConDetalles(venta, carrito);
        }
    }
}
