using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Classes
{
    public class AdmUser: Usuario
    {
        public bool Verificado { get; set; }
        public string NivelAcesso { get; set; }
        public string Cidade { get; set; }
        public string NivelDeEscolaridade { get; set; }
    }
}
