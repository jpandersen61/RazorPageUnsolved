﻿using EFCoreTeaching_RazorPages.Models;
using EFCoreTeaching_RazorPages.Services.Interface;

namespace EFCoreTeaching_RazorPages.Services.EFServices
{
    public class EFEnrollmentService : IEnrollmentService
    {

        RegistrationDBContext context;
        public EFEnrollmentService(RegistrationDBContext cont)
        {
            context = cont;
        }
        public IEnumerable<Enrollment> GetEnrollments()
        {
            return context.Enrollments;
        }
    }
}
