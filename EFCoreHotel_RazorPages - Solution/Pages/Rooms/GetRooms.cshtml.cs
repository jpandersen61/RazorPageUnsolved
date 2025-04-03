using EFCoreHotel_RazorPages.Models;
using EFCoreHotel_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreHotel_RazorPages.Pages.Rooms
{
    public class GetRoomsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public double ? PriceLowFilter { get; set; }

        [BindProperty(SupportsGet = true)]
        public double ? PriceHighFilter { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ? TypeFilter { get; set; }

        public IEnumerable<Room> Rooms { get; set; }

        IRoomService roomService;
        public GetRoomsModel(IRoomService service)
        {
            roomService = service;
            Rooms = new List<Room>();   
        }
        public void OnGet()
        {
            Rooms = roomService.GetRooms(PriceLowFilter, PriceHighFilter, TypeFilter);            
        }
    }
}
