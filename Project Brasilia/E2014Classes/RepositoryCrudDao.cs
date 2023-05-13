using E2014Classes.Objetos;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2014Classes
{
    public class RepositoryCrudDao<T> : ICrudDao<T> where T : class
    {
        public void Inserir(T Entidade)
        {
            using (ISession session = FluentySessionFactory.AbriSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(Entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao inserir entidade: " + ex.ToString());
                    }
                }
            }
        }

        public T RetornarPorID(string id)
        {
            using (ISession session = FluentySessionFactory.AbriSession())
            {
                return session.Get<T>(id);
            }
        }

        public void StringSQL(string StringSQLASerExecutada)
        {
            using (ISession session = FluentySessionFactory.AbriSession())
            {
                session.CreateSQLQuery(StringSQLASerExecutada).ExecuteUpdate();
            }
        }

        public void DefinirDado(int id, string tabela, string coluna, int IntASerInserida)
        {
            using (ISession session = FluentySessionFactory.AbriSession())
            {
                session.CreateSQLQuery("update " + tabela + " set " + coluna + "=" + IntASerInserida + " where id =" + id + ";").ExecuteUpdate();
            }
        }
        public void DefinirDado(int id, string tabela, string coluna, DateTime DataASerInserida)
        {
            using (ISession session = FluentySessionFactory.AbriSession())
            {
                session.CreateSQLQuery("update " + tabela + " set " + coluna + "='" + DataASerInserida.ToString("yyyy-MM-dd HH:mm:ss") + "' where id =" + id + ";").ExecuteUpdate();
            }
        }
    }
}
