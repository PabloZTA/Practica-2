using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Shared.Entities
{
    internal class Investigador_Proyecto
    {
        public int Id { get; set; }

        public int ProyectoInvestigacionId { get; set; }

        public ProyectoInvestigacion ProyectoInvestigaciones { get; set; }

        public int InvestigadoresId { get; set; }

        public Investigadores Investigadores { get; set; }
    }
}
