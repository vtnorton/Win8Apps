using Microsoft.AspNetCore.Mvc;
using ProjectCachoeiro.Web.Models;
using System.Diagnostics;

namespace ProjectCachoeiro.Web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly string ViewURI = "~/Views/App/Dashboard/";
        
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return View(ViewURI + "Index.cshtml");
            else
                return RedirectToAction(nameof(HomePage));
        }

        public IActionResult HomePage()
        {
            if (User.Identity.IsAuthenticated)
                return View(ViewURI + "Index.cshtml");
            else
                return View(ViewURI + "HomePage.cshtml");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}