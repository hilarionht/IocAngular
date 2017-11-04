using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class Cancelacion:FidBase
    {
        public int EstatusContratoId { get; set; }
        public decimal Total { get; set; }
        public bool Cierre { get; set; }

        public virtual IEnumerable<CancelacionDetalle> DetalleCancelaciones { get; set; }
        public virtual IList<CancelacionArchivo> CancelacionArchivos { get; set; }
    }
}
