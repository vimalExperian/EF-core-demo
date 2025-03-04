using dumbledore.DL.Models;
using dumbledore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dumbledore.Controllers
{
    public class MovieController: ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService) { 
            _movieService= movieService;
        }

        [HttpPost]
        [Route("movie")]
        [ProducesResponseType(200)]
        public IActionResult AddMovie(CreateMovierRequest createMovierRequest)
        {
            _movieService.AddMovie(createMovierRequest);

            return Ok("success");
        }


        [HttpGet]
        [Route("movie/{MovieId}")]
        public IActionResult FetchMovie(int MovieId)
        {
            var movie=_movieService.FetchMovie(MovieId);
            return Ok(movie);
        }
        [HttpGet]
        [Route("movies")]
        public IActionResult GetListOfMovies(List<int> MoviedIds)
        {
            var movies=_movieService.GetListOfMovies(MoviedIds);
            return Ok(movies);
        }
        [HttpPost]
        [Route("AddMovies")]
        public IActionResult AddMultipleMovies([FromBody] List<CreateMovierRequest> createMovierRequests )
        {
            var movies=_movieService.AddMultipleMovies(createMovierRequests);
            return Ok(movies);
        }
        [HttpGet]
        [Route("HighBudget")]
        public IActionResult GetHighBudgetMovies()
        {
            var movies = _movieService.GetHighBudgetMovies();
            return Ok(movies);
        }
    }
}
