using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class GastoAdministracionDetalle
    {
        public int Id { get; set; }
        public decimal SaldoAplicar { get; set; }
        public decimal MontoSolicitado { get; set; }
        public GastoAdministracion GastoAdministracion { get; set; }
        public int GastoAdministracionId { get; set; }
    }
}
