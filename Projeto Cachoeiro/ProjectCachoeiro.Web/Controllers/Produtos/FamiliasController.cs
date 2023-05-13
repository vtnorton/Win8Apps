using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCachoeiro.Web.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ProjectCachoeiro.Web.Models;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using ProjectCachoeiro.Web.Models.Produtos;
using System.Collections.Generic;
using ProjectCachoeiro.Web.Models.Utilitarios;

namespace ProjectCachoeiro.Web.Controllers.Produtos
{
    [Authorize(Roles = "Admin")]
    public class FamiliasController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Manage/Sistema/Propriedades/Familias/";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public FamiliasController(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        
        public IActionResult Index()
        {
            ViewData["tipos"] = TiposFamilia();
            return View(ViewURI + "Index.cshtml");
        }

        public IActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            return Json(_context.Familia.Where(c => c.CompanyId == user.CompanyId).ToDataSourceResult(request));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Familia> itempraatualizar)
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
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, Familia model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
        
        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
                return NotFound();

            var familia = await _context.Familia.SingleOrDefaultAsync(m => m.Id == id);

            if (familia == null)
                return NotFound();

            return View(ViewURI + "Detalhes.cshtml", familia);
        }
        
        public IActionResult Criar()
        {
            ViewData["tipos"] = TiposFamilia();
            return View(ViewURI + "Criar.cshtml");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("Nome,Sigla,Type,Observacao")] Familia familia)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ViewData["tipos"] = TiposFamilia();

            //TODO: Precisa adicionar isso também na pagina de edição
            if (_context.Familia.Where(c => c.CompanyId == user.CompanyId).Any(contem => contem.Nome == familia.Nome))
                ModelState.AddModelError("", "Já existe um item cadastrado com esse nome");

            if (ModelState.IsValid)
            {
                familia.CompanyId = user.CompanyId;
                _context.Add(familia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Criar.cshtml", familia);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            ViewData["tipos"] = TiposFamilia();

            if (id == null)
                return NotFound();

            var familia = await _context.Familia.SingleOrDefaultAsync(m => m.Id == id);
            if (familia == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", familia);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nome,Sigla,Type,Observacao")] Familia familia)
        {
            ViewData["tipos"] = TiposFamilia();

            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (id != familia.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    familia.CompanyId = user.CompanyId;
                    _context.Update(familia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FamiliaExists(familia.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", familia);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Familia.Remove(_context.Familia.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private bool FamiliaExists(int id)
        {
            return _context.Familia.Any(e => e.Id == id);
        }
        private List<TipoFamilia> TiposFamilia()
        {
            return new List<TipoFamilia>() {
                new TipoFamilia() { Name = "Primário", Type = 1},
                new TipoFamilia() { Name = "Secundário", Type = 2},
                new TipoFamilia() { Name = "Terciário", Type = 3},
            };
        }
    }
}
