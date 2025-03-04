using dumbledore.DL.Entity;
using dumbledore.DL.Models;

namespace dumbledore.DL.Interfaces
{
    public interface IMovieRepository
    {
        public CreateMovierRequest CreateMovie(CreateMovierRequest createMovierRequest);

        public CreateMovierRequest FetchMovie(int Id);
        public List<HighBudgetMovieResponse> GetHighBudget();
    }
}
