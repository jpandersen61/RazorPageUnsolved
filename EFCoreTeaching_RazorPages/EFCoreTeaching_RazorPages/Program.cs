using EFCoreTeaching_RazorPages.Models;
using EFCoreTeaching_RazorPages.Services.EFServices;
using EFCoreTeaching_RazorPages.Services.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTeaching_RazorPages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<RegistrationDBContext>();
            builder.Services.AddTransient<IStudentService, EFStudentService>();
            builder.Services.AddTransient<ICourseService, EFCourseService>();
            builder.Services.AddTransient<IEnrollmentService, EFEnrollmentService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapRazorPages()
               .WithStaticAssets();

            app.Run();
        }
    }
}
