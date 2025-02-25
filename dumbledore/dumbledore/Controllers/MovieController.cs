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
        [ProducesResponseType(200)]
        public IActionResult AddMovie(CreateMovierRequest createMovierRequest)
        {
            _movieService.AddMovie(createMovierRequest);

            return Ok("Hi");
        }
    }
}
