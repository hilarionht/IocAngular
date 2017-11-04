using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class PrestamoImpresion : PrintBase
    {
        public Prestamo Prestamo { get; set; }
        public int PrestamoId { get; set; }

    }
}
