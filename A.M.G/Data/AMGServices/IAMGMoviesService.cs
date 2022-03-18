using A.M.G.Data.Base;
using A.M.G.Data.ViewModels;
using A.M.G.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.M.G.Data.AMGServices
{
    public interface IAMGMoviesService : IEntityBaseRepository<AMGMovie>
    {
        Task<AMGMovie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
