using FluentNHibernate.Mapping;
using Core.Shared;
using MoonCore.Classes;

namespace MoonCore.Mapping
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(c => c.Id);
            Map(c => c.Description);
            Map(c => c.Name);
            Table(TableNames.Category);
        }
    }
}
