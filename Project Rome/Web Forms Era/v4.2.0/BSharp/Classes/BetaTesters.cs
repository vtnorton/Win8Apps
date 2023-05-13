using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSharp.Classes
{
    public class BetaTesters
    {
        public virtual int Id { get; set; }
        public virtual String Email { get; set; }
        public virtual String Twitter { get; set; }
        public virtual Boolean HasWindows10Mobile { get; set; }
        public virtual Boolean HasWindows10 { get; set; }
        public virtual Boolean HasAndroid { get; set; }
        public virtual Boolean HasiPhone { get; set; }
        public virtual Boolean HasiPad { get; set; }
        
    }
}
