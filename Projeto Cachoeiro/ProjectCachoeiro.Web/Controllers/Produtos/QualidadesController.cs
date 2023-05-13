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
    public class QualidadesController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Manage/Sistema/Propriedades/Qualidades/";
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public QualidadesController(ApplicationDbContext context,
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
            return Json(_context.Qualidade.Where(c => c.CompanyId == user.CompanyId).ToDataSourceResult(request));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Qualidade> itempraatualizar)
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
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, Qualidade model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
        
        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qualidade = await _context.Qualidade
                .SingleOrDefaultAsync(m => m.Id == id);
            if (qualidade == null)
            {
                return NotFound();
            }

            return View(ViewURI + "Detalhes.cshtml", qualidade);
        }
        
        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("Nome,Sigla,Descricao")] Qualidade qualidade)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (_context.Qualidade.Where(c => c.CompanyId == user.CompanyId).Any(contem => contem.Nome == qualidade.Nome))
                ModelState.AddModelError("", "Já existe um item cadastrado com esse nome");
            if (ModelState.IsValid)
            {
                qualidade.CompanyId = user.CompanyId;
                _context.Add(qualidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Criar.cshtml", qualidade);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var qualidade = await _context.Qualidade.SingleOrDefaultAsync(m => m.Id == id);
            if (qualidade == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", qualidade);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nome,Sigla,Descricao")] Qualidade qualidade)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (id != qualidade.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    qualidade.CompanyId = user.CompanyId;
                    _context.Update(qualidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QualidadeExists(qualidade.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", qualidade);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Qualidade.Remove(_context.Qualidade.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private bool QualidadeExists(int id)
        {
            return _context.Qualidade.Any(e => e.Id == id);
        }
    }
}
