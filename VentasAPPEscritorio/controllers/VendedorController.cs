using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasAPPEscritorio.models;
using VentasAPPEscritorio.models.DAO;

namespace VentasAPPEscritorio.controllers
{
    public class VendedorController
    {
        // Método para guardar el vendedor
        private ConnectionBD conexion = new ConnectionBD();
        private readonly VendedorDAO dao = new VendedorDAO();
        public bool GuardarVendedor(Vendedor v)
        {

            // Nota: Usamos las propiedades del modelo Vendedor
            string sql = "INSERT INTO vendedores (nombre1V, nombre2V, apellido1V, apellido2V, emailV, telefonoV, passwordV, rol, fecha_registro) " +
                         "VALUES (" +
                         $"'{v.Nombre1V}', " +
                         $"'{v.Nombre2V}', " +
                         $"'{v.Apellido1V}', " +
                         $"'{v.Apellido2V}', " +
                         $"'{v.EmailV}', " +
                         $"'{v.TelefonoV}', " +
                         $"'{v.PasswordV}', " +
                         $"'{v.Rol}', " +
                         $"'{v.FechaRegistro:yyyy-MM-dd HH:mm:ss}')";

            // Ejecuta la consulta a través de tu clase ConnectionBD
            return conexion.ExecuteQuery(sql);
        }
        public Vendedor Login(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                return null;

            return dao.Login(user.Trim(), pass.Trim());
        }

        public DataTable ListarVendedores()
        {
            string sql = @"
        SELECT 
            IdV,
            CONCAT(nombre1V, ' ', apellido1V) AS Vendedor,
            emailV,
            rol
        FROM vendedores
        ORDER BY nombre1V, apellido1V;
    ";

            return conexion.ExecuteSelect(sql);
        }
    }
}
