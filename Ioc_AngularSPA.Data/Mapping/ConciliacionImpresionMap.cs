using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc_AngularSPA.Core.Data;

namespace Ioc_AngularSPA.Data.Mapping
{
    public class ConciliacionImpresionMap : EntityTypeConfiguration<ConciliacionImpresion>
    {
        public ConciliacionImpresionMap()
        {
            //key
            HasKey(t => t.ID);
            //properties
            Property(t => t.FirmaResponsable).IsRequired().HasMaxLength(100).HasColumnType("Varchar"); 
            Property(t => t.FechaImpresion).IsRequired();
            Property(t => t.FechaImpresion).IsRequired();
            Property(t => t.EstatusId).IsRequired();
            //autor
            Property(t => t.UsuarioId).IsRequired();
            //table  
            ToTable(tableName: "FID_ConciliacionImpresion");
        }
    }
}
