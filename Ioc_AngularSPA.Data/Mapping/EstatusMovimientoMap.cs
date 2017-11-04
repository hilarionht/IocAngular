using Ioc_AngularSPA.Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Data.Mapping
{
    class EstatusMovimientoMap : EntityTypeConfiguration<EstatusMovimiento>
    {
        public EstatusMovimientoMap()
        {
            //key  
            HasKey(t => t.Id);
            //properties  
            ToTable("FID_EstatusMovimiento");
        }
        
    }
}
