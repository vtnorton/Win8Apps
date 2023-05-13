using AllVtnorton;
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
        private SqlConnection conns = new SqlConnection(Information.ActualStringConnection());
        private SqlCommand sqlCommand;

        public void SQLCommand(String xCommand)
        {
            using (SqlConnection conn = new SqlConnection(Information.ActualStringConnection()))
            {
                conn.Open();

                sqlCommand = new SqlCommand(xCommand, conn);
                sqlCommand.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}
