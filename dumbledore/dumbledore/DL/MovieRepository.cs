using dumbledore.DL.Entity;
using dumbledore.DL.Interfaces;
using dumbledore.DL.Models;
using Microsoft.EntityFrameworkCore;

namespace dumbledore.DL
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext _context;

        public MovieRepository(MovieContext context) {
            _context = context;
        }

        public CreateMovierRequest CreateMovie(CreateMovierRequest request)
        {
            var entity = new MovieEntity
            {
                Name=request.Name,
                YearReleased=request.Year,
                Genre=request.genre,
                Budget=request.Budget
            };
            _context.Movie.Add(entity);
            _context.SaveChanges();
            return request;
        }

        public CreateMovierRequest FetchMovie(int Id)
        {
            var movie = _context.Movie?.Where(x=>x.ID==Id).FirstOrDefault();
            if (movie == null)
                return null;
            return new CreateMovierRequest
            {
                Name=movie.Name,
                Budget=movie.Budget,
                Year=movie.YearReleased,
                genre=movie.Genre
            };

        }
        public List<HighBudgetMovieResponse> GetHighBudget()
        {
            var result = _context.Movie.Where(x => x.Budget > 50).Select(x => new HighBudgetMovieResponse{Name=x.Name,Budget=x.Budget }).ToList();
            return result;
        }
    }
}
