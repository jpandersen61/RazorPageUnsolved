using EFCoreTeaching_RazorPages.Models;

namespace EFCoreTeaching_RazorPages.Services.Interface
{
    public interface IEnrollmentService
    {
        IEnumerable<Enrollment> GetEnrollments();
    }
}
