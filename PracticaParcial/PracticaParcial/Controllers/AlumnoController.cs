using PracticaParcial.Models;
using PracticaParcial.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaParcial.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Crear()
        {
            Alumno alumno = new Alumno();
            return View(alumno);
            
        }

        [HttpPost]
        public ActionResult Crear(Alumno alumno)
        {
            AlumnoRepository alumnoRepository = new AlumnoRepository();
            alumnoRepository.Crear(alumno);
            TempData["llave"] = "Mensaje del TempData";
            return RedirectToAction("Listar");
        }
        
        public ActionResult Listar()
        {
            AlumnoRepository alumnoRepository = new AlumnoRepository();
            ViewData["key"] = "Este es un mensaje de prueba para el ViewData";
            ViewBag.key2 = "Este es un mensaje de prueba para el ViewBag";
            return View(alumnoRepository.listar());
        }

        public ActionResult Modificar(int id)
        {
            AlumnoRepository alumnoRepository = new AlumnoRepository();
            return View(alumnoRepository.buscarAlumnoPorId(id));
        }

        [HttpPost]
        public ActionResult Modificar(Alumno alumno)
        {
            AlumnoRepository alumnoRepository = new AlumnoRepository();
            alumnoRepository.Modificar(alumno);
            return RedirectToAction("Listar");
        }
    }
}