namespace dumbledore.DL.Models
{
    public class UpdateCrewRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Role { get; set; }

        public int MovieId { get; set; }
    }
}
