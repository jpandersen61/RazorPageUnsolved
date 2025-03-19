using EFCoreMovie2_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreMovie1_RazorPages.Pages.Studios
{
    public class GetStudiosModel : PageModel
    {
        public string ? FilterCriteria { get; set; }

        private MovieDBContext context;
        public GetStudiosModel(MovieDBContext service)
        {
            context = service;
        }
        public IEnumerable<Studio> Studios { get; set; } = new List<Studio>();
        public void OnGet()
        {
            Studios = context.Studios;
        }
    }
}
