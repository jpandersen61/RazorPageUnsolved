using EFCoreTeaching_RazorPages.Models;

namespace EFCoreTeaching_RazorPages.Services.Interface
{
    public interface IEnrollmentService
    {
        public IEnumerable<Enrollment> GetEnrollments();
        public void AddEnrollment(Enrollment enrollment);
    }
}
