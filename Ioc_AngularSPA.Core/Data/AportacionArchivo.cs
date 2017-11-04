using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class AportacionArchivo: FidFileBase
    {
       
        public Aportacion Aportacion { get; set; }
        public int AportacionId { get; set; }
    }
}
