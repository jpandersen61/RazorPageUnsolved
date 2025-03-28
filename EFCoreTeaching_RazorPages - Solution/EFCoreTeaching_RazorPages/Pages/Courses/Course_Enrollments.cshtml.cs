using EFCoreTeaching_RazorPages.Models;
using EFCoreTeaching_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreTeaching_RazorPages_Solution.Pages.Courses
{
    public class Course_EnrollmentsModel : PageModel
    {
        ICourseService? service;
        public Course_EnrollmentsModel(ICourseService serv)
        {
            service = serv;
            Course = new Course();
        }
        public Course Course { get; set; }
        public IActionResult OnGet(int cid)
        {
            if (service == null)
            {
                return BadRequest();
            }

            Course? result = service.GetCourse(cid);
            if (result == null)
            {
                return NotFound();
            }

            Course = result;
            return Page();
        }
    }
}
