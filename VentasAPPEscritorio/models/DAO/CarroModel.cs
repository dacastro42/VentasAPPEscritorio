using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasAPPEscritorio.models.DAO
{
    public class CarroModel
    {
        private readonly ConnectionBD db = new ConnectionBD();

        public DataTable ListarPorSql(string sql)
        {
            return db.ExecuteSelect(sql);
        }
    }
}
