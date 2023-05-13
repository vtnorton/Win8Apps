using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectCachoeiro.Web.Models.Utilitarios
{
    public class LogEntity
    {
        [Display(Name = "Criado em")]
        public string DateCreated { get; set; }

        [Display(Name = "Criado por")]
        public string UserCreated { get; set; }

        [Display(Name = "Atualizado em")]
        public string DateModified { get; set; }

        [Display(Name = "Atualizado por")]
        public string UserModified { get; set; }

        //Criado pelo departamento
    }
}
