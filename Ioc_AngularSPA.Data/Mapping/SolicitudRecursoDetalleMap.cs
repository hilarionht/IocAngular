using Ioc_AngularSPA.Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Data.Mapping
{
    public class SolicitudRecursoDetalleMap : EntityTypeConfiguration<SolicitudRecursoDetalle>
    {
        public SolicitudRecursoDetalleMap()
        {
            HasKey(x => x.ID);
            ToTable("FID_SolicitudRecursoDetalle");
        }
    }
}
