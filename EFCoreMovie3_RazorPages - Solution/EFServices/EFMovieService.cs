using EFCoreMovie2_RazorPages.Models;
using EFCoreMovie3_RazorPages.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovie3_RazorPages.EFServices
{
    public class EFMovieService : IMovieService
    {
        MovieDBContext dbContext;
        public EFMovieService(MovieDBContext context) 
        {
            dbContext = context;
        }

        public void AddMovie(Movie movie)
        {
            dbContext.Movies.Add(movie);
            dbContext.SaveChanges();
        }

        public IEnumerable<Movie> GetMovies()
        {
            return dbContext.Movies;
        }

        public IEnumerable<Movie> GetMovies(string title)
        {
            return dbContext.Movies.Where(m => m.Title.StartsWith(title)).AsNoTracking().ToList();
        }
    }
}
