using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class AportacionDetalle 
    {
        public int ID { get; set; }
        public string NroGrupo { get; set; }
        public string SubCuenta { get; set; }
        public decimal SaldoAplicar { get; set; }
        public decimal MontoTraspaso { get; set; }
        public Aportacion Aportacion { get; set; }
        public int AportacionId { get; set; }
    }
}
