using Core;
using Core.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MoonCore.Methods
{
    public class Read
    {
        private SqlConnection conns = new SqlConnection(CoreInformation.ConnectionString());
        private DataTable dt = new DataTable();
        private SqlDataAdapter sda;
        private SqlCommand sqlCommand;

        #region Author
        public DataTable Author()
        {
            sda = new SqlDataAdapter("select * from " + TableNames.Author + " ORDER BY Id DESC", conns);
            sda.Fill(dt);
            return dt;
        }
        #endregion Author

        #region Post
        public int NumberOfPosts()
        {
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT COUNT(*) FROM " + TableNames.Post, conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                return Convert.ToInt32(newId);
            }
        }
        public DataTable Post(int NumberOfPosts, int AfterThe)
        {
            string Comando1 = "SELECT * FROM " + TableNames.Post;
            string Comando2 = " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY";

            sda = new SqlDataAdapter(Comando1 + Comando2, conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable PostByVisits(int NumberOfPosts)
        {
            sda = new SqlDataAdapter("select top " + NumberOfPosts + " * from " + TableNames.Post + " ORDER BY Visits DESC", conns);
            sda.Fill(dt);
            return dt;
        }
        public DataTable PostFiltred(int NumberOfPosts, int AfterThe, int xIdCategory, string xSearch)
        {
            string Comando1 = "SELECT * FROM " + TableNames.Post;
            string Comando2 = " Order by Id desc OFFSET " + AfterThe + " ROWS FETCH NEXT " + NumberOfPosts + " ROWS ONLY";

            if (xSearch == null)
                xSearch = "";
            else
                xSearch = " Content like '%" + xSearch + "%' and";

            switch (xIdCategory)
            {
                case 108:
                    sda = new SqlDataAdapter(Comando1 + " WHERE " + xSearch + Comando2, conns);
                    sda.Fill(dt);
                    return dt;

                default:
                    sda = new SqlDataAdapter(Comando1 + " WHERE " + xSearch + " IdCategory = " + xIdCategory + Comando2, conns);
                    sda.Fill(dt);
                    return dt;
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
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT MAX(Id) AS LastID FROM " + TableNames.Post, conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                return Convert.ToInt32(newId);
            }
        }
        public int[] PostLastAndPenultimateId()
        {
            using (conns)
            {
                conns.Open();

                sqlCommand = new SqlCommand("SELECT TOP 1 * From (select Top 2 * from " + TableNames.Post + " ORDER BY Id DESC) x ORDER BY Id", conns);
                sqlCommand.ExecuteNonQuery();
                int PenultimateId = (Int32)sqlCommand.ExecuteScalar();

                sqlCommand = new SqlCommand("SELECT MAX(Id) AS LastID FROM " + TableNames.Post, conns);
                sqlCommand.ExecuteNonQuery();
                int LastId = (Int32)sqlCommand.ExecuteScalar();

                conns.Close();

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
            using (conns)
            {
                conns.Open();
                sqlCommand = new SqlCommand("SELECT MAX(Id) AS LastID FROM " + TableNames.Category, conns);
                sqlCommand.ExecuteNonQuery();
                Int32 newId = (Int32)sqlCommand.ExecuteScalar();
                conns.Close();
                return Convert.ToInt32(newId);
            }
        }
        #endregion Categoria
    }
}