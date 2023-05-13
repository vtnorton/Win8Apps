using FluentNHibernate.Mapping;
using vtnCore.Classes;

namespace vtnCore.Mapping
{
    public class EbookMap : ClassMap<Ebook>
    {
        public EbookMap()
        {
            Id(c => c.Id);
            Map(c => c.Downloads);
            Map(c => c.Name);
            Map(c => c.Descricao);
            Table(TableNames.Ebooks);
        } 
    }
}