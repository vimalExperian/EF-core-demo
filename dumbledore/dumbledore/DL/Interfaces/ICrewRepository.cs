using dumbledore.DL.Entity;
using dumbledore.DL.Models;

namespace dumbledore.DL.Interfaces
{
    public interface ICrewRepository
    {
        public bool AddCrew(CreateCrewRequest request);
        List<CrewEntity> GetCrewMembersByMovieId(int movieId);
        List<CrewEntity> FetchCrewsByRole(int movieId, string role);
    }
}
