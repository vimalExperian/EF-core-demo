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
        public CreateMovierRequest AddMovie(CreateMovierRequest movierRequest)
        {
            var movie=_movieRepository.CreateMovie(movierRequest);
            return movie;
        }

        public CreateMovierRequest FetchMovie(int MovieID)
        {
            var movieDetails=_movieRepository.FetchMovie(MovieID);
            return movieDetails;
        }

        
        public List<CreateMovierRequest> GetListOfMovies(List<int> MovieIds)
        {
            var result=new List<CreateMovierRequest>();
            foreach(int id in MovieIds)
            {
                result.Add(FetchMovie(id));
            }
            return result;
        } 
        public List<CreateMovierRequest> AddMultipleMovies(List<CreateMovierRequest> createMovierRequests)
        {
            var result = new List<CreateMovierRequest>();
            foreach(var movie in createMovierRequests)
            {
                result.Add(AddMovie(movie));
            }
            return result;
        }
        public List<HighBudgetMovieResponse> GetHighBudgetMovies()
        {
            var result = _movieRepository.GetHighBudget();
            return result;
        }
    }
}
