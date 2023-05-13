using System;
using System.Data.SqlClient;

namespace vtnCore.Methods
{
    public class SqlCommands
    {
        private SqlConnection conns = new SqlConnection(CoreInformation.ConnectionString);
        private SqlCommand sqlCommand;

        public void SQLCommand(string xCommand)
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
