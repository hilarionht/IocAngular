namespace Ioc_AngularSPA.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FID_ConciliacionImpresion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ConciliacionId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        FirmaResponsable = c.String(nullable: false, maxLength: 100, unicode: false),
                        FechaImpresion = c.DateTime(nullable: false),
                        EstatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_Conciliacion", t => t.ConciliacionId, cascadeDelete: true)
                .Index(t => t.ConciliacionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FID_ConciliacionImpresion", "ConciliacionId", "dbo.FID_Conciliacion");
            DropIndex("dbo.FID_ConciliacionImpresion", new[] { "ConciliacionId" });
            DropTable("dbo.FID_ConciliacionImpresion");
        }
    }
}
