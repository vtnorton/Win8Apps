using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using Vtnorton.Code;
using Vtnorton.Model;

namespace Vtnorton.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _env;
        public HomeController(IHostingEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            ViewData["feedBlog"] = new RSS().GetRSS("http://blog.vtnorton.com/feed", 3).Result;
            ViewData["feedDev"] = new RSS().GetRSS("http://dev.vtnorton.com/feed", 3).Result;

            return View();
        }

        [HttpPost]
        public IActionResult Index(Emails mail)
        {
            ViewData["feedBlog"] = new RSS().GetRSS("http://blog.vtnorton.com/feed", 3).Result;
            ViewData["feedDev"] = new RSS().GetRSS("http://dev.vtnorton.com/feed", 3).Result;

            mail.ListID = 1;

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

        [Route("search")]
        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        [Route("vitor")]
        [Route("norton")]
        [Route("me")]
        public IActionResult Vitor()
        {
            return View();
        }
    }
}
