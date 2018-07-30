using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Listar()
        {
            EmpleadoRepository repository = new EmpleadoRepository();
            return View(repository.ListarTodos());
        }

        public ActionResult VerDetalle(int id)
        {
            EmpleadoRepository repository = new EmpleadoRepository();
            return View(repository.BuscarEmpleado(id));
        }

        public ActionResult Editar(int id)
        {
            EmpleadoRepository repository = new EmpleadoRepository();
            return View(repository.BuscarEmpleado(id));
        }
        [HttpPost]
        public ActionResult Editar(Empleado emp)
        {
            EmpleadoRepository repository = new EmpleadoRepository();
            ViewBag.Mensaje = "Se guardo de manera exitosa";
        
            try
            {
                repository.Editar(emp);
            } 
            catch(Exception ex)
            {
                ViewBag.Mensaje = "Error al intentar guardar";

                return View("Listar", ViewBag);
            }

            return RedirectToAction("Listar");
        }

    }
}