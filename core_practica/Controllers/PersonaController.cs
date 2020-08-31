using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace core_practica.Controllers
{
    public class PersonaController : Controller
    {
        public String Index( string nombre, string apellido)
        {
            return "hola " +nombre +" "+apellido;
        }

        public int suma(int a, int b)
        {
            return (a + b);
        }
    }
}