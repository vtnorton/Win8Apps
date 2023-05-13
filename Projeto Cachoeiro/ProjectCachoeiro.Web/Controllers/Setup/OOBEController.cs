using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectCachoeiro.Web.Data;
using ProjectCachoeiro.Web.Models;
using ProjectCachoeiro.Web.Models.Empresa;
using ProjectCachoeiro.Web.Models.AccountViewModels;
using ProjectCachoeiro.Web.Services;
using ProjectCachoeiro.Web.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProjectCachoeiro.Web.Controllers.Setup
{
    public class OOBEController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;

        public OOBEController(
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

        [Route("/oobe")]
        public IActionResult Index()
        {
            if (Request.Cookies.ContainsKey("email"))
                ViewData["email"] = Request.Cookies["email"];

            return View("~/Views/OOBE/Index.cshtml");
        }
        /*
         * TODO: 
         * 
         * 1. Verificar se está logado
         * 2. Verificar se o convite permite a pagina
         * 3. Verificar se o mesmo já passou pela página   |
         * 4. Verificar se o mesmo não está pulando etapas |
         * 5. Alterar menu de acordo com o resultado
         * 
         */
        [HttpPost]
        [Route("/oobe")]
        public IActionResult Index(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                Response.Cookies.Append("email", email, new CookieOptions
                {
                    //TODO: cookie não esta expirando
                    Expires = DateTime.Now.AddHours(1)
                });

                foreach (var item in _context.Invite)
                {
                    if (item.Email == email)
                    {
                        if (item.Valido)
                        {
                            if (item.Type == "Externo")
                                return RedirectToAction(nameof(EditarEmpresa));
                            else
                                return RedirectToAction(nameof(Usuarios));
                            //TODO: OOBE bloquear usuários de voltar em edição da emrpesa caso convite seja externo
                        }
                        else
                        {
                            ModelState.AddModelError("", "O convite para este e-mail expirou, verifique se você já não possui acesso ao sistema");
                            return View("~/Views/OOBE/Index.cshtml");
                        }
                    }
                }

                if (Check.EhDoDominio(email))
                    return RedirectToAction(nameof(EditarEmpresa));

                ViewData["erro"] = "#step2";
                ModelState.AddModelError("", "Este e-mail não recebeu um convite ou o convite expirou.");
                return View("~/Views/OOBE/Index.cshtml");
            }
            else
            {
                ViewData["erro"] = "#step2";
                ModelState.AddModelError("", "Por favor, insira um e-mail válido.");
                return View("~/Views/OOBE/Index.cshtml");
            }
        }

        public async Task<IActionResult> Usuarios()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(User);

                var model = new RegisterViewModel
                {
                    Nome = user.Nome,
                    Sobrenome = user.Sobrenome,
                    CPF = user.CPF,
                    Email = user.Email
                };

                return View("~/Views/OOBE/Usuarios.cshtml", model);
            }
            else
            {
                return View("~/Views/OOBE/Usuarios.cshtml");
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Usuarios(RegisterViewModel model, string returnUrl = "/OOBE/Usuarios#step2")
        {
            if (ModelState.IsValid)
            {
                int companyId = 0;
                Invite convite = new Invite();

                if (!Check.EhDoDominio(model.Email))
                {
                    foreach (var item in _context.Invite)
                    {
                        if (item.Email == model.Email.ToLower())
                        {
                            item.Valido = false;
                            convite = item;
                        }
                    }
                }

                companyId = convite.CompanyId;

                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email.ToLower(),
                    Nome = model.Nome,
                    Sobrenome = model.Sobrenome,
                    CPF = model.CPF,
                    CompanyId = companyId
                };

                if (companyId == 0 && !Check.EhDoDominio(model.Email))
                {
                    ModelState.AddModelError("", "Não foi possível registar o usuário na empresa, verifique se você está utilizando o mesmo e-mail que validou o convite do sistema.");
                    return View("~/Views/OOBE/Usuarios.cshtml");
                }

                new UserRoles().CriarRolesAsync(_userManager, _roleManager);
               
                var result = await _userManager.CreateAsync(user, model.Password);
                
                if (convite.Type == "Interno")
                    await _userManager.AddToRoleAsync(user, "User");
                else if (convite.Type == "Externo")
                    await _userManager.AddToRoleAsync(user, "Admin");
                else if(Check.EhDoDominio(model.Email))
                    await _userManager.AddToRoleAsync(user, "SysAdmin");
                else
                {
                    ModelState.AddModelError("", "Houve algum problema ao gerar a sua conta, por favor entre em contato com o seguinte código: 0xOOBE001");
                    return View("~/Views/OOBE/Usuarios.cshtml");
                }

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.EmailConfirmationLink(user.Id, code, Request.Scheme);
                    await _emailSender.SendEmailConfirmationAsync(model.Email, callbackUrl);

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    _logger.LogInformation("User created a new account with password.");
                    
                    await _context.SaveChangesAsync();

                    if (convite.Type == "Externo" || Check.EhDoDominio(user.Email))
                        return RedirectToAction(nameof(EnviarConvites));
                    else
                        return RedirectToAction(nameof(Finalizar));
                }

                AddErrors(result);
            }

            return View("~/Views/OOBE/Usuarios.cshtml", model);
        }

        // GET: OOBE/EditarEmpresa
        public IActionResult EditarEmpresa()
        {
            return View("~/Views/OOBE/EditarEmpresa.cshtml");
        }

        // POST: OOBE/EditarEmpresa
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditarEmpresa([Bind("Id,CNPJ,RazaoSocial,NomeFantasia,EmailCadastroSistema,Endereco,Estado,CEP,Cidade,Site,Descricao,Telefone,Email,URLLogonImage,URLLogo,Slogan,DateCreated,UserCreated,DateModified,UserModified")] Company company)
        {
            if (ModelState.IsValid)
            {
                company.EmailCadastroSistema = Request.Cookies["email"];

                _context.Add(company);
                await _context.SaveChangesAsync();

                foreach (var item in _context.Invite)
                {
                    if (item.Email == Request.Cookies["email"])
                        item.CompanyId = company.Id;
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Usuarios));
            }
            return View("~/Views/OOBE/EditarEmpresa.cshtml", company);
        }

        [Authorize(Roles = "Admin,SysAdmin")]
        public IActionResult ImportarDados()
        {
            return View("~/Views/OOBE/ImportarDados.cshtml");
        }

        [Authorize]
        public IActionResult Finalizar()
        {
            return View("~/Views/OOBE/Finalizar.cshtml");
        }

        [Authorize(Roles = "Admin,SysAdmin")]
        public IActionResult EnviarConvites()
        {
            return View("~/Views/OOBE/EnviarConvites.cshtml");
        }

        [HttpPost]
        [Authorize(Roles = "Admin,SysAdmin")]
        public async Task<IActionResult> EnviarConvites(ICollection<string> emails)
        {
            ApplicationUser user = _userManager.GetUserAsync(HttpContext.User).Result;
            
            foreach (var item in emails)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    _context.Invite.Add(new Invite()
                    {
                        Type = "Interno",
                        Email = item,
                        Valido = true,
                        CompanyId = user.CompanyId
                    });
                }
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ImportarDados));
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