using dumbledore.DL.Interfaces;
using dumbledore.DL.Models;
using dumbledore.Services.Interfaces;

namespace dumbledore.Services
{
    public class CrewService : ICrewService
    {
        public readonly ICrewRepository _crewRepository;
        public CrewService(ICrewRepository crewRepository)
        {
            _crewRepository = crewRepository;
        }
        public void AddCrew(CreateCrewRequest cr)
        {

            _crewRepository.CreateCrew(cr);
        }
    }
}
