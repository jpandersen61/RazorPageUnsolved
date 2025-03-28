using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTeaching_RazorPages.Models
{
#pragma warning disable CS8618

    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string Name { get; set; }
        public string? Address { get; set; }
        public virtual  ICollection<Enrollment> Enrollments { get; set; }
    }
#pragma warning restore CS8618

}
