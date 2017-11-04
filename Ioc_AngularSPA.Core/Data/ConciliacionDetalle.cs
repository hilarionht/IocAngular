using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class ConciliacionDetalle
    {
        public int ID { get; set; }
        public string NroGrupo { get; set; }
        public string SubCuenta { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal UtilidadPerdidaOperacion { get; set; }
        public decimal PlusValiaMinusvalia { get; set; }
        public decimal UtilidadPerdida { get; set; }
        public decimal VencidoPlusvaliaMinusvalia { get; set; }
        public decimal MensualUtilidadPerdida { get; set; }
        public decimal MensaulaPlusvaliaMinusvalia { get; set; }
        public decimal Total { get; set; }
        public decimal MesActualComportamientoEfectivoCaja { get; set; }
        public decimal MesVencidoComportamientoEfectivoCaja { get; set; }
        public decimal EdoCuenta { get; set; }
        public decimal Diferencia { get; set; }
        public Conciliacion Conciliacion { get; set; }
        public int ConciliacionId { get; set; }

    }
}
