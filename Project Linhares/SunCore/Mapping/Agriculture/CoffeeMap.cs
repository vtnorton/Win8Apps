using FluentNHibernate.Mapping;
using SunCore.Classes.Agriculture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunCore.Mapping.Agriculture
{
    public class CoffeeMap : ClassMap<Coffee>
    {
        public CoffeeMap()
        {
            Id(c => c.Id);
            Map(c => c.Boxing);
            Map(c => c.Classification);
            Map(c => c.Drying);
            Map(c => c.Flowering);
            Map(c => c.Grinding);
            Map(c => c.Harvest);
            Map(c => c.Packing);
            Map(c => c.Plantation);
            Map(c => c.Processing);
            Map(c => c.Region);
            Map(c => c.Roasting);
            Map(c => c.Type);
            Table(TableNames.Coffee);
        }
    }
}
