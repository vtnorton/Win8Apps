namespace ProjectCachoeiro.Web.Util
{
    public class Util
    {
        public static string RetornarEndereco(string endereco, int numero, string complemente, string cidade, string estado, string cep)
        {
            string retornar = endereco + " Nº " + numero;

            if (!string.IsNullOrEmpty(complemente))
                retornar += " (" + complemente + ")";

            if (!string.IsNullOrEmpty(cidade))
            {
                if (!string.IsNullOrEmpty(estado))
                    retornar += ", " + cidade + "/" + estado;
                else
                    retornar += ", " + cidade;
            }

            if (!string.IsNullOrEmpty(cep))
                retornar += " (" + cep + ")";

            return retornar;
        }
    }
}
