using EFCoreTeaching_RazorPages.Models;

namespace EFCoreTeaching_RazorPages.Services.Interface
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        void AddStudent(Student student);
        Student ? GetStudent(int id);
    }
}
