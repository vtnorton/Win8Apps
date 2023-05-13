using System.Data.SqlClient;

namespace VTNORTON.Core
{
    public class SQLCommands
    {
        private SqlConnection conns = new SqlConnection("");
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
