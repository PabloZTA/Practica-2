using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Shared.Entities
{
    public class ProyectoInvestigacion
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de Proyecto")]
        [MaxLength(100, ErrorMessage = "No se permiten más de 100 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre_Proyecto { get; set; }


        [Display(Name = "Descripción")]
        [MaxLength(200, ErrorMessage = "No se permiten más de 200 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Descripcion { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime FechaInicio { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime FechaFinal { get; set; }

        //public Investigadores Investigadores { get; set; }
        //public RecursosEspecializados RecursosEspecializados { get; set; }

        //Relacion con actividades de Investigacion
        public ICollection<ActividadesInvestigacion> ActividadesInvestigacion { get; set; } = new HashSet<ActividadesInvestigacion>();

        //Relacion con recursos especializados
        public ICollection<RecursosEspecializados> RecursosEspecializados { get; set; } = new HashSet<RecursosEspecializados>();

        //Relacion con publicaciones
        public ICollection<Publicacion> Publicaciones { get; set; } = new HashSet<Publicacion>();


    }
}
