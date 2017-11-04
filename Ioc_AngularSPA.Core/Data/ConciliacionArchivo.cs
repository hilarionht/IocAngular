using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class ConciliacionArchivo: FidFileBase
    {
        public Conciliacion Conciliacion { get; set; }
        public int ConciliacionId { get; set; }
    }
}
