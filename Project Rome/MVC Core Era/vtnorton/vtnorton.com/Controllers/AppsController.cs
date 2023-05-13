using Microsoft.AspNetCore.Mvc;
using Vtnorton.Code;

namespace Vtnorton.Controllers
{
    public class AppsController : Controller
    {
        [Route("/conjugar")]
        public IActionResult Conjugar()
        {
            ViewData["feed"] = new RSS().GetRSS("http://blog.vtnorton.com/category/apps/conjugar/feed", 3).Result;
            return View();
        }

        [Route("/formula")]
        public IActionResult Formula()
        {
            ViewData["feed"] = new RSS().GetRSS("http://blog.vtnorton.com/category/apps/formula-universal-code-editor/feed", 3).Result;
            return View();
        }
        [Route("/formula/privacy")]
        public IActionResult FormulaPrivacy()
        {
            return View();
        }

        [Route("/mixer")]
        public IActionResult Mixer()
        {
            return View();
        }

        [Route("/neverever")]
        public IActionResult NeverEver()
        {
            ViewData["feed"] = new RSS().GetRSS("http://blog.vtnorton.com/category/apps/other-apps/feed", 3).Result;
            return View();
        }

        [Route("/random42")]
        public IActionResult Random42()
        {
            ViewData["feed"] = new RSS().GetRSS("http://blog.vtnorton.com/category/apps/random-42/feed", 3).Result;
            return View();
        }

        [Route("/timecalculator")]
        public IActionResult Timecalculator()
        {
            ViewData["feed"] = new RSS().GetRSS("http://blog.vtnorton.com/category/apps/other-apps/feed", 3).Result;
            return View();
        }

        [Route("/tochaolimpica")]
        public IActionResult Tochaolimpica()
        {
            ViewData["feed"] = new RSS().GetRSS("http://blog.vtnorton.com/category/apps/other-apps/feed", 3).Result;
            return View();
        }

        [Route("/verdadeouconsequencia")]
        public IActionResult VerdadeOuConsequencia()
        {
            ViewData["feed"] = new RSS().GetRSS("http://blog.vtnorton.com/category/apps/other-apps/feed", 3).Result;
            return View();
        }
    }
}
