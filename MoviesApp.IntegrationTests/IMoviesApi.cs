using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MoviesApp.Models;
using Refit;

namespace MoviesApp.IntegrationTests
{
    public interface IMoviesApi
    {
        [Get("/movies/{id}")]
        Task<Movie> GetAsync(Guid id);

        [Get("/movies")]
        Task<IEnumerable<Movie>> GetAsync();
    }
}
