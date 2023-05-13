using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Vtnorton.Code;
using Vtnorton.Model;

namespace Vtnorton.Controllers
{
    public class TalksController : Controller
    {
        private IHostingEnvironment _env;
        public TalksController(IHostingEnvironment env)
        {
            _env = env;
        }

        [Route("/pronatec/")]
        public IActionResult Pronatec()
        {
            ViewData["key"] = "NULL";
            return View();
        }

        [HttpPost]
        [Route("/pronatec/")]
        public IActionResult Pronatec(Emails mail)
        {
            mail.ListID = 5;

            string[] listaemails = new string[] { "vitor@vtnorton.com", "doh3194@live.com", "jhonath-2012@live.com", "euclidesgsouza@hotmail.com", "marcio.102@bol.com.br", "cassiano.th@gmail.com", "thallytamoreira18@gmail.com", "walacesouza863@gmail.com", "queilabatistafraga@gmail.com", "vinicius.escoralique@yahoo.com.br", "marcelo190993@hotmail.com" };

            if (ModelState.IsValid)
            {
                if (listaemails.Contains(mail.Email.Trim().ToLower()))
                {
                    try
                    {
                        NewsletterBuilder.Insert(mail, _env);
                        new SendEmail().SendFormulaKeyPT("http://go.microsoft.com/fwlink/?LinkId=532540&mstoken=7JG72-GR9KM-R2TX7-VKDHM-JV2DZ", mail.Email.Trim().ToLower());
                        ViewData["result"] = "Easter Egg";
                    }
                    catch (Exception ex)
                    {
                        ViewData["error"] = ex.InnerException;
                    }
                }
            }

            return View(mail);
        }

        [Route("/formula-mvp/")]
        public IActionResult FormulaMVP()
        {
            ViewData["result"] = null;
            return View();
        }

        [HttpPost]
        [Route("/formula-mvp/")]
        public IActionResult FormulaMVP(Emails mail)
        {
            mail.ListID = 3;

            if (ModelState.IsValid)
            {
                try
                {
                    NewsletterBuilder.Insert(mail, _env);
                    Message x = new Message();
                    x.Content = "New request to key for Formula (MVP Request): " + mail.Email + "<br/>The profile link is: " + mail?.Observation + " (if does not show up it's because it don't have a link)";
                    x.EmailTo = "contato@vtnorton.com";
                    x.Title = "Formula MVP Key request";
                    x.NameTo = "Vítor Norton";
                    new SendEmail().SendEmailAsync(x);
                    ViewData["result"] = "Easter Egg";
                }
                catch (Exception ex)
                {
                    ViewData["error"] = ex.InnerException;
                }
            }

            return View(mail);
        }

        [Route("/formula-beta/")]
        public IActionResult FormulaBeta()
        {
            return View();
        }

        [HttpPost]
        [Route("/formula-beta/")]
        public IActionResult FormulaBeta(Emails mail)
        {
            mail.ListID = 3;

            if (ModelState.IsValid)
            {
                try
                {
                    NewsletterBuilder.Insert(mail, _env);
                    Message x = new Message();
                    x.Content = "New request to key for Formula beta tester: " + mail.Email + "<br/>This is how they found out Formula: " + mail?.Observation;
                    x.EmailTo = "contato@vtnorton.com";
                    x.Title = "New Formula beta tester";
                    x.NameTo = "Vítor Norton";
                    new SendEmail().SendEmailAsync(x);
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
