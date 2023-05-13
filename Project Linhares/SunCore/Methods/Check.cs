using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunCore.Methods
{
    public class Check
    {
        private SqlConnection conns = new SqlConnection(ConnectionDB.ConnectionString());
        private DataTable dt = new DataTable();
        private SqlDataAdapter sda;
        private SqlCommand sqlCommand;
        public int IsEmailExist(string xTable, string xEmail)
        {
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT COUNT(*) FROM " + xTable + " WHERE Email = '" + xEmail.ToLower().Trim() + "'", conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                int xNewId = Convert.ToInt32(newId);
                if (xNewId >= 1)
                    return xNewId;
                else
                    return 0;
            }
        }
        public int IsBrazilCPFExist(string xBrazilCPF)
        {
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT COUNT(*) FROM " + TableNames.Document + " WHERE BrazilCPF = '" + xBrazilCPF + "'", conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                int xNewId = Convert.ToInt32(newId);
                if (xNewId >= 1)
                    return xNewId;
                else
                    return 0;
            }
        }
        public int IsBrazilRGExist(string xBrazilRG)
        {
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT COUNT(*) FROM " + TableNames.Document + " WHERE BrazilRG = '" + xBrazilRG + "'", conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                int xNewId = Convert.ToInt32(newId);
                if (xNewId >= 1)
                    return xNewId;
                else
                    return 0;
            }
        }
        public int IsPassportExist(string xPassport)
        {
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT COUNT(*) FROM " + TableNames.Document + " WHERE Passport = '" + xPassport + "'", conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                int xNewId = Convert.ToInt32(newId);
                if (xNewId >= 1)
                    return xNewId;
                else
                    return 0;
            }
        }
        public int IsBrazilCNHExist(string xBrazilCNH)
        {
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT COUNT(*) FROM " + TableNames.Document + " WHERE BrazilCNH = '" + xBrazilCNH + "'", conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                int xNewId = Convert.ToInt32(newId);
                if (xNewId >= 1)
                    return xNewId;
                else
                    return 0;
            }
        }
        public int IsBrazilCNPJExist(string xBrazilCNPJ)
        {
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT COUNT(*) FROM " + TableNames.Document + " WHERE BrazilCNPJ = '" + xBrazilCNPJ + "'", conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                int xNewId = Convert.ToInt32(newId);
                if (xNewId >= 1)
                    return xNewId;
                else
                    return 0;
            }
        }
        public int IsBrazilCDTNumeroExist(string xBrazilCDTNumero)
        {
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT COUNT(*) FROM " + TableNames.Document + " WHERE BrazilCDTNumero = '" + xBrazilCDTNumero + "'", conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                int xNewId = Convert.ToInt32(newId);
                if (xNewId >= 1)
                    return xNewId;
                else
                    return 0;
            }
        }
    }
}
