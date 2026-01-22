using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using VentasAPPEscritorio.models;

namespace VentasAPPEscritorio.models.DAO
{
    public class VendedorDAO
    {
        private readonly ConnectionBD db = new ConnectionBD();
       
        public Vendedor Login(string mail, string clave)
        {
            // AJUSTA nombres reales: tabla y columnas (mail/clave)
            string sql = @"
                SELECT IdV, nombre1V, apellido1V, emailV, passwordV
                FROM vendedores
                WHERE emailV = @mail  AND passwordV = @clave
                LIMIT 1;
            ";

            using (var conn = db.DataSource())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@clave", clave);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read()) return null;

                        return new Vendedor
                        {
                            IdV = dr.GetInt32("IdV"),
                            Nombre1V = dr.GetString("nombre1V"),
                            Apellido1V = dr.GetString("apellido1V"),
                            EmailV = dr.GetString("emailV"),
                            PasswordV = dr.GetString("passwordV")
                        };
                    }
                }
            }
        }
    }
}
