using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCachoeiro.Web.Data;
using ProjectCachoeiro.Web.Models.Utilitarios;
using Microsoft.AspNetCore.Authorization;

namespace ProjectCachoeiro.Web.Controllers.Utilitarios
{
    [Authorize(Roles = "Admin,User")]
    public class ImagensController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Imagens/";
        private readonly ApplicationDbContext _context;

        public ImagensController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(ViewURI + "Index.cshtml", await _context.Imagem.ToListAsync());
        }
        
        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
                return NotFound();

            var imagem = await _context.Imagem.SingleOrDefaultAsync(m => m.Id == id);
            if (imagem == null)
                return NotFound();

            return View(ViewURI + "Detalhes.cshtml", imagem);
        }
        
        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("URL,Alt,Legenda,CorPredominante,Tags")] Imagem imagem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(imagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Criar.cshtml", imagem);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var imagem = await _context.Imagem.SingleOrDefaultAsync(m => m.Id == id);
            if (imagem == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", imagem);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,URL,Alt,Legenda,CorPredominante,Tags")] Imagem imagem)
        {
            if (id != imagem.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imagem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImagemExists(imagem.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }

            return View(ViewURI + "Editar.cshtml", imagem);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Imagem.Remove(_context.Imagem.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private bool ImagemExists(int id)
        {
            return _context.Imagem.Any(e => e.Id == id);
        }
    }
}
