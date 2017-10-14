namespace newAirlines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kierunek",
                c => new
                    {
                        KierunekId = c.Int(nullable: false, identity: true),
                        MiejsceOdlotu = c.String(),
                        MiejscePrzylotu = c.String(),
                    })
                .PrimaryKey(t => t.KierunekId);
            
            CreateTable(
                "dbo.Lot",
                c => new
                    {
                        LotId = c.Int(nullable: false, identity: true),
                        NumerLotu = c.String(),
                        KierunekId = c.Int(nullable: false),
                        SamolotId = c.Int(nullable: false),
                        ZalogaId = c.Int(nullable: false),
                        DataOdlotu = c.DateTime(nullable: false),
                        DataPrzylotu = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LotId)
                .ForeignKey("dbo.Kierunek", t => t.KierunekId, cascadeDelete: true)
                .ForeignKey("dbo.Samolot", t => t.SamolotId, cascadeDelete: true)
                .Index(t => t.KierunekId)
                .Index(t => t.SamolotId);
            
            CreateTable(
                "dbo.Odprawa",
                c => new
                    {
                        OdprawaId = c.Int(nullable: false, identity: true),
                        LotId = c.Int(nullable: false),
                        ZalogantId = c.Int(nullable: false),
                        NrBramki = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OdprawaId);
            
            CreateTable(
                "dbo.OdprawaPasazer",
                c => new
                    {
                        OdproawaId = c.Int(nullable: false),
                        Pesel = c.String(nullable: false, maxLength: 128),
                        Bagaz = c.Boolean(nullable: false),
                        WagaBagazu = c.Int(nullable: false),
                        CzasOdrpawy = c.DateTime(nullable: false),
                        Odprawa_OdprawaId = c.Int(),
                    })
                .PrimaryKey(t => new { t.OdproawaId, t.Pesel })
                .ForeignKey("dbo.Odprawa", t => t.Odprawa_OdprawaId)
                .ForeignKey("dbo.Pasazer", t => t.Pesel, cascadeDelete: true)
                .Index(t => t.Pesel)
                .Index(t => t.Odprawa_OdprawaId);
            
            CreateTable(
                "dbo.Pasazer",
                c => new
                    {
                        Pesel = c.String(nullable: false, maxLength: 128),
                        Adres = c.String(),
                        Kraj = c.String(),
                    })
                .PrimaryKey(t => t.Pesel);
            
            CreateTable(
                "dbo.Samolot",
                c => new
                    {
                        SamolotId = c.Int(nullable: false, identity: true),
                        NrSeryjny = c.String(nullable: false, maxLength: 5, fixedLength: true),
                        TypId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SamolotId)
                .ForeignKey("dbo.TypSamolotu", t => t.TypId, cascadeDelete: true)
                .Index(t => t.TypId);
            
            CreateTable(
                "dbo.TypSamolotu",
                c => new
                    {
                        TypId = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        IloscMiejsc = c.String(),
                    })
                .PrimaryKey(t => t.TypId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Samolot", "TypId", "dbo.TypSamolotu");
            DropForeignKey("dbo.Lot", "SamolotId", "dbo.Samolot");
            DropForeignKey("dbo.OdprawaPasazer", "Pesel", "dbo.Pasazer");
            DropForeignKey("dbo.OdprawaPasazer", "Odprawa_OdprawaId", "dbo.Odprawa");
            DropForeignKey("dbo.Lot", "KierunekId", "dbo.Kierunek");
            DropIndex("dbo.Samolot", new[] { "TypId" });
            DropIndex("dbo.OdprawaPasazer", new[] { "Odprawa_OdprawaId" });
            DropIndex("dbo.OdprawaPasazer", new[] { "Pesel" });
            DropIndex("dbo.Lot", new[] { "SamolotId" });
            DropIndex("dbo.Lot", new[] { "KierunekId" });
            DropTable("dbo.TypSamolotu");
            DropTable("dbo.Samolot");
            DropTable("dbo.Pasazer");
            DropTable("dbo.OdprawaPasazer");
            DropTable("dbo.Odprawa");
            DropTable("dbo.Lot");
            DropTable("dbo.Kierunek");
        }
    }
}
