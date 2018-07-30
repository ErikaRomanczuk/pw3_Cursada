using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class EmpleadoRepository
    {
        private static List<Empleado> Empleados = new List<Empleado> (); 
        

        public List<Empleado> ListarTodos()
        {
            Empleado emp1 = new Empleado();
            emp1.Nombre = "Pepe";
            emp1.Apellido = "Pepon";
            emp1.Id = 1;
            Empleados.Add(new Empleado { Nombre = "Roberto", Apellido = "Ramirez", Id = 2 });
            Empleados.Add(emp1);
            return Empleados;
        }

        //public Empleado BuscarEmpleado(int id)
        //{
        //    List<Empleado> le= ListarTodos();
        //    Empleado empleado = new Empleado();
        //    empleado =le.Where(x => x.Id ==id).FirstOrDefault();
        //    return empleado;
        //}
        
        public Empleado BuscarEmpleado(int id)
        {
            Empleado emp = new Empleado();
            foreach (Empleado em in Empleados)
            {
                if (em.Id == id)
                {
                    emp = em;
                }
            }
            return emp;
       
        }

        public void Alta (Empleado emp)
        {
            Empleados.Add(emp);
        }

        public void Editar (Empleado emp)
        {
            Empleado EmpActual = BuscarEmpleado(emp.Id);
            if (EmpActual == null)
                throw new ArgumentException("Empleado con Id: " + emp.Id + " No se encontró");
            EmpActual.Nombre = emp.Nombre;
            EmpActual.Apellido = emp.Apellido;
        }
    }
}