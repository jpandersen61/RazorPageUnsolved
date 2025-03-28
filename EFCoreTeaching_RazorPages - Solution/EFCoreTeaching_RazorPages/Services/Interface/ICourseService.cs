using EFCoreTeaching_RazorPages.Models;

namespace EFCoreTeaching_RazorPages.Services.Interface
{
    public interface ICourseService
    {
        IEnumerable<Course> GetCourses();
        Course ? GetCourse(int cid);
    }
}
