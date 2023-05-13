using FluentNHibernate.Mapping;
using SunCore.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunCore.Mapping
{
    public class CountryMap : ClassMap<Country>
    {
        public CountryMap()
        {
            Id(c => c.Id);
            Map(c => c.Name);
            Map(c => c.Code);
            Table(TableNames.Country);
        }
    }
}
