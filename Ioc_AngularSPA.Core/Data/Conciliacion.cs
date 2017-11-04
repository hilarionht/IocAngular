using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class Conciliacion : FidBase
    {
        public DateTime FechaEmision { get; set; }
        public virtual IEnumerable<ConciliacionDetalle> ConciliacionDetalles { get; set; }
        public virtual IList<ConciliacionArchivo> ConciliacionArchivo { get; set; }
    }
}
