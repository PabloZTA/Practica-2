using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Shared.Entities
{
    internal class Actividad_Recurso
    {
        public int Id { get; set; }
        public int ActividadInvestigacionId { get; set; }

        public ActividadesInvestigacion ActividadesInvestigaciones { get; set; }

        public int RecursosEspecializadosId { get; set; }

        public RecursosEspecializados RecursosEspecializadoss { get; set; }
    }
}
