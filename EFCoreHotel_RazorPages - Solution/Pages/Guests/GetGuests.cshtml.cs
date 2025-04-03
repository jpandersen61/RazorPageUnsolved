using EFCoreHotel_RazorPages.Models;
using EFCoreHotel_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreHotel_RazorPages.Pages.Guests
{
    public class GetGuestsModel : PageModel
    {
        public IEnumerable<Guest> Guests { get; set; }

        IGuestService guestService;
        public GetGuestsModel(IGuestService service)
        {
            guestService = service;
            Guests = new List<Guest>(); 
        }
        public void OnGet()
        {
            Guests = guestService.GetGuests();
        }
    }
}
