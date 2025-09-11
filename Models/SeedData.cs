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
                new Movie //01
                {
                    Title = "Arrival",
                    ReleaseDate = DateTime.Parse("2016-09-02"),
                    Genre = "Sci-Fi",
                    Price = 7.99M,
                },
                new Movie //02
                {
                    Title = "Alien",
                    ReleaseDate = DateTime.Parse("1979-01-15"),
                    Genre = "Sci-Fi",
                    Price = 8.99M,
                },
                new Movie //03
                {
                    Title = "Interstellar",
                    ReleaseDate = DateTime.Parse("2014-11-06"),
                    Genre = "Sci-Fi",
                    Price = 6.99M,
                },
                new Movie //04
                {
                    Title = "Ex Machina",
                    ReleaseDate = DateTime.Parse("2015-01-21"),
                    Genre = "Sci-Fi",
                    Price = 7.99M,
                },
                new Movie //05
                {
                    Title = "Annihilation",
                    ReleaseDate = DateTime.Parse("2018-01-23"),
                    Genre = "Sci-Fi",
                    Price = 7.99M,
                }
            );
            context.SaveChanges();
        }
    }
}