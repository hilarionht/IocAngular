using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class SolicitudRecursoImpresion : PrintBase
    {
        public SolicitudRecurso SolicitudRecurso { get; set; }
        public int SolicitudRecursoId { get; set; }

    }
}
