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

        public void DeleteMovie(Movie movie)
        {
            dbContext.Movies.Remove(movie); ;
            dbContext.SaveChanges();
        }

        public Movie ? GetMovieById(int sid)
        {
            return dbContext.Movies.FirstOrDefault(m => m.Id == sid);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return dbContext.Movies;
        }

        public IEnumerable<Movie> GetMovies(string title)
        {
            return dbContext.Movies.Where(m => m.Title.ToLower().StartsWith(title.ToLower())).AsNoTracking().ToList();
        }

        public IEnumerable<Movie> GetMovies(int? studioId)
        {
            if (studioId == null)
            {
                return dbContext.Movies;
            }
            else
            {
                return dbContext.Movies.Where(m => m.StudioId == studioId).AsNoTracking().ToList();
            }
        }
    }
}
