using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class CancelacionContrato:FidBase
    {
        public int EstatusContratoId { get; set; }
        public decimal Total { get; set; }
        public bool Cierre { get; set; }
        public virtual IEnumerable<CancelacionContratoDetalle> CancelacionContratoDetalles { get; set; }
    }
}
