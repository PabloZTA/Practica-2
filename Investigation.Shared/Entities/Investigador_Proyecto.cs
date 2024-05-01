using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Investigation.Shared.Entities
{
    public class Investigador_Proyecto
    {
        public int Id { get; set; }

        [JsonIgnore]
        public ProyectoInvestigacion ProyectoInvestigaciones { get; set; }
        public int ProyectoInvestigacionId { get; set; }

        [JsonIgnore]
        public Investigadores Investigadoress { get; set; }
        public int InvestigadoresId { get; set;}
    }
}
