using DouaiCore.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

namespace DouaiIrregularMake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Criador de verbos irregulares v1.2";
            Console.WriteLine("==== CRIADOR DE VERBOS IRREGULARES ====");
            Console.WriteLine("==== Projeto: Douai                ====");
            Console.WriteLine("[1] Criar verbos irregulares");
            Console.WriteLine("[2] Listar número de conjugações");
            Console.WriteLine("[3] Criar tabela de verbos irregulares");
            Console.Write("Opção: ");
            int resposta = int.Parse(Console.ReadLine());
            if (resposta == 1)
                CriarVerbosIrregulares();
            else if (resposta == 2)
                Listar();
            else if (resposta == 3)
                CriarTabela();
            else
            {
                Console.WriteLine("Você digitou algo errado, o programa deverá fechado.");
                Console.Read();
            }
        }

        public static void CriarTabela()
        {
            Console.WriteLine("Criando verbos irregulares");

            List<VerboIrregular> verbosIrregulares = new List<VerboIrregular>();
            verbosIrregulares = Irregulares.listaVerbosIrregulares();

            int NumeroDeVerbos = Irregulares.listaVerbosIrregulares().Count - 1;
            string inicio = "<!DOCTYPE html><html lang='en' xmlns='http://www.w3.org/1999/xhtml'><head><link href='heartthrob.css' rel='stylesheet' /><meta charset='utf-8' /><title>Verbos Irregulares | Project Douai</title></head><body style='padding:30px'>";

            using (StreamWriter escritor = new StreamWriter("ListaIrregulares.html"))
            {
                escritor.WriteLine(inicio);
                foreach (var item in verbosIrregulares)
                {
                    Console.WriteLine("Processando verbo: " + item.Nome);
                    escritor.WriteLine("<h2 class='text-center'>" + item.Nome + "</h2><br/>");
                    escritor.WriteLine("<table margin='10' class='table-condensed'>");
                    escritor.WriteLine("<tr><thead><td width='200'>Tempo</td><td>Eu</td><td>Tu</td><td>Ele</td><td>Nós</td><td>Vós</td><td>Eles</td></tr></thead><tbody>");
                    escritor.WriteLine("<tr><td>Presente</td><td>" + item.Conjugacoes.Presente.Replace("\n", "</td><td>") + "</td><tr>");
                    escritor.WriteLine("<tr><td>PreteritoImperfeito</td><td>" + item.Conjugacoes.PreteritoImperfeito.Replace("\n", "</td><td>") + "</td><tr>");
                    escritor.WriteLine("<tr><td>PreteritoPerfeito</td><td>" + item.Conjugacoes.PreteritoPerfeito.Replace("\n", "</td><td>") + "</td><tr>");
                    escritor.WriteLine("<tr><td>PreteritoMaisQuePerfeito</td><td>" + item.Conjugacoes.PreteritoMaisQuePerfeito.Replace("\n", "</td><td>") + "</td><tr>");
                    escritor.WriteLine("<tr><td>FuturoDoPresente</td><td>" + item.Conjugacoes.FuturoDoPresente.Replace("\n", "</td><td>") + "</td><tr>");
                    escritor.WriteLine("<tr><td>FuturoDoPreterito</td><td>" + item.Conjugacoes.FuturoDoPreterito.Replace("\n", "</td><td>") + "</td><tr>");
                    escritor.WriteLine("<tr><td>PresenteDoSubjuntivo</td><td>" + item.Conjugacoes.PresenteDoSubjuntivo.Replace("\n", "</td><td>") + "</td><tr>");
                    escritor.WriteLine("<tr><td>PreteritoImperfeitoDoSubjuntivo</td><td>" + item.Conjugacoes.PreteritoImperfeitoDoSubjuntivo.Replace("\n", "</td><td>") + "</td><tr>");
                    escritor.WriteLine("<tr><td>FuturoDoSubjuntivo</td><td>" + item.Conjugacoes.FuturoDoSubjuntivo.Replace("\n", "</td><td>") + "</td><tr>");
                    escritor.WriteLine("<tr><td>ImperativoAfirmativo</td><td>" + item.Conjugacoes.ImperativoAfirmativo.Replace("\n", "</td><td>") + "</td><tr>");
                    escritor.WriteLine("<tr><td>ImperativoNegativo</td><td>" + item.Conjugacoes.ImperativoNegativo.Replace("\n", "</td><td>") + "</td><tr>");
                    escritor.WriteLine("<tr><td>InfinitivoPessoal</td><td>" + item.Conjugacoes.InfinitivoPessoal.Replace("\n", "</td><td>") + "</td></tr></tbody>");
                    escritor.WriteLine("</table><br />");
                }
                escritor.WriteLine("<p class='text-center'>Projeto Douai | Confidencial</p></body></html>");
            }
            Console.WriteLine("Verbos irregulares criados com sucesso em ListaIrregulares.html");
            Console.Read();
        }

        public static void Listar()
        {
            List<VerboIrregular> verbosIrregulares = new List<VerboIrregular>();
            verbosIrregulares = Irregulares.listaVerbosIrregulares();

            foreach (var item in verbosIrregulares)
            {
                int NumeroConjugacoes = item.Conjugacoes.FuturoDoPresente.Length +
                    item.Conjugacoes.FuturoDoPreterito.Length + item.Conjugacoes.FuturoDoSubjuntivo.Length +
                    item.Conjugacoes.ImperativoAfirmativo.Length + item.Conjugacoes.ImperativoNegativo.Length +
                    item.Conjugacoes.InfinitivoPessoal.Length + item.Conjugacoes.Presente.Length +
                    item.Conjugacoes.PresenteDoSubjuntivo.Length + item.Conjugacoes.PreteritoImperfeito.Length +
                    item.Conjugacoes.PreteritoImperfeitoDoSubjuntivo.Length + item.Conjugacoes.PreteritoMaisQuePerfeito.Length +
                    item.Conjugacoes.PreteritoPerfeito.Length + item.Conjugacoes.Principal.Length;
                Console.WriteLine(item.Nome + " - " + NumeroConjugacoes);
            }
            Console.Read();
        }

        public static void CriarVerbosIrregulares()
        {
            int NumeroDeVerbos = Irregulares.listaVerbosIrregulares().Count - 1;
            float porcentage;
            string escrever, errono = "Verbos com erro: ";
            List<string> verbosIrregulares = Irregulares.verboIrregulares();

            using (StreamWriter escritor = new StreamWriter("Irregulares.txt"))
            {
                for (int i = 0; i <= NumeroDeVerbos; i++)
                {
                    porcentage = (((float)i * 100) / NumeroDeVerbos) / 100;
                    Console.Write("Processando: " + i.ToString("000") + "/" + NumeroDeVerbos + " - " + porcentage.ToString("00.00%") + " - Verbo: " + verbosIrregulares[i] + ": ");

                    try
                    {
                        escrever = "public static string[] " + verbosIrregulares[i] + " = { \"" + verbosIrregulares[i] + "\",";

                        using (var client = new WebClient())
                        {
                            string contents = client.DownloadString("https://www.conjugacao.com.br/verbo-"+ verbosIrregulares[i].Replace("ç", "c") + "/");
                            string contentOhter = client.DownloadString("http://www.conjuga-me.net/verbo-"+ verbosIrregulares[i].Replace("ç", "c"));

                            contents = contents.Replace(Environment.NewLine, "");
                            contents = contents.Replace(" irregular", "");

                            escrever += "\"" + contentOhter.GetBetween("<span class=\"gerundio\">Gerúndio: </span>", "</td></tr>").Trim() + "\",";
                            escrever += "\"" + contentOhter.GetBetween("<span class=\"gerundio\">Particípio passado: </span> <span class=\"irreg\"><span class=\"irreg\">", "</span></span>").Trim() + "\",";

                            //0: Presente
                            //1: PreteritoImperfeito
                            //2: PreteritoPerfeito
                            //3: PreteritoMaisQuePerfeito
                            //4: FuturoDoPresente
                            //5: FuturoDoPreterito
                            //6: PresenteDoSubjuntivo
                            //7: PreteritoImperfeitoDoSubjuntivo
                            //8: FuturoDoSubjuntivo
                            //9: ImperativoAfirmativo
                            //10: ImperativoNegativo
                            //11: InfinitivoPessoal

                            string[] Conjugacoes =
                            {
                            contents.GetBetween("<h4 class=\"tempo-conjugacao-titulo\">Presente</h4>", "</div><div").Trim(),
                            contents.GetBetween("<h4 class=\"tempo-conjugacao-titulo\">Pretérito Imperfeito</h4>", "</div><div").Trim(),
                            contents.GetBetween("<h4 class=\"tempo-conjugacao-titulo\">Pretérito Perfeito</h4>", "</div><div").Trim(),
                            contents.GetBetween("<h4 class=\"tempo-conjugacao-titulo\">Pretérito Mais-que-perfeito</h4>", "</div><div").Trim(),
                            contents.GetBetween("<h4 class=\"tempo-conjugacao-titulo\">Futuro do Presente</h4>", "</div><div").Trim(),
                            contents.GetBetween("<h4 class=\"tempo-conjugacao-titulo\">Futuro do Pretérito</h4>", "</div><div").Trim(),
                            contents.GetBetweenSubjuntivo("<h4 class=\"tempo-conjugacao-titulo\">Presente</h4>", "</div><div").Trim(),
                            contents.GetBetweenSubjuntivo("<h4 class=\"tempo-conjugacao-titulo\">Pretérito Imperfeito</h4>", "</div><div").Trim(),
                            contents.GetBetweenSubjuntivo("<h4 class=\"tempo-conjugacao-titulo\">Futuro</h4>", "</div><div").Trim(),
                            contents.GetBetween("<h4 class=\"tempo-conjugacao-titulo\">Imperativo Afirmativo</h4>", "</div><div").Trim(),
                            contents.GetBetween("<h4 class=\"tempo-conjugacao-titulo\">Imperativo Negativo</h4>", "</div><div").Trim(),
                            contents.GetBetween("<h4 class=\"tempo-conjugacao-titulo\">Infinitivo Pessoal</h4>", "</div><div").Trim()
                        };

                            for (int y = 0; y < 11; y++)
                            {
                                Conjugacoes[y] = Conjugacoes[y].Replace(" ", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("tu", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("eles", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("ele", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("nós", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("vós", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("<span>eu</span>", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("<span>", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("quando</span>", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("se</span>", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("não</span>", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("seeu</span>", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("queeu</span>", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("quandoeu</span>", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("</span>", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("</br>", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("</div>", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("</p>", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("<p>", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("<span", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("class=\"f\">", "");
                                Conjugacoes[y] = Conjugacoes[y].Replace("\n", "\", \"");

                                escrever += "\"" + Conjugacoes[y] + "\",";
                            }
                        }

                        escrever += "};";
                        escrever.Replace(",};", "};");
                        escritor.WriteLine(escrever);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.ResetColor();
                        Console.WriteLine("concluído.");
                    }
                    catch (Exception ex)
                    {
                        errono += verbosIrregulares[i] + ", ";
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erro: " + ex.Message);
                        Console.ResetColor();
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Concluído com sucesso");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errono);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
