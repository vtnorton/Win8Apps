using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using Vtnorton.Code;
using Vtnorton.Model;

namespace Vtnorton.Controllers
{
    public class ExtensionsController : Controller
    {
        private IHostingEnvironment _env;
        public ExtensionsController(IHostingEnvironment env)
        {
            _env = env;
        }

        [Route("/truedarkmode")]
        public IActionResult TrueDarkMode()
        {
            ViewData["feed"] = new RSS().GetRSS("http://dev.vtnorton.com/category/apps/true-dark-mode/feed", 3).Result;
            return View();
        }

        [HttpPost]
        [Route("/truedarkmode")]
        public IActionResult TrueDarkMode(Emails mail)
        {
            ViewData["feed"] = new RSS().GetRSS("http://dev.vtnorton.com/category/apps/true-dark-mode/feed", 3).Result;

            mail.ListID = 4;

            if (ModelState.IsValid)
            {
                try
                {
                    NewsletterBuilder.Insert(mail, _env);
                    ViewData["result"] = "Easter Egg";
                }
                catch (Exception ex)
                {
                    ViewData["error"] = ex.InnerException;
                }
            }

            return View(mail);
        }
    }
}
