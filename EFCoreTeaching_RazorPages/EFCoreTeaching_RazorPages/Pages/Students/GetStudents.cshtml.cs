using EFCoreTeaching_RazorPages.Models;
using EFCoreTeaching_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreTeaching_RazorPages.Pages.Students
{
    public class GetStudentsModel : PageModel
    {
        public IEnumerable<Student>  Students { get; set; }
        private IStudentService  context;
        public GetStudentsModel(IStudentService service)
        {
            Students = new List<Student>();
            context = service;
        }
        public void OnGet()
        {
            Students = context.GetStudents();
        }
    }
}
