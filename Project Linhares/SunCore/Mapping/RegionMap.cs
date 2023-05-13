using FluentNHibernate.Mapping;
using SunCore.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunCore.Mapping
{
    public class RegionMap: ClassMap<Region>
    {
        public RegionMap()
        {
            Id(c => c.Id);
            Map(c => c.IdCountry);
            Map(c => c.Name);
            Table(TableNames.Region);
        }
    }
}
