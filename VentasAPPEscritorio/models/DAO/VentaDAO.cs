using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using VentasAPPEscritorio.models;

namespace VentasAPPEscritorio.models.DAO
{
    public class VentaDAO
    {
        private readonly ConnectionBD db = new ConnectionBD();

        public int GuardarVentaConDetalles(Venta venta, List<VentaDetalle> detalles)
        {
            if (venta == null) throw new ArgumentNullException(nameof(venta));
            if (detalles == null || detalles.Count == 0) throw new Exception("No hay detalles para guardar.");

            using (MySqlConnection conn = db.DataSource())
            {
                conn.Open();
                using (var tx = conn.BeginTransaction())
                {
                    try
                    {
                        // 1) Insert Venta (cabecera)
                        string sqlVenta = @"
                            INSERT INTO ventas (vendedor_id, fechaVenta, totalVenta, iva)
                            VALUES (@vendedorId, @fechaVenta, @totalVenta, @iva);
                        ";

                        using (var cmdVenta = new MySqlCommand(sqlVenta, conn, tx))
                        {
                            cmdVenta.Parameters.AddWithValue("@vendedorId", venta.VendedorId);
                            cmdVenta.Parameters.AddWithValue("@fechaVenta", venta.FechaVenta);
                            cmdVenta.Parameters.AddWithValue("@totalVenta", venta.TotalVenta);
                            cmdVenta.Parameters.AddWithValue("@iva", venta.Iva);

                            cmdVenta.ExecuteNonQuery();

                            // MySQL: Id autoincrement recién insertado
                            int ventaId = (int)cmdVenta.LastInsertedId;

                            // 2) Insert Detalles
                            string sqlDetalle = @"
                                INSERT INTO venta_detalles (venta_id, carro_id, cantidad, precio_unitario, subtotal)
                                VALUES (@ventaId, @carroId, @cantidad, @precioUnitario, @subtotal);
                            ";

                            foreach (var d in detalles)
                            {
                                using (var cmdDet = new MySqlCommand(sqlDetalle, conn, tx))
                                {
                                    cmdDet.Parameters.AddWithValue("@ventaId", ventaId);
                                    cmdDet.Parameters.AddWithValue("@carroId", d.CarroId);
                                    cmdDet.Parameters.AddWithValue("@cantidad", d.Cantidad);
                                    cmdDet.Parameters.AddWithValue("@precioUnitario", d.PrecioUnitario);
                                    cmdDet.Parameters.AddWithValue("@subtotal", d.Subtotal);
                                    cmdDet.ExecuteNonQuery();
                                }
                            }

                            tx.Commit();
                            return ventaId;
                        }
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
