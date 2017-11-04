using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class SolicitudRecurso:FidBase
    {
        public decimal MontoSeleccionado { get; set; }
        public int EstatusContratoId { get; set; }
        public decimal Total { get; set; }
        public virtual IEnumerable<SolicitudRecursoDetalle> DevolucionRecursoDetalles { get; set; }
        public virtual IList<DevolucionRecursoArchivo>  DevolucionRecursoArchivos { get; set; }
    }
}
