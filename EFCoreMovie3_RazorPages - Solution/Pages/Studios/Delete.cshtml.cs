using EFCoreMovie2_RazorPages.Models;
using EFCoreMovie3_RazorPages.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreMovie3_RazorPages_Solution.Pages.Studios
{
    public class DeleteModel : PageModel
    {
        IStudioService service;
        public DeleteModel(IStudioService service)
        {
            this.service = service;
        }
        
           
        public Studio Studio { get; set; }
        public void OnGet(int id)
        {

            Studio = service.GetStudioById(id);
        }

        public IActionResult OnPost(int id)
        {
            Studio toBeDeleted = service.GetStudioById(id);
            service.DeleteStudio(toBeDeleted);
            return RedirectToPage("GetStudios");
        }
    }
}
