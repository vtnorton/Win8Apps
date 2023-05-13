using Microsoft.AspNetCore.Mvc;
using ProjectCachoeiro.Web.Models.Utilitarios;
using System.ComponentModel.DataAnnotations;

namespace ProjectCachoeiro.Web.Models
{
    public class Invite : LogEntity
    {
        public int Id { get; set; }

        [Required]
        public int CompanyId { get; set; }
        public bool Valido { get; set; }

        [Remote("IsExist", "Email", ErrorMessage = "Este e-mail já possui convite")]
        public string Email { get; set; }
        public string Type { get; set; }
    }
}
