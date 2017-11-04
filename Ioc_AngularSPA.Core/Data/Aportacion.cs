using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{

    public class Aportacion : FidBase
    {
        public int EstatusContratoId { get; set; }
        public decimal Total { get; set; }
        public bool Cierre { get; set; }
        public virtual IEnumerable<AportacionDetalle> AportacionDetalles { get; set; }
        public virtual IList<AportacionArchivo> AportacionArchivo { get; set; }
    }
}
