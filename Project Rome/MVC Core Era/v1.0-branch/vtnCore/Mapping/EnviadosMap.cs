using FluentNHibernate.Mapping;
using vtnCore.Classes;

namespace vtnCore.Mapping
{
    public class EnviadosMap : ClassMap<Enviados>
    {
        public EnviadosMap()
        {
            Id(c => c.Id);
            Map(c => c.Conteudo);
            Map(c => c.Descrição);
            Map(c => c.Enviado);
            Map(c => c.Nome);
            Table(TableNames.Enviados);
        }
    }
}
