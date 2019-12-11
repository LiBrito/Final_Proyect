using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Visitas.Models
{
    public class Contacto
    {
        [Key]
        public int ContactoID { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Identificacion { get; set; }
        [Display(Name ="Fecha de Creacion")]
        public DateTime CreDate { get; set; }
    }
}