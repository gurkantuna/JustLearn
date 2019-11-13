namespace ORM.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyTeamToTablePlayer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Players", "Team_Id", c => c.Int());
            CreateIndex("dbo.Players", "Team_Id");
            AddForeignKey("dbo.Players", "Team_Id", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropColumn("dbo.Players", "Team_Id");
            DropTable("dbo.Teams");
        }
    }
}
