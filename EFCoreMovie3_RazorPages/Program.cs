using EFCoreMovie2_RazorPages.Models;
using EFCoreMovie3_RazorPages.EFServices;
using EFCoreMovie3_RazorPages.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovie1_RazorPages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<MovieDBContext>();
            builder.Services.AddTransient<IMovieService,EFMovieService>();
            builder.Services.AddTransient<IStudioService,EFStudioService>();


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
