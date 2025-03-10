using dumbledore.DL.Entity;
using dumbledore.DL.Models;

namespace dumbledore.Services.Interfaces
{
    public interface ICrewService
    {
        public bool AddCrew(CreateCrewRequest request);
        List<CrewEntity> FetchCrewMembers(int movieId);
        List<string> FetchCrewsByRole(int movieId, string role);
    }
}
