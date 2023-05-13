using System;
using System.Data;
using System.Data.SqlClient;

namespace vtnCore.Methods
{
    public class Read
    {
        private SqlConnection conns = new SqlConnection(CoreInformation.ConnectionString);
        private DataTable dt = new DataTable();
        private SqlDataAdapter sda;

        public DataTable Ebooks()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Ebooks, conns);
            sda.Fill(dt);
            return dt;
        }

        public DataTable OneNoteEmails()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.OneNoteEmails, conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable Email()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Email, conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable Evento()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Evento, conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable Evento(bool JaPassou)
        {
            int x;
            if (JaPassou)
                x = 1;
            else
                x = 0;
            sda = new SqlDataAdapter("select * from " + TableNames.Evento + " where JaPassou = " + x + " ORDER BY Data", conns);
            sda.Fill(dt);
            return dt;
        }
    }
}
