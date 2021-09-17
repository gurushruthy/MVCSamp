using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCpro.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.WelcomeMsg = "Welcome to Core MVC";
            return View();
        }
        public ViewResult ShowFruits()
        {
            IEnumerable<string> names = new List<string>()
            {
                "Mango","Apple","Orange","Banana","Grapes"
            };
            return View(names);

        }
    }
}
