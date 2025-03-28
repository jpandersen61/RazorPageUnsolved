using EFCoreTeaching_RazorPages.Models;
using EFCoreTeaching_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreTeaching_RazorPages.Pages.Enrollments
{


    public class GetEnrollmentsModel : PageModel
    {
        public IEnumerable<Enrollment> Enrollments { get; set; }
        IEnrollmentService service;
        public GetEnrollmentsModel(IEnrollmentService serv)
        {
            service = serv;
            Enrollments = new List<Enrollment>();
        }
        public void OnGet()
        {
            Enrollments = service.GetEnrollments();
        }
    }


}
