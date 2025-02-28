using dumbledore.DL.Models;
using Microsoft.AspNetCore.Mvc;

namespace dumbledore.Services.Interfaces
{
    public interface IMovieService
    {
        public void AddMovie(CreateMovierRequest createMovierRequest);

        public CreateMovierRequest FetchMovie(int MovieID);
    }
}
