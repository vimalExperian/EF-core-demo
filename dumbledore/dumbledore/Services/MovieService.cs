using dumbledore.DL.Interfaces;
using dumbledore.DL.Models;
using dumbledore.Services.Interfaces;

namespace dumbledore.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository) {
            _movieRepository = movieRepository;
        }
        public void AddMovie(CreateMovierRequest movierRequest)
        {
            _movieRepository.CreateMovie();
        }

    }
}
