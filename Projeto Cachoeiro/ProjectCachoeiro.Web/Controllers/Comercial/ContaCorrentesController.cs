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
    [Authorize(Roles = "Admin,User")]
    public class ContaCorrentesController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Manage/Sistema/Propriedades/ContaCorrentes/";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ContaCorrentesController(ApplicationDbContext context,
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
            return Json(_context.ContaCorrente.Where(c => c.IdCompany == user.CompanyId).ToDataSourceResult(request));
        }

        [HttpPost]
        public async Task<IActionResult> Update([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ContaCorrente> conta)
        {
            if (conta != null && ModelState.IsValid)
            {
                foreach (var item in conta)
                {
                    _context.Update(item);
                }
            }
            await _context.SaveChangesAsync();
            return Json(conta.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, ContaCorrente model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
        
        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
                return NotFound();

            var contaCorrente = await _context.ContaCorrente.SingleOrDefaultAsync(m => m.Id == id);
            if (contaCorrente == null)
                return NotFound();

            return View(ViewURI + "Detalhes.cshtml", contaCorrente);
        }
        
        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("IdCompany,Banco,Telefone,Titulo,Beneficiario,Endereco,IBAN,Swift,BranchSwift,Conta,Aba,Observacoes")] ContaCorrente contaCorrente)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (_context.ContaCorrente.Where(c => c.IdCompany == user.CompanyId).Any(contem => contem.IBAN == contaCorrente.IBAN))
                ModelState.AddModelError("", "Já existe um item cadastrado com esse CNPJ");
            if (ModelState.IsValid)
            {
                contaCorrente.IdCompany = user.CompanyId;
                _context.Add(contaCorrente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Criar.cshtml", contaCorrente);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var conta = await _context.ContaCorrente.SingleOrDefaultAsync(m => m.Id == id);
            if (conta == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", conta);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,IdCompany,Banco,Telefone,Titulo,Beneficiario,Endereco,IBAN,Swift,BranchSwift,Conta,Aba,Observacoes")] ContaCorrente contaCorrente)
        {
            if (id != contaCorrente.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contaCorrente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContaCorrenteExists(contaCorrente.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", contaCorrente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.ContaCorrente.Remove(_context.ContaCorrente.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //TODO: Mostrar mensagem de erro
                return View();
            }
        }

        private bool ContaCorrenteExists(int id)
        {
            return _context.ContaCorrente.Any(e => e.Id == id);
        }
    }
}
