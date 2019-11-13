using System.Collections.Generic;

namespace ORM.EntityFramework {
    public class Sponsor : EntityBase {

        public Sponsor() {
            Teams = new HashSet<Team>();
        }

        public string Name { get; set; }

        public decimal? Current { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
