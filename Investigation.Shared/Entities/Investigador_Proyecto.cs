using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Shared.Entities
{
    public class Investigador_Proyecto
    {
        public int Id { get; set; }

        public ProyectoInvestigacion ProyectoInvestigaciones { get; set; }

        public Investigadores Investigadoress { get; set; }
    }
}
