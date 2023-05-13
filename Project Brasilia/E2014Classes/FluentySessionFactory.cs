using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2014Classes
{
    public class FluentySessionFactory
    {
        private static ISessionFactory session;
        public static ISessionFactory CriarSession()
        {
            if (session != null)
            {
                return session;
            }
            else
            {
                IPersistenceConfigurer configDB = MsSqlConfiguration.MsSql2008.ConnectionString(c => c.Server("dwnffwkgak.database.windows.net,1433").Database("Eleicao").Username("Orochimaru-SQL@dwnffwkgak").Password("g0BF9lrPM0#"));
                var configMap = Fluently.Configure().Database(configDB).Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapeamento.VotosMap>());
                //session = configMap.BuildSessionFactory();
                session = configMap.ExposeConfiguration(c => c.Properties.Add("hbm2ddl.keywords", "none")).BuildSessionFactory();
                return session;
            }
        }

        public static ISession AbriSession()
        {
            return CriarSession().OpenSession();
        }
    }
}
