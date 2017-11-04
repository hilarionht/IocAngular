using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class DevolucionRecurso:FidBase
    {
        public decimal MontoSeleccionado { get; set; }
        public virtual IEnumerable<DevoluvionRecursoDetalle> DevolucionRecursoDetalles { get; set; }
        public virtual IList<DevolucionRecursoArchivo> DevolucionRecursoArchivo { get; set; }
    }
}
