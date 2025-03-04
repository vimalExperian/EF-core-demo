using dumbledore.DL.Entity;
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
        public bool ReplaceCrew(UpdateCrewRequest cr)
        {
            return _crewRepository.DeleteAndAddCrew(cr);
        }
        public List<CrewEntity> GetCrewByMovie(int movieId)
        {
            return _crewRepository.GetCrewByMovieId(movieId);
        }

        public CrewEntity GetCrewWithMostMovies()
        {
            return _crewRepository.GetCrewWithMostMovies();
        }
    }
}
