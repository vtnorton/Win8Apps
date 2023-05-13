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
        public DataTable Email()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Email, conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable Email(int xIdLista)
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Email + " where IdLista = " + xIdLista, conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable Enviados()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Enviados, conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable ListaEmails()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.ListaEmails, conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable Temas()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Temas, conns);
            sda.Fill(dt);
            return dt;
        }
    }
}
