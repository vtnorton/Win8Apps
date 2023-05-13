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
            Map(c => c.Version);
            Map(c => c.Name);
            Map(c => c.URLCape);
            Map(c => c.URLIcon);
            Map(c => c.IsCompatibleWithAndroid);
            Map(c => c.IsCompatibleWithHoloLens);
            Map(c => c.IsCompatibleWithiPhone);
            Map(c => c.IsCompatibleWithSurfaceHub);
            Map(c => c.IsCompatibleWithWindows10);
            Map(c => c.IsCompatibleWithWindows10Mobile);
            Map(c => c.IsCompatibleWithWindows8);
            Map(c => c.IsCompatibleWithWindowsPhone8);
            Map(c => c.IsCompatibleWithXbox);
            Map(c => c.LinkStoreAndroid);
            Map(c => c.LinkStoreApple);
            Map(c => c.LinkStoreWindows);
            Map(c => c.LongDescription);
            Map(c => c.URLLargeIcon);
            Table(TableNames.Application);
        }
    }
}
