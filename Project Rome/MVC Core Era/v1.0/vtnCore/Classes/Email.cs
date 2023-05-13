using System;

namespace vtnCore.Classes
{
    public class Email
    {
        public virtual int Id { get; set; }
        public virtual int IdLista { get; set; }
        public virtual string Mail { get; set; }
        public virtual DateTime Data { get; set; }
    }
}
