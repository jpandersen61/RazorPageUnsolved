using EFCoreTeaching_RazorPages.Models;
using EFCoreTeaching_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreTeaching_RazorPages.Pages.Students
{
    public class Student_EnrollmentsModel : PageModel
    {
        IStudentService ? context;
        public Student_EnrollmentsModel(IStudentService service)
        {
            context = service;
            Student = new Student();
        }
        public Student  Student { get; set; }
        public IActionResult OnGet(int sid)
        {
            if (context == null)
            {
                return BadRequest();
            }

            Student ? result = context.GetStudent(sid);
            if (result == null)
            {
                return NotFound();
            }

            Student = result;
            return Page();
        }
    }
}
