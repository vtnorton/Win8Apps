using ProjectCachoeiro.Web.Models.Utilitarios;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ProjectCachoeiro.Web.Models.Produtos
{
    public class Produto : LogEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        [Display(Name = "Número do bloco")]
        public int NumeroBloco { get; set; }
        [Display(Name = "Código do produto")]
        public string CodigoProduto { get; set; }
        
        [Display(Name ="Disponibilidade em estoque")]
        public bool DisponivelEmEstoque { get; set; }

        [Required]
        [Display(Name = "Título")]
        [MaxLength(100, ErrorMessage = "O título não pode ter mais do que 100 dígitos")]
        public string Titulo { get; set; }

        [Display(Name = "Nome a ser exibido")]
        [MaxLength(50, ErrorMessage = "O nome a ser exibido não pode ter mais do que 50 dígitos")]
        public string DisplayName { get; set; }
        
        [Display(Name = "Código NCM")]
        public string CodigoNCM { get; set; }
        
        [Display(Name = "Código EAN")]
        public string CodigoEAN { get; set; }

        [Display(Name = "Observações")]
        [DataType(DataType.MultilineText)]
        [MaxLength(1000, ErrorMessage = "As observações não podem possuir mais de 1000 caracteres")]
        public string Observacoes { get; set; }

        [Required]
        [Display(Name = "Preço de venda")]
        [DataType(DataType.Currency)]
        public decimal PrecoVenda { get; set; }

        [Required]
        [Display(Name = "Preço de custo")]
        [DataType(DataType.Currency)]
        public decimal PrecoCusto { get; set; }

        public decimal Peso { get; set; }
        public decimal Largura { get; set; }
        public decimal Altura { get; set; }
        public decimal Comprimento { get; set; }

        //TODO: Adicionar data de entrada através do sistema
        public DateTime DataDeEntrada { get; set; }
        public bool Resinado { get; set; }

        public int IdStatus { get; set; }
        public int IdFamilia { get; set; }
        public int IdEspessura { get; set; }
        public int IdMaterial { get; set; }
        public int IdQualidade { get; set; }
        public int IdCor { get; set; }
        public int IdTipo { get; set; }
        public int IdImagemPrincipal { get; set; }
        public int IdProdutoDerivado { get; set; }

        public string GetName { get
            {
                if (string.IsNullOrEmpty(DisplayName))
                    return Titulo;
                else
                    return DisplayName;
            }
        }

        public string GetPreco
        {
            get
            {
                return string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", PrecoVenda);
            }
        }

        public decimal GetMetragemAoQuadrado
        {
            get
            {
                return Largura * Altura;
            }
        }

        public decimal GetMetragemAoCubo
        {
            get
            {
                return Largura * Altura * Comprimento;
            }
        }

        public Produto()
        {

        }
        
    }
}
