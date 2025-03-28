using EFCoreHotel_RazorPages.Models;
using EFCoreHotel_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreHotel_RazorPages.Pages.Bookings
{
    public class GetBookingsModel : PageModel
    {
        public IEnumerable<Booking> Bookings { get; set; }

        IBookingService bookingService;
        public GetBookingsModel(IBookingService service)
        {
            bookingService = service;
        }
        public void OnGet()
        {
            Bookings = bookingService.GetBookings();
        }
    }
}
