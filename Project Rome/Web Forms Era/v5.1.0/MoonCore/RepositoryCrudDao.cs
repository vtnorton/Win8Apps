using NHibernate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonCore
{
    public class RepositoryCrudDao<T> : ICrudDao<T> where T : class
    {
        public void Create(T Entidade)
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
                        throw new Exception(ex.ToString());
                    }
                }
            }
        }

        public void Update(T Entidade)
        {
            using (ISession session = FluentySessionFactory.AbriSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(Entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception(ex.Message);
                    }
                }
            }
        }

        public void Delete(T Entidade)
        {
            using (ISession session = FluentySessionFactory.AbriSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(Entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception(ex.Message);
                    }
                }
            }
        }

        public T RetornarID(int id)
        {
            using (ISession session = FluentySessionFactory.AbriSession())
            {
                return session.Get<T>(id);
            }
        }
    }
}
