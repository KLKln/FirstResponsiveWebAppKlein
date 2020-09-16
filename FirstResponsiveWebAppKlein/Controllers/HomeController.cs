using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppKlein.Models;

namespace FirstResponsiveWebAppKlein.Controllers
{
    public class HomeController : Controller
    {
        public string Name = "";
        public string BirthYear = "";

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "";
            ViewBag.BirthYear = "";
            return View();
        }
        [HttpPost]
        public IActionResult Index(FirstResponsiveWebAppKleinModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.BD = model.Greeting(Name, BirthYear);
            }
            else
            {
                ViewBag.BD = "";
            }
            return View(model);

        }

    }
}
