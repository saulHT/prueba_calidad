using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace core_practica.Controllers
{
    public class CalculadoraController : Controller
    {
        public String index()
        {
            return "calculadora";
        }
        public int suma(int a,int b)
        {
            return (a+b);
        }
    }
}