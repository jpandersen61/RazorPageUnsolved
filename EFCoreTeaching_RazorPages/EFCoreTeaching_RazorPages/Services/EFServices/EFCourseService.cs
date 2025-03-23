using EFCoreTeaching_RazorPages.Models;
using EFCoreTeaching_RazorPages.Services.Interface;

namespace EFCoreTeaching_RazorPages.Services.EFServices
{
    public class EFCourseService : ICourseService
    {
        RegistrationDBContext context;
        public EFCourseService(RegistrationDBContext service)
        {
            context = service;
        }
    }
}
