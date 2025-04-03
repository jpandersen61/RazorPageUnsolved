using EFCoreHotel_RazorPages.Models;
using EFCoreHotel_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreHotel_RazorPages.Pages.Bookings
{
    public class GetBookingsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public DateTime ? DateFrom { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? DateTo { get; set; }

        public IEnumerable<Booking> Bookings { get; set; }

        IBookingService bookingService;
        public GetBookingsModel(IBookingService service)
        {
            bookingService = service;
            Bookings = new List<Booking>();
        }
        public void OnGet()
        {
            Bookings = bookingService.GetBookings(DateFrom, DateTo);
        }
    }
}
