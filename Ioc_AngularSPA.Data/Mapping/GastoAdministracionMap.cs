using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc_AngularSPA.Core.Data;
using System.Data.Entity.ModelConfiguration;

namespace Ioc_AngularSPA.Data.Mapping
{
    class GastoAdministracionMap: EntityTypeConfiguration<GastoAdministracion>
    {
        public GastoAdministracionMap()
        {
            HasKey(t => t.ID);
            ToTable("FID_GastoAdministracion");
        }
    }
}
