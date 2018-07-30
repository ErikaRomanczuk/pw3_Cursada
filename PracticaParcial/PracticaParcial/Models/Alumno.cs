using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaParcial.Models
{
    public class Alumno
    {
        public int id;
        [Required(ErrorMessage = "El nombre {0} no es válido")]
        [Display(Description = "NombrE")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "La edad {0} es inválida")]
        [Display(Description = "EdaD")]
        public int edad { get; set; }
    }
}