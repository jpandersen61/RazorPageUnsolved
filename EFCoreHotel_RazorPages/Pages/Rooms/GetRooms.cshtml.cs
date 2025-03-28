using EFCoreHotel_RazorPages.Models;
using EFCoreHotel_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreHotel_RazorPages.Pages.Rooms
{
    public class GetRoomsModel : PageModel
    {
        public IEnumerable<Room> Rooms { get; set; }

        IRoomService roomService;
        public GetRoomsModel(IRoomService service)
        {
            roomService = service;
        }
        public void OnGet()
        {
            Rooms = roomService.GetRooms();
        }
    }
}
