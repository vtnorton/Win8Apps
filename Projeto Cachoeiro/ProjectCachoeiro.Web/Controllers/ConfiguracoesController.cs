using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectCachoeiro.Web.Controllers
{
    [Authorize]
    public class ConfiguracoesController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Manage/";

        [Route("Sistema/Propriedades")]
        public IActionResult Propriedades()
        {
            return View(ViewURI + "Sistema/Propriedades.cshtml");
        }

    }
}
