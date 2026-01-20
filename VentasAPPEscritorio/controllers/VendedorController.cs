using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasAPPEscritorio.models;

namespace VentasAPPEscritorio.controllers
{
    public class VendedorController
    {
        // Método para guardar el vendedor
        private ConnectionBD conexion = new ConnectionBD();

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
    }
}
