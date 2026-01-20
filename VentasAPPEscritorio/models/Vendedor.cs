using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasAPPEscritorio.models
{
    public class Vendedor
    {
        // Identificador único (Primary Key)
        public int IdV { get; set; }

        // Nombres
        public string Nombre1V { get; set; }
        public string Nombre2V { get; set; }

        // Apellidos
        public string Apellido1V { get; set; }
        public string Apellido2V { get; set; }

        // Datos de contacto
        public string EmailV { get; set; }
        public string TelefonoV { get; set; }

        // Seguridad y Acceso
        public string PasswordV { get; set; }
        public string Rol { get; set; }

        // Metadatos
        public DateTime FechaRegistro { get; set; }

        // Propiedad calculada (Opcional, muy útil para mostrar en la UI)
        public string NombreCompleto => $"{Nombre1V} {Apellido1V}";
    }
}
