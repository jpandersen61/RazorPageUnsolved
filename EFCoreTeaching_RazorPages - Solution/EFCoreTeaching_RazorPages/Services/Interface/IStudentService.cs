using EFCoreTeaching_RazorPages.Models;

namespace EFCoreTeaching_RazorPages.Services.Interface
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetStudents();
        public void AddStudent(Student student);
        public Student ? GetStudent(int id);

        public void DeleteStudent(int studentID);
    }
}
