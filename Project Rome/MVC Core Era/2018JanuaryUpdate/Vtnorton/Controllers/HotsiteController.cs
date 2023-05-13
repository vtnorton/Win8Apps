using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using Vtnorton.Code;
using Vtnorton.Model;

namespace Vtnorton.Controllers
{
    public class HotsiteController : Controller
    {
        private IHostingEnvironment _env;
        public HotsiteController(IHostingEnvironment env)
        {
            _env = env;
        }
        [Route("/onenote")]
        public IActionResult OneNote()
        {
            return View();
        }

        [HttpPost]
        [Route("/onenote")]
        public IActionResult OneNote(Emails mail)
        {
            mail.ListID = 2;

            if (ModelState.IsValid)
            {
                try
                {
                    NewsletterBuilder.Insert(mail, _env);
                    return View("OneNoteDownload");
                }
                catch (Exception ex)
                {
                    ViewData["error"] = ex.InnerException;
                }
            }
                

            return View(mail);
        }
        
        public IActionResult OneNoteDownload()
        {
            return View();
        }

        [Route("/devnasnuvens")]
        [Route("/devnanuvem")]
        public IActionResult DevNasNuvens()
        {
            return View();
        }
    }
}
