using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCachoeiro.Web.Data;
using ProjectCachoeiro.Web.Models;
using Microsoft.Extensions.Logging;
using ProjectCachoeiro.Web.Services;
using Microsoft.AspNetCore.Identity;
using ProjectCachoeiro.Web.Models.AccountViewModels;
using Microsoft.AspNetCore.Authorization;
using System;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace ProjectCachoeiro.Web.Controllers.Sistema
{
    [Authorize(Roles = "SysAdmin")]
    public class AdminUsersController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Manage/SystemAdmin/AdminUsers/";
        /* TODO: Esse código (registrar usuário) está repetindo aqui e na OOBE */
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;

        public AdminUsersController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            ILogger<AccountController> logger,
            ApplicationDbContext context,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
            _context = context;
            _roleManager = roleManager;
        }
        
        public IActionResult Index()
        {
            return View(ViewURI + "Index.cshtml");
        }

        public IActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            //TODO: Controlar o que está sendo passado para a View pois está indo o objeto inteiro inclusive PasswordHash
            return Json(_context.ApplicationUser.Where(c => c.IsSysAdmin == true).ToDataSourceResult(request));
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest] DataSourceRequest request, ApplicationUser model)
        {
            _context.Remove(model);
            _context.SaveChanges();

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
        
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
                return NotFound();

            var applicationUser = await _context.ApplicationUser.SingleOrDefaultAsync(m => m.Id == id);
            if (applicationUser == null)
                return NotFound();

            return View(ViewURI + "Detalhes.cshtml", applicationUser);
        }

        public IActionResult Criar()
        {
            return View(ViewURI + "Criar.cshtml");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegisterViewModel applicationUser)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = applicationUser.Email,
                    Email = applicationUser.Email.ToLower(),
                    Nome = applicationUser.Nome,
                    Sobrenome = applicationUser.Sobrenome,
                    CPF = applicationUser.CPF,
                    IsSysAdmin = true,
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                
                if ((await _roleManager.FindByNameAsync("SysAdmin") == null))
                    await _roleManager.CreateAsync(new IdentityRole { Name = "SysAdmin" });
                
                var result = await _userManager.CreateAsync(user, applicationUser.Password);
                await _userManager.AddToRoleAsync(user, "SysAdmin");

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.EmailConfirmationLink(user.Id, code, Request.Scheme);
                    await _emailSender.SendEmailConfirmationAsync(applicationUser.Email, callbackUrl);

                    _logger.LogInformation("User created a new account with password.");

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                AddErrors(result);
            }

            return View(ViewURI + "Criar.cshtml", applicationUser);
        }
        
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
                return NotFound();

            var applicationUser = await _context.ApplicationUser.SingleOrDefaultAsync(m => m.Id == id);
            if (applicationUser == null)
                return NotFound();

            return View(ViewURI + "Editar.cshtml", applicationUser);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Nome,Sobrenome,CPF,DataDeNascimento,Email")] ApplicationUser applicationUser)
        {
            if (id != applicationUser.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicationUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationUserExists(applicationUser.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ViewURI + "Editar.cshtml", applicationUser);
        }

        private bool ApplicationUserExists(string id)
        {
            return _context.ApplicationUser.Any(e => e.Id == id);
        }

        #region Helpers
        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
        #endregion
    }
}
