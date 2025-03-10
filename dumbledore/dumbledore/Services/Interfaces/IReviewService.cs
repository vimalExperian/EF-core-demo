using dumbledore.DL.Models;

namespace dumbledore.Services.Interfaces
{
    public interface IReviewService
    {
        public bool AddReview(CreateRatingRequest request);
        public TopRatedMovieResponse FetchTopRatedMovie();
    }
}
