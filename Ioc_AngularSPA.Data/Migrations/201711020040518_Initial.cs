namespace Ioc_AngularSPA.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FID_Aportacion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EstatusContratoId = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cierre = c.Boolean(nullable: false),
                        TipoMovimientoId = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaOperacion = c.DateTime(nullable: false),
                        MesAnio = c.DateTime(nullable: false),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aprobacion = c.Boolean(nullable: false),
                        EstatusMovimientoId = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        IdUsuarioModificion = c.Int(nullable: false),
                        IdUsuarioDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_EstatusMovimiento", t => t.EstatusMovimientoId, cascadeDelete: true)
                .ForeignKey("dbo.FID_TipoMovimiento", t => t.TipoMovimientoId, cascadeDelete: true)
                .Index(t => t.TipoMovimientoId)
                .Index(t => t.EstatusMovimientoId);
            
            CreateTable(
                "dbo.FID_AportacionArchivo",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        AportacionId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ContentType = c.String(nullable: false),
                        FileName = c.String(nullable: false),
                        Size = c.Long(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_Aportacion", t => t.AportacionId, cascadeDelete: true)
                .Index(t => t.AportacionId);
            
            CreateTable(
                "dbo.FID_EstatusMovimiento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FID_TipoMovimiento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                        UsuadioModiciacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FID_AportacionImpresion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AportacionId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        FirmaResponsable = c.String(nullable: false, maxLength: 100, unicode: false),
                        FechaImpresion = c.DateTime(nullable: false),
                        EstatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_Aportacion", t => t.AportacionId, cascadeDelete: true)
                .Index(t => t.AportacionId);
            
            CreateTable(
                "dbo.FID_CancelacionContratoImpresion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CancelacionContratoId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        FirmaResponsable = c.String(nullable: false, maxLength: 100, unicode: false),
                        FechaImpresion = c.DateTime(nullable: false),
                        EstatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_CancelacionContrato", t => t.CancelacionContratoId, cascadeDelete: true)
                .Index(t => t.CancelacionContratoId);
            
            CreateTable(
                "dbo.FID_CancelacionContrato",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EstatusContratoId = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cierre = c.Boolean(nullable: false),
                        TipoMovimientoId = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaOperacion = c.DateTime(nullable: false),
                        MesAnio = c.DateTime(nullable: false),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aprobacion = c.Boolean(nullable: false),
                        EstatusMovimientoId = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        IdUsuarioModificion = c.Int(nullable: false),
                        IdUsuarioDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_EstatusMovimiento", t => t.EstatusMovimientoId, cascadeDelete: true)
                .ForeignKey("dbo.FID_TipoMovimiento", t => t.TipoMovimientoId, cascadeDelete: true)
                .Index(t => t.TipoMovimientoId)
                .Index(t => t.EstatusMovimientoId);
            
            CreateTable(
                "dbo.FID_ConciliacionArchivo",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConciliacionId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ContentType = c.String(nullable: false),
                        FileName = c.String(nullable: false),
                        Size = c.Long(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_Conciliacion", t => t.ConciliacionId, cascadeDelete: true)
                .Index(t => t.ConciliacionId);
            
            CreateTable(
                "dbo.FID_Conciliacion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FechaEmision = c.DateTime(nullable: false),
                        TipoMovimientoId = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaOperacion = c.DateTime(nullable: false),
                        MesAnio = c.DateTime(nullable: false),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aprobacion = c.Boolean(nullable: false),
                        EstatusMovimientoId = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        IdUsuarioModificion = c.Int(nullable: false),
                        IdUsuarioDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_EstatusMovimiento", t => t.EstatusMovimientoId, cascadeDelete: true)
                .ForeignKey("dbo.FID_TipoMovimiento", t => t.TipoMovimientoId, cascadeDelete: true)
                .Index(t => t.TipoMovimientoId)
                .Index(t => t.EstatusMovimientoId);
            
            CreateTable(
                "dbo.FID_PrestamoImpresion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PrestamoId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        FirmaResponsable = c.String(nullable: false, maxLength: 100, unicode: false),
                        FechaImpresion = c.DateTime(nullable: false),
                        EstatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_Prestamo", t => t.PrestamoId, cascadeDelete: true)
                .Index(t => t.PrestamoId);
            
            CreateTable(
                "dbo.FID_Prestamo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IdTipoPrestamo = c.Int(nullable: false),
                        FechaMovGrupo = c.DateTime(nullable: false),
                        NoPrestamo = c.Int(nullable: false),
                        TieneInteres = c.Boolean(nullable: false),
                        TipoMovimientoId = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaOperacion = c.DateTime(nullable: false),
                        MesAnio = c.DateTime(nullable: false),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aprobacion = c.Boolean(nullable: false),
                        EstatusMovimientoId = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        IdUsuarioModificion = c.Int(nullable: false),
                        IdUsuarioDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_EstatusMovimiento", t => t.EstatusMovimientoId, cascadeDelete: true)
                .ForeignKey("dbo.FID_TipoMovimiento", t => t.TipoMovimientoId, cascadeDelete: true)
                .Index(t => t.TipoMovimientoId)
                .Index(t => t.EstatusMovimientoId);
            
            CreateTable(
                "dbo.FID_PrestamoArchivo",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        PrestamoId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ContentType = c.String(nullable: false),
                        FileName = c.String(nullable: false),
                        Size = c.Long(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_Prestamo", t => t.PrestamoId, cascadeDelete: true)
                .Index(t => t.PrestamoId);
            
            CreateTable(
                "dbo.FID_SolicitudRecursoImpresion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SolicitudRecursoId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        FirmaResponsable = c.String(nullable: false, maxLength: 100, unicode: false),
                        FechaImpresion = c.DateTime(nullable: false),
                        EstatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_SolicitudRecurso", t => t.SolicitudRecursoId, cascadeDelete: true)
                .Index(t => t.SolicitudRecursoId);
            
            CreateTable(
                "dbo.FID_SolicitudRecurso",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MontoSeleccionado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstatusContratoId = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoMovimientoId = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaOperacion = c.DateTime(nullable: false),
                        MesAnio = c.DateTime(nullable: false),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aprobacion = c.Boolean(nullable: false),
                        EstatusMovimientoId = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        IdUsuarioModificion = c.Int(nullable: false),
                        IdUsuarioDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_EstatusMovimiento", t => t.EstatusMovimientoId, cascadeDelete: true)
                .ForeignKey("dbo.FID_TipoMovimiento", t => t.TipoMovimientoId, cascadeDelete: true)
                .Index(t => t.TipoMovimientoId)
                .Index(t => t.EstatusMovimientoId);
            
            CreateTable(
                "dbo.FID_DevolucionRecursoArchivo",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        DevolucionRecursoId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ContentType = c.String(nullable: false),
                        FileName = c.String(nullable: false),
                        Size = c.Long(nullable: false),
                        Active = c.Boolean(nullable: false),
                        SolicitudRecurso_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_DevolucionRecurso", t => t.DevolucionRecursoId, cascadeDelete: true)
                .ForeignKey("dbo.FID_SolicitudRecurso", t => t.SolicitudRecurso_ID)
                .Index(t => t.DevolucionRecursoId)
                .Index(t => t.SolicitudRecurso_ID);
            
            CreateTable(
                "dbo.FID_DevolucionRecurso",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MontoSeleccionado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoMovimientoId = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaOperacion = c.DateTime(nullable: false),
                        MesAnio = c.DateTime(nullable: false),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aprobacion = c.Boolean(nullable: false),
                        EstatusMovimientoId = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        IdUsuarioModificion = c.Int(nullable: false),
                        IdUsuarioDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_EstatusMovimiento", t => t.EstatusMovimientoId, cascadeDelete: true)
                .ForeignKey("dbo.FID_TipoMovimiento", t => t.TipoMovimientoId, cascadeDelete: true)
                .Index(t => t.TipoMovimientoId)
                .Index(t => t.EstatusMovimientoId);
            
            CreateTable(
                "dbo.FID_DevolucionRecursoImpresion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DevolucionRecursoId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        FirmaResponsable = c.String(nullable: false, maxLength: 100, unicode: false),
                        FechaImpresion = c.DateTime(nullable: false),
                        EstatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_DevolucionRecurso", t => t.DevolucionRecursoId, cascadeDelete: true)
                .Index(t => t.DevolucionRecursoId);
            
            CreateTable(
                "dbo.FID_GastoAdministracionArchivo",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        GastoAdministracionId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ContentType = c.String(nullable: false),
                        FileName = c.String(nullable: false),
                        Size = c.Long(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_GastoAdministracion", t => t.GastoAdministracionId, cascadeDelete: true)
                .Index(t => t.GastoAdministracionId);
            
            CreateTable(
                "dbo.FID_GastoAdministracion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Cierre = c.Boolean(nullable: false),
                        TipoMovimientoId = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaOperacion = c.DateTime(nullable: false),
                        MesAnio = c.DateTime(nullable: false),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aprobacion = c.Boolean(nullable: false),
                        EstatusMovimientoId = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        IdUsuarioModificion = c.Int(nullable: false),
                        IdUsuarioDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_EstatusMovimiento", t => t.EstatusMovimientoId, cascadeDelete: true)
                .ForeignKey("dbo.FID_TipoMovimiento", t => t.TipoMovimientoId, cascadeDelete: true)
                .Index(t => t.TipoMovimientoId)
                .Index(t => t.EstatusMovimientoId);
            
            CreateTable(
                "dbo.FID_SolicitudRecursoArchivo",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        SolicitudRecursoId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ContentType = c.String(nullable: false),
                        FileName = c.String(nullable: false),
                        Size = c.Long(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_SolicitudRecurso", t => t.SolicitudRecursoId, cascadeDelete: true)
                .Index(t => t.SolicitudRecursoId);
            
            CreateTable(
                "dbo.FID_CancelacionContratoDetalle",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CancelacionContratoId = c.Int(nullable: false),
                        NroGrupo = c.String(nullable: false),
                        SubCuenta = c.String(nullable: false),
                        Contrato = c.String(nullable: false),
                        Cliente = c.String(nullable: false),
                        TotalAprobado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Penalizacion1994 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Penalizacion2006 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DevolucionAportaciones = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Selected = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_CancelacionContrato", t => t.CancelacionContratoId, cascadeDelete: true)
                .Index(t => t.CancelacionContratoId);
            
            CreateTable(
                "dbo.FID_AportacionDetalle",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NroGrupo = c.String(nullable: false),
                        SubCuenta = c.String(nullable: false),
                        SaldoAplicar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MontoTraspaso = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AportacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_Aportacion", t => t.AportacionId, cascadeDelete: true)
                .Index(t => t.AportacionId);
            
            CreateTable(
                "dbo.FID_ConciliacionDetalle",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NroGrupo = c.String(nullable: false),
                        SubCuenta = c.String(nullable: false),
                        SaldoAnterior = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UtilidadPerdidaOperacion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PlusValiaMinusvalia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UtilidadPerdida = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VencidoPlusvaliaMinusvalia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MensualUtilidadPerdida = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MensaulaPlusvaliaMinusvalia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MesActualComportamientoEfectivoCaja = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MesVencidoComportamientoEfectivoCaja = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EdoCuenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Diferencia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ConciliacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_Conciliacion", t => t.ConciliacionId, cascadeDelete: true)
                .Index(t => t.ConciliacionId);
            
            CreateTable(
                "dbo.FID_SolicitudRecursoDetalle",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NroGrupo = c.String(),
                        SubCuenta = c.String(),
                        Contrato = c.String(),
                        Cliente = c.String(),
                        Selected = c.Boolean(nullable: false),
                        FechaSolicitud = c.DateTime(nullable: false),
                        FechaAdjudicacion = c.DateTime(nullable: false),
                        FechaDisposicion = c.DateTime(nullable: false),
                        MontoAdjudicado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DevoluvionRecursoId = c.Int(nullable: false),
                        SolicitudRecurso_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_SolicitudRecurso", t => t.SolicitudRecurso_ID)
                .Index(t => t.SolicitudRecurso_ID);
            
            CreateTable(
                "dbo.FID_GastoAdministracionDetalle",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SaldoAplicar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MontoSolicitado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GastoAdministracionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FID_GastoAdministracion", t => t.GastoAdministracionId, cascadeDelete: true)
                .Index(t => t.GastoAdministracionId);
            
            CreateTable(
                "dbo.FID_DevolucionRecursoDetalle",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NroGrupo = c.String(),
                        SubCuenta = c.String(),
                        Contrato = c.String(),
                        Cliente = c.String(),
                        Selected = c.Boolean(nullable: false),
                        FechaSolicitud = c.DateTime(nullable: false),
                        MontoAdjudicado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DevoluvionRecursoId = c.Int(nullable: false),
                        DevolucionRecurso_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FID_DevolucionRecurso", t => t.DevolucionRecurso_ID)
                .Index(t => t.DevolucionRecurso_ID);
            
            CreateTable(
                "dbo.FID_PrestamoDetalle",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NroGrupo = c.String(),
                        SubCuenta = c.String(),
                        MontoPrestamo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrestamoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_Prestamo", t => t.PrestamoId, cascadeDelete: true)
                .Index(t => t.PrestamoId);
            
            CreateTable(
                "dbo.FID_GastoLegalPromocional",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TipoMovimientoId = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaOperacion = c.DateTime(nullable: false),
                        MesAnio = c.DateTime(nullable: false),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aprobacion = c.Boolean(nullable: false),
                        EstatusMovimientoId = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        IdUsuarioModificion = c.Int(nullable: false),
                        IdUsuarioDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_EstatusMovimiento", t => t.EstatusMovimientoId, cascadeDelete: true)
                .ForeignKey("dbo.FID_TipoMovimiento", t => t.TipoMovimientoId, cascadeDelete: true)
                .Index(t => t.TipoMovimientoId)
                .Index(t => t.EstatusMovimientoId);
            
            CreateTable(
                "dbo.FID_Cancelacion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EstatusContratoId = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cierre = c.Boolean(nullable: false),
                        TipoMovimientoId = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaOperacion = c.DateTime(nullable: false),
                        MesAnio = c.DateTime(nullable: false),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aprobacion = c.Boolean(nullable: false),
                        EstatusMovimientoId = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        IdUsuarioModificion = c.Int(nullable: false),
                        IdUsuarioDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_EstatusMovimiento", t => t.EstatusMovimientoId, cascadeDelete: true)
                .ForeignKey("dbo.FID_TipoMovimiento", t => t.TipoMovimientoId, cascadeDelete: true)
                .Index(t => t.TipoMovimientoId)
                .Index(t => t.EstatusMovimientoId);
            
            CreateTable(
                "dbo.FID_CancelacionArchivo",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        CancelacionId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ContentType = c.String(nullable: false),
                        FileName = c.String(nullable: false),
                        Size = c.Long(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_Cancelacion", t => t.CancelacionId, cascadeDelete: true)
                .Index(t => t.CancelacionId);
            
            CreateTable(
                "dbo.FID_CancelacionDetalle",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CancelacionId = c.Int(nullable: false),
                        NroGrupo = c.String(nullable: false),
                        SubCuenta = c.String(nullable: false),
                        Contrato = c.String(nullable: false),
                        Cliente = c.String(nullable: false),
                        TotalAprobado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Penalizacion1994 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Penalizacion2006 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DevolucionAportaciones = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Selected = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_Cancelacion", t => t.CancelacionId, cascadeDelete: true)
                .Index(t => t.CancelacionId);
            
            CreateTable(
                "dbo.FID_CancelacionImpresion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CancelacionId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        FirmaResponsable = c.String(nullable: false, maxLength: 100, unicode: false),
                        FechaImpresion = c.DateTime(nullable: false),
                        EstatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FID_Cancelacion", t => t.CancelacionId, cascadeDelete: true)
                .Index(t => t.CancelacionId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        UserModifedId = c.Int(nullable: false),
                        IP = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(maxLength: 100),
                        Address = c.String(maxLength: 4000),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        UserModifedId = c.Int(nullable: false),
                        IP = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProfile", "ID", "dbo.User");
            DropForeignKey("dbo.FID_CancelacionImpresion", "CancelacionId", "dbo.FID_Cancelacion");
            DropForeignKey("dbo.FID_CancelacionDetalle", "CancelacionId", "dbo.FID_Cancelacion");
            DropForeignKey("dbo.FID_Cancelacion", "TipoMovimientoId", "dbo.FID_TipoMovimiento");
            DropForeignKey("dbo.FID_Cancelacion", "EstatusMovimientoId", "dbo.FID_EstatusMovimiento");
            DropForeignKey("dbo.FID_CancelacionArchivo", "CancelacionId", "dbo.FID_Cancelacion");
            DropForeignKey("dbo.FID_GastoLegalPromocional", "TipoMovimientoId", "dbo.FID_TipoMovimiento");
            DropForeignKey("dbo.FID_GastoLegalPromocional", "EstatusMovimientoId", "dbo.FID_EstatusMovimiento");
            DropForeignKey("dbo.FID_PrestamoDetalle", "PrestamoId", "dbo.FID_Prestamo");
            DropForeignKey("dbo.FID_DevolucionRecursoDetalle", "DevolucionRecurso_ID", "dbo.FID_DevolucionRecurso");
            DropForeignKey("dbo.FID_GastoAdministracionDetalle", "GastoAdministracionId", "dbo.FID_GastoAdministracion");
            DropForeignKey("dbo.FID_SolicitudRecursoDetalle", "SolicitudRecurso_ID", "dbo.FID_SolicitudRecurso");
            DropForeignKey("dbo.FID_ConciliacionDetalle", "ConciliacionId", "dbo.FID_Conciliacion");
            DropForeignKey("dbo.FID_AportacionDetalle", "AportacionId", "dbo.FID_Aportacion");
            DropForeignKey("dbo.FID_CancelacionContratoDetalle", "CancelacionContratoId", "dbo.FID_CancelacionContrato");
            DropForeignKey("dbo.FID_SolicitudRecursoArchivo", "SolicitudRecursoId", "dbo.FID_SolicitudRecurso");
            DropForeignKey("dbo.FID_GastoAdministracion", "TipoMovimientoId", "dbo.FID_TipoMovimiento");
            DropForeignKey("dbo.FID_GastoAdministracionArchivo", "GastoAdministracionId", "dbo.FID_GastoAdministracion");
            DropForeignKey("dbo.FID_GastoAdministracion", "EstatusMovimientoId", "dbo.FID_EstatusMovimiento");
            DropForeignKey("dbo.FID_DevolucionRecursoImpresion", "DevolucionRecursoId", "dbo.FID_DevolucionRecurso");
            DropForeignKey("dbo.FID_SolicitudRecursoImpresion", "SolicitudRecursoId", "dbo.FID_SolicitudRecurso");
            DropForeignKey("dbo.FID_SolicitudRecurso", "TipoMovimientoId", "dbo.FID_TipoMovimiento");
            DropForeignKey("dbo.FID_SolicitudRecurso", "EstatusMovimientoId", "dbo.FID_EstatusMovimiento");
            DropForeignKey("dbo.FID_DevolucionRecursoArchivo", "SolicitudRecurso_ID", "dbo.FID_SolicitudRecurso");
            DropForeignKey("dbo.FID_DevolucionRecurso", "TipoMovimientoId", "dbo.FID_TipoMovimiento");
            DropForeignKey("dbo.FID_DevolucionRecurso", "EstatusMovimientoId", "dbo.FID_EstatusMovimiento");
            DropForeignKey("dbo.FID_DevolucionRecursoArchivo", "DevolucionRecursoId", "dbo.FID_DevolucionRecurso");
            DropForeignKey("dbo.FID_PrestamoImpresion", "PrestamoId", "dbo.FID_Prestamo");
            DropForeignKey("dbo.FID_Prestamo", "TipoMovimientoId", "dbo.FID_TipoMovimiento");
            DropForeignKey("dbo.FID_PrestamoArchivo", "PrestamoId", "dbo.FID_Prestamo");
            DropForeignKey("dbo.FID_Prestamo", "EstatusMovimientoId", "dbo.FID_EstatusMovimiento");
            DropForeignKey("dbo.FID_Conciliacion", "TipoMovimientoId", "dbo.FID_TipoMovimiento");
            DropForeignKey("dbo.FID_Conciliacion", "EstatusMovimientoId", "dbo.FID_EstatusMovimiento");
            DropForeignKey("dbo.FID_ConciliacionArchivo", "ConciliacionId", "dbo.FID_Conciliacion");
            DropForeignKey("dbo.FID_CancelacionContratoImpresion", "CancelacionContratoId", "dbo.FID_CancelacionContrato");
            DropForeignKey("dbo.FID_CancelacionContrato", "TipoMovimientoId", "dbo.FID_TipoMovimiento");
            DropForeignKey("dbo.FID_CancelacionContrato", "EstatusMovimientoId", "dbo.FID_EstatusMovimiento");
            DropForeignKey("dbo.FID_AportacionImpresion", "AportacionId", "dbo.FID_Aportacion");
            DropForeignKey("dbo.FID_Aportacion", "TipoMovimientoId", "dbo.FID_TipoMovimiento");
            DropForeignKey("dbo.FID_Aportacion", "EstatusMovimientoId", "dbo.FID_EstatusMovimiento");
            DropForeignKey("dbo.FID_AportacionArchivo", "AportacionId", "dbo.FID_Aportacion");
            DropIndex("dbo.UserProfile", new[] { "ID" });
            DropIndex("dbo.FID_CancelacionImpresion", new[] { "CancelacionId" });
            DropIndex("dbo.FID_CancelacionDetalle", new[] { "CancelacionId" });
            DropIndex("dbo.FID_CancelacionArchivo", new[] { "CancelacionId" });
            DropIndex("dbo.FID_Cancelacion", new[] { "EstatusMovimientoId" });
            DropIndex("dbo.FID_Cancelacion", new[] { "TipoMovimientoId" });
            DropIndex("dbo.FID_GastoLegalPromocional", new[] { "EstatusMovimientoId" });
            DropIndex("dbo.FID_GastoLegalPromocional", new[] { "TipoMovimientoId" });
            DropIndex("dbo.FID_PrestamoDetalle", new[] { "PrestamoId" });
            DropIndex("dbo.FID_DevolucionRecursoDetalle", new[] { "DevolucionRecurso_ID" });
            DropIndex("dbo.FID_GastoAdministracionDetalle", new[] { "GastoAdministracionId" });
            DropIndex("dbo.FID_SolicitudRecursoDetalle", new[] { "SolicitudRecurso_ID" });
            DropIndex("dbo.FID_ConciliacionDetalle", new[] { "ConciliacionId" });
            DropIndex("dbo.FID_AportacionDetalle", new[] { "AportacionId" });
            DropIndex("dbo.FID_CancelacionContratoDetalle", new[] { "CancelacionContratoId" });
            DropIndex("dbo.FID_SolicitudRecursoArchivo", new[] { "SolicitudRecursoId" });
            DropIndex("dbo.FID_GastoAdministracion", new[] { "EstatusMovimientoId" });
            DropIndex("dbo.FID_GastoAdministracion", new[] { "TipoMovimientoId" });
            DropIndex("dbo.FID_GastoAdministracionArchivo", new[] { "GastoAdministracionId" });
            DropIndex("dbo.FID_DevolucionRecursoImpresion", new[] { "DevolucionRecursoId" });
            DropIndex("dbo.FID_DevolucionRecurso", new[] { "EstatusMovimientoId" });
            DropIndex("dbo.FID_DevolucionRecurso", new[] { "TipoMovimientoId" });
            DropIndex("dbo.FID_DevolucionRecursoArchivo", new[] { "SolicitudRecurso_ID" });
            DropIndex("dbo.FID_DevolucionRecursoArchivo", new[] { "DevolucionRecursoId" });
            DropIndex("dbo.FID_SolicitudRecurso", new[] { "EstatusMovimientoId" });
            DropIndex("dbo.FID_SolicitudRecurso", new[] { "TipoMovimientoId" });
            DropIndex("dbo.FID_SolicitudRecursoImpresion", new[] { "SolicitudRecursoId" });
            DropIndex("dbo.FID_PrestamoArchivo", new[] { "PrestamoId" });
            DropIndex("dbo.FID_Prestamo", new[] { "EstatusMovimientoId" });
            DropIndex("dbo.FID_Prestamo", new[] { "TipoMovimientoId" });
            DropIndex("dbo.FID_PrestamoImpresion", new[] { "PrestamoId" });
            DropIndex("dbo.FID_Conciliacion", new[] { "EstatusMovimientoId" });
            DropIndex("dbo.FID_Conciliacion", new[] { "TipoMovimientoId" });
            DropIndex("dbo.FID_ConciliacionArchivo", new[] { "ConciliacionId" });
            DropIndex("dbo.FID_CancelacionContrato", new[] { "EstatusMovimientoId" });
            DropIndex("dbo.FID_CancelacionContrato", new[] { "TipoMovimientoId" });
            DropIndex("dbo.FID_CancelacionContratoImpresion", new[] { "CancelacionContratoId" });
            DropIndex("dbo.FID_AportacionImpresion", new[] { "AportacionId" });
            DropIndex("dbo.FID_AportacionArchivo", new[] { "AportacionId" });
            DropIndex("dbo.FID_Aportacion", new[] { "EstatusMovimientoId" });
            DropIndex("dbo.FID_Aportacion", new[] { "TipoMovimientoId" });
            DropTable("dbo.UserProfile");
            DropTable("dbo.User");
            DropTable("dbo.FID_CancelacionImpresion");
            DropTable("dbo.FID_CancelacionDetalle");
            DropTable("dbo.FID_CancelacionArchivo");
            DropTable("dbo.FID_Cancelacion");
            DropTable("dbo.FID_GastoLegalPromocional");
            DropTable("dbo.FID_PrestamoDetalle");
            DropTable("dbo.FID_DevolucionRecursoDetalle");
            DropTable("dbo.FID_GastoAdministracionDetalle");
            DropTable("dbo.FID_SolicitudRecursoDetalle");
            DropTable("dbo.FID_ConciliacionDetalle");
            DropTable("dbo.FID_AportacionDetalle");
            DropTable("dbo.FID_CancelacionContratoDetalle");
            DropTable("dbo.FID_SolicitudRecursoArchivo");
            DropTable("dbo.FID_GastoAdministracion");
            DropTable("dbo.FID_GastoAdministracionArchivo");
            DropTable("dbo.FID_DevolucionRecursoImpresion");
            DropTable("dbo.FID_DevolucionRecurso");
            DropTable("dbo.FID_DevolucionRecursoArchivo");
            DropTable("dbo.FID_SolicitudRecurso");
            DropTable("dbo.FID_SolicitudRecursoImpresion");
            DropTable("dbo.FID_PrestamoArchivo");
            DropTable("dbo.FID_Prestamo");
            DropTable("dbo.FID_PrestamoImpresion");
            DropTable("dbo.FID_Conciliacion");
            DropTable("dbo.FID_ConciliacionArchivo");
            DropTable("dbo.FID_CancelacionContrato");
            DropTable("dbo.FID_CancelacionContratoImpresion");
            DropTable("dbo.FID_AportacionImpresion");
            DropTable("dbo.FID_TipoMovimiento");
            DropTable("dbo.FID_EstatusMovimiento");
            DropTable("dbo.FID_AportacionArchivo");
            DropTable("dbo.FID_Aportacion");
        }
    }
}
