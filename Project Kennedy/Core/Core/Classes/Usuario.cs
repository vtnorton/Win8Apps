using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Classes
{
    public class Usuario
    {
        public int ID { get; set; }
        public int IdNivel { get; set; }
        public int IdCidade { get; set; }
        public int Pontuacao { get; set; }
        public int TempoDeUso { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Organizacao { get; set; }
        public string Profissao { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }
        public string LinkFacebook { get; set; }
        public string LinkTwitter { get; set; }
        public string LinkGoogle { get; set; }
        public string LinkLinkeding { get; set; }
        public string LinkSite { get; set; }
        public string URLFoto { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public DateTime DataDoUltimoAcesso { get; set; }
    }
}
