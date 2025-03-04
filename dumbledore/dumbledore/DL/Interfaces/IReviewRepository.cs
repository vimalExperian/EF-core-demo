using dumbledore.DL.Entity;
using dumbledore.DL.Models;

namespace dumbledore.DL.Interfaces
{
    public interface IReviewRepository
    {
        public bool AddReview(CreateRatingRequest request);
        public bool AddReviews(AddMultipleRatingsRequest request);
        public ReviewEntity GetReviewById(int id);
        public bool UpdateReview(UpdateRatingRequest request);

        public List<ReviewEntity> GetReviewsByMovieId(int movieId);
    }
}
