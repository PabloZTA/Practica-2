using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Investigation.Shared.Entities
{
    public class Actividad_Recurso
    {
        public int Id { get; set; }

        public ActividadesInvestigacion ActividadesInvestigaciones { get; set; }

        public RecursosEspecializados RecursosEspecializadoss { get; set; }
    }
}
