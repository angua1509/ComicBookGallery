using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookGallery.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Message is variable name
            ViewBag.Message = "Detta är tet som kommer från controllern";
            return View();

            // calls a specified View
            // return View("AlternativtIndex");
        }
    }
}
