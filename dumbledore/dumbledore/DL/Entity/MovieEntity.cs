using System.ComponentModel.DataAnnotations.Schema;

namespace dumbledore.DL.Entity
{
    [Table("Movie")]
    public class MovieEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int YearReleased { get; set; }

        public double Budget {  get; set; }
        
        public string Genre { get; set; }

        public virtual List<CrewEntity> Crew { get; set; }

        public virtual List<ReviewEntity> Review { get; set; }


    }
}
