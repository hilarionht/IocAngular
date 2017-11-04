using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core
{
    public class FidDetBase
    {
        public int ID { get; set; }
        public string NroGrupo { get; set; }
        public string SubCuenta { get; set; }
        public string Contrato { get; set; }
        public string Cliente { get; set; }
        public decimal TotalAprobado { get; set; }
        public decimal Penalizacion1994 { get; set; }
        public decimal Penalizacion2006 { get; set; }
        public decimal DevolucionAportaciones { get; set; }
        public bool Selected { get; set; }
    }
}
