namespace ORM.EntityFramework.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class RenameCitNameyColumnToCityForTableTeam : DbMigration {
        public override void Up() {
            AddColumn("dbo.Teams", "City", c => c.String());
            Sql("update Teams set City = CityName");
            DropColumn("dbo.Teams", "CityName");
        }

        public override void Down() {
            AddColumn("dbo.Teams", "CityName", c => c.String());
            Sql("update Teams set CityName = City");
            DropColumn("dbo.Teams", "City");
        }
    }
}
