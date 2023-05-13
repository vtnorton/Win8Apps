using AllVtnorton;
using BSharp.Classes;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladon.Mapping
{
    public class SeasonMap : ClassMap<Season>
    {
        public SeasonMap()
        {
            Id(c => c.Id);
            Map(c => c.IdHistory);
            Map(c => c.SeasonName);
            Map(c => c.Title);
            Map(c => c.Description);
            Table(TableNames.Season);
        }
    }
}
