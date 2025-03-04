using dumbledore.DL.Entity;
using dumbledore.DL.Models;

namespace dumbledore.Services.Interfaces
{
    public interface IReviewService
    {
        public bool AddReview(CreateRatingRequest request);

        public bool AddReviews(AddMultipleRatingsRequest request);

        public bool UpdateReview(UpdateRatingRequest request);

        public List<ReviewEntity> GetReviewsByMovieId(int movieId);
    }
}
