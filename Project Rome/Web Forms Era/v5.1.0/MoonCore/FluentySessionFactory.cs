using Core;
using Core.Shared;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace MoonCore
{
    public class FluentySessionFactory
    {
        public static ISessionFactory session;
        public static ISessionFactory CriarSession()
        {
            if (session != null)
            {
                return session;
            }
            else
            {
                IPersistenceConfigurer configDB;
                configDB = MsSqlConfiguration.MsSql2008.ConnectionString(CoreInformation.ConnectionString());

                var configMap = Fluently.Configure().Database(configDB).Mappings(c => c.FluentMappings.AddFromAssemblyOf<MoonCore.Mapping.AuthorMap>());
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