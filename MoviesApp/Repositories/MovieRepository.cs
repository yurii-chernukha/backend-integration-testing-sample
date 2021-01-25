using MoviesApp.Models;
using System;
using System.Collections.Generic;

namespace MoviesApp.Repositories
{
    public class MovieRepository
    {
        public Movie GetById(Guid id)
        {
            return new Movie
            {
                Id = id,
                Title = "The Undoing",
                Year = 2020,
                Actors = new string[] { "Nicole Kidman", "Hugh Grant", "Edgar Ramírez" },
                Plot = "Grace Fraser is living the only life she ever wanted for herself. She's a successful therapist, has a devoted husband and young son who attends an elite private school in New York City."
            };
        }


        public IEnumerable<Movie> Get()
        {
            return new Movie[]
            {
                new Movie
                {
                    Title = "Edge of Tomorrow",
                    Year = 2014,
                    Actors = new string[] { "Tom Cruise", "Emily Blunt", "Brendan Gleeson" },
                    Plot = "A soldier fighting aliens gets to relive the same day over and over again, the day restarting every time he dies."
                },
                new Movie
                {
                    Title = "House of Cards",
                    Year = 2013,
                    Actors = new string[] { "Robin Wright", "Michael Kelly", "Kevin Spacey", "Justin Doescher" },
                    Plot = "A Congressman works with his equally conniving wife to exact revenge on the people who betrayed him."
                }
            };
        }
    }
}
