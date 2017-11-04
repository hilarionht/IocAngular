using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc_AngularSPA.Core.Data;

namespace Ioc_AngularSPA.Data.Mapping
{
    public class GastoAdministracionArchivoMap : EntityTypeConfiguration<GastoAdministracionArchivo>
    {
        public GastoAdministracionArchivoMap()
        {
            //key
            HasKey(t => t.ID);
            //properties
            Property(t => t.Date).IsRequired();
            Property(t => t.ContentType).IsRequired();
            Property(t => t.FileName).IsRequired();
            Property(t => t.Size).IsRequired();
            Property(t => t.Active).IsRequired();


            
            //table  
            ToTable("FID_GastoAdministracionArchivo");

        }
    }
}
