using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectCachoeiro.Web.Data;
using ProjectCachoeiro.Web.Models;
using ProjectCachoeiro.Web.Models.Produtos;

namespace ProjectCachoeiro.Web.Controllers.Produtos
{
    public class ProductDetailsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ProductDetailsController(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public ActionResult ProductDetails_Read([DataSourceRequest] DataSourceRequest request, int Id)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            return Json(_context.Produto.Where(c => c.CompanyId == user.CompanyId).Where(c => c.IdProdutoDerivado == Id).ToDataSourceResult(request));
        }

        public ActionResult ProdutosParaPropostas_Read([DataSourceRequest] DataSourceRequest request)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            return Json(_context.Produto.Where(c => c.CompanyId == user.CompanyId).Where(c => c.DisponivelEmEstoque == true).ToDataSourceResult(request));
        }


        [HttpPost]
        public async Task<IActionResult> ProductDetails_UpdateAsync([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Produto> products)
        {
            if (products != null && ModelState.IsValid)
            {
                foreach (var product in products)
                {
                    _context.Update(product);
                }
            }
            await _context.SaveChangesAsync();
            return Json(products.ToDataSourceResult(request, ModelState));
        }
    }
}