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
    public class MateriaisController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Manage/Sistema/Propriedades/Materiais/";
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public MateriaisController(ApplicationDbContext context,
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
            return Json(_context.Material.Where(c => c.CompanyId == user.CompanyId).ToDataSourceResult(request));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Material> itempraatualizar)
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
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, Material model)
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

            var material = await _context.Material
                .SingleOrDefaultAsync(m => m.Id == id);
            if (material == null)
            {
                return NotFound();
            }

            return View(ViewURI + "Detalhes.cshtml", material);
        }
        
        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("Nome,Descricao")] Material material)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (_context.Material.Where(c => c.CompanyId == user.CompanyId).Any(contem => contem.Nome == material.Nome))
                ModelState.AddModelError("", "Já existe um item cadastrado com esse nome");
            if (ModelState.IsValid)
            {
                material.CompanyId = user.CompanyId;
                _context.Add(material);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Criar.cshtml", material);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var material = await _context.Material.SingleOrDefaultAsync(m => m.Id == id);
            if (material == null)
            {
                return NotFound();
            }
            return View(ViewURI + "Editar.cshtml", material);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nome,Descricao")] Material material)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (id != material.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    material.CompanyId = user.CompanyId;
                    _context.Update(material);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaterialExists(material.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", material);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Material.Remove(_context.Material.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private bool MaterialExists(int id)
        {
            return _context.Material.Any(e => e.Id == id);
        }
    }
}
