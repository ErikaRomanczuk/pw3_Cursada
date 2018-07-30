using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class AltaController : Controller
    {
        // GET: Alta
        public ActionResult AltaAlumno()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AltaAlumno(AlumnoModel alumno)
        {
            string nombreBinding = alumno.Nombre;
            string apellidoBinding = alumno.Apellido;
            int DniBinding = alumno.Dni;
            int EdadBinding = alumno.Edad;
            return View("AltaConfirmacion", alumno);
        }


    }
}