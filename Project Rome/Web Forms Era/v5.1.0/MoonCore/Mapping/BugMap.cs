using Core.Shared;
using FluentNHibernate.Mapping;
using MoonCore.Classes;

namespace MoonCore.Mapping
{
    public class BugMap : ClassMap<Bug>
    {
        public BugMap()
        {
            Id(c => c.Id);
            Map(c => c.Upvotes);
            Map(c => c.Project);
            Map(c => c.Menssage);
            Map(c => c.Date);
            Map(c => c.Email);
            Map(c => c.Status);
            Map(c => c.Type);
            Map(c => c.StatusCSSClass);
            Table(TableNames.Bug);
        }
    }
}
