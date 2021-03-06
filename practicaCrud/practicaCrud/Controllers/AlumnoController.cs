﻿using practicaCrud.Models;
using practicaCrud.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practicaCrud.Controllers
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
            alumnoRepository.crearAlumno(alumno);
            return RedirectToAction("Listar");
        }

        public ActionResult Listar()
        {
            AlumnoRepository alumnoRepository = new AlumnoRepository();
            return View(alumnoRepository.listarAlumnos());
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