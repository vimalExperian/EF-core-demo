namespace dumbledore.DL.Models
{
    public class UpdateRatingRequest
    {
        public int Id { get; set; } 

        public int MovieId { get; set; }

        public int Rating { get; set; } 

        public string CriticName { get; set; } 

        public string Description { get; set; } 
    }
}
