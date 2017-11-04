using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core
{
    public class PrintBase
    {
        public int ID { get; set; }
        public int UsuarioId { get; set; }
        public string FirmaResponsable { get; set; }
        public DateTime FechaImpresion { get; set; }
        public int EstatusId { get; set; }
    }
}
