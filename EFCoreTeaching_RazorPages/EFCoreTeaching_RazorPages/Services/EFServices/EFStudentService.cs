using EFCoreTeaching_RazorPages.Models;
using EFCoreTeaching_RazorPages.Services.Interface;
using Microsoft.EntityFrameworkCore;


namespace EFCoreTeaching_RazorPages.Services.EFServices
{
    public class EFStudentService : IStudentService
    {
        RegistrationDBContext context;
        public EFStudentService(RegistrationDBContext service)
        {
            context = service;
        }
        public IEnumerable<Student> GetStudents()
        {
            return context.Students;
        }
        public void AddStudent(Student ? student)
        {
            if (student != null)
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public Student ? GetStudent(int id)
        {
            var student = context.Students
          .Include(s => s.Enrollments).ThenInclude(c => c.Course)
          .AsNoTracking()
          .FirstOrDefault(m => m.StudentId == id);
            return student;
        }
    }
}
