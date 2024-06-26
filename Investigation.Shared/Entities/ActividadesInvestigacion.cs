﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Shared.Entities
{
    public class ActividadesInvestigacion
    {
        public int Id { get; set; }


        [Display(Name = "Nombre: ")]
        [MaxLength(100, ErrorMessage = "No se permiten más de 50 Caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }



        [Display(Name = "Descripción")]
        [MaxLength(100, ErrorMessage = "No se permiten más de 100 Caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Descripcion { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public DateTime FechaInicio { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public DateTime FechaFinal { get; set; }

        //Relacion con proyectos de investigacion cientifica
        public ProyectoInvestigacion ProyectoInvestigaciones { get; set; }
 
        //Relacion con recursos especializados
        public ICollection<RecursosEspecializados> RecursosEspecializados { get; set; } = new List<RecursosEspecializados>();

        public ICollection<Actividad_Recurso> Actividad_Recursos { get; set; } 


    }
}
