using System;

namespace DouaiCore
{
    public class Samples
    {
        private static string[] Exemplo = { "" };

        public static string SortearExemplo()
        {
            Random randomSortearExemplo = new Random();
            return Exemplo[randomSortearExemplo.Next(0, Exemplo.Length - 1)];
        }
    }
}
