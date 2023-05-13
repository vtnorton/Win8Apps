using System;
using System.Data.SqlClient;
using vtnCore.Classes;
using vtnCore.Repository;

namespace vtnCore.Methods
{
    public class Create
    {
        private SqlConnection conns = new SqlConnection(CoreInformation.ConnectionString);
        
        public void NewEvento(int xDia, int xJaPassou, int xEhOnline, int xAno, string xEndereco, string xNome, string xMes, string xDescricao, string xURL)
        {
            int x = 0;

            Evento objEvento = new Evento();
            EventoRepository repoEvento = new EventoRepository();

            objEvento.Ano = xAno;
            objEvento.Descricao = xDescricao;
            objEvento.Dia = xDia;
            objEvento.EhOnline = xEhOnline;
            objEvento.Endereco = xEndereco;
            objEvento.JaPassou = xJaPassou;
            objEvento.Mes = xMes;
            objEvento.Nome = xNome;
            objEvento.URL = xURL;

            switch (xMes)
            {
                case "Janeiro":
                    x = 101;
                    break;
                case "Fevereiro":
                    x = 102;
                    break;
                case "Março":
                    x = 103;
                    break;
                case "Abril":
                    x = 104;
                    break;
                case "Maio":
                    x = 105;
                    break;
                case "Junho":
                    x = 106;
                    break;
                case "Julho":
                    x = 107;
                    break;
                case "Agosto":
                    x = 108;
                    break;
                case "Setembro":
                    x = 109;
                    break;
                case "Outubro":
                    x = 110;
                    break;
                case "Novembro":
                    x = 111;
                    break;
                case "Dezembro":
                    x = 112;
                    break;
            }

            objEvento.Data = xAno.ToString() + x.ToString() + xDia.ToString();

            repoEvento.Create(objEvento);
        }

        public void NewEbook(string xName)
        {
            Ebook objEbook = new Ebook();
            EbookRepository repoEbook = new EbookRepository();

            objEbook.Name = xName;
            objEbook.Downloads = "0";

            repoEbook.Create(objEbook);
        }
        public void NewOneNote(string xEmail)
        {
            OneNote objOneNote = new OneNote();
            OneNoteRepository repoOneNote = new OneNoteRepository();

            objOneNote.Email = xEmail;

            repoOneNote.Create(objOneNote);
        }
        public void NewEmail(string xEmail)
        {
            Email objEmail = new Email();
            EmailRepository repoEmail = new EmailRepository();

            objEmail.Mail = xEmail;
            objEmail.Data = DateTime.Now.ToString();

            repoEmail.Create(objEmail);
        }
    }
}
