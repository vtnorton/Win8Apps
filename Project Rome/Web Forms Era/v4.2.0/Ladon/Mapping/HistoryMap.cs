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
    public class HistoryMap : ClassMap<History>
    {
        public HistoryMap()
        {
            Id(c => c.Id);
            Map(c => c.LongResume);
            Map(c => c.Resume);
            Map(c => c.Title);
            Table(TableNames.History);
        }
    }
}
