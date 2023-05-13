using vtnCore.Classes;
using vtnCore.Repository;

namespace vtnCore.Methods
{
    public class Delete {
        public void DeleteEbook(int xId)
        {
            Ebook obj = new Ebook();
            EbookRepository repo = new EbookRepository();
            obj.Id = xId;
            repo.Delete(obj);
        }
        public void DeleteEmail(int xId)
        {
            Email obj = new Email();
            EmailRepository repo = new EmailRepository();
            obj.Id = xId;
            repo.Delete(obj);
        }
        public void DeleteOneNote(int xId)
        {
            OneNote obj = new OneNote();
            OneNoteRepository repo = new OneNoteRepository();
            obj.Id = xId;
            repo.Delete(obj);
        }
        public void DeleteEvento(int xId)
        {
            Evento obj = new Evento();
            EventoRepository repo = new EventoRepository();
            obj.Id = xId;
            repo.Delete(obj);
        }
    }
}
