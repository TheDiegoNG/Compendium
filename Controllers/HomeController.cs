using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Compendium.Models;

namespace Compendium.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View("Index");

        public IActionResult PersonaAdd(){
            List<Arcana> arcanas = Repositorio.Arcanas.ToList();
            ViewBag.Arcanas = arcanas;
            return View("PersonaAdd");
        } 
            
        public IActionResult ArcanaAdd() => View("ArcanaAdd");

        [HttpPost]
        public IActionResult ArcanaAdd(Arcana arcana)
        {
            Repositorio.AgregarArcana(arcana);
            return View("ArcanaList", Repositorio.Arcanas);
        }
       
        [HttpPost]
        public IActionResult PersonaAdd(Persona persona)
        {
            Repositorio.AgregarPersona(persona);
            return View("PersonaList", Repositorio.Personas);
        }

        public ViewResult PersonaList() => View(Repositorio.Personas);
        public ViewResult ArcanaList() => View(Repositorio.Arcanas);
    }
}
