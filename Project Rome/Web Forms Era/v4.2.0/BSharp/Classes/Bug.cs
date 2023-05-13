using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSharp.Classes
{
    public class Bug
    {
        public virtual int Id { get; set; }
        public virtual int Upvotes { get; set; }
        public virtual String Date { get; set; }
        public virtual String Project { get; set; }
        public virtual String Menssage { get; set; }
        public virtual String Status { get; set; } //"Em andamento", "Recebido", "Cancelado", "Concluído", "Disponível na atualização", "Não recebido"
        public virtual String StatusCSSClass { get; set; } //".goingon", ".recived", ".canceled", ".done", ".nextupdate", ".nonrecived"
        public virtual String Email { get; set; }
        public virtual String Type { get; set; } //"Problema", "Sugestão"
    }
}
