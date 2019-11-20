using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EscolaDePrograma.Models;

namespace EscolaDePrograma.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route ("materias")]
        public IActionResult Materias()
        {
            List<Materia> materias = new List<Materia>();
            materias.Add(new Materia()
            {
                Nome = "React",
                Descricao = "Desenvolvimento Web"
            });


            materias.Add(new Materia()
            {
                Nome = "C#"
            });
            return View("Views/Home/Paginas/Materias.cshtml", materias);

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
