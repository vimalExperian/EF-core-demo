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
    }
}
