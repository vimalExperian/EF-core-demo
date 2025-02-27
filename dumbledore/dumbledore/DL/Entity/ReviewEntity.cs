using System.ComponentModel.DataAnnotations.Schema;

namespace dumbledore.DL.Entity
{
    [Table("Review")]
    public class ReviewEntity
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int Rating { get; set; }

        public string CriticName { get; set; }

        public string Description { get; set; }

        public virtual MovieEntity Movie { get; set; }

    }
}
