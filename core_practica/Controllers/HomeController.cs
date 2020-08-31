using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using core_practica.Models;

namespace core_practica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private int numero = 0;
        [HttpGet]
        public ViewResult  Index()
        {
            //ViewBag.a = c;
           //  numero = c;
            //return numero;
            return View();
        }
        public string valores(Usuario u)
        {
            
            return u.Username + u.Password;
            
        } 
        public ViewResult productos(Producto p)
        {
            // return p.serie + p.categoria + p.nombre + p.precio + p.proveedor;
            ViewBag.producto = p;
            return View("Producto");
        }

        public string Hola(string caracter)
        {
            var persona = new Persona();
            persona.id = 1;
            persona.nombre = "josue";
            persona.apellido = "Huaman";


           // ViewBag.Numero = numero; //almacena todos los satos como diccionario
          //  ViewBag.Persona  = persona;

            //return View("Hola",persona);
            return caracter;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
