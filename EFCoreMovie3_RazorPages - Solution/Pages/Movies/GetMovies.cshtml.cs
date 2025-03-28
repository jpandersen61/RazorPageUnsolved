using EFCoreMovie2_RazorPages.Models;
using EFCoreMovie3_RazorPages.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreMovie1_RazorPages.Pages.Movies
{
    public class GetMoviesModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? FilterCriteria { get; set; }

        private IMovieService service;
        public GetMoviesModel(IMovieService service)
        {
            this.service = service;
        }
        public IEnumerable<Movie> Movies { get; set; } = new List<Movie>();
        public void OnGet(int ? sid)
        {
            if (String.IsNullOrEmpty(FilterCriteria))
            {
                Movies = service.GetMovies(sid);
            }
            else
            {
                Movies = service.GetMovies(FilterCriteria);
            }
        }
    }
}
