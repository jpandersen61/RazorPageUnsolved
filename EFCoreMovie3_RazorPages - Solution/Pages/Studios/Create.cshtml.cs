using EFCoreMovie3_RazorPages.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EFCoreMovie2_RazorPages.Models;

namespace EFCoreMovie3_RazorPages_Solution.Pages.Studios
{
    public class CreateModel : PageModel
    {
        
        private IStudioService service;

        [BindProperty]
        public Studio Studio { get; set; }

        public CreateModel(IStudioService service)
        {
            this.service = service;
        }
        public void OnGet()
        {
            Studio = new Studio();
        }



        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            service.AddStudio(Studio);

            return RedirectToPage("GetStudios");
        }
    }
}
