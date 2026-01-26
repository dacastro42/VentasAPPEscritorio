using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasAPPEscritorio.models;

namespace VentasAPPEscritorio.controllers
{
    public class ReportesController
    {
        private readonly ConnectionBD db = new ConnectionBD();
        public DataTable CarroMasVendido()
        {
            // Ajusta nombre de tabla detalle si es diferente
            string sql = @"
                SELECT 
                    c.idC AS CarroId,
                    CONCAT(c.Marca, ' ', c.Modelo, ' ', c.Anio) AS Carro,
                    SUM(vd.Cantidad) AS UnidadesVendidas,
                    SUM(vd.Subtotal) AS TotalVendido
                FROM venta_detalles vd
                INNER JOIN carros c ON c.IdC = vd.carro_id
                GROUP BY c.IdC, c.marca, c.modelo, c.anio
                ORDER BY UnidadesVendidas DESC
                LIMIT 1;
            ";

            return db.ExecuteSelect(sql);
        }

        public DataTable VendedorTop()
        {
            string sql = @"
                SELECT 
                    v.IdV AS VendedorId,
                    CONCAT(v.nombre1V, ' ', v.apellido1V) AS Vendedor,
                    COUNT(ve.idVentas) AS CantidadVentas,
                    SUM(ve.totalVenta) AS TotalVendido
                FROM ventas ve
                INNER JOIN vendedores v ON v.IdV = ve.vendedor_id
                GROUP BY v.IdV, v.nombre1V, v.apellido1V
                ORDER BY TotalVendido DESC
                LIMIT 1;
            ";

            return db.ExecuteSelect(sql);
        }
    }
}
