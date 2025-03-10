using dumbledore.DL.Entity;
using dumbledore.DL.Interfaces;
using dumbledore.DL.Models;

namespace dumbledore.DL
{
    public class CrewRepository : ICrewRepository
    {
        private readonly CrewContext _crewContext;

        public CrewRepository(CrewContext crewContext)
        {
            _crewContext = crewContext;
        }
        public bool AddCrew(CreateCrewRequest request)
        {
            var success = true;
            try
            {
                var entity = new CrewEntity
                {
                    Name = request.Name,
                    Role = request.Role,
                    MovieId = request.MovieId,
                };
                _crewContext.Crew.Add(entity);
                _crewContext.SaveChanges();
            }
            catch (Exception ex)
            {
                success = false;
            }
            return success;
        }
        public List<CrewEntity> GetCrewMembersByMovieId(int movieId)
        {
            return _crewContext.Crew.Where(x => x.MovieId == movieId).ToList();
        }

        public List<CrewEntity> FetchCrewsByRole(int movieId, string role)
        {
            return _crewContext.Crew.Where(x => x.MovieId == movieId && x.Role == role).ToList();
        }
    }
}
