using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Visitas.Models
{
    public class Visita
    {
        [Key]
        public int VisitaID { get; set; }
        [Display(Name = "Fecha de Visita")]
        public DateTime date_vis { get; set; }
        [Display(Name = "Hora de Visita")]
        public TimeSpan bg_vis { get; set; }
        [Display(Name = "Hora de Salida")]
        public TimeSpan end_vis { get; set; }
        [Display(Name = "Motivo de Visita")]
        public String vis_motive { get; set; }
        public virtual Contacto Contacto { get; set; }
        public int ContactoID { get; set; }
    }
}