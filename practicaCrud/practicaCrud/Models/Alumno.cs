using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace practicaCrud.Models
{
    public class Alumno
    {
        public int id { get; set; }

        [Required(ErrorMessage = "El nombre {0} es incorrecto")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido {0} es incorrecto")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
    }
}