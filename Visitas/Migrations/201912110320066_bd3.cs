namespace Visitas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bd3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        ContactoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Identificacion = c.String(),
                        CreDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContactoID);
            
            CreateTable(
                "dbo.Visitas",
                c => new
                    {
                        VisitaID = c.Int(nullable: false, identity: true),
                        date_vis = c.DateTime(nullable: false),
                        bg_vis = c.Time(nullable: false, precision: 7),
                        end_vis = c.Time(nullable: false, precision: 7),
                        vis_motive = c.String(),
                        ContactoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VisitaID)
                .ForeignKey("dbo.Contactoes", t => t.ContactoID, cascadeDelete: true)
                .Index(t => t.ContactoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visitas", "ContactoID", "dbo.Contactoes");
            DropIndex("dbo.Visitas", new[] { "ContactoID" });
            DropTable("dbo.Visitas");
            DropTable("dbo.Contactoes");
        }
    }
}
