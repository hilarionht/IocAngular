using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Ioc_AngularSPA.Core.Data;

namespace Ioc_AngularSPA.Data.Mapping
{
    class DevolucionRecursoMap : EntityTypeConfiguration<DevolucionRecurso>
    {
        public DevolucionRecursoMap()
        {
            //key  
            HasKey(t => t.ID);
            //properties  
            ToTable("FID_DevolucionRecurso");

        }

    }
}
