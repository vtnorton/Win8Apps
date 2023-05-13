using FluentNHibernate.Mapping;
using vtnCore.Classes;

namespace vtnCore.Mapping
{
    public class OneNoteMap : ClassMap<OneNote>
    {
        public OneNoteMap()
        {
            Id(c => c.Id);
            Map(c => c.Email);
            Table(TableNames.OneNoteEmails);
        }
    }
}
