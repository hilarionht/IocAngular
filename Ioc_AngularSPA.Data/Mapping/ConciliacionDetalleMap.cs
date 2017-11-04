using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc_AngularSPA.Core.Data;

namespace Ioc_AngularSPA.Data.Mapping
{
    public class ConciliacionDetalleMap : EntityTypeConfiguration<ConciliacionDetalle>
    {
        public ConciliacionDetalleMap()
        {
            HasKey(t => t.ID);
            //properties             
            Property(t => t.NroGrupo ).IsRequired();
            Property(t => t.SubCuenta ).IsRequired();
           
            //table          DevolucionAportaciones
            ToTable("FID_ConciliacionDetalle");
        }
    }
}
