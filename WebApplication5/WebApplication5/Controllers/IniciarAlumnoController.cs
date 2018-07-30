using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class IniciarAlumnoController : Controller
    {
       // GET: IniciarAlumno
        public ActionResult Alta()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Alta(AlumnoModel alumno)
        {
            string bindNombre = alumno.Nombre;
            int bindDni = alumno.Dni;
            int bindEdad = alumno.Edad;

            return View("AltaExito", alumno);
        }

    }
}