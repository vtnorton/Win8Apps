using ProjectCachoeiro.Web.Models.Utilitarios;
using System.ComponentModel.DataAnnotations;

namespace ProjectCachoeiro.Web.Comercial
{
    public class Cliente : LogEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        [Display(Name = "Razão social")]
        [MaxLength(100, ErrorMessage = "A razão social não pode ter mais do que 100 caracteres")]
        public string RazaoSocial { get; set; }

        [Required]
        [Display(Name = "Nome fantasia")]
        [MaxLength(100, ErrorMessage = "O nome fantasia da empresa não pode ter mais do que 100 caracteres")]
        public string NomeFantasia { get; set; }

        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }
        [Display(Name = "Inscrição estadual")]
        public string InscricaoEstadual { get; set; }

        [Display(Name = "Descrição")]
        [DataType(DataType.MultilineText)]
        [MaxLength(1000, ErrorMessage = "A descrição não pode ter mais do que 1000 caracteres")]
        public string Descricao { get; set; }
        
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
        
        [DataType(DataType.Url)]
        public string Site { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailContato { get; set; }

        public int IdLogoEmpresa { get; set; }

        public Cliente()
        {

        }

        public string GetName
        {
            get
            {

                if (string.IsNullOrEmpty(NomeFantasia))
                    return RazaoSocial;
                else
                    return NomeFantasia;
            }
        }

        public string GetEndereco => Util.Util.RetornarEndereco(Endereco, Numero, Complemento, Cidade, Estado, CEP);
    }
}
