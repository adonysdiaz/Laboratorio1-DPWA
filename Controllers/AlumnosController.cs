using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using MVC5.Db;
using MVC5.Models;
namespace MVC5.Controllers
{
    public class AlumnosController : Controller
    {
        private readonly AppDbContext _dbConn;
        public AlumnosController(AppDbContext appDb)
        {
            _dbConn = appDb;
        }
        public IActionResult Index()
        {
            List<Alumnos> alumnos = _dbConn.Alumnos.ToList();
            return View(alumnos);
        }

        [HttpGet]
        public IActionResult Upsert(int id)
        {
            if (id == 0)
            {
                //Registro nuevo
                Alumnos alumno = new();
                return View(alumno);

            }
            else
            {
                // Registro existente

                Alumnos alumno = _dbConn.Alumnos.FirstOrDefault(row => row.AlumnoId == id) ?? new();
                return View(alumno);
            }
            
        }

        [HttpPost]
        public IActionResult Upsert(Alumnos model)
        {
            ModelState.Remove("NombreCompleto");
            if(model.AlumnoId == 0)
            {
                if (ModelState.IsValid)
                {
                    _dbConn.Alumnos.Add(model);
                    _dbConn.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    _dbConn.Alumnos.Update(model);
                    _dbConn.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Alumnos alumno = _dbConn.Alumnos.FirstOrDefault(row => row.AlumnoId== id) ?? new();
            alumno.IsActive = false;
            // Para eliminar solo se escribe Alumnos.Remove
            _dbConn.Alumnos.Update(alumno);
            _dbConn.SaveChanges();
            return RedirectToAction("Index");
        }
         


    }
}
    
        
    

