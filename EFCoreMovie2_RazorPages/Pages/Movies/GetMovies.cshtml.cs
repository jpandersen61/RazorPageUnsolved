using EFCoreMovie2_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreMovie1_RazorPages.Pages.Movies
{
    public class GetMoviesModel : PageModel
    {
        public string? FilterCriteria { get; set; }

        private MovieDBContext context;
        public GetMoviesModel(MovieDBContext service)
        {
            context = service;
        }
        public IEnumerable<Movie> Movies { get; set; } = new List<Movie>();
        public void OnGet()
        {
            Movies = context.Movies;
        }
    }
}
