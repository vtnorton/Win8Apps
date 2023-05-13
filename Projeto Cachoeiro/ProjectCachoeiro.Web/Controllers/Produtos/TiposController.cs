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
    public class TiposController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Manage/Sistema/Propriedades/Tipos/";
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TiposController(ApplicationDbContext context,
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
            return Json(_context.Tipo.Where(c => c.CompanyId == user.CompanyId).ToDataSourceResult(request));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Tipo> itempraatualizar)
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
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, Tipo model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
        
        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
                return NotFound();

            var tipo = await _context.Tipo.SingleOrDefaultAsync(m => m.Id == id);
            if (tipo == null)
                return NotFound();

            return View(ViewURI + "Detalhes.cshtml", tipo);
        }
        
        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("Nome,Sigla,Descricao")] Tipo tipo)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (_context.Tipo.Where(c => c.CompanyId == user.CompanyId).Any(contem => contem.Nome == tipo.Nome))
                ModelState.AddModelError("", "Já existe um item cadastrado com esse nome");
            if (ModelState.IsValid)
            {
                tipo.CompanyId = user.CompanyId;
                _context.Add(tipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Criar.cshtml", tipo);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var tipo = await _context.Tipo.SingleOrDefaultAsync(m => m.Id == id);
            if (tipo == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", tipo);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nome,Sigla,Descricao")] Tipo tipo)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (id != tipo.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    tipo.CompanyId = user.CompanyId;
                    _context.Update(tipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoExists(tipo.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", tipo);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Tipo.Remove(_context.Tipo.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private bool TipoExists(int id)
        {
            return _context.Tipo.Any(e => e.Id == id);
        }
    }
}
