using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSharp.Classes
{
    public class Poll
    {
        public virtual int Id { get; set; }
        public virtual int HowManyInterviews { get; set; }
        public virtual int HowManyAndroidUser { get; set; }
        public virtual int HowManyiOsUser { get; set; }
        public virtual int HowManyWinPhone { get; set; }
        public virtual int HowManyOthers { get; set; }
        public virtual String Emails { get; set; }
        public virtual String Observation { get; set; }
        public virtual String AppIdea { get; set; }
        public virtual String WinPhoneBestFeature { get; set; }
        public virtual String WinPhoneWorstFeature { get; set; }
        public virtual DateTime PollDate { get; set; }
        
    }
}
