using ProjectCachoeiro.Web.Models.Utilitarios;
using System.ComponentModel.DataAnnotations;

namespace ProjectCachoeiro.Web.Models.Empresa
{
    public class Company : LogEntity
    {
        public int Id { get; set; }

        [Required]
        public string CNPJ { get; set; }

        [Required]
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

        [StringLength(140, ErrorMessage = "o endereço não pode conter mais de 140 caracteres")]
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        [StringLength(2, ErrorMessage = "O estado não pode conter mais de 2 caracteres")]
        public string Estado { get; set; }

        [StringLength(9, ErrorMessage = "O CEP não pode conter mais de 9 caracteres")]
        public string CEP { get; set; }

        [StringLength(50, ErrorMessage = "A cidade não pode conter mais de 50 caracteres")]
        public string Cidade { get; set; }

        [DataType(DataType.Url)]
        public string Site { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.ImageUrl)]
        public string URLLogonImage { get; set; }

        [DataType(DataType.ImageUrl)]
        public string URLLogo { get; set; }
        public string Slogan { get; set; }

        [EmailAddress]
        public string EmailCadastroSistema { get; set; }

        public string GetEndereco
        {
            get
            {
                return Util.Util.RetornarEndereco(Endereco, Numero, Complemento, Cidade, Estado, CEP);
            }
        }
    }
}
