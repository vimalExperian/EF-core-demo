using dumbledore.DL.Models;
using dumbledore.DL.Entity;
namespace dumbledore.DL.Interfaces
{
    public interface ICrewRepository
    {
        public void CreateCrew(CreateCrewRequest Createcrewrequest);
        public bool DeleteAndAddCrew(UpdateCrewRequest Updatecrewrequest);
        public List<CrewEntity> GetCrewByMovieId(int movieId);
        public CrewEntity GetCrewWithMostMovies();

    }
}
