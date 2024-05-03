using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Investigation.Shared.Entities
{
    public class Investigador
    {
        public int Id { get; set; }


        [Display(Name = "Cedula")]
        [MaxLength(100, ErrorMessage = "No se permiten más de 100 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Cedula { get; set; }

        [Display(Name ="Nombre")]
        [MaxLength(100, ErrorMessage ="No se permiten más de 100 dígitos")]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string Nombre { get; set; }
        [Display(Name = "Especialidad")]
        [MaxLength(100, ErrorMessage = "No se permiten más de 100 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string especialidad { get; set; }

        [Display(Name = "Afiliacion")]
        [MaxLength(100, ErrorMessage = "No se permiten más de 100 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string afiliacion { get; set; }

        [JsonIgnore]
        public ProyectoInvestigacion ProyectoInvestigacion { get; set; } 
    }
}
