using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC5.Db;
using MVC5.Models;

namespace MVC5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        


        public HomeController(ILogger<HomeController> logger)

        {
            _logger = logger;
            //appDbContext = _dbContext;
        }

        public IActionResult Index()
        {
            //var alumnos = appDbContext.Alumnos.ToList();
            return View();
            // Crear el alumno, el NombreCompleto se asigna en el constructor
            //Alumnos alumno1 = new Alumnos("Ezequiel", 24, "Ramirez", DateTime.Now, "A12345");
            //return View(alumno1);
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
