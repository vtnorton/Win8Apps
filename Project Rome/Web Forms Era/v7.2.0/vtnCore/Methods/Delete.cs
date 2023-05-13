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
        public void DeleteEnviados(int xId)
        {
            Enviados obj = new Enviados();
            EnviadosRepository repo = new EnviadosRepository();
            obj.Id = xId;
            repo.Delete(obj);
        }
        public void DeleteLista(int xId)
        {
            ListaEmails obj = new ListaEmails();
            ListaEmailsRepository repo = new ListaEmailsRepository();
            obj.Id = xId;
            repo.Delete(obj);
        }
        public void DeleteTema(int xId)
        {
            Temas obj = new Temas();
            TemaRepository repo = new TemaRepository();
            obj.Id = xId;
            repo.Delete(obj);
        }
    }
}
