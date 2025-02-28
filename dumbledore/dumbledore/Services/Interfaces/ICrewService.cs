using dumbledore.DL.Models;

namespace dumbledore.Services.Interfaces
{
    public interface ICrewService
    {
        public void AddCrew(CreateCrewRequest createCrewRequest);
    }
}
