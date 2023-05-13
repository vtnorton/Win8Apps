using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCachoeiro.Web.Data;
using ProjectCachoeiro.Web.Models;
using ProjectCachoeiro.Web.Models.Produtos;

namespace ProjectCachoeiro.Web.Controllers.Produtos
{
    [Authorize(Roles = "Admin")]
    public class CorsController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Manage/Sistema/Propriedades/Cores/";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public CorsController(ApplicationDbContext context,
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
            return Json(_context.Cor.Where(c => c.CompanyId == user.CompanyId).ToDataSourceResult(request));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Cor> itempraatualizar)
        {
            if (itempraatualizar != null && ModelState.IsValid)
            {
                foreach (var item in itempraatualizar)
                {
                    _context.Update(item);
                }
            }
            await _context.SaveChangesAsync();
            return Json(itempraatualizar.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, Cor model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
        
        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
                return NotFound();

            var cor = await _context.Cor.SingleOrDefaultAsync(m => m.Id == id);
            if (cor == null)
                return NotFound();

            return View(ViewURI + "Detalhes.cshtml", cor);
        }
        
        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("CompanyId,Sigla,Nome,Descricao")] Cor cor)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (_context.Cor.Where(c => c.CompanyId == user.CompanyId).Any(contem => contem.Nome == cor.Nome))
                ModelState.AddModelError("", "Já existe um item cadastrado com esse nome");
            if (ModelState.IsValid)
            {
                cor.CompanyId = user.CompanyId;
                _context.Add(cor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Criar.cshtml",cor);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var cor = await _context.Cor.SingleOrDefaultAsync(m => m.Id == id);
            if (cor == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", cor);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,CompanyId,Sigla,Nome,Descricao")] Cor cor)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (id != cor.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    cor.CompanyId = user.CompanyId;
                    _context.Update(cor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CorExists(cor.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", cor);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Cor.Remove(_context.Cor.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private bool CorExists(int id)
        {
            return _context.Cor.Any(e => e.Id == id);
        }
    }
}
