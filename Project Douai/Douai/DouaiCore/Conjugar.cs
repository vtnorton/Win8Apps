using DouaiCore.Classes;

namespace DouaiCore
{
    public class Conjugar
    {
        public static Verbo Conjugador(string verbo)
        {
            if (!Check.EhVerboIrregular(verbo))
                return ConjugadorRegular(verbo);
            else
                return ConjugadorIrregular(verbo);
        }

        public static Verbo ConjugadorRegular(string verbo)
        {
            string Radical = PegarRadical(verbo);
            Verbo sendoConjugado = new Verbo()
            {
                Nome = verbo
            };
            if (verbo.EndsWith("ar"))
            {
                sendoConjugado.Principal = "infinitivo: " + verbo + "\ngerúndio: " + Radical + "ando\nparticípio: " + Radical + "ado";
                sendoConjugado.Presente = "eu " + Radical + "o \ntu " + Radical + "as \nele " + Radical + "a \nnós " + Radical + "amos \nvós " + Radical + "ais \neles " + Radical + "am";
                sendoConjugado.PreteritoImperfeito = "eu " + Radical + "ava \ntu " + Radical + "avas \nele/ela " + Radical + "ava \nnós " + Radical + "ávamos \nvós " + Radical + "áveis \neles/elas " + Radical + "avam";
                sendoConjugado.PreteritoPerfeito = "eu " + Radical + "ei \ntu " + Radical + "aste \nele/ela " + Radical + "ou \nnós " + Radical + "amos \nvós " + Radical + "astes \neles/elas " + Radical + "aram";
                sendoConjugado.PreteritoMaisQuePerfeito = "eu " + Radical + "ara \ntu " + Radical + "aras \nele/ela " + Radical + "ara \nnós " + Radical + "áramos \nvós " + Radical + "áreis \neles/elas " + Radical + "aram";
                sendoConjugado.FuturoDoPresente = "eu " + Radical + "arei \ntu " + Radical + "arás \nele/ela " + Radical + "ará \nnós " + Radical + "aremos \nvós " + Radical + "areis \neles/elas " + Radical + "arão";
                sendoConjugado.FuturoDoPreterito = "eu " + Radical + "aria \ntu " + Radical + "arias \nele/ela " + Radical + "aria \nnós " + Radical + "aríamos \nvós " + Radical + "aríeis \neles " + Radical + "ariam";
                sendoConjugado.PresenteDoSubjuntivo = "eu " + Radical + "e \ntu " + Radical + "es \nele/ela " + Radical + "e \nnós " + Radical + "emos \nvós " + Radical + "eis \nele/elass " + Radical + "em";
                sendoConjugado.PreteritoImperfeitoDoSubjuntivo = "eu " + Radical + "asse \ntu " + Radical + "assses \nele/ela " + Radical + "asse \nnós " + Radical + "ássemos \nvós " + Radical + "ásseis \neles/elas " + Radical + "assem";
                sendoConjugado.FuturoDoSubjuntivo = "eu " + Radical + "ar \ntu " + Radical + "ares \nele/ela " + Radical + "ar \nnós " + Radical + "armos \nvós " + Radical + "ardes \neles/elas " + Radical + "arem";
                sendoConjugado.ImperativoAfirmativo = "--- eu\n" + Radical + "a tu\n" + Radical + "e ele/ela\n" + Radical + "emos nós\n" + Radical + "ai vós\n" + Radical + "em eles/elas";
                sendoConjugado.ImperativoNegativo = "não --- eu\nnão " + Radical + "ues tu\nnão " + Radical + "ue ele/ela\nnão " + Radical + "uemos nós\nnão " + Radical + "ueis vós\nnão " + Radical + "uem eles/elas";
                sendoConjugado.InfinitivoPessoal = "para " + Radical + "ar eu\npara " + Radical + "ares tu\npara " + Radical + "ar ele/ela\npara " + Radical + "armos nós\npara " + Radical + "ardes vós\npara" + Radical + "arem eles/elas";
            }
            else if (verbo.EndsWith("er"))
            {
                sendoConjugado.Principal = "infinitivo: " + verbo + "\ngerúndio: " + Radical + "endo\nparticípio: " + Radical + "ito";
                sendoConjugado.Presente = "eu " + Radical + "o \ntu " + Radical + "es \nele/ela " + Radical + "e \nnós " + Radical + "emos \nvós " + Radical + "eis \neles/elas " + Radical + "em";
                sendoConjugado.PreteritoImperfeito = "eu " + Radical + "ia \ntu " + Radical + "ias \nele/ela " + Radical + "ia \nnós " + Radical + "iamos \nvós " + Radical + "ieis \neles/elas " + Radical + "iam";
                sendoConjugado.PreteritoPerfeito = "eu " + Radical + "i \ntu " + Radical + "este \nele/ela " + Radical + "eu \nnós " + Radical + "emos \nvós " + Radical + "estes \neles/elas " + Radical + "eram";
                sendoConjugado.PreteritoMaisQuePerfeito = "eu " + Radical + "era \ntu " + Radical + "eras \nele/ela " + Radical + "era \nnós " + Radical + "êramos \nvós " + Radical + "êreis \neles/elas " + Radical + "eram";
                sendoConjugado.FuturoDoPresente = "eu " + Radical + "erei \ntu " + Radical + "erás \nele/ela " + Radical + "erá \nnós " + Radical + "eremos \nvós " + Radical + "ereis \neles/elas " + Radical + "erão";
                sendoConjugado.FuturoDoPreterito = "eu " + Radical + "eria \ntu " + Radical + "erias \nele/ela " + Radical + "eria \nnós " + Radical + "eríamos \nvós " + Radical + "eríeis \neles/elas " + Radical + "eriam";
                sendoConjugado.PresenteDoSubjuntivo = "eu " + Radical + "a \ntu " + Radical + "as \nele/ela " + Radical + "a \nnós " + Radical + "amos \nvós " + Radical + "ais \neles/elas " + Radical + "am";
                sendoConjugado.PreteritoImperfeitoDoSubjuntivo = "eu " + Radical + "esse \ntu " + Radical + "essses \nele " + Radical + "esse \nnós " + Radical + "êssemos \nvós " + Radical + "êsseis \neles/elas " + Radical + "essem";
                sendoConjugado.FuturoDoSubjuntivo = "eu " + Radical + "er \ntu " + Radical + "eres \nele/ela " + Radical + "er \nnós " + Radical + "ermos \nvós " + Radical + "erdes \neles " + Radical + "erem/elas";
                sendoConjugado.ImperativoAfirmativo = "--- eu\n" + Radical + "e tu\n" + Radical + "a ele/ela\n" + Radical + "amos nós\n" + Radical + "ei vós\n" + Radical + "am eles/elas";
                sendoConjugado.ImperativoNegativo = "não --- eu\nnão " + Radical + "as tu\nnão " + Radical + "a ele/ela\nnão " + Radical + "amos nós\nnão " + Radical + "ais vós\nnão " + Radical + "am eles/elas";
                sendoConjugado.InfinitivoPessoal = "para " + Radical + "er eu\npara " + Radical + "eres tu\npara " + Radical + "er ele/ela\npara " + Radical + "ermos nós\npara " + Radical + "erdes vós\npara" + Radical + "erem eles/elas";
            }
            else
            {
                sendoConjugado.Principal = "infinitivo: " + verbo + "\ngerúndio: " + Radical + "indo\nparticípio: " + Radical + "ido";
                sendoConjugado.Presente = "eu " + Radical + "o \ntu " + Radical + "es \nele/ela " + Radical + "e \nnós " + Radical + "imos \nvós " + Radical + "is \neles/elas " + Radical + "em";
                sendoConjugado.PreteritoImperfeito = "eu " + Radical + "ia \ntu " + Radical + "ias \nele/ela " + Radical + "ia \nnós " + Radical + "iamos \nvós " + Radical + "ieis \neles/elas " + Radical + "iam";
                sendoConjugado.PreteritoPerfeito = "eu " + Radical + "i \ntu " + Radical + "iste \nele/ela " + Radical + "iu \nnós " + Radical + "imos \nvós " + Radical + "istes \neles/elas " + Radical + "iram";
                sendoConjugado.PreteritoMaisQuePerfeito = "eu " + Radical + "ira \ntu " + Radical + "iras \nele/ela " + Radical + "ira \nnós " + Radical + "íramos \nvós " + Radical + "íreis \neles/elas " + Radical + "iram";
                sendoConjugado.FuturoDoPresente = "eu " + Radical + "irei \ntu " + Radical + "irás \nele/ela " + Radical + "irá \nnós " + Radical + "iremos \nvós " + Radical + "ireis \neles/elas " + Radical + "irão";
                sendoConjugado.FuturoDoPreterito = "eu " + Radical + "iria \ntu " + Radical + "irias \nele/ela " + Radical + "iria \nnós " + Radical + "iríamos \nvós " + Radical + "iríeis \neles/elas " + Radical + "iriam";
                sendoConjugado.PresenteDoSubjuntivo = "eu " + Radical + "a \ntu " + Radical + "as \nele/ela " + Radical + "a \nnós " + Radical + "amos \nvós " + Radical + "ais \neles/elas " + Radical + "am";
                sendoConjugado.PreteritoImperfeitoDoSubjuntivo = "eu " + Radical + "isse \ntu " + Radical + "issses \nele/ela " + Radical + "isse \nnós " + Radical + "íssemos \nvós " + Radical + "ísseis \neles/elas " + Radical + "issem";
                sendoConjugado.FuturoDoSubjuntivo = "eu " + Radical + "ir \ntu " + Radical + "ires \nele/ela " + Radical + "ir \nnós " + Radical + "irmos \nvós " + Radical + "irdes \neles/elas " + Radical + "irem";
                sendoConjugado.ImperativoAfirmativo = "--- eu\n" + Radical + "e tu\n" + Radical + "a ele/ela\n" + Radical + "amos nós\n" + Radical + "i vós\n" + Radical + "am eles/elas";
                sendoConjugado.ImperativoNegativo = "não --- eu\nnão " + Radical + "as tu\nnão " + Radical + "a ele/ela\nnão " + Radical + "amos nós\nnão " + Radical + "ais vós\nnão " + Radical + "am eles/elas";
                sendoConjugado.InfinitivoPessoal = "para " + Radical + "ir eu\npara " + Radical + "ires tu\npara " + Radical + "ir ele/ela\npara " + Radical + "irmos nós\npara " + Radical + "irdes vós\npara" + Radical + "irem eles/elas";
            }
            
            return sendoConjugado;
        }

        public static Verbo ConjugadorIrregular(string verbo)
        {
            Verbo toReturn = new Verbo();
            foreach (var item in Irregulares.listaVerbosIrregulares())
            {
                if (item.Nome == verbo)
                    toReturn = item.Conjugacoes;
            }
            return toReturn;
        }

        private static string PegarRadical(string verbo)
        {
            return verbo.Substring(0, verbo.Length - 2).ToLower();
        }
    }
}
