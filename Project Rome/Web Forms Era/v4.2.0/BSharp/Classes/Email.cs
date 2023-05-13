using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSharp.Classes
{
    public class Email
    {
        public virtual int Port { get; set; }
        public virtual bool UseDefaultCredentials { get; set; }
        public static bool EnableSsl { get; set; }
        public virtual bool IsBodyHtml { get; set; }
        public virtual String Host { get; set; }
        public virtual String From { get; set; }
        public virtual String EmailAddress { get; set; }
        public virtual String Password { get; set; }
    }
}
