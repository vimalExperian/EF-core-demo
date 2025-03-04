using dumbledore.DL.Models;
using dumbledore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dumbledore.Controllers
{
    public class CrewController : ControllerBase
    {
        public readonly ICrewService _crewService;
        public CrewController(ICrewService crewService) {
            _crewService = crewService;
        }

        [HttpPost]
        [Route("crew")]
        public IActionResult AddCrew(CreateCrewRequest createCrewRequest)
        {
            _crewService.AddCrew(createCrewRequest);
            return Ok("Success");
        }
        [HttpPut]
        [Route("crewReplace")]
        public IActionResult ReplaceCrew(UpdateCrewRequest updateCrewRequest)
        {
            var result = _crewService.ReplaceCrew(updateCrewRequest);
            if (result)
            {
                return Ok("Crew Replaced Successfully");
            }
            else
            {
                return BadRequest("Failed to Replace crew");
            }
        }
        [HttpGet]
        [Route("crew/{movieId}")]
        public IActionResult GetCrewByMovie(int movieId)
        {
            var crewMembers = _crewService.GetCrewByMovie(movieId);
            if(crewMembers==null || crewMembers.Count == 0)
            {
                return NotFound("There is no crew member found for this movie!");
            }
            return Ok(crewMembers);
        }
        [HttpGet]
        [Route("crew/MostMovies")]
        public IActionResult GetCrewWithMostMovies()
        {
            var crewMember = _crewService.GetCrewWithMostMovies();
            if (crewMember == null)
            {
                return NotFound("No Crew members found");
            }
            return Ok(crewMember);
        }
    }
}
