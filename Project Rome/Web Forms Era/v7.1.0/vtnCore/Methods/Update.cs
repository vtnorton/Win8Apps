using vtnCore.Classes;
using vtnCore.Repository;

namespace vtnCore.Methods
{
    public class Update
    {
        public void NewEvento(int xId, int xDia, int xJaPassou, int xEhOnline, int xAno, string xEndereco, string xNome, string xMes, string xDescricao, string xURL)
        {
            int x;
            Evento objEvento = new Evento();
            EventoRepository repoEvento = new EventoRepository();

            objEvento.Id = xId;
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

            objEvento.Data = xAno + xMes + xDia;

            repoEvento.Update(objEvento);
        }
        public void UpdateEbook(int xId, string xName)
        {
            Ebook objEbook = new Ebook();
            EbookRepository repoEbook = new EbookRepository();

            objEbook.Id = xId;
            objEbook.Name = xName;
            objEbook.Downloads = "0";

            repoEbook.Create(objEbook);
        }
        public void UpdateOneNote(int xId, string xEmail)
        {
            OneNote objOneNote = new OneNote();
            OneNoteRepository repoOneNote = new OneNoteRepository();

            objOneNote.Id = xId;
            objOneNote.Email = xEmail;

            repoOneNote.Update(objOneNote);
        }
    }
}
