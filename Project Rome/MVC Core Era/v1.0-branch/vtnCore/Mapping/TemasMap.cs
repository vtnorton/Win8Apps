using FluentNHibernate.Mapping;
using vtnCore.Classes;

namespace vtnCore.Mapping
{
    public class TemasMap : ClassMap<Temas>
    {
        public TemasMap()
        {
            Id(c => c.Id);
            Map(c => c.Conteudo);
            Map(c => c.Descricao);
            Map(c => c.Nome);
            Table(TableNames.Temas);
        }
    }
}
