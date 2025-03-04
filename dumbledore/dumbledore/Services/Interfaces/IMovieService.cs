using dumbledore.DL.Models;

namespace dumbledore.Services.Interfaces
{
    public interface IMovieService
    {
        public CreateMovierRequest AddMovie(CreateMovierRequest createMovierRequest);

        public CreateMovierRequest FetchMovie(int MovieID);
        public List<CreateMovierRequest> GetListOfMovies(List<int> MovieIds);
        public List<CreateMovierRequest> AddMultipleMovies(List<CreateMovierRequest> createMovierRequests);
        public List<HighBudgetMovieResponse> GetHighBudgetMovies();
    }
}
