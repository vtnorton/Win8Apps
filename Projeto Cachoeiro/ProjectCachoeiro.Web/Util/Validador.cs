using System.Text.RegularExpressions;

namespace ProjectCachoeiro.Web.Util
{
    public class Validador
    {
        public static bool CheckValidFormatHtmlColor(string inputColor) => Regex.Match(inputColor, "^#?(([0-9a-fA-F]{2}){3}|([0-9a-fA-F]){3})$").Success;

        public static bool ValidarCep(string cep) => Regex.Match(cep, @"^\d{5}\-?\d{3}$").Success;
        public static bool ValidarEmail(string email) => Regex.Match(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$").Success;

        public static bool IsCNPJ(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                int[] digitos, soma, resultado;
                int nrDig;
                string ftmt;
                bool[] cnpjOk;

                cnpj = cnpj.Replace("/", "");
                cnpj = cnpj.Replace(".", "");
                cnpj = cnpj.Replace("-", "");

                if (cnpj == "00000000000000")
                    return false;

                ftmt = "6543298765432";
                digitos = new int[14];

                soma = new int[2];
                soma[0] = 0;
                soma[1] = 0;

                resultado = new int[2];
                resultado[0] = 0;
                resultado[1] = 0;

                cnpjOk = new bool[2];
                cnpjOk[0] = false;
                cnpjOk[1] = false;

                try
                {
                    for (nrDig = 0; nrDig < 14; nrDig++)
                    {
                        digitos[nrDig] = int.Parse(cnpj.Substring(nrDig, 1));

                        if (nrDig <= 11)
                            soma[0] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1)));
                        if (nrDig <= 12)
                            soma[1] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1)));
                    }
                    for (nrDig = 0; nrDig < 2; nrDig++)
                    {
                        resultado[nrDig] = (soma[nrDig] % 11);

                        if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                            cnpjOk[nrDig] = (digitos[12 + nrDig] == 0);
                        else
                            cnpjOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));
                    }
                    return (cnpjOk[0] && cnpjOk[1]);
                }
                catch
                {
                    return false;
                }
            }
            else
                return false;
        }
    }
}
