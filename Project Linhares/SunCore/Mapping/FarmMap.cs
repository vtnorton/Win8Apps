using FluentNHibernate.Mapping;
using SunCore;
using SunCore.Classes;

namespace SunCore.Mapping
{
    public class FarmMap : ClassMap<Farm>
    {
        public FarmMap()
        {
            Id(c => c.Id);
            Map(c => c.Address);
            Map(c => c.Name);
            Map(c => c.Size);
            Map(c => c.Type);
            Map(c => c.AllowedUsers);
            Map(c => c.Owner);
            Map(c => c.IdCountry);
            Map(c => c.IdRegion);
            Table(TableNames.Farm);
        }
    }
}
