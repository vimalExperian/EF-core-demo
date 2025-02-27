namespace dumbledore.DL.Models
{
    public class CreateRatingRequest
    {
        public int Rating { get; set; }

        public string Description { get; set; }

        public string CriticName { get; set; }

        public int MovieId { get; set; }
    }
}
