using EFCoreTeaching_RazorPages.Models;
using EFCoreTeaching_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreTeaching_RazorPages_Solution.Pages.Students
{
    public class DeleteModel : PageModel
    {
        IStudentService studentService;

        [BindProperty]
        public int StudentId { get; set; }

        public Student Student { get; private set; }

        public DeleteModel(IStudentService sServ) 
        {
            studentService = sServ;
            Student = new Student();
        }
        public void OnGet(int sid)
        {
            Student ? foundStudent = studentService.GetStudent(sid);
            if (foundStudent != null)
            {
                Student = foundStudent;
            }
            StudentId = sid;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            studentService.DeleteStudent(StudentId);
            return RedirectToPage("/Students/GetStudents");
        }
    }
}
