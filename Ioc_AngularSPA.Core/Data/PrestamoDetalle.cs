using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class PrestamoDetalle
    {
        public int ID { get; set; }
        public string NroGrupo { get; set; }
        public string SubCuenta { get; set; }
        public decimal MontoPrestamo { get; set; }
        public Prestamo Prestamo { get; set; }
        public int PrestamoId { get; set; }
    }
}
