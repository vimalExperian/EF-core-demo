using dumbledore.DL.Entity;
using dumbledore.DL.Interfaces;
using dumbledore.DL.Models;
using dumbledore.Services.Interfaces;

namespace dumbledore.Services
{
    public class CrewService : ICrewService
    {
        private readonly ICrewRepository _crewRepository;

        public CrewService(ICrewRepository crewRepository)
        {
            _crewRepository = crewRepository;
        }
        public bool AddCrew(CreateCrewRequest request)
        {
            var IsSuccess = _crewRepository.AddCrew(request);
            return IsSuccess;
        }
        public List<CrewEntity> FetchCrewMembers(int movieId)
        {
            return _crewRepository.GetCrewMembersByMovieId(movieId);
        }
        public List<string> FetchCrewsByRole(int movieId, string role)
        {
            var names = _crewRepository.FetchCrewsByRole(movieId, role);
            return names.Select(x => x.Name).ToList();
        }
    }
}
