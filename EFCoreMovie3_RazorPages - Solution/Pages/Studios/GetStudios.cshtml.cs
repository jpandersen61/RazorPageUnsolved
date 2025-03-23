using EFCoreMovie2_RazorPages.Models;
using EFCoreMovie3_RazorPages.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreMovie1_RazorPages.Pages.Studios
{
    public class GetStudiosModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string ? FilterCriteria { get; set; }

        private IStudioService service;
        public GetStudiosModel(IStudioService service)
        {
            this.service = service;
        }
        public IEnumerable<Studio> Studios { get; set; } = new List<Studio>();
        public void OnGet()
        {
            if (String.IsNullOrEmpty(FilterCriteria) )
            {
                Studios = service.GetStudios();
            }
            else
            {
                Studios = service.GetStudios(FilterCriteria);
            }          
        }
    }
}
