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
        public String Name = "";
        public String BD = "";

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "";
            ViewBag.BD = "";
            return View();
        }
        [HttpPost]
        public IActionResult Index(FirstResponsiveWebAppKleinModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.BD = model.Greeting();
            }
            else
            {
                ViewBag.BD = "";
            }
            return View(model);

        }

    }
}
