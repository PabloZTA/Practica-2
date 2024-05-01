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

        [JsonIgnore]
        public ActividadesInvestigacion ActividadesInvestigaciones { get; set; }

        public int ActividadesInvestigacionId { get; set; }

        [JsonIgnore]
        public RecursosEspecializados RecursosEspecializadoss { get; set; }

        public int RecursosEspecializadosId { get; set; }

    }
}
