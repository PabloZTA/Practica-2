using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Investigation.Shared.Entities
{
    public class Publicacion
    {

        public int Id { get; set; }

        [Display(Name = "Título de la publicación")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Titulo { get; set; }

        [Display(Name = "Nombre del Autor")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Autor {  get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime FechaPublicacion { get; set; }

        //Relacion con proyectos de investigacion
        [JsonIgnore]

        public ProyectoInvestigacion Proyectos { get; set; }
    }
}
