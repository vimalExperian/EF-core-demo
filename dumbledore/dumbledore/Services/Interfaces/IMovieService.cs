using dumbledore.DL.Models;

namespace dumbledore.Services.Interfaces
{
    public interface IMovieService
    {
        public void AddMovie(CreateMovierRequest createMovierRequest);
    }
}
