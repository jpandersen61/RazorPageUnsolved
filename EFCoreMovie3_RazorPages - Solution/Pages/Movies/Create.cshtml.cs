using EFCoreMovie2_RazorPages.Models;
using EFCoreMovie3_RazorPages.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EFCoreMovie3_RazorPages_Solution.Pages.Movies
{
    public class CreateModel : PageModel
    {
        IMovieService service;

        public CreateModel(IMovieService service) 
        {
            this.service=service;
            Movie = new Movie();
        }

        [BindProperty]
        public Movie Movie { get; set; }
        public void OnGet(int id)
        {
            Movie = new Movie() { StudioId = id };
        }

        public IActionResult OnPost()
        {
            ModelState.Remove("Movie.Studio");
            if (!ModelState.IsValid)
            {
                return Page();
            }

            service.AddMovie(Movie);

            return RedirectToPage("GetMovies");
        }
    }
}
