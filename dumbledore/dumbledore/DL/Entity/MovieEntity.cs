namespace dumbledore.DL.Entity
{
    public class MovieEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int YearReleased { get; set; }

        public double Budget {  get; set; }
        
        public string Genre { get; set; }

        public virtual List<CrewEntity> Crew { get; set; }


    }
}
