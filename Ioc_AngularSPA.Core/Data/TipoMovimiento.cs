using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class TipoMovimiento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Creado { get; set; }
        public DateTime Modificado { get; set; }
        public int UsuadioModiciacionId { get; set; }

    }
}
