using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasAPPEscritorio.models;
using VentasAPPEscritorio.models.DAO;

namespace VentasAPPEscritorio.controllers
{
    public class CarroController
    {
        private readonly CarroModel carroModel = new CarroModel();

        public DataTable ListarCarros()
        {
            // Aquí SOLO SQL / lógica (filtrar disponibles, ordenar, etc.)
            string sql = @"
                SELECT 
                    IdC,
                    Marca,
                    Modelo,
                    Anio,
                    PrecioC
                FROM carros
                ORDER BY Marca, Modelo, Anio;
            ";

            return carroModel.ListarPorSql(sql);
        }
    }
}
