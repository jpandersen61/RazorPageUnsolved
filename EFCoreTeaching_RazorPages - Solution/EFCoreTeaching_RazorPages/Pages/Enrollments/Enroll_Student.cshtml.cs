using EFCoreTeaching_RazorPages.Models;
using EFCoreTeaching_RazorPages.Services.EFServices;
using EFCoreTeaching_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using System.Security.Cryptography;

namespace EFCoreTeaching_RazorPages_Solution.Pages.Enrollments
{
    public class Enroll_StudentModel : PageModel
    {
        ICourseService cService;
        IStudentService sService;
        IEnrollmentService eService;
        public Enroll_StudentModel(ICourseService cServ, IStudentService sServ, IEnrollmentService eServ)
        {
            cService=cServ;
            sService=sServ;
            eService=eServ;
            Student = new Student();
            Course = new Course();
        }

        [BindProperty]
        public int CourseId { get; set; }

        [BindProperty]
        public int StudentId { get; set; }

        public Student Student { get; private set; }
        public Course Course { get; private set; }


        public void OnGet(int cid, int sid)
        {
            CourseId = cid;
            StudentId = sid;
            Student ? foundStudent= sService.GetStudent(sid);
            if (foundStudent != null)
            {
                Student = foundStudent;
            }

            Course ? foundCourse = cService.GetCourse(cid);
            if (foundCourse != null)
            {
                Course = foundCourse;
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Enrollment erm = new Enrollment()
            {
                CourseId = this.CourseId,
                StudentId = this.StudentId
            };
            eService.AddEnrollment(erm);
            return RedirectToPage("/Students/Student_Enrollments", new { sid = StudentId });
        }
    }
}
