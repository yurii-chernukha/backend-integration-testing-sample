using MoviesApp.Models;
using MoviesApp.Repositories;
using System;
using System.Collections.Generic;

namespace MoviesApp.Services
{
    public class MovieService
    {
        private readonly MovieRepository _repository;

        public MovieService(MovieRepository repository)
        {
            _repository = repository;
        }

        public Movie GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Movie> Get()
        {
            return _repository.Get();
        }
    }
}
