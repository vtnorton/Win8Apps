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
    public class AppCategoryMap : ClassMap<AppCategory>
    {
        public AppCategoryMap()
        {
            Id(c => c.Id);
            Map(c => c.Name);
            Map(c => c.URLCover);
            Map(c => c.URLIcon);
            Map(c => c.Description);
            Table(TableNames.AppCategory);
        }
    }
}
