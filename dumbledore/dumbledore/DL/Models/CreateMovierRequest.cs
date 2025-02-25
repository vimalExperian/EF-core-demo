namespace dumbledore.DL.Models
{
    public class CreateMovierRequest
    {
        public string Name {  get; set; }

        public int Year { get; set; }

        public double Budget { get; set; }

        public string genre { get; set; }
    }
}
