using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectCachoeiro.Web.Comercial;
using ProjectCachoeiro.Web.Data;
using ProjectCachoeiro.Web.Models;

namespace ProjectCachoeiro.Web.Controllers.Comercial
{
    public class ItensDetailsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ItensDetailsController(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public ActionResult ItensDetails_Read([DataSourceRequest] DataSourceRequest request, int Id)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            return Json(_context.Item.Where(c => c.CompanyId == user.CompanyId).Where(c => c.IdProposta == Id).ToDataSourceResult(request));
        }


        [HttpPost]
        public async Task<IActionResult> ItensDetails_UpdateAsync([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<Item> items)
        {
            if (items != null && ModelState.IsValid)
            {
                foreach (var item in items)
                {
                    _context.Update(item);
                }
            }
            await _context.SaveChangesAsync();
            return Json(items.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Delete(int id)
        {
            try
            {
                _context.Item.Remove(_context.Item.Find(id));
                _context.SaveChanges();
            }
            catch
            {
                
            }
        }
    }
}
