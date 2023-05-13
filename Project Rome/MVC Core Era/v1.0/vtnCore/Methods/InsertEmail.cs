using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using vtnCore.Classes;
using vtnCore.Repository;

namespace vtnCore.Methods
{
    public class InsertEmail
    {
        public static void Insert(string xMail, int xIdLista)
        {
            if (new EmailAddressAttribute().IsValid(xMail))
            {
                int userCount = 0;
                Email obj = new Email();
                EmailRepository repo = new EmailRepository();
                ListaEmailsRepository repoLista = new ListaEmailsRepository();
                SqlConnection conns = new SqlConnection(CoreInformation.ConnectionString);
                SqlCommand sqlCommand;

                obj.Data = DateTime.Now;
                obj.IdLista = xIdLista;
                obj.Mail = xMail;

                try
                {
                    try
                    {
                        using (conns)
                        {
                            conns.Open();
                            sqlCommand = new SqlCommand("SELECT COUNT(*) FROM " + TableNames.Email + " WHERE Mail LIKE " + xMail + " AND IdLista" + xIdLista);
                            userCount = (int)sqlCommand.ExecuteScalar();
                            conns.Close();
                        }
                    }
                    finally
                    {
                        if (userCount == 0)
                            repo.Create(obj);

                        ListaEmails objLista = repoLista.RetornarID(xIdLista);
                        objLista.Inscritos = objLista.Inscritos++;
                        repoLista.Update(objLista);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
