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
    }
}
