using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vtnorton.Model
{
    public class Message
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string EmailTo { get; set; }
        public string NameTo { get; set; }
    }
}
