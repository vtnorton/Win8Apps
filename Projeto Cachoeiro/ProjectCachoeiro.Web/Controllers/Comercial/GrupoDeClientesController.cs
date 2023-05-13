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
using System.Collections.Generic;

namespace ProjectCachoeiro.Web.Controllers.Comercial
{
    [Authorize(Roles = "Admin,User")]
    public class GrupoDeClientesController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Manage/Sistema/Propriedades/GrupoDeClientes/";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public GrupoDeClientesController(ApplicationDbContext context,
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
            return Json(_context.GrupoDeClientes.Where(c => c.CompanyId == user.CompanyId).ToDataSourceResult(request));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<GrupoDeClientes> itempraatualizar)
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
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, GrupoDeClientes model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
        
        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
                return NotFound();

            var grupoDeClientes = await _context.GrupoDeClientes
                .SingleOrDefaultAsync(m => m.Id == id);
            if (grupoDeClientes == null)
                return NotFound();

            return View(ViewURI + "Detalhes.cshtml", grupoDeClientes);
        }
        
        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("Nome,Descricao")] GrupoDeClientes grupoDeClientes)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (_context.GrupoDeClientes.Where(c => c.CompanyId == user.CompanyId).Any(contem => contem.Nome == grupoDeClientes.Nome))
                ModelState.AddModelError("", "Já existe um item cadastrado com esse nome");
            if (ModelState.IsValid)
            {
                grupoDeClientes.CompanyId = user.CompanyId;
                _context.Add(grupoDeClientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(ViewURI + "Criar.cshtml", grupoDeClientes);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var grupoDeClientes = await _context.GrupoDeClientes.SingleOrDefaultAsync(m => m.Id == id);
            if (grupoDeClientes == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", grupoDeClientes);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nome,Descricao")] GrupoDeClientes grupoDeClientes)
        {
            if (id != grupoDeClientes.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grupoDeClientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GrupoDeClientesExists(grupoDeClientes.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", grupoDeClientes);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.GrupoDeClientes.Remove(_context.GrupoDeClientes.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private bool GrupoDeClientesExists(int id)
        {
            return _context.GrupoDeClientes.Any(e => e.Id == id);
        }
    }
}
