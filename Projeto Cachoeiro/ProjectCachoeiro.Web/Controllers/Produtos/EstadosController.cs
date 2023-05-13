using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCachoeiro.Web.Data;
using Microsoft.AspNetCore.Authorization;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using ProjectCachoeiro.Web.Models;
using Microsoft.AspNetCore.Identity;
using ProjectCachoeiro.Web.Models.Produtos;
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Controllers.Produtos
{
    [Authorize(Roles = "Admin")]
    public class EstadosController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Manage/Sistema/Propriedades/Estados/";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public EstadosController(ApplicationDbContext context,
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
            return Json(_context.Estado.Where(c => c.CompanyId == user.CompanyId).ToDataSourceResult(request));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Estado> estado)
        {
            if (estado != null && ModelState.IsValid)
            {
                foreach (var item in estado)
                {
                    _context.Update(item);
                }
            }
            await _context.SaveChangesAsync();
            return Json(estado.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, Estado model)
        {
            _context.Estado.Remove(model);
            _context.SaveChanges();
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
                return NotFound();

            var status = await _context.Estado.SingleOrDefaultAsync(m => m.Id == id);
            if (status == null)
                return NotFound();

            return View(ViewURI + "Detalhes.cshtml", status);
        }

        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("Nome,Sigla,Descricao")] Estado status)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (_context.Estado.Where(c => c.CompanyId == user.CompanyId).Any(contem => contem.Nome == status.Nome))
                ModelState.AddModelError("", "Já existe um item cadastrado com esse nome");
            if (ModelState.IsValid)
            {
                status.CompanyId = user.CompanyId;
                _context.Add(status);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Criar.cshtml", status);
        }

        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var status = await _context.Estado.SingleOrDefaultAsync(m => m.Id == id);
            if (status == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", status);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nome,Sigla,Descricao")] Estado status)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (id != status.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    status.CompanyId = user.CompanyId;
                    _context.Update(status);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatusExists(status.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", status);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Estado.Remove(_context.Estado.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private bool StatusExists(int id)
        {
            return _context.Estado.Any(e => e.Id == id);
        }
    }
}
