namespace dumbledore.DL.Models
{
    public class CreateCrewRequest
    {
        public string Name { get; set; }

        public string Role { get; set; }

        public int MovieId { get; set; }
    }
}
