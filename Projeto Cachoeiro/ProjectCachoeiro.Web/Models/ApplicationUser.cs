using Microsoft.AspNetCore.Identity;
using System;

namespace ProjectCachoeiro.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int CompanyId { get; set; }
        public bool IsSysAdmin { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string Cargo { get; set; }
        public string ProfileImagePath { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public ApplicationUser()
        {
            UserName = Nome;
        }

        public string NomeCompleto { get { return Nome + " " + Sobrenome; } }
    }
}