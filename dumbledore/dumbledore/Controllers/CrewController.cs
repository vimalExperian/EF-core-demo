using dumbledore.DL.Models;
using dumbledore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dumbledore.Controllers
{
    public class CrewController : ControllerBase
    {
        private readonly ICrewService _crewService;
        public CrewController(ICrewService crewService) {
            _crewService = crewService;
        }
        [HttpPost]
        [Route("AddCrew")]
        [ProducesResponseType(200)]
        public IActionResult AddCrew(CreateCrewRequest crewRequest)
        {
            var success = _crewService.AddCrew(crewRequest);
            return Ok(success);
        }
        [HttpGet]
        [Route("fetchCrews/{movieId}")]
        [ProducesResponseType(200)]
        public IActionResult FetchCrewMembers(int movieId)
        {
            var crewMembers = _crewService.FetchCrewMembers(movieId);
            return Ok(crewMembers);
        }
        [HttpGet]
        [Route("crew/{movieId}/{role}")]
        [ProducesResponseType(200)]
        public IActionResult FetchCrewsByRole(int movieId, string role)
        {
            var crewNames = _crewService.FetchCrewsByRole(movieId, role);
            return Ok(crewNames);
        }
    }
}
