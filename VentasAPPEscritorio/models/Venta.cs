using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasAPPEscritorio.models
{
    public class Venta
    {
        // Identificador único de la factura (Primary Key)
        public int IdVentas { get; set; }

        // Relación con el Vendedor (Foreign Key)
        public int VendedorId { get; set; }

        // Fecha y hora de la transacción
        public DateTime FechaVenta { get; set; }

        // Montos financieros (usamos decimal por precisión)
        public decimal TotalVenta { get; set; }
        public decimal Iva { get; set; }

        // --- Propiedades de Navegación (Opcionales pero recomendadas) ---

        // Esto permite acceder a los datos del vendedor que hizo la venta
        public Vendedor Vendedor { get; set; }

        // Esto permite acceder a la lista de carros vendidos en esta factura
        public List<VentaDetalle> Detalles { get; set; }

        public Venta()
        {
            // Inicializamos la lista para evitar errores de "referencia nula"
            Detalles = new List<VentaDetalle>();
            FechaVenta = DateTime.Now; // Por defecto, la fecha actual
        }
    }
}
