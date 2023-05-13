using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BSharp.Methods
{
    
    public class Password
    {
        private int geraPontosSenha(string senha)
        {
            if (senha == null) return 0;
            int pontosPorTamanho = GetPontoPorTamanho(senha);
            int pontosPorMinusculas = GetPontoPorMinusculas(senha);
            int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
            int pontosPorDigitos = GetPontoPorDigitos(senha);
            int pontosPorSimbolos = GetPontoPorSimbolos(senha);
            int pontosPorRepeticao = GetPontoPorRepeticao(senha);
            return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
        }
        private int GetPontoPorTamanho(string senha)
        {
            return Math.Min(10, senha.Length) * 6;
        }
        private int GetPontoPorMinusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }
        private int GetPontoPorMaiusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }
        private int GetPontoPorDigitos(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }
        private int GetPontoPorSimbolos(string senha)
        {
            int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }
        private int GetPontoPorRepeticao(string senha)
        {
            Regex regex = new Regex(@"(\w)*.*\1");
            bool repete = regex.IsMatch(senha);
            if (repete)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }


        public String PasswordVerify(String Senha, int MinLength, int MaxLength, bool Simbol, bool Max, bool Min)
        {
            if((Senha.Length <= MaxLength) && (Senha.Length >= MinLength))
            {
                int placar = geraPontosSenha(Senha);

                if (placar < 50)
                    return "Invalid";
                else if (placar < 60)
                    return "Fraca";
                else if (placar < 80)
                    return "Acceptd";
                else if (placar < 100)
                    return "Strong";
                else
                    return "Saft";

            }
            else
            {
                return "Size Invalid";
            }
        }
    }
}