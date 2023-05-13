using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSharp.Classes
{
    public class History
    {
        public virtual int Id { get; set; }
        public virtual String Title { get; set; }
        public virtual String Resume { get; set; }
        public virtual String LongResume { get; set; }
    }
}
