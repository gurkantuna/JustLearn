namespace ORM.EntityFramework {
    public class Player : EntityBase {
        public string Name { get; set; }

        public string LastName { get; set; }

        public Team Team { get; set; }

        public PlayerAdress Adress { get; set; }
    }
}
