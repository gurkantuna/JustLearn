using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORM.EntityFramework {
    public class PlayerAdress {
        [Key]
        [ForeignKey("Player")]
        public int PlayerAdressId { get; set; }

        public string Adress1 { get; set; }

        public string StreetName { get; set; }

        public Player Player { get; set; }
    }
}
