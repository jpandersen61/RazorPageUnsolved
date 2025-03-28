using EFCoreTeaching_RazorPages.Models;
using EFCoreTeaching_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace EFCoreTeaching_RazorPages.Pages.Courses
{
    public class GetCoursesModel : PageModel
    {
        public IEnumerable<Course> Courses { get; private set; }
        private ICourseService cService;
        private IStudentService sService;
        public Student? Student { get; private set; } = null;
        public GetCoursesModel(ICourseService cserv, IStudentService sserv)
        {
            Courses = new List<Course>();
            cService = cserv;
            sService = sserv;
        }
        public void OnGet(int ? sid)
        {
            if (sid != null)
            {
                Student = sService.GetStudent(sid.Value);
            }
            Courses = cService.GetCourses();
        }
    }
}
