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
        private readonly ConnectionBD db = new ConnectionBD();

        public DataTable ListarCarros()
        {
            
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


        public string ObtenerFotoPrincipal(int carroId)
        {
            string sql = $@"
        SELECT url_recurso
        FROM carro_multimedia
        WHERE carro_id = {carroId}
          AND tipo = 'IMG'
          AND es_principal = 1
        ORDER BY orden ASC
        LIMIT 1;
    ";

            var dt = db.ExecuteSelect(sql);
            if (dt.Rows.Count == 0) return null;

            return dt.Rows[0]["url_recurso"].ToString();
        }


        public DataTable ListarMultimediaPorCarro(int carroId)
        {
            string sql = $@"
        SELECT
            tipo,
            titulo_recurso,
            formato,
            es_principal,
            orden,
            url_recurso
        FROM carro_multimedia
        WHERE carro_id = {carroId}
        ORDER BY es_principal DESC, orden ASC;
    ";

            return db.ExecuteSelect(sql);
        }
    }


}
