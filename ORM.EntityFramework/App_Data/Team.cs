using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORM.EntityFramework {
    public class Team : EntityBase {

        public Team() {
            Players = new HashSet<Player>();
            Sponsors = new HashSet<Sponsor>();
        }

        //Data Annotations
        //[Key]
        //[ForeignKey("Player")]
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        public string City { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Sponsor> Sponsors { get; set; }

        //[ForeignKey("Department")]//You have to choose from a navigation property
        //public int DepartmentId { get; set; }
        //public Department Department { get; set; }
    }
}
