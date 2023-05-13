using FluentNHibernate.Mapping;
using vtnCore.Classes;

namespace vtnCore.Mapping
{
    public class EmailMap : ClassMap<Email>
    {
        public EmailMap()
        {
            Id(c => c.Id);
            Map(c => c.Data);
            Map(c => c.Mail);
            Table(TableNames.Email);
        }
    }
}
