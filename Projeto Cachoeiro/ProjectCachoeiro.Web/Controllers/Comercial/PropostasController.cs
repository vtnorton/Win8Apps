using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ProjectCachoeiro.Web.Models;
using ProjectCachoeiro.Web.Data;
using ProjectCachoeiro.Web.Comercial;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace ProjectCachoeiro.Web.Controllers.Comercial
{
    [Authorize(Roles = "Admin,User")]
    public class PropostasController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Propostas/";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public PropostasController(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        
        public IActionResult Index()
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);
            ViewData["clientes"] = _context.Cliente.Where(c => c.CompanyId == user.CompanyId);
            
            return View(ViewURI + "Index.cshtml");
        }
        public IActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            return Json(_context.Proposta.Where(c => c.CompanyId == user.CompanyId).ToDataSourceResult(request));
        }
        public IActionResult ReadCliente([DataSourceRequest] DataSourceRequest request, int Id)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            return Json(_context.Proposta.Where(c => c.CompanyId == user.CompanyId).Where(c => c.IdCliente == Id).ToDataSourceResult(request));
        }

        [HttpPost]
        public ActionResult Update([DataSourceRequest] DataSourceRequest request, Proposta model)
        {
            _context.Update(model);
            _context.SaveChanges();
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, Proposta model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        
        public async Task<IActionResult> Detalhes(int? id)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            if (id == null)
                return NotFound();

            var proposta = await _context.Proposta.SingleOrDefaultAsync(m => m.Id == id);
            if (proposta == null)
                return NotFound();

            ///TODO: Colocar descrição caso ela exista
            ViewData["pagamentodetails"] = _context.OpcoesPagamento.SingleOrDefault(m => m.Id == proposta.IdOpcoesDePagamento).Nome;
           // ViewData["clientedaproposta"] = _context.Cliente.SingleOrDefaultAsync(m => m.Id == proposta.IdCliente);

            return View(ViewURI + "Detalhes.cshtml", proposta);
        }
        
        public IActionResult Criar()
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            return View(ViewURI + "Criar.cshtml");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("NomeDaProposta,IdCliente,Observacoes,IdOpcoesDePagamento")] Proposta proposta)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            ViewData["posted"] = "true";

            if (ModelState.IsValid)
            {
                proposta.CompanyId = user.CompanyId;
                _context.Add(proposta);
                await _context.SaveChangesAsync();
                ViewData["id"] = proposta.Id;
            }

            return View(ViewURI + "Criar.cshtml", proposta);
        }

        [HttpPost]
        [Route("/AddItens")]
        public async Task<IActionResult> AddItens(int IdProposta, List<int> Ids)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            ViewData["posted"] = "true";
            ViewData["id"] = IdProposta;

            var proposta = await _context.Proposta.SingleOrDefaultAsync(m => m.Id == IdProposta);
            if (proposta == null)
                return NotFound();

            foreach (var item in Ids)
            {
                var produto = await _context.Produto.SingleOrDefaultAsync(m => m.Id == item);
                _context.Item.Add(new Item {
                    CompanyId = proposta.CompanyId,
                    IdProduto = item,
                    IdProposta = IdProposta,
                    Valor = produto.PrecoVenda
                });
            }

            await _context.SaveChangesAsync();

            return View(ViewURI + "Editar.cshtml", proposta);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            if (id == null)
                return NotFound();

            var proposta = await _context.Proposta.SingleOrDefaultAsync(m => m.Id == id);
            if (proposta == null)
                return NotFound();

            ViewData["itens"] = _context.Item.Where(c => c.CompanyId == user.CompanyId).Where(c => c.IdProposta == id);

            return View(ViewURI + "Editar.cshtml", proposta);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,NomeDaProposta,IdCliente,Observacoes,IdOpcoesDePagamento")] Proposta proposta)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            if (id != proposta.Id)
                return NotFound();

            ViewData["itens"] = _context.Item.Where(c => c.CompanyId == user.CompanyId).Where(c => c.IdProposta == id);

            if (ModelState.IsValid)
            {
                try
                {
                    proposta.CompanyId = user.CompanyId;
                    _context.Update(proposta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropostaExists(proposta.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }

            return View(ViewURI + "Editar.cshtml", proposta);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Proposta.Remove(_context.Proposta.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private bool PropostaExists(int id)
        {
            return _context.Proposta.Any(e => e.Id == id);
        }

        private void ValoresEmViewData(ApplicationUser user)
        {
            ViewData["estado"] = _context.Estado.Where(c => c.CompanyId == user.CompanyId);
            ViewData["familia"] = _context.Familia.Where(c => c.CompanyId == user.CompanyId);
            ViewData["qualidade"] = _context.Qualidade.Where(c => c.CompanyId == user.CompanyId);
            ViewData["tipo"] = _context.Tipo.Where(c => c.CompanyId == user.CompanyId);
            ViewData["material"] = _context.Material.Where(c => c.CompanyId == user.CompanyId);
            ViewData["espessura"] = _context.Espessura.Where(c => c.CompanyId == user.CompanyId);
            ViewData["clientes"] = _context.Cliente.Where(c => c.CompanyId == user.CompanyId);
            ViewData["pagamento"] = _context.OpcoesPagamento.Where(c => c.CompanyId == user.CompanyId);
            ViewData["produtos"] = _context.Produto.Where(c => c.CompanyId == user.CompanyId);
            ViewData["cor"] = _context.Cor.Where(c => c.CompanyId == user.CompanyId);
        }
    }
}
