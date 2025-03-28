using EFCoreTeaching_RazorPages.Models;
using EFCoreTeaching_RazorPages.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTeaching_RazorPages.Services.EFServices
{
    public class EFCourseService : ICourseService
    {
        RegistrationDBContext context;
        public EFCourseService(RegistrationDBContext cont)
        {
            context = cont;
        }

        public Course ? GetCourse(int cid)
        {
            var course = context.Courses
            .Include(c => c.Enrollments).ThenInclude(e=> e.Student)
            .AsNoTracking()
            .FirstOrDefault(e => e.CourseId == cid);
            return course;
        }

        public IEnumerable<Course> GetCourses()
        {
            return context.Courses;
        }
    }
}
