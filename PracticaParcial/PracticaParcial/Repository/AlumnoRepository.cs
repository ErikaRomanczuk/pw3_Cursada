using PracticaParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaParcial.Repository
{
    public class AlumnoRepository
    {
        List<Alumno> lista = new List<Alumno>();
        public List<Alumno> listar ()
        {
            Alumno a1 = new Alumno();
            a1.nombre = "Alumno 1";
            a1.edad = 20;
            a1.id = 1;
            Alumno a2 = new Alumno();
            a2.nombre = "Alumno 2";
            a2.edad = 30;
            a2.id = 2;

            lista.Add(a1);
            lista.Add(a2);

            return lista;
        }

        public void Crear(Alumno alu)
        {
            Alumno nuevoAlumno = new Alumno();
            nuevoAlumno.nombre = alu.nombre;
            nuevoAlumno.edad = alu.edad;
            lista.Add(nuevoAlumno);
        }
        public Alumno buscarAlumnoPorId(int id)
        {
            List<Alumno> la = listar();
            foreach(var a in la)
            {
                if(a.id == id)
                {
                    return a;
                }
            }
            throw new Exception("Alumno no encontrado");
        }
        public void Modificar (Alumno alumno)
        {
            List<Alumno> la = listar();
            foreach(var al in la)
            {
                if (alumno.id == al.id)
                {
                    al.nombre = alumno.nombre;
                    al.edad = alumno.edad;
                    lista.Add(al);
                }
            }
        }
    }
}