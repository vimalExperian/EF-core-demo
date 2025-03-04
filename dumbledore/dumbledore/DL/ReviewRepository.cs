using dumbledore.DL.Entity;
using dumbledore.DL.Interfaces;
using dumbledore.DL.Models;

namespace dumbledore.DL
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ReviewContext _context;
        public ReviewRepository(ReviewContext context) {
            _context = context;
        }
        public bool AddReview(CreateRatingRequest request)
        {
            bool succes = true;
            try
            {
                var entity = new ReviewEntity
                {
                    MovieId = request.MovieId,
                    Rating = request.Rating,
                    Description = request.Description,
                    CriticName = request.CriticName,
                };
                _context.Review.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                succes = false;
            }
            return succes;
        }

        public bool AddReviews(AddMultipleRatingsRequest request)
        {
            bool success = true;
            try
            {
                foreach (var rating in request.Ratings)
                {
                    var entity = new ReviewEntity
                    {
                        MovieId = rating.MovieId,
                        Rating = rating.Rating,
                        Description = rating.Description,
                        CriticName = rating.CriticName,
                    };
                    _context.Review.Add(entity);
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                success = false;
            }
            return success;
        }

        public ReviewEntity GetReviewById(int id)
        {
            return _context.Review.Find(id);
        }

        public bool UpdateReview(UpdateRatingRequest request)
        {
            bool success = true;
            try
            {
                var review = _context.Review.Find(request.Id);
                if (review == null)
                {
                    return false;
                }

                review.MovieId = request.MovieId;
                review.Rating = request.Rating;
                review.CriticName = request.CriticName;
                review.Description = request.Description;

                _context.Review.Update(review);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                success = false;
            }
            return success;
        }

        public List<ReviewEntity> GetReviewsByMovieId(int movieId)
        {
            return _context.Review.Where(r => r.MovieId == movieId).ToList();
        }
    }
}
