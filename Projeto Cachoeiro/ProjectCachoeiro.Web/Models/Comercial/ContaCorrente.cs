using ProjectCachoeiro.Web.Models.Utilitarios;
using System.ComponentModel.DataAnnotations;

namespace ProjectCachoeiro.Web.Models.Comercial
{
    public class ContaCorrente : LogEntity
    {
        public int Id { get; set; }
        public int IdCompany { get; set; }
        public string Banco { get; set; }
        public string Telefone { get; set; }
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Display(Name = "Beneficiário")]
        public string Beneficiario { get; set; }
        [Required]
        public string IBAN { get; set; }
        [Required]
        public string Swift { get; set; }
        [Display(Name = "Branch Swift")]
        public string BranchSwift { get; set; }
        public string Conta { get; set; }
        public string Aba { get; set; }
        public string Observacoes { get; set; }

        [Display(Name = "Endereço")]
        [DataType(DataType.MultilineText)]
        [MaxLength(300, ErrorMessage = "O endereço da empresa não pode ter mais do que 300 caracteres")]
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Pais { get; set; }

        public string GetEndereco => Util.Util.RetornarEndereco(Endereco, Numero, Complemento, Cidade, Estado, CEP);
    }
}
