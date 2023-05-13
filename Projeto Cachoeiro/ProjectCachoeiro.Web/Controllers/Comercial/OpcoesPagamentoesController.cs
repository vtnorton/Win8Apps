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
using ProjectCachoeiro.Web.Models.Comercial;

namespace ProjectCachoeiro.Web.Controllers.Comercial
{
    [Authorize(Roles = "Admin")]
    public class OpcoesPagamentoesController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Manage/Sistema/Propriedades/OpcoesPagamento/";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public OpcoesPagamentoesController(ApplicationDbContext context,
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
            return Json(_context.OpcoesPagamento.Where(c => c.CompanyId == user.CompanyId).ToDataSourceResult(request));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<OpcoesPagamento> itempraatualizar)
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
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, OpcoesPagamento model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
        
        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
                return NotFound();

            var opcoesPagamento = await _context.OpcoesPagamento.SingleOrDefaultAsync(m => m.Id == id);
            if (opcoesPagamento == null)
                return NotFound();

            return View(ViewURI + "Detalhes.cshtml", opcoesPagamento);
        }
        
        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("Id,Nome,NomeEmIngles,NomeNaOmie,Descricao")] OpcoesPagamento opcoesPagamento)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (_context.OpcoesPagamento.Where(c => c.CompanyId == user.CompanyId).Any(contem => contem.Nome == opcoesPagamento.Nome))
                ModelState.AddModelError("", "Já existe um item cadastrado com esse nome");

            if (ModelState.IsValid)
            {
                opcoesPagamento.CompanyId = user.CompanyId;
                _context.Add(opcoesPagamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Criar.cshtml", opcoesPagamento);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var opcoesPagamento = await _context.OpcoesPagamento.SingleOrDefaultAsync(m => m.Id == id);
            if (opcoesPagamento == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", opcoesPagamento);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nome,NomeEmIngles,NomeNaOmie,,Descricao")] OpcoesPagamento opcoesPagamento)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (id != opcoesPagamento.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    opcoesPagamento.CompanyId = user.CompanyId;
                    _context.Update(opcoesPagamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OpcoesPagamentoExists(opcoesPagamento.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", opcoesPagamento);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.OpcoesPagamento.Remove(_context.OpcoesPagamento.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private bool OpcoesPagamentoExists(int id)
        {
            return _context.OpcoesPagamento.Any(e => e.Id == id);
        }
    }
}
