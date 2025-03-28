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
            Studio = new Studio();
        }
        
           
        public Studio Studio { get; set; }
        public void OnGet(int id)
        {
            Studio ? toBeDeleted = service.GetStudioById(id);
            if (toBeDeleted != null)
            {
                Studio = toBeDeleted;
            }
        }

        public IActionResult OnPost(int id)
        {
            Studio ? toBeDeleted = service.GetStudioById(id);
            if (toBeDeleted != null)
            {
                service.DeleteStudio(toBeDeleted);
            }
            return RedirectToPage("GetStudios");
        }
    }
}
