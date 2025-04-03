using EFCoreHotel_RazorPages.HotelDBContext;
using EFCoreHotel_RazorPages.Services.EFService;
using EFCoreHotel_RazorPages.Services.Interface;

namespace EFCoreHotel_RazorPages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<HoteldbContext>();
            builder.Services.AddTransient<IHotelService, EFHotelService>();
            builder.Services.AddTransient<IGuestService, EFGuestService>();
            builder.Services.AddTransient<IRoomService, EFRoomService>();
            builder.Services.AddTransient<IBookingService, EFBookingService>();

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
