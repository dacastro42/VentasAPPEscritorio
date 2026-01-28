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

        public DataTable TotalMes(int mes, int anio)
        {
            string sql = $@"
                SELECT
                    {anio} AS Anio,
                    {mes} AS Mes,
                    COUNT(v.idVentas) AS CantidadVentas,
                    SUM(v.iva) AS IvaMes,
                    SUM(v.totalVenta) AS TotalMes,
                    (SUM(v.totalVenta) - SUM(v.iva)) AS SubtotalMes
                FROM ventas v
                WHERE YEAR(v.fechaVenta) = {anio}
                  AND MONTH(v.fechaVenta) = {mes};
            ";

            return db.ExecuteSelect(sql);
        }

        internal DataTable VentasPorVendedor(int vendedorId)
        {
            string sql = $@"
                SELECT
                    v.idVentas AS IdVenta,
                    v.fechaVenta AS Fecha,
                    (v.totalVenta - v.iva) AS Subtotal,
                    v.iva AS Iva,
                    v.totalVenta AS Total
                FROM ventas v
                WHERE v.vendedor_id = {vendedorId}
                ORDER BY v.fechaVenta DESC;
            ";

            return db.ExecuteSelect(sql);
        }

        public DataTable VentasPorRangoFechas(DateTime desde, DateTime hasta)
        {
            string sql = $@"
                SELECT
                    COUNT(v.idVentas) AS CantidadVentas,
                    SUM(v.iva) AS IvaTotal,
                    SUM(v.totalVenta) AS TotalVendido,
                    (SUM(v.totalVenta) - SUM(v.iva)) AS Subtotal
                FROM ventas v
                WHERE v.fechaVenta BETWEEN 
                      '{desde:yyyy-MM-dd}' AND '{hasta:yyyy-MM-dd}';
            ";

            return db.ExecuteSelect(sql);
        }


    }
}
