using dumbledore.DL.Interfaces;
using dumbledore.DL.Models;
using dumbledore.Services.Interfaces;

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
    }
}
