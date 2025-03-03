using dumbledore.DL.Models;
using dumbledore.DL.Entity;
namespace dumbledore.Services.Interfaces
{
    public interface ICrewService
    {
        public void AddCrew(CreateCrewRequest createCrewRequest);
        public bool ReplaceCrew(UpdateCrewRequest updateCrewRequest);
        public List<CrewEntity> GetCrewByMovie(int movieId);
    }
}
