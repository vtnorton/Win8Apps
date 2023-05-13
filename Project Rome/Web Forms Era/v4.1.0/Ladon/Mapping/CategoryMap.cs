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
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(c => c.Id);
            Map(c => c.Description);
            Map(c => c.Name);
            Map(c => c.URLCover);
            Map(c => c.URLIcon);
            Table(TableNames.Category);
        }
    }
}
