using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCachoeiro.Web.Data;
using ProjectCachoeiro.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace ProjectCachoeiro.Web.Controllers.Sistema
{
    [Authorize(Roles = "SysAdmin")]
    public class InvitesController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Manage/SystemAdmin/Invites/";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public InvitesController(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        
        public IActionResult Index()
        {
            //TODO: ao apagar um convite uma mensagem de erro aparece
            return View(ViewURI + "Index.cshtml");
        }

        public IActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(_context.Invite.ToDataSourceResult(request));
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, Invite model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
        
        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
                return NotFound();

            var invite = await _context.Invite.SingleOrDefaultAsync(m => m.Id == id);
            if (invite == null)
                return NotFound();

            return View(ViewURI + "Detalhes.cshtml", invite);
        }
        
        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar([Bind("Email")] Invite invite)
        {
            if (ModelState.IsValid)
            {
                invite.Type = "Externo";

                bool cangGo = true;

                foreach (var item in _context.Invite)
                {
                    if (item.Email == invite.Email)
                        cangGo = false;
                }

                if (cangGo)
                {
                    invite.Valido = true;
                    invite.Email = invite.Email.ToLower();
                    _context.Add(invite);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("", "Este e-mail já está cadastrado no sistema");
                }
                
            }
            return View(ViewURI + "Criar.cshtml", invite);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Invite.Remove(_context.Invite.Find(id));
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private bool InviteExists(int id)
        {
            return _context.Invite.Any(e => e.Id == id);
        }
    }
}
