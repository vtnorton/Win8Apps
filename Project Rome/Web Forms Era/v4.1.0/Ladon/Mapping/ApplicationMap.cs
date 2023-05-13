using AllVtnorton;
using FluentNHibernate.Mapping;
using BSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladon.Mapping
{
    public class ApplicationMap : ClassMap<Application>
    {
        public ApplicationMap()
        {
            Id(c => c.Id);
            Map(c => c.Description);
            Map(c => c.IdAppCategory);
            Map(c => c.Version);
            Map(c => c.Name);
            Map(c => c.Size);
            Map(c => c.URLCape);
            Map(c => c.URLIcon);
            Table(TableNames.Application);
        }
    }
}
