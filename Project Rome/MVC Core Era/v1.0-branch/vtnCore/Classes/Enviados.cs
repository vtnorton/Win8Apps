using System;

namespace vtnCore.Classes
{
    public class Enviados
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Conteudo { get; set; }
        public virtual string Descrição { get; set; }
        public virtual DateTime Enviado { get; set; }
    }
}
