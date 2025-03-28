using EFCoreMovie2_RazorPages.Models;
using EFCoreMovie3_RazorPages.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreMovie3_RazorPages_Solution.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        IMovieService service;
        public DeleteModel(IMovieService serv)
        {
            service = serv;
            Movie = new Movie();
        }
        public Movie  Movie { get; set; }
        public void OnGet(int id)
        {
            Movie ? movieToBeDeleted = service.GetMovieById(id);
            if (movieToBeDeleted != null)
            {
                Movie = movieToBeDeleted;
            }
            else
            {
                Movie = new Movie();
            }
        }

        public IActionResult OnPost(int id)
        {
            Movie ? toBeDeleted = service.GetMovieById(id);
            if (toBeDeleted != null)
            {
                service.DeleteMovie(toBeDeleted);
            }
            return RedirectToPage("GetMovies");
        }
    }
}
