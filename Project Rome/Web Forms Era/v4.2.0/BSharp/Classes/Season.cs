using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSharp.Classes
{
    public class Season
    {
        public virtual int Id { get; set; }
        public virtual int IdHistory { get; set; }
        public virtual int SeasonName { get; set; }
        public virtual String Title { get; set; }
        public virtual String Description { get; set; }

    }
}
