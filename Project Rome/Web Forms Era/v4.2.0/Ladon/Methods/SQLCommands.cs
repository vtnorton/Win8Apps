using AllVtnorton;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladon.Methods
{
    public class SQLCommands
    {
        private SqlConnection conns = new SqlConnection(ActualStringConnection());
        private SqlCommand sqlCommand;

        private static String ActualStringConnection()
        {
            String Conn;
            if (Information.Database == 1)
            {
                Conn = StringConnectionDev.ConnectionString();
            }
            else
            {
                Conn = StringConnection.ConnectionString();
            }

            return Conn;
            //return "Data Source=axna8xeyyv.database.windows.net;Initial Catalog=vtnorton-sql-devmode;Persist Security Info=True;User ID=vtn_db_lg-042@axna8xeyyv;Password=#M1161W4Jm";

        }

        public void SQLCommand(String xCommand)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.Open();

                sqlCommand = new SqlCommand(xCommand, conn);
                sqlCommand.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}
