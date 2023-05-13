using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hidra.Resultados
{
    public class Bing
    {
        public static String Resultado(String StringDePesquisa)
        {
            String StringDeRetorno;
            int NumeroDeResultados = 1; //Retorna o número de resultados;
            if (NumeroDeResultados != 0)
            {
                StringDeRetorno = "Encontramos " + NumeroDeResultados + " resultado(s).  <br />";
            }
            else
            {
                StringDeRetorno = "Nada encontrado no Bing. <br />";
            }
            return StringDeRetorno;
        }
    }
}
