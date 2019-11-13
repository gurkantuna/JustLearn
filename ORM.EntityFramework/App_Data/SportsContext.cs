using System.Data.Entity;

namespace ORM.EntityFramework {
    public class SportsContext : DbContext {
        public SportsContext() : base("SportsConnectionString") {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<PlayerAdress> PlayerAdresses { get; set; }
    }
}
