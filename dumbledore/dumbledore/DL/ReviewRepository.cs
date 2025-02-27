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
    }
}
