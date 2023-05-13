using AllVtnorton;
using BSharp.Classes;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Ladon.Methods
{
    public class Read
    {
        private SqlConnection conns = new SqlConnection(ActualStringConnection());
        private DataTable dt = new DataTable();
        private SqlDataAdapter sda;
        private SqlCommand sqlCommand;

        private static String ActualStringConnection()
        {
            String Conn;
            if(Information.Database == 1)
            {
                Conn = StringConnectionDev.ConnectionString();
            }
            else
            {
                Conn = StringConnection.ConnectionString();
            }

            return Conn;
            //return "Data Source=axna8xeyyv.database.windows.net;Initial Catalog=vtnorton-sql-devmode;Persist Security Info=True;User ID=vtn_db_lg-042@axna8xeyyv;Password=#M1161W4Jm";

        }

        #region Author
        public DataTable Author()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Author + " ORDER BY Id DESC", conns);
            sda.Fill(dt);
            return dt;
        }
        #endregion Author

        #region Post
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
        public DataTable Post(bool Reverse, int NumberOfPosts, int AfterThe, int xOnline)
        {
            if (Reverse)
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Online = " + xOnline + " ORDER BY Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            else
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Online = " + xOnline + " ORDER BY Id OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            sda.Fill(dt);
            return dt;
        }
        public DataTable PostByCategory(bool Reverse, int NumberOfPosts, int AfterThe, int xIdCategory)
        {
            if (Reverse)
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE IdCategory = " + xIdCategory + " and Online = 1 Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            else
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE IdCategory = " + xIdCategory + " and Online = 1 OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            sda.Fill(dt);
            return dt;
        }
        public DataTable PostByCategoryForEmail(bool Reverse, int NumberOfPosts, int AfterThe, int xIdCategory)
        {
            if (Reverse)
            {
                sda = new SqlDataAdapter("SELECT Title, AuthorName, PostedDate, Visits FROM " + TableNames.Post + " WHERE IdCategory = " + xIdCategory + " and Online = 1 Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            else
            {
                sda = new SqlDataAdapter("SELECT Title, AuthorName, PostedDate, Visits FROM " + TableNames.Post + " WHERE IdCategory = " + xIdCategory + " and Online = 1 OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            sda.Fill(dt);
            return dt;
        }
        public DataTable PostFiltred(bool Reverse, int NumberOfPosts, int AfterThe, int xIdCategory, int xIdAuthor, int xOnline)
        {
            switch (xIdAuthor)
            {
                case 108:
                    switch (xIdCategory)
                    {
                        case 108:
                            switch (xOnline)
                            {
                                case 0:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                case 1:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                default:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                            }
                        default:
                            switch (xOnline)
                            {
                                case 0:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE IdCategory = " + xIdCategory + " and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                case 1:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE IdCategory = " + xIdCategory + " and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                default:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE IdCategory = " + xIdCategory + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                            }
                    }
                default:
                    switch (xIdCategory)
                    {
                        case 108:
                            switch (xOnline)
                            {
                                case 0:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE IdAuthor = " + xIdAuthor + " and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                case 1:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE IdAuthor = " + xIdAuthor + " and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                default:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE IdAuthor = " + xIdAuthor + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                            }
                        default:
                            switch (xOnline)
                            {
                                case 0:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE IdAuthor = " + xIdAuthor + " and IdCategory=" + xIdCategory + " and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                case 1:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE IdAuthor = " + xIdAuthor + " and IdCategory=" + xIdCategory + " and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                default:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE IdAuthor = " + xIdAuthor + " and IdCategory=" + xIdCategory + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                            }
                    }
            }
        }
        public DataTable PostFiltred(bool Reverse, int NumberOfPosts, int AfterThe, int xIdCategory, int xIdAuthor, int xOnline, String xSearch)
        {
            switch (xIdAuthor)
            {
                case 108:
                    switch (xIdCategory)
                    {
                        case 108:
                            switch (xOnline)
                            {
                                case 0:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Content like '%" + xSearch + "%' and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                case 1:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Content like '%" + xSearch + "%' and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                default:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " Where Content like '%" + xSearch + "%' Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                            }
                        default:
                            switch (xOnline)
                            {
                                case 0:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Content like '%" + xSearch + "%' and IdCategory = " + xIdCategory + " and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                case 1:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Content like '%" + xSearch + "%' and IdCategory = " + xIdCategory + " and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                default:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Content like '%" + xSearch + "%' and IdCategory = " + xIdCategory + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                            }
                    }
                default:
                    switch (xIdCategory)
                    {
                        case 108:
                            switch (xOnline)
                            {
                                case 0:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Content like '%" + xSearch + "%' and IdAuthor = " + xIdAuthor + " and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                case 1:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Content like '%" + xSearch + "%' and IdAuthor = " + xIdAuthor + " and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                default:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Content like '%" + xSearch + "%' and IdAuthor = " + xIdAuthor + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                            }
                        default:
                            switch (xOnline)
                            {
                                case 0:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Content like '%" + xSearch + "%' and IdAuthor = " + xIdAuthor + " and IdCategory=" + xIdCategory + " and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                case 1:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Content like '%" + xSearch + "%' and IdAuthor = " + xIdAuthor + " and IdCategory=" + xIdCategory + " and Online = " + xOnline + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                                default:
                                    sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Post + " WHERE Content like '%" + xSearch + "%' and IdAuthor = " + xIdAuthor + " and IdCategory=" + xIdCategory + " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
                                    sda.Fill(dt);
                                    return dt;
                            }
                    }
            }
        }
        public List<Int32> PostListIds()
        {
            sda = new SqlDataAdapter("select distinct * from " + TableNames.Post, conns);
            sda.Fill(dt);
            return dt.AsEnumerable().Select(n => n.Field<Int32>(0)).ToList();
        }
        public int PostLastId()
        {
            using (SqlConnection conn = new SqlConnection(ActualStringConnection()))
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
            using (SqlConnection conn = new SqlConnection(ActualStringConnection()))
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
        #endregion Post

        #region Bug
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
        public DataTable Bug(int xLoad, int xStartWith, int xTipo, int xPostsSelected, int xOrderBy, String xStatus, String xSearch)
        {
            String strCommand = "SELECT * FROM " + TableNames.Bug;

            if (xTipo == 1)
                strCommand += " WHERE Type='Sugestão'";
            else if (xTipo == 2)
                strCommand += " WHERE Type='Problema'";
            else
                strCommand += " WHERE ((Type='Problema') OR (Type='Sugestão'))";

            if (xPostsSelected == 1)
                strCommand += " AND Email='jade@vtnorton.com'";
            else if (xPostsSelected == 2)
                strCommand += " AND NOT Email='jade@vtnorton.com'";
            else
                strCommand += "";

            if (xSearch == null)
                strCommand += "";
            else
                strCommand += " AND Menssage LIKE '%" + xSearch + "%'";

            switch (xStatus)
            {
                case "Todos":
                    strCommand += "";
                    break;
                case "Recebido":
                    strCommand += " AND Status='" + xStatus + "'";
                    break;
                case "Em andamento":
                    strCommand += " AND Status='" + xStatus + "'";
                    break;
                case "Disponivel na atualização":
                    strCommand += " AND Status='" + xStatus + "'";
                    break;
                case "Cancelado":
                    strCommand += " AND Status='" + xStatus + "'";
                    break;
                case "Concluído":
                    strCommand += " AND Status='" + xStatus + "'";
                    break;
                case "Não recebido":
                    strCommand += " AND Status='" + xStatus + "'";
                    break;
                default:
                    strCommand += "";
                    break;
            }

            if (xOrderBy == 1)
                strCommand += " ORDER BY Id DESC OFFSET " + xStartWith + " ROWS FETCH NEXT " + xLoad + " ROWS ONLY";
            else
                strCommand += " ORDER BY Upvotes OFFSET " + xStartWith + " ROWS FETCH NEXT " + xLoad + " ROWS ONLY";

            sda = new SqlDataAdapter(strCommand, conns);

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
        #endregion Bug

        #region Categoria
        /// <summary>
        /// Retorna um DataTable com as categorias
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable Category()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Category, conns);
            sda.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Retorna um DataTable com as categorias
        /// </summary>
        /// <param name="NumberOfPosts">Número de posts a serem apresentados</param>
        /// <param name="AfterThe">Os posts começaram depois de...</param>
        /// <returns>DataTable</returns>
        public DataTable Category(int NumberOfPosts, int AfterThe)
        {
            sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Category + " ORDER BY Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            sda.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Retorna um DataTable com as categorias
        /// </summary>
        /// <param name="NumberOfPosts">Número de posts a serem apresentados</param>
        /// <param name="AfterThe">Os posts começaram depois de...</param>
        /// <param name="xSearch">String de pesquisa no nome da categoria</param>
        /// <returns>DataTable</returns>
        public DataTable Category(int NumberOfPosts, int AfterThe, String xSearch)
        {
            sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Category + " WHERE Name like '%" + xSearch + "%' ORDER BY Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            sda.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Retorna um DataTable com as categorias, podendo ordenar por ordem alfabética o nome da categoria
        /// </summary>
        /// <param name="NumberOfPosts">Número de posts a serem apresentados</param>
        /// <param name="AfterThe">Os posts começam depois de...</param>
        /// <param name="OrderBy">Caso (1) Ordena o nome da categoria em ordem alfabéfica, caso (2) ordena em ordem alfabética decrescente e caso (0) ordena normalmente. Só esse valores são aplicados.</param>
        /// <returns>DataTable</returns>
        public DataTable Category(int NumberOfPosts, int AfterThe, int OrderBy)
        {
            if (OrderBy == 1)
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Category + " ORDER BY Name OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            else if (OrderBy == 0)
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Category + " ORDER BY Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            else
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Category + " ORDER BY Name desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            sda.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Retorna um DataTable com as categorias, podendo ordenar por ordem alfabética o nome da categoria
        /// </summary>
        /// <param name="NumberOfPosts">Número de posts a serem apresentados</param>
        /// <param name="AfterThe">Os posts começam depois de...</param>
        /// <param name="OrderBy">Caso (1) Ordena o nome da categoria em ordem alfabéfica, caso (2) ordena em ordem alfabética decrescente e caso (0) ordena normalmente. Só esse valores são aplicados.</param>
        /// <param name="xSearch">String de pesquisa no nome da categoria</param>
        /// <returns>DataTable</returns>
        public DataTable Category(int NumberOfPosts, int AfterThe, int OrderBy, String xSearch)
        {
            if (OrderBy == 1)
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Category + " WHERE Name like '%" + xSearch + "%' ORDER BY Name OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            else if (OrderBy == 0)
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Category + " WHERE Name like '%" + xSearch + "%' ORDER BY Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }
            else
            {
                sda = new SqlDataAdapter("SELECT * FROM " + TableNames.Category + " WHERE Name like '%" + xSearch + "%' ORDER BY Name desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY", conns);
            }

            sda.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Retorna o último Id cadastrado em categoria
        /// </summary>
        /// <returns>int</returns>
        public int CategoryLastId()
        {
            using (SqlConnection conn = new SqlConnection(ActualStringConnection()))
            {
                conn.Open();
                sqlCommand = new SqlCommand("SELECT MAX(Id) AS LastID FROM " + TableNames.Category, conn);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conn.Close();
                return Convert.ToInt32(newId);
            }
        }
        #endregion Categoria
    }
}
