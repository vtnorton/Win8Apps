using ProjectCachoeiro.Web.Util;
using ProjectCachoeiro.Web.Exceptions;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectCachoeiro.Web.Models.Utilitarios
{
    public class Imagem : LogEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        [Required]
        [Display(Name = "Url da imagem")]
        [DataType(DataType.ImageUrl)]
        public string URL { get; set; }

        public string Alt { get; set; }

        [DataType(DataType.MultilineText)]
        public string Legenda { get; set; }

        [Display(Name = "Cor predominante")]
        public string CorPredominante { get; set; }

        public string Tags { get; set; }

        public Imagem()
        {

        }
    }
}
