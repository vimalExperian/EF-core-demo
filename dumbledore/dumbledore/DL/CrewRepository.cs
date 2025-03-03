using System.Reflection.Metadata.Ecma335;
using dumbledore.DL.Entity;
using dumbledore.DL.Interfaces;
using dumbledore.DL.Models;

namespace dumbledore.DL
{
    public class CrewRepository : ICrewRepository
    {
        public readonly CrewContext _context;
        public CrewRepository(CrewContext context)
        {
            _context = context;
        }
        public void CreateCrew(CreateCrewRequest request)
        {
            var entity = new CrewEntity
            {
                Name = request.Name,
                Role = request.Role,
                MovieId = request.MovieId
            };
            _context.CrewEntity.Add(entity);
            _context.SaveChanges();
        }
        public bool DeleteAndAddCrew(UpdateCrewRequest request)
        {
            var currentEntity = _context.CrewEntity.FirstOrDefault(c => c.Id == request.Id);
            if (currentEntity != null)
            {
                _context.CrewEntity.Remove(currentEntity);
                _context.SaveChanges();
            }
            var entity = new CrewEntity
            {
                Name = request.Name,
                Role = request.Role,
                MovieId = request.MovieId
            };
            _context.CrewEntity.Add(entity);
            _context.SaveChanges();
            return true;
        }

        public List<CrewEntity> GetCrewByMovieId(int movieId)
        {
            return _context.CrewEntity.Where(c => c.MovieId == movieId).ToList();
        }
    }
}
