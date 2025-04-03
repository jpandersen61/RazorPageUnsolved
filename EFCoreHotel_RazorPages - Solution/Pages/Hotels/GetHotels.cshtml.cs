using EFCoreHotel_RazorPages.Models;
using EFCoreHotel_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreHotel_RazorPages.Pages.Hotels
{
    public class GetHotelsModel : PageModel
    {
        public IEnumerable<Hotel> Hotels { get; set; }
        IHotelService hotelService;
        public GetHotelsModel(IHotelService service)
        {
            hotelService = service;
            Hotels = new List<Hotel>();
        }
        public void OnGet()
        {
            Hotels = hotelService.GetHotels();
        }
    }
}
