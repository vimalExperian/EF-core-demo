using dumbledore.DL.Models;

namespace dumbledore.DL.Interfaces
{
    public interface IReviewRepository
    {
        public bool AddReview(CreateRatingRequest request);
    }
}
