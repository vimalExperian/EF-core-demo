using dumbledore.DL.Entity;
using dumbledore.DL.Interfaces;
using dumbledore.DL.Models;
using dumbledore.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace dumbledore.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        public ReviewService(IReviewRepository reviewRepository) {
            _reviewRepository = reviewRepository;
        
        }
        public bool AddReview(CreateRatingRequest request)
        {
            var IsSuccess= _reviewRepository.AddReview(request);
            return IsSuccess;
        }

        public bool AddReviews(AddMultipleRatingsRequest request)
        {
            var isSuccess = _reviewRepository.AddReviews(request);
            return isSuccess;
        }

        public bool UpdateReview(UpdateRatingRequest request)
        {
            var isSuccess = _reviewRepository.UpdateReview(request);
            return isSuccess;
        }

        public List<ReviewEntity> GetReviewsByMovieId(int movieId)
        {
            return _reviewRepository.GetReviewsByMovieId(movieId);
        }
    }
}
