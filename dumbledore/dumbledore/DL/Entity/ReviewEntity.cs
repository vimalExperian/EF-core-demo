namespace dumbledore.DL.Entity
{
    public class ReviewEntity
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int Ratings { get; set; }

        public string CriticName { get; set; }

        public string Description { get; set; }


    }
}
