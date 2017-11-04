using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc_AngularSPA.Core.Data;
using System.Data.Entity.ModelConfiguration;

namespace Ioc_AngularSPA.Data.Mapping
{
    class GastoAdministracionDetalleMap: EntityTypeConfiguration<GastoAdministracionDetalle>
    {
        public GastoAdministracionDetalleMap()
        {
            HasKey(t => t.Id);
            ToTable("FID_GastoAdministracionDetalle");
        }
    }
}
