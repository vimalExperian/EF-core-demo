using dumbledore.DL.Models;

namespace dumbledore.Services.Interfaces
{
    public interface IMovieService
    {
        public CreateMovieResponse AddMovie(CreateMovierRequest createMovierRequest);

        public CreateMovierRequest FetchMovie(int MovieID);
    }
}
