using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace EFCoreTeaching_RazorPages.Models
{
#pragma warning disable CS8618

    public class Enrollment
   {
    public int EnrollmentId { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }

    [DisplayFormat(NullDisplayText = "No Grade")]
    public int? Grade { get; set; }
	}

#pragma warning restore CS8618
}
