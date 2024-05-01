using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Investigation.Shared.Entities
{
    public class RecursosEspecializados
    {
        public int Id { get; set; }


        [Display(Name = "Nombre: ")]
        [MaxLength(100, ErrorMessage = "No se permiten más de 50 Caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }



        [Display(Name = "Cantidad Requerida: ")]
        public float CantRequerida { get; set; }


        [Display(Name = "Proveedor: ")]
        [MaxLength(100, ErrorMessage = "No se permiten más de 50 Caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Proveedor { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public DateTime FechaEntrega { get; set; }

        //Relacion con actividades de investigacion
        [JsonIgnore]

        public ProyectoInvestigacion ProyectosInvestigaciones { get; set; }
        public int ProyectoInvestigacionId { get; set; }    

    }
}
