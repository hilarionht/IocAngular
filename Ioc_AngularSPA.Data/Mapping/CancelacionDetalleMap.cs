using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc_AngularSPA.Core.Data;

namespace Ioc_AngularSPA.Data.Mapping
{
    public class CancelacionDetalleMap : EntityTypeConfiguration<CancelacionDetalle>
    {
        public CancelacionDetalleMap()
        {
            HasKey(t => t.ID);
            //properties             
            Property(t => t.NroGrupo ).IsRequired();
            Property(t => t.SubCuenta ).IsRequired();
            Property(t => t.Contrato ).IsRequired();
            Property(t => t.Cliente ).IsRequired();
            Property(t => t.TotalAprobado ).IsRequired();
            Property(t => t.Penalizacion1994 ).IsRequired();
            Property(t => t.Penalizacion2006 ).IsRequired();
            Property(t => t.DevolucionAportaciones).IsRequired();
            //table          DevolucionAportaciones
            ToTable("FID_CancelacionDetalle");
        }
    }
}
