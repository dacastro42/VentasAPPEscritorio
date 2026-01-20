using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasAPPEscritorio.models
{
    public class VentaDetalle
    {
        // Identificador único del renglón (Primary Key)
        public int IdVentaDetalle { get; set; }

        // Relación con la cabecera de la venta (Foreign Key)
        public int VentaId { get; set; }

        // Relación con el vehículo vendido (Foreign Key)
        public int CarroId { get; set; }

        // Cantidad de unidades
        public int Cantidad { get; set; }

        // Precios con decimal para evitar errores contables
        public decimal PrecioUnitario { get; set; }

        // El subtotal suele ser (PrecioUnitario * Cantidad)
        public decimal Subtotal { get; set; }

        // --- Propiedades de Navegación ---
        // Esto te permite saber qué carro se vendió en este renglón sin buscar otra vez
        public Carro Carro { get; set; }
    }
}
