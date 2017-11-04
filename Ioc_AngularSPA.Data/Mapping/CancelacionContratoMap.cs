using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc_AngularSPA.Core.Data;

namespace Ioc_AngularSPA.Data.Mapping
{
    public class CancelacionContratoMap: EntityTypeConfiguration<CancelacionContrato>
    {
        public CancelacionContratoMap()
        {
            //key  
            HasKey(t => t.ID);
            //properties             
            Property(t => t.FechaRegistro).IsRequired();
            Property(t => t.FechaOperacion).IsRequired();
            Property(t => t.MesAnio).IsRequired();
            Property(t => t.Aprobacion).IsRequired();
            Property(t => t.IdUsuario).IsRequired();
            //table  
            ToTable("FID_CancelacionContrato");
            //relation            
            //HasRequired(t => t.User).WithRequiredDependent(u => u.UserProfile);
        }
    }
}
