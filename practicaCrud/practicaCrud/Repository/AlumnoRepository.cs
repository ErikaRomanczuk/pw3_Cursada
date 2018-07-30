using practicaCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practicaCrud.Repository
{
    public class AlumnoRepository
    {
        List<Alumno> listAlumno = new List<Alumno>();


        public List<Alumno> listarAlumnos()
        {
            Alumno a1 = new Alumno();
            Alumno a2 = new Alumno();
            a1.Nombre = "Nombre 1";
            a1.Apellido = "Apellido 1";
            a1.id = 1;
            a2.Nombre = "Nombre 2";
            a2.Apellido = "Apellido 2";
            a2.id = 2;
            listAlumno.Add(a1);
            listAlumno.Add(a2);

            return listAlumno;

        }

        public void crearAlumno (Alumno alumno)
        {
            listAlumno.Add(alumno);

        }

        public Alumno buscarAlumnoPorId (int id)
        {
         //   List<Alumno> listAl = listarAlumnos();

            foreach(var al in listarAlumnos())
            {
                if (id == al.id)
                {
                    return al;
                }
            }

            throw new Exception("Alumno inexistente");
        }

        public void Modificar (Alumno alumno)
        {
            Alumno aluModi = buscarAlumnoPorId(alumno.id);
            aluModi.Nombre = alumno.Nombre;
            aluModi.Apellido = alumno.Apellido;
        }
    }
}