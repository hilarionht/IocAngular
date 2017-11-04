using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class GastoAdministracionImpresion : PrintBase
    {
        public GastoAdministracion GastoAdministracion { get; set; }
        public int GastoAdministracionId { get; set; }

    }
}
