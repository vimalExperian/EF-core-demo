using dumbledore.DL.Entity;
using dumbledore.DL.Models;

namespace dumbledore.DL.Interfaces
{
    public interface IMovieRepository
    {
        public void CreateMovie(CreateMovierRequest createMovierRequest);

        public CreateMovierRequest FetchMovie(int Id);
    }
}
