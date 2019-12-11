namespace ClubReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Afiliadoes",
                c => new
                    {
                        AfiliadoID = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        BDate = c.DateTime(nullable: false),
                        Edad = c.Int(nullable: false),
                        Socios_SocioID = c.Int(),
                        Socio_SocioID = c.Int(),
                        SocioID_SocioID = c.Int(),
                    })
                .PrimaryKey(t => t.AfiliadoID)
                .ForeignKey("dbo.Socios", t => t.Socios_SocioID)
                .ForeignKey("dbo.Socios", t => t.Socio_SocioID)
                .ForeignKey("dbo.Socios", t => t.SocioID_SocioID)
                .Index(t => t.Socios_SocioID)
                .Index(t => t.Socio_SocioID)
                .Index(t => t.SocioID_SocioID);
            
            CreateTable(
                "dbo.Socios",
                c => new
                    {
                        SocioID = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        Identificacion = c.String(),
                        Telefono = c.Long(nullable: false),
                        Celular = c.Long(nullable: false),
                        Sexo = c.String(),
                        Edad = c.Int(nullable: false),
                        BDate = c.DateTime(nullable: false),
                        Membresia = c.String(),
                        LTrabajo = c.String(),
                        tradress = c.String(),
                        TelOffice = c.String(),
                        EstMen = c.Boolean(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Imagen = c.String(),
                        AfiliadoID_AfiliadoID = c.Int(),
                    })
                .PrimaryKey(t => t.SocioID)
                .ForeignKey("dbo.Afiliadoes", t => t.AfiliadoID_AfiliadoID)
                .Index(t => t.AfiliadoID_AfiliadoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Afiliadoes", "SocioID_SocioID", "dbo.Socios");
            DropForeignKey("dbo.Afiliadoes", "Socio_SocioID", "dbo.Socios");
            DropForeignKey("dbo.Socios", "AfiliadoID_AfiliadoID", "dbo.Afiliadoes");
            DropForeignKey("dbo.Afiliadoes", "Socios_SocioID", "dbo.Socios");
            DropIndex("dbo.Socios", new[] { "AfiliadoID_AfiliadoID" });
            DropIndex("dbo.Afiliadoes", new[] { "SocioID_SocioID" });
            DropIndex("dbo.Afiliadoes", new[] { "Socio_SocioID" });
            DropIndex("dbo.Afiliadoes", new[] { "Socios_SocioID" });
            DropTable("dbo.Socios");
            DropTable("dbo.Afiliadoes");
        }
    }
}
