using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClubReg.Models
{
    public class Afiliado
    {
        [Key]
        public int AfiliadoID { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime BDate { get; set; }
        public int Edad { get; set; }
        public Socios SocioID { get; set; }
        public virtual Socios Socio { get; set; }
    }
}