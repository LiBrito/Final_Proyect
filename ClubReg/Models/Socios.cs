using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClubReg.Models
{
    public class Socios
    {
        [Key]
        public int SocioID { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Identificacion { get; set; }
        public long Telefono { get; set; }
        public long Celular { get; set; }
        public String Sexo { get; set; }
        public int Edad { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime BDate { get; set; }
        public String Membresia { get; set; }
        [Display(Name = "Lugar de Trabajo")]
        public String LTrabajo { get; set; }
        [Display(Name = "Direccion del Trabajo")]
        public String tradress { get; set; }
        [Display(Name = "Telefono de Oficina")]
        public String TelOffice { get; set; }
        [Display(Name = "Estado de Menbresia")]
        public Boolean EstMen { get; set; }

        [Display(Name = "Fecha de Salida")]
        public DateTime EndDate { get; set; }
        public Afiliado AfiliadoID { get; set; }
        public virtual ICollection<Afiliado> Afiliado { get; set; }
        public String Imagen { get; set; }

    }
}