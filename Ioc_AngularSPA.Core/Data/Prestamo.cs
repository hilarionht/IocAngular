using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class Prestamo:FidBase
    {
        
        public int IdTipoPrestamo { get; set; }
        public DateTime FechaMovGrupo { get; set; }
        public int NoPrestamo { get; set; }
        public bool TieneInteres { get; set; }
        public virtual IEnumerable<PrestamoDetalle> PrestamoDetalles { get; set; }
        public virtual IList<PrestamoArchivo> PrestamoArchivos { get; set; }
    }
}
