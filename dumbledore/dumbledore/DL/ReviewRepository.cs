using dumbledore.DL.Entity;
using dumbledore.DL.Interfaces;
using dumbledore.DL.Models;

namespace dumbledore.DL
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ReviewContext _context;
        private readonly IMovieRepository _movieRepository;
        public ReviewRepository(ReviewContext context, IMovieRepository movieRepository)
        {
            _context = context;
            _movieRepository = movieRepository;
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
        public TopRatedMovieResponse FetchTopRatedMovie()
        {
            var reviews = _context.Review.ToList();
            var topRatedMovie = reviews
                .GroupBy(r => r.MovieId)
                .Select(g => new
                {
                    MovieId = g.Key,
                    TotalRating = g.Sum(x => x.Rating),
                    ReviewCount = g.Count()
                }).OrderByDescending(x => x.TotalRating).FirstOrDefault();

            if (topRatedMovie != null)
            {
                var movie = _movieRepository.FetchMovie(topRatedMovie.MovieId);
                int maxPossibleRating = topRatedMovie.ReviewCount * 5;
                return new TopRatedMovieResponse
                {
                    MovieName = movie.Name,
                    TotalRating = topRatedMovie.TotalRating,
                    MaxPossibleRating = maxPossibleRating,
                };
            }
            return null;
        }
    }
}
