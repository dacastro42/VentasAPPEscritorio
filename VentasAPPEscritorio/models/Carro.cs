using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasAPPEscritorio.models
{
    public class Carro
    {
        // Identificador único (Primary Key)
        public int IdC { get; set; }

        // Detalles del vehículo
        public string Marca { get; set; }
        public string Modelo { get; set; }

        // El tipo INT en DB se mapea a int en C#
        public int Anio { get; set; }

        // El tipo DECIMAL(12,2) se mapea siempre a decimal en C# 
        // para evitar errores de redondeo en dinero
        public decimal PrecioC { get; set; }

        // Propiedad calculada para mostrar en listados o facturas
        public string InformacionVehiculo => $"{Marca} {Modelo} ({Anio})";
    }

}
