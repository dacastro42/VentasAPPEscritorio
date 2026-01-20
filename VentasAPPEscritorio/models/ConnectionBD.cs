using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasAPPEscritorio.models
{
    public class ConnectionBD
    {
        public MySqlConnection connManager;
        string server = "127.0.0.1;";
        string database = "ventasdb;";
        string user = "root;";
        string pass = "root;";

        public MySqlConnection DataSource()
        {
            connManager = new MySqlConnection($"server={server} database={database} Uid={user} password={pass}");
            return connManager;
        }

        public void ConnectOpened()
        {
            //DataSource();
            connManager.Open();
        }
        public void ConnectClosed()
        {
            DataSource();
            connManager.Close();
        }

        #region Métodos a BD

        //Insert
        public bool ExecuteQuery(string sql)
        {
            bool result = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();

                cmd.ExecuteNonQuery();
                result = true;
                //ConnectClosed();
            }
            catch (Exception w)
            {
                Console.WriteLine("ERROOOOOOR " + w.Message);

                ConnectClosed();
            }
            finally
            {
                ConnectClosed();
            }
            return result;
        }

        //Select, retorna una tabla 
        public DataTable ExecuteSelect(string sql)
        {
            using (MySqlConnection conn = DataSource())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        #endregion
    }
}
