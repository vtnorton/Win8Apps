using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectCachoeiro.Web.Data;
using ProjectCachoeiro.Web.Util;
using ProjectCachoeiro.Web.Models;
using ProjectCachoeiro.Web.Models.Produtos;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace ProjectCachoeiro.Web.Controllers.Produtos
{
    [Authorize(Roles = "Admin,User")]
    public class ProdutosController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Produtos/";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ProdutosController(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        
        public IActionResult Index()
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            return View(ViewURI + "Index.cshtml");
        }

        public IActionResult Blocos()
        {
            //TODO: Colocar esse filtro de empresa no DbContext
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            return View(ViewURI + "Blocos.cshtml");
        }
        public IActionResult Chapas()
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            return View(ViewURI + "Chapas.cshtml");
        }

        public IActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            IQueryable<Produto> produtos = _context.Produto.Where(c => c.CompanyId == user.CompanyId);
            return Json(produtos.ToDataSourceResult(request));
        }
        
        public IActionResult Read_Blocos([DataSourceRequest] DataSourceRequest request)
        {
            return Json(ProdutosPorFamilia(1).ToDataSourceResult(request));
        }

        public IActionResult Read_Chapas([DataSourceRequest] DataSourceRequest request)
        {
            return Json(ProdutosPorFamilia(2).ToDataSourceResult(request));
        }

        [HttpPost]
        public ActionResult Update([DataSourceRequest] DataSourceRequest request, Produto model)
        {
            _context.Update(model);
            _context.SaveChanges();
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, Produto model)
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

            var produto = await _context.Produto.SingleOrDefaultAsync(m => m.Id == id);
            if (produto == null)
                return NotFound();

            return View(ViewURI + "Detalhes.cshtml", produto);
        }
        
        public IActionResult Criar()
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            return View(ViewURI + "Criar.cshtml");
        }

        public async Task<IActionResult> Transformar(int? id)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);
            ViewData["familiasecundaria"] = _context.Familia.Where(c => c.CompanyId == user.CompanyId).Where(c => c.Type == 2);
            //TODO: Impedir que produtos que já foram transformandos entrem aqui

            if (id == null)
                return NotFound();

            var produto = await _context.Produto.SingleOrDefaultAsync(m => m.Id == id);
            if (produto == null)
                return NotFound();

            return View(ViewURI + "Transformar.cshtml", produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Transformar(int? id, string Familia, string Peso, string UserTitulo,
            string Estado, string Numero, string Preco, string Espessura, string NCM, string Largura, string Altura)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);
            ViewData["familiasecundaria"] = _context.Familia.Where(c => c.CompanyId == user.CompanyId).Where(c => c.Type == 2);

            ViewData["posted"] = "true";

            if (id == null)
                return NotFound();

            var produto = await _context.Produto.SingleOrDefaultAsync(m => m.Id == id);
            if (produto == null)
                return NotFound();


            //Variavel para tirar peso do processamento
            string _titulo = await new Transformacao(_context).CriarTituloAsync(produto, int.Parse(Familia));
            List<Produto> derivados = new List<Produto>();

            for (int i = 1; i <= int.Parse(Numero); i++)
            {
                string titulo;

                if (string.IsNullOrEmpty(UserTitulo))
                    titulo = _titulo;
                else
                    titulo = UserTitulo.Trim();

                titulo += " " + i.ToString("00");
                _context.Produto.Add(new Produto
                {
                    Titulo = titulo,
                    DataDeEntrada = DateTime.Now.Date,
                    CodigoEAN = produto.CodigoEAN,
                    CompanyId = produto.CompanyId,
                    Comprimento = produto.Comprimento,
                    IdMaterial = produto.IdMaterial,
                    IdProdutoDerivado = produto.Id,
                    IdQualidade = produto.IdQualidade,
                    IdTipo = produto.IdTipo,
                    Resinado = produto.Resinado,
                    CodigoNCM = NCM,
                    DisponivelEmEstoque = true,
                    IdStatus = int.Parse(Estado),
                    IdFamilia = int.Parse(Familia),
                    IdEspessura = int.Parse(Espessura),
                    Peso = decimal.Parse(Peso),
                    Largura = decimal.Parse(Largura),
                    Altura = decimal.Parse(Altura),
                    PrecoVenda = decimal.Parse(Preco)
                });
            }

            produto.DisponivelEmEstoque = false;
            _context.Update(produto);

            await _context.SaveChangesAsync();

            return View(ViewURI + "Transformar.cshtml", produto);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("IdCor,CodigoProduto,NumeroBloco,DataDeEntrada,DisponivelEmEstoque,Titulo,DisplayName,CodigoNCM,CodigoEAN,Observacoes,PrecoVenda,PrecoCusto,Peso,Largura,Altura,Comprimento,IdStatus,IdFamilia,IdEspessura,IdMaterial,IdQualidade,IdTipo,IdImagemPrincipal,IdProdutoDerivado")] Produto produto)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            if (ModelState.IsValid)
            {
                produto.CompanyId = user.CompanyId;
                produto.DisponivelEmEstoque = true;
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(ViewURI + "Criar.cshtml", produto);
        }
        
        public async Task<IActionResult> Editar(int? id)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            if (id == null)
                return NotFound();

            var produto = await _context.Produto.SingleOrDefaultAsync(m => m.Id == id);
            if (produto == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", produto);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id, IdCor, CodigoProduto, NumeroBloco, DataDeEntrada, DisponivelEmEstoque, Titulo, DisplayName, CodigoNCM, CodigoEAN, Observacoes, PrecoVenda, PrecoCusto, Peso, Largura, Altura, Comprimento, IdStatus, IdFamilia, IdEspessura, IdMaterial, IdQualidade, IdTipo, IdImagemPrincipal, IdProdutoDerivado")] Produto produto)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            ValoresEmViewData(user);

            if (id != produto.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    produto.CompanyId = user.CompanyId;
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Produto.Remove(_context.Produto.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produto.Any(e => e.Id == id);
        }

        //TODO: Colocar em uma classe separada pois também é utilizada em propostas
        private void ValoresEmViewData(ApplicationUser user)
        {
            ViewData["estado"] = _context.Estado.Where(c => c.CompanyId == user.CompanyId);
            ViewData["familia"] = _context.Familia.Where(c => c.CompanyId == user.CompanyId);
            ViewData["qualidade"] = _context.Qualidade.Where(c => c.CompanyId == user.CompanyId);
            ViewData["tipo"] = _context.Tipo.Where(c => c.CompanyId == user.CompanyId);
            ViewData["material"] = _context.Material.Where(c => c.CompanyId == user.CompanyId);
            ViewData["espessura"] = _context.Espessura.Where(c => c.CompanyId == user.CompanyId);
            ViewData["cor"] = _context.Cor.Where(c => c.CompanyId == user.CompanyId);
        }

        private List<int> Familias(int tipoFamilia)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            List<int> familiasPrimarias = new List<int>();
            foreach (var item in _context.Familia.Where(c => c.CompanyId == user.CompanyId))
            {
                if (item.Type == tipoFamilia)
                    familiasPrimarias.Add(item.Id);
            }
            return familiasPrimarias;
        }

        private List<Produto> ProdutosPorFamilia(int tipoFamilia)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            IQueryable<Produto> produtos = _context.Produto.Where(c => c.CompanyId == user.CompanyId);
            List<int> familiasPrimarias = Familias(tipoFamilia);
            List<Produto> produtosPrimarios = new List<Produto>();

            foreach (var item in produtos)
            {
                if (familiasPrimarias.Contains(item.IdFamilia))
                    produtosPrimarios.Add(item);
            }

            return produtosPrimarios;
        }
    }
}
