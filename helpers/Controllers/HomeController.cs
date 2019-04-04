using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using helpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace helpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Formulario()
        {
            Persona p = new Persona();
            return View(p);
        }
        [HttpPost]
        public IActionResult Formulario(Persona persona) {
            
            return View(persona);
        }
    }
}