namespace newAirlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedStanowisko : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zalogant",
                c => new
                    {
                        ZalogantId = c.Int(nullable: false, identity: true),
                        Pesel = c.String(),
                        StanowiskoId = c.Int(nullable: false),
                        DataZatrudnienia = c.DateTime(nullable: false),
                        Adres = c.String(),
                        NrTelefonu = c.String(),
                        ZalogaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ZalogantId)
                .ForeignKey("dbo.Stanowisko", t => t.StanowiskoId, cascadeDelete: true)
                .Index(t => t.StanowiskoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zalogant", "StanowiskoId", "dbo.Stanowisko");
            DropIndex("dbo.Zalogant", new[] { "StanowiskoId" });
            DropTable("dbo.Zalogant");
        }
    }
}
