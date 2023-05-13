using SunCore;
using SunCore.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunCore.Methods
{
    public class Read
    {
        private SqlConnection conns = new SqlConnection(ConnectionDB.ConnectionString());
        private DataTable dt = new DataTable();
        private SqlDataAdapter sda;
        private SqlCommand sqlCommand;

        public DataTable User()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.User + " ORDER BY Name", conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable Client(int xIdFarm, int NumberOfPosts, int AfterThe)
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Client + " WHERE IdFarm = " + xIdFarm + " ORDER BY Name OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable Country()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Country, conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable Region(int xIdCountry)
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Region + " where IdCountry = "+xIdCountry+" ORDER BY Name", conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable Farm(int xIdUser)
        {
            //sda = new SqlDataAdapter("select * from " + TableNames.Farm + " Where AllowedUsers like '%"+xIdUser+"%' ORDER BY Name", conns);
            sda = new SqlDataAdapter("select * from " + TableNames.Farm + " ORDER BY Name", conns);
            sda.Fill(dt);
            
            return dt;
        }
        public DataTable Employee(int xIdFarm, int NumberOfPosts, int AfterThe)
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Employee + " WHERE IdFarm = " + xIdFarm + " ORDER BY Name OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable Employee(int xIdFarm, bool xTemp, int NumberOfPosts, int AfterThe)
        {
            int temp;
            if (xTemp)
                temp = 1;
            else
                temp = 0;

            sda = new SqlDataAdapter("select * from " + TableNames.Employee + " WHERE IdFarm = " + xIdFarm + " and Temp = "+temp+ " ORDER BY Name, LastName OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable User(int xIdFarm)
        {
            sda = new SqlDataAdapter("select * from " + TableNames.User + " WHERE IdFarm = " + xIdFarm + " ORDER BY Name", conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable ProductionCost(int xIdFarm)
        {
            sda = new SqlDataAdapter("select * from " + TableNames.ProductionCost + " WHERE IdFarm = " + xIdFarm + " ORDER BY Id desc", conns);
            sda.Fill(dt);
            return dt;
        }

        public int NumberOfItens(int xIdFarm, string Table)
        {
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT COUNT(*) FROM " + Table + " WHERE IdFarm = " + xIdFarm, conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                return Convert.ToInt32(newId);
            }
        }
        public int NumberOfItensEmployee(int xIdFarm, string Table, int xTemp)
        {
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT COUNT(*) FROM " + Table + " WHERE IdFarm = " + xIdFarm + " and Temp = " + xTemp, conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                return Convert.ToInt32(newId);
            }
        }
        #region AGRICULTURE
        public DataTable Coffee(int xIdFarm)
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Coffee + " WHERE IdFarm = " + xIdFarm + " ORDER BY Id desc", conns);
            sda.Fill(dt);
            return dt;
        }
        #endregion

        #region USER AGRICULTURE
        public DataTable UserCoffee(int xIdFarm)
        {
            sda = new SqlDataAdapter("select * from " + TableNames.UserCoffee + " WHERE IdFarm = " + xIdFarm + " ORDER BY Id desc", conns);
            sda.Fill(dt);
            return dt;
        }
        #endregion
    }
}
