using FluentNHibernate.Mapping;
using vtnCore.Classes;

namespace vtnCore.Mapping
{
    public class ListaEmailMap : ClassMap<ListaEmail>
    {
        public ListaEmailMap()
        {
            Id(c => c.Id);
            Map(c => c.Nome);
            Table(TableNames.Email);
        }
    }
}
