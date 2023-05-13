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
    [Authorize(Roles = "Admin,User")]
    public class BundlesController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Produtos/Bundles/";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public BundlesController(ApplicationDbContext context,
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
            return Json(_context.Bundle.Where(c => c.IdCompany == user.CompanyId).ToDataSourceResult(request));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Bundles> itempraatualizar)
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
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, Bundles model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
                return NotFound();

            var bundle = await _context.Bundle.SingleOrDefaultAsync(m => m.Id == id);
            if (bundle == null)
                return NotFound();

            return View(ViewURI + "Detalhes.cshtml", bundle);
        }

        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("IdCompany,Codigo,Observacao")] Bundles bundles)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (_context.Bundle.Where(c => c.IdCompany == user.CompanyId).Any(contem => contem.Codigo == bundles.Codigo))
                ModelState.AddModelError("", "Já existe um item cadastrado com esse código.");

            if (ModelState.IsValid)
            {
                bundles.IdCompany = user.CompanyId;
                _context.Add(bundles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Criar.cshtml", bundles);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var bundles = await _context.Bundle.SingleOrDefaultAsync(m => m.Id == id);
            if (bundles == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", bundles);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("IdCompany,Codigo,Observacao")] Bundles bundles)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (id != bundles.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    bundles.IdCompany = user.CompanyId;
                    _context.Update(bundles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BundlesExists(bundles.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", bundles);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Bundle.Remove(_context.Bundle.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
                //TODO: remover também todos os itens deste bundle
                //TODO: fazer isso também em propostas
            }
            catch
            {
                return View();
            }
        }

        private bool BundlesExists(int id)
        {
            return _context.Bundle.Any(e => e.Id == id);
        }
    }
}
