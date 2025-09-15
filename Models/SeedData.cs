using Microsoft.EntityFrameworkCore;
using MvcMovies.Data;

namespace MvcMovies.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMoviesContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMoviesContext>>()))
        {
            if (context.Movie.Any()) return;

            context.Movie.AddRange(
                new Movie // 01
                {
                    Title = "Arrival",
                    ReleaseDate = DateTime.Parse("2016-09-02"),
                    Genre = "Sci-Fi",
                    Price = 7.99M,
                    Rating = "R",
                },
                new Movie // 02
                {
                    Title = "Alien",
                    ReleaseDate = DateTime.Parse("1979-01-15"),
                    Genre = "Sci-Fi",
                    Price = 8.99M,
                    Rating = "R",
                }, 
                new Movie // 03
                {
                    Title = "Interstellar",
                    ReleaseDate = DateTime.Parse("2014-11-06"),
                    Genre = "Sci-Fi",
                    Price = 6.99M,
                    Rating = "R",
                },
                new Movie // 04
                {
                    Title = "Ex Machina",
                    ReleaseDate = DateTime.Parse("2015-01-21"),
                    Genre = "Sci-Fi",
                    Price = 7.99M,
                    Rating = "R",
                },
                new Movie // 05
                {
                    Title = "Annihilation",
                    ReleaseDate = DateTime.Parse("2018-01-23"),
                    Genre = "Sci-Fi",
                    Price = 7.99M,
                    Rating = "R",    
                },
                new Movie // 06
                {
                    Title = "Blade Runner 2049",
                    ReleaseDate = DateTime.Parse("2017-10-06"),
                    Genre = "Sci-Fi",
                    Price = 9.99M,
                    Rating = "R",
                },
                new Movie // 07
                {
                    Title = "The Matrix",
                    ReleaseDate = DateTime.Parse("1999-03-31"),
                    Genre = "Sci-Fi",
                    Price = 8.99M,
                    Rating = "R",
                },
                new Movie // 08
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-07-16"),
                    Genre = "Sci-Fi",
                    Price = 7.99M,
                    Rating = "PG-13",
                },
                new Movie // 09
                {
                    Title = "The Martian",
                    ReleaseDate = DateTime.Parse("2015-10-02"),
                    Genre = "Sci-Fi",
                    Price = 7.49M,
                    Rating = "PG-13",
                },
                new Movie // 10
                {
                    Title = "Gravity",
                    ReleaseDate = DateTime.Parse("2013-10-04"),
                    Genre = "Sci-Fi",
                    Price = 6.99M,
                    Rating = "PG-13",
                },
                new Movie // 11
                {
                    Title = "Tenet",
                    ReleaseDate = DateTime.Parse("2020-08-26"),
                    Genre = "Sci-Fi",
                    Price = 8.49M,
                    Rating = "PG-13",
                },
                new Movie // 12
                {
                    Title = "Dune",
                    ReleaseDate = DateTime.Parse("2021-10-22"),
                    Genre = "Sci-Fi",
                    Price = 9.49M,
                    Rating = "PG-13",
                },
                new Movie // 13
                {
                    Title = "District 9",
                    ReleaseDate = DateTime.Parse("2009-08-14"),
                    Genre = "Sci-Fi",
                    Price = 6.99M,
                    Rating = "R",
                },
                new Movie // 14
                {
                    Title = "Her",
                    ReleaseDate = DateTime.Parse("2013-12-18"),
                    Genre = "Sci-Fi",
                    Price = 7.99M,
                    Rating = "R",
                },
                new Movie // 15
                {
                    Title = "Edge of Tomorrow",
                    ReleaseDate = DateTime.Parse("2014-06-06"),
                    Genre = "Sci-Fi",
                    Price = 7.49M,
                    Rating = "PG-13",
                },
                new Movie // 16
                {
                    Title = "The Shawshank Redemption",
                    ReleaseDate = DateTime.Parse("1994-09-23"),
                    Genre = "Drama",
                    Price = 7.99M,
                    Rating = "R",
                },
                new Movie // 17
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1972-03-24"),
                    Genre = "Crime",
                    Price = 8.99M,
                    Rating = "R",
                },
                new Movie // 18
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-07-18"),
                    Genre = "Action",
                    Price = 9.49M,
                    Rating = "PG-13",
                },
                new Movie // 19
                {
                    Title = "Pulp Fiction",
                    ReleaseDate = DateTime.Parse("1994-10-14"),
                    Genre = "Crime",
                    Price = 7.49M,
                    Rating = "R",
                },
                new Movie // 20
                {
                    Title = "Forrest Gump",
                    ReleaseDate = DateTime.Parse("1994-07-06"),
                    Genre = "Drama",
                    Price = 6.99M,
                    Rating = "PG-13",
                },
                new Movie // 21
                {
                    Title = "The Grand Budapest Hotel",
                    ReleaseDate = DateTime.Parse("2014-03-28"),
                    Genre = "Comedy",
                    Price = 7.49M,
                    Rating = "R",
                },
                new Movie // 22
                {
                    Title = "Get Out",
                    ReleaseDate = DateTime.Parse("2017-02-24"),
                    Genre = "Horror",
                    Price = 6.99M,
                    Rating = "R",
                },
                new Movie // 23
                {
                    Title = "Inside Out",
                    ReleaseDate = DateTime.Parse("2015-06-19"),
                    Genre = "Animation",
                    Price = 6.49M,
                    Rating = "PG",
                },
                new Movie // 24
                {
                    Title = "The Lion King",
                    ReleaseDate = DateTime.Parse("1994-06-24"),
                    Genre = "Animation",
                    Price = 5.99M,
                    Rating = "G",
                },
                new Movie // 25
                {
                    Title = "Gladiator",
                    ReleaseDate = DateTime.Parse("2000-05-05"),
                    Genre = "Action",
                    Price = 7.99M,
                    Rating = "R",
                },
                new Movie // 26
                {
                    Title = "La La Land",
                    ReleaseDate = DateTime.Parse("2016-12-09"),
                    Genre = "Musical",
                    Price = 7.99M,
                    Rating = "PG-13",
                },
                new Movie // 27
                {
                    Title = "The Notebook",
                    ReleaseDate = DateTime.Parse("2004-06-25"),
                    Genre = "Romance",
                    Price = 6.49M,
                    Rating = "PG-13",
                },
                new Movie // 28
                {
                    Title = "Amélie",
                    ReleaseDate = DateTime.Parse("2001-04-25"),
                    Genre = "Romantic Comedy",
                    Price = 6.99M,
                    Rating = "R",
                },
                new Movie // 29
                {
                    Title = "Don't Look Up",
                    ReleaseDate = DateTime.Parse("2021-12-24"),
                    Genre = "Satire",
                    Price = 7.49M,
                    Rating = "R",
                },
                new Movie // 30
                {
                    Title = "Won’t You Be My Neighbor?",
                    ReleaseDate = DateTime.Parse("2018-06-08"),
                    Genre = "Documentary",
                    Price = 5.99M,
                    Rating = "PG-13",
                },
                new Movie // 31
                {
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    ReleaseDate = DateTime.Parse("2001-12-19"),
                    Genre = "Fantasy",
                    Price = 8.99M,
                    Rating = "PG-13",
                },
                new Movie // 32
                {
                    Title = "Black Swan",
                    ReleaseDate = DateTime.Parse("2010-12-17"),
                    Genre = "Thriller",
                    Price = 7.99M,
                    Rating = "R",
                },
                new Movie // 33
                {
                    Title = "Liza, the Fox-Fairy",
                    ReleaseDate = DateTime.Parse("2015-02-19"),
                    Genre = "Fantasy Comedy",
                    Price = 6.49M,
                    Rating = "PG-13",
                },
                new Movie // 34
                {
                    Title = "Kincsem",
                    ReleaseDate = DateTime.Parse("2017-03-16"),
                    Genre = "Historical Drama",
                    Price = 6.99M,
                    Rating = "PG-13",
                },
                new Movie // 35
                {
                    Title = "Testről és lélekről",
                    ReleaseDate = DateTime.Parse("2017-03-02"),
                    Genre = "Drama",
                    Price = 6.99M,
                    Rating = "R",
                },
                new Movie // 36
                {
                    Title = "The Revenant",
                    ReleaseDate = DateTime.Parse("2015-12-25"),
                    Genre = "Adventure",
                    Price = 8.49M,
                    Rating = "R",
                },
                new Movie // 37
                {
                    Title = "The Social Network",
                    ReleaseDate = DateTime.Parse("2010-10-01"),
                    Genre = "Biography",
                    Price = 7.49M,
                    Rating = "PG-13",
                },
                new Movie // 38
                {
                    Title = "1917",
                    ReleaseDate = DateTime.Parse("2019-12-25"),
                    Genre = "War",
                    Price = 8.99M,
                    Rating = "R",
                },
                new Movie // 39
                {
                    Title = "The Big Lebowski",
                    ReleaseDate = DateTime.Parse("1998-03-06"),
                    Genre = "Comedy",
                    Price = 6.49M,
                    Rating = "R",
                },
                new Movie // 40
                {
                    Title = "No Country for Old Men",
                    ReleaseDate = DateTime.Parse("2007-11-21"),
                    Genre = "Crime Thriller",
                    Price = 7.99M,
                    Rating = "R",
                },
                new Movie // 41
                {
                    Title = "Parasite",
                    ReleaseDate = DateTime.Parse("2019-05-30"),
                    Genre = "Thriller",
                    Price = 8.49M,
                    Rating = "R",
                },
                new Movie // 42
                {
                    Title = "Jojo Rabbit",
                    ReleaseDate = DateTime.Parse("2019-10-18"),
                    Genre = "Comedy Drama",
                    Price = 7.49M,
                    Rating = "PG-13",
                },
                new Movie // 43
                {
                    Title = "Joker",
                    ReleaseDate = DateTime.Parse("2019-10-04"),
                    Genre = "Crime Drama",
                    Price = 8.99M,
                    Rating = "R",
                },
                new Movie // 44
                {
                    Title = "Once Upon a Time in Hollywood",
                    ReleaseDate = DateTime.Parse("2019-07-26"),
                    Genre = "Comedy Drama",
                    Price = 8.49M,
                    Rating = "R",
                },
                new Movie // 45
                {
                    Title = "A Star is Born",
                    ReleaseDate = DateTime.Parse("2018-10-05"),
                    Genre = "Musical Drama",
                    Price = 7.49M,
                    Rating = "R",
                },
                new Movie // 46
                {
                    Title = "Logan",
                    ReleaseDate = DateTime.Parse("2017-03-03"),
                    Genre = "Action",
                    Price = 7.99M,
                    Rating = "R",
                },
                new Movie // 47
                {
                    Title = "Deadpool",
                    ReleaseDate = DateTime.Parse("2016-02-12"),
                    Genre = "Action Comedy",
                    Price = 7.49M,
                    Rating = "R",
                },
                new Movie // 48
                {
                    Title = "Mad Max: Fury Road",
                    ReleaseDate = DateTime.Parse("2015-05-15"),
                    Genre = "Action",
                    Price = 8.49M,
                    Rating = "R",
                },
                new Movie // 49
                {
                    Title = "The Hateful Eight",
                    ReleaseDate = DateTime.Parse("2015-12-25"),
                    Genre = "Western",
                    Price = 7.99M,
                    Rating = "R",
                },
                new Movie // 50
                {
                    Title = "Saul fia",
                    ReleaseDate = DateTime.Parse("2015-06-11"),
                    Genre = "Historical Drama",
                    Price = 6.99M,
                    Rating = "R",
                }
            );
            context.SaveChanges();
        }
    }
}