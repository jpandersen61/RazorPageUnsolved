using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTeaching_RazorPages.Models
{
    public class RegistrationDBContext:DbContext
    {
        string ? connectionString = null;
        public RegistrationDBContext(IConfiguration conf)
        {
            connectionString = conf.GetConnectionString("RegistrationDB");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder  options)
        {
            //options.UseSqlServer (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RegistrationDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            options.UseSqlServer(connectionString);
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments{ get; set; }
    }
}
