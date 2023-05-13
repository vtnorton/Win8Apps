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
    public class SlideMap : ClassMap<Slide>
    {
        public SlideMap()
        {
            Id(c => c.Id);
            Map(c => c.Description);
            Map(c => c.Title);
            Map(c => c.URLImage);
            Map(c => c.URLLink);
            Table(TableNames.Slide);
        }
    }
}
