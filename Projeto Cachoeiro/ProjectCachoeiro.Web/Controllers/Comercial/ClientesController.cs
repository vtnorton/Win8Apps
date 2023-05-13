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

namespace ProjectCachoeiro.Web.Controllers.Comercial
{
    [Authorize(Roles = "Admin,User")]
    //TODO: Melhorar a tela de não tem autorização para isso
    public class ClientesController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Clientes/";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        
        public ClientesController(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Clientes
        public IActionResult Index()
        {
            return View(ViewURI + "Index.cshtml");
        }

        public IActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            return Json(_context.Cliente.Where(c => c.CompanyId == user.CompanyId).ToDataSourceResult(request));
        }

        [HttpPost]
        public ActionResult Update([DataSourceRequest] DataSourceRequest request, Cliente model)
        {
            _context.Update(model);
            _context.SaveChanges();
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, Cliente model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
                return NotFound();
            
            var cliente = await _context.Cliente.SingleOrDefaultAsync(m => m.Id == id);

            if (cliente == null)
                return NotFound();

            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            return View(ViewURI + "Detalhes.cshtml", cliente);
        }

        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("RazaoSocial,InscricaoEstadual,NomeFantasia,CNPJ,Descricao,Endereco,Numero,Bairro,Estado,Cidade,Complemento,CEP,Pais,Site,Telefone,EmailContato")] Cliente cliente)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (_context.Cliente.Where(c => c.CompanyId == user.CompanyId).Any(contem => contem.CNPJ == cliente.CNPJ))
                ModelState.AddModelError("", "Já existe um item cadastrado com esse CNPJ");
            if (ModelState.IsValid)
            {
                cliente.CompanyId = user.CompanyId;
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(ViewURI + "Criar.cshtml", cliente);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var cliente = await _context.Cliente.SingleOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", cliente);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("RazaoSocial,InscricaoEstadual,NomeFantasia,CNPJ,Descricao,Endereco,Numero,Bairro,Estado,Cidade,Complemento,CEP,Pais,Site,Telefone,EmailContato")] Cliente cliente)
        {
            if (id != cliente.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Cliente.Remove(_context.Cliente.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //TODO: Mostrar mensagem de erro
                return View();
            }
        }
        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.Id == id);
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
        }
    }
}
