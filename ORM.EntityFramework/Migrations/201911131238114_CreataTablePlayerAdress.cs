namespace ORM.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreataTablePlayerAdress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerAdresses",
                c => new
                    {
                        PlayerAdressId = c.Int(nullable: false),
                        Adress1 = c.String(),
                        StreetName = c.String(),
                    })
                .PrimaryKey(t => t.PlayerAdressId)
                .ForeignKey("dbo.Players", t => t.PlayerAdressId)
                .Index(t => t.PlayerAdressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerAdresses", "PlayerAdressId", "dbo.Players");
            DropIndex("dbo.PlayerAdresses", new[] { "PlayerAdressId" });
            DropTable("dbo.PlayerAdresses");
        }
    }
}
