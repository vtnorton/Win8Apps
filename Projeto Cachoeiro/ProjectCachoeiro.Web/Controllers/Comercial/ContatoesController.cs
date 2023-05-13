using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCachoeiro.Web.Data;
using ProjectCachoeiro.Web.Comercial;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ProjectCachoeiro.Web.Models;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace ProjectCachoeiro.Web.Controllers.Comercial
{
    [Authorize(Roles = "Admin,User")]
    public class ContatoesController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Contatos/";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ContatoesController(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        
        public IActionResult Index()
        {
            return View(ViewURI + "Index.cshtml");
        }

        public IActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            return Json(_context.Contato.Where(c => c.CompanyId == user.CompanyId).ToDataSourceResult(request));
        }

        [HttpPost]
        public ActionResult Update([DataSourceRequest] DataSourceRequest request, Contato model)
        {
            _context.Update(model);
            _context.SaveChanges();
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, Contato model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
        
        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
                return NotFound();

            var contato = await _context.Contato.SingleOrDefaultAsync(m => m.Id == id);

            if (contato == null)
                return NotFound();

            return View(ViewURI + "Detalhes.cshtml", contato);
        }
        
        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("PrimeiroNome,UltimoNome,Email,Telefone,Cargo,Observacao")] Contato contato)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (_context.Contato.Where(c => c.CompanyId == user.CompanyId).Any(contem => contem.Email == contato.Email))
                ModelState.AddModelError("", "Já existe um item cadastrado com esse e-mail");
            if (ModelState.IsValid)
            {
                contato.CompanyId = user.CompanyId;
                _context.Add(contato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(ViewURI + "Criar.cshtml", contato);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var contato = await _context.Contato.SingleOrDefaultAsync(m => m.Id == id);
            if (contato == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", contato);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,PrimeiroNome,UltimoNome,Email,Telefone,Cargo,Observacao")] Contato contato)
        {
            if (id != contato.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContatoExists(contato.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", contato);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Contato.Remove(_context.Contato.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private bool ContatoExists(int id)
        {
            return _context.Contato.Any(e => e.Id == id);
        }
    }
}
