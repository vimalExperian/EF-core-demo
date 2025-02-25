namespace dumbledore.DL.Entity
{
    public class CrewEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }

        public int MovieId { get; set; }

        public virtual MovieEntity Movie { get; set; }
    }
}
