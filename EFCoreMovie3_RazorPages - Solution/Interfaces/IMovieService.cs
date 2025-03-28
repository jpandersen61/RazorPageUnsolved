using EFCoreMovie2_RazorPages.Models;

namespace EFCoreMovie3_RazorPages.Interfaces
{
    public interface IMovieService
    {
        public IEnumerable<Movie> GetMovies();
        IEnumerable<Movie> GetMovies(string title);
        void AddMovie(Movie movie);

        public IEnumerable<Movie> GetMovies(int ? studioId);

        public Movie ? GetMovieById(int id);

        public void DeleteMovie(Movie movie);
    }
}
