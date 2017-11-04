using Ioc_AngularSPA.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core
{
    public class FidBase
    {
        public int ID { get; set; }
        public TipoMovimiento TipoMovimiento { get; set; }
        public int TipoMovimientoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaOperacion { get; set; }
        public DateTime MesAnio { get; set; }
        public decimal Monto { get; set; }
        public bool Aprobacion { get; set; }
        public EstatusMovimiento EstatusMovimiento { get; set; }
        public int EstatusMovimientoId { get; set; }
        public bool Deleted { get; set; }
        public int IdUsuario { get; set; }
        public int IdUsuarioModificion { get; set; }
        public int IdUsuarioDeleted { get; set; }
    }
}
