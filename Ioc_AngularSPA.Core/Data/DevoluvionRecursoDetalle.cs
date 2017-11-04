using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class DevoluvionRecursoDetalle
    {
        public int Id { get; set; }
        public string NroGrupo { get; set; }
        public string SubCuenta { get; set; }
        public string Contrato { get; set; }
        public string Cliente { get; set; }
        [Required]
        public bool Selected { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public decimal MontoAdjudicado { get; set; }
        public DevolucionRecurso  DevolucionRecurso { get; set; }
        public int DevoluvionRecursoId { get; set; }
    }
}
