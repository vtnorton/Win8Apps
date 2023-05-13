using Core;
using System;
using System.Data.SqlClient;

namespace MoonCore.Methods
{
    public class SQLCommands
    {
        private SqlConnection conns = new SqlConnection(CoreInformation.ConnectionString());
        private SqlCommand sqlCommand;

        public void SQLCommand(String xCommand)
        {
            using (conns)
            {
                try
                {
                    conns.Open();
                    sqlCommand = new SqlCommand(xCommand, conns);
                    sqlCommand.ExecuteNonQuery();
                }
                catch
                {

                }
                finally
                {
                    conns.Close();
                }
            }
        }
    }
}
