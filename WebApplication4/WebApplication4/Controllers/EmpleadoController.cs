using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult EmpleadoDelMes()
        {
            EmpleadoModel empleado = new EmpleadoModel();

            empleado.Nombre = "Cristiano";
            empleado.Apellido = "Ronaldo";
            empleado.Edad = 32;
            empleado.Antiguedad = 12;

            return View(empleado);
        }

        public ActionResult Alta()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Alta(EmpleadoModel empleado)
        {
            string nombreBindAutomatico = empleado.Nombre;
            int edadBindAutomatico = empleado.Edad;
/*
            string Nombre = Request["Nombre"];
            string Apellido = Request["Apellido"];
            string Edad = Request["Edad"];
            string Antiguedad = Request["Antiguedad"];*/
            return View("EmpleadoDelMes", empleado);
        }
    }
}