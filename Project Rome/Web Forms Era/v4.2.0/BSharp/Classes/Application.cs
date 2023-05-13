using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSharp.Classes
{
    public class Application
    {
        public virtual int Id { get; set; }
        public virtual String Name { get; set; }
        public virtual String Description { get; set; }
        public virtual String LongDescription { get; set; }
        public virtual String URLIcon { get; set; }
        public virtual String URLLargeIcon { get; set; }
        public virtual String URLCape { get; set; }
        public virtual String LinkStoreWindows { get; set; }
        public virtual String LinkStoreApple { get; set; }
        public virtual String LinkStoreAndroid { get; set; }
        public virtual String Version { get; set; }
        public virtual Boolean IsCompatibleWithWindowsPhone8 { get; set; }
        public virtual Boolean IsCompatibleWithWindows8 { get; set; }
        public virtual Boolean IsCompatibleWithWindows10Mobile { get; set; }
        public virtual Boolean IsCompatibleWithWindows10 { get; set; }
        public virtual Boolean IsCompatibleWithAndroid { get; set; }
        public virtual Boolean IsCompatibleWithiPhone { get; set; }
        public virtual Boolean IsCompatibleWithXbox { get; set; }
        public virtual Boolean IsCompatibleWithSurfaceHub { get; set; }
        public virtual Boolean IsCompatibleWithHoloLens { get; set; }
    }
}
