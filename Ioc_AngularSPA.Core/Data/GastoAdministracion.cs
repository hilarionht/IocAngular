using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class GastoAdministracion :FidBase
    {
        public bool Cierre { get; set; }
        public virtual IEnumerable<GastoAdministracionDetalle> GastoAdministracionDetalles { get; set; }
        public virtual IList<GastoAdministracionArchivo> GastoAdministracionArchivos { get; set; }
    }
}
