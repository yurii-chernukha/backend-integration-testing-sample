using Microsoft.AspNetCore.Mvc.Testing;
using MoviesApp.Models;
using NUnit.Framework;
using Refit;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MoviesApp.IntegrationTests
{
    public class Tests
    {
        protected static HttpClient Client { get; private set; }

        protected static IMoviesApi MoviesApi { get; set; }

        [OneTimeSetUp]
        public virtual void OneTimeSetUp()
        {
            var webAppFactory = new WebApplicationFactory<Startup>();
            Client = webAppFactory.CreateClient();
            MoviesApi = RestService.For<IMoviesApi>(Client);
        }      

        [Test]
        public async Task TestGetById_Success()
        {
            var id = Guid.NewGuid();
            var response = await Client.GetAsync($"movies/{id}");

            response.EnsureSuccessStatusCode();
            var movie = await response.Content.ReadFromJsonAsync<Movie>();

            Assert.AreEqual("The Undoing", movie.Title);
            Assert.AreEqual(id, movie.Id);
        }

        [Test]
        public async Task TestGetById_Refit_Success()
        {
            // arrange
            var id = Guid.NewGuid();

            // act
            var movie = await MoviesApi.GetAsync(id);

            // assert
            Assert.AreEqual("The Undoing", movie.Title);
            Assert.AreEqual(id, movie.Id);
            Assert.IsNotEmpty(movie.Actors);
        }
    }
}