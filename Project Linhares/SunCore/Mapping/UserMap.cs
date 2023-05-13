using FluentNHibernate.Mapping;
using SunCore;
using SunCore.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunCore.Mapping
{
    class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(c => c.Id);
            Map(c => c.AccessType);
            Map(c => c.FirstLogin);
            Map(c => c.LastLogin);
            Map(c => c.Password);
            Map(c => c.Unity);
            Map(c => c.IdEmployee);
            Table(TableNames.User);
        }
    }
}
