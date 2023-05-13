using AllVtnorton;
using BSharp.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Ladon.Methods
{
    public class Read
    {
        private SqlConnection conns = new SqlConnection(Information.ActualStringConnection());
        private DataTable dt = new DataTable();
        private SqlDataAdapter sda;
        private SqlCommand sqlCommand;

        public DataTable Post(bool Reverse, int NumberOfPosts, int AfterThe)
        {
            if (Reverse)
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " ORDER BY Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            else
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " ORDER BY Id OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            sda.Fill(dt);
            return dt;
        }
        public DataTable PostByCategory(bool Reverse, int NumberOfPosts, int AfterThe, int xIdCategory)
        {
            if (Reverse)
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE IdCategory = " + xIdCategory + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            else
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE IdCategory = " + xIdCategory + " OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            sda.Fill(dt);
            return dt;
        }
        public List<Int32> PostListIds()
        {
            sda = new SqlDataAdapter("select distinct * from " + TableNames.Post, conns);
            sda.Fill(dt);
            return dt.AsEnumerable().Select(n => n.Field<Int32>(0)).ToList();
        }
        public int PostLastId()
        {
            using (SqlConnection conn = new SqlConnection(Information.ActualStringConnection()))
            {
                conn.Open();
                sqlCommand = new SqlCommand("SELECT MAX(Id) AS LastID FROM " + TableNames.Post, conn);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conn.Close();
                return Convert.ToInt32(newId);
            }
        }
        public int[] PostLastAndPenultimateId()
        {
            using (SqlConnection conn = new SqlConnection(Information.ActualStringConnection()))
            {
                conn.Open();

                sqlCommand = new SqlCommand("SELECT TOP 1 * From (select Top 2 * from " + TableNames.Post + " ORDER BY Id DESC) x ORDER BY Id", conn);
                sqlCommand.ExecuteNonQuery();
                int PenultimateId = (Int32)sqlCommand.ExecuteScalar();

                sqlCommand = new SqlCommand("SELECT MAX(Id) AS LastID FROM " + TableNames.Post, conn);
                sqlCommand.ExecuteNonQuery();
                int LastId = (Int32)sqlCommand.ExecuteScalar();

                conn.Close();

                int[] Ids = new int[2];
                Ids[0] = PenultimateId;
                Ids[1] = LastId;

                return Ids;
            }
        }
        public DataTable Bug()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Bug + " ORDER BY Id DESC", conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable Bug(int NumberOfPosts, int AfterThe)
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Bug + " ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable Bug(String xType, String xStatus, int NumberOfPosts, int AfterThe)
        {
            if ((xType != null) && (xStatus != null))
            {
                switch (xStatus)
                {
                    case "All":
                        switch (xType)
                        {
                            case "Both":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Sugestion":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Suggestion' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Bugs":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Bugs' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                        }
                        break;
                    case "NonRecived":
                        switch (xType)
                        {
                            case "Both":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHARE Status='" + xStatus + "' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Sugestion":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Suggestion' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Bugs":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Bugs' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                        }
                        break;
                    case "Recived":
                        switch (xType)
                        {
                            case "Both":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHARE Status='" + xStatus + "' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Sugestion":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Suggestion' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Bugs":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Bugs' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                        }
                        break;
                    case "GoingOn":
                        switch (xType)
                        {
                            case "Both":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHARE Status='" + xStatus + "' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Sugestion":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Suggestion' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Bugs":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Bugs' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                        }
                        break;
                    case "NextUpdate":
                        switch (xType)
                        {
                            case "Both":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHARE Status='" + xStatus + "' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Sugestion":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Suggestion' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Bugs":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Bugs' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                        }
                        break;
                    case "Canceled":
                        switch (xType)
                        {
                            case "Both":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHARE Status='" + xStatus + "' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Sugestion":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Suggestion' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Bugs":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Bugs' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                        }
                        break;
                    case "Done":
                        switch (xType)
                        {
                            case "Both":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHARE Status='" + xStatus + "' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Sugestion":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Suggestion' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                            case "Bugs":
                                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " WHERE Status='" + xStatus + "' AND Type='Bugs' ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                break;
                        }
                        break;
                }
            }
            else
            {
                sda = new SqlDataAdapter("select * from " + TableNames.Bug + " ORDER BY Id DESC OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            sda.Fill(dt);
            return dt;
        }
        public int BugLastId()
        {
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT MAX(Id) AS LastID FROM " + TableNames.Bug, conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                return Convert.ToInt32(newId);
            }
        }

        public DataTable Category()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Category, conns);
            sda.Fill(dt);
            return dt;
        }
        public List<Int32> CategoryListIds()
        {
            sda = new SqlDataAdapter("select distinct * from " + TableNames.Category, conns);
            sda.Fill(dt);
            return dt.AsEnumerable().Select(n => n.Field<Int32>(0)).ToList();
        }
        public List<String> CategoryListNames()
        {
            sda = new SqlDataAdapter("select distinct * from " + TableNames.Category, conns);
            sda.Fill(dt);
            return dt.AsEnumerable().Select(n => n.Field<String>(1)).ToList();
        }
        public int CategoryLastId()
        {
            using (SqlConnection conn = new SqlConnection(Information.ActualStringConnection()))
            {
                conn.Open();
                sqlCommand = new SqlCommand("SELECT MAX(Id) AS LastID FROM " + TableNames.Category, conn);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conn.Close();
                return Convert.ToInt32(newId);
            }
        }

        public DataTable Slide()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Slide, conns);
            sda.Fill(dt);
            return dt;
        }
        public int SlideLastId()
        {
            using (SqlConnection conn = new SqlConnection(Information.ActualStringConnection()))
            {
                conn.Open();
                sqlCommand = new SqlCommand("SELECT MAX(Id) AS LastID FROM " + TableNames.Slide, conn);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conn.Close();
                return Convert.ToInt32(newId);
            }
        }
    }
}
