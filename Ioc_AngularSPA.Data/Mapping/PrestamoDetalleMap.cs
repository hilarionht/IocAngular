using Ioc_AngularSPA.Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Data.Mapping
{
    class PrestamoDetalleMap: EntityTypeConfiguration<PrestamoDetalle>
    {
        public PrestamoDetalleMap()
        {
            HasKey(d=> d.ID);
            ToTable("FID_PrestamoDetalle");
        }
    }
}
