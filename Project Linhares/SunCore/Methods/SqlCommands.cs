using System;
using System.Data.SqlClient;

namespace SunCore.Methods
{
    public class SqlCommands
    {
        private SqlConnection conns = new SqlConnection(ConnectionDB.ConnectionString());
        private SqlCommand sqlCommand;

        public void SQLCommand(String xCommand)
        {
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand(xCommand, conns);
                sqlCommand.ExecuteNonQuery();
                conns.Close();

            }
        }
    }
}
