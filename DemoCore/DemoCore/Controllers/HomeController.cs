using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCore.Controllers
{
    public class HomeController:Controller
    {
        //[Route("batata/teste")] // exemplo de rota
        //public string Index()
        //{
        //    return "Bateu no Home/Index";

        //}

        public IActionResult Index()
        {
            return View();

        }


    }
}
