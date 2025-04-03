using ADONetMovie_RazorPages.Services.ADOActorService;
using ADONetMovie_RazorPages.Services.ADOMovieService;
using ADONetMovie_RazorPages.Services.ADOStudioService;
using ADONetMovie_RazorPages.Services.Interfaces;

namespace ADONetMovie_RazorPages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddTransient<AdonetMovieService>();
            builder.Services.AddTransient<IMovieService, MovieService>();
            builder.Services.AddTransient<AdonetActorService>();
            builder.Services.AddTransient<IActorService, ActorService>();
            builder.Services.AddTransient<AdonetStudioService>();
            builder.Services.AddTransient<IStudioService, StudioService>();

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
