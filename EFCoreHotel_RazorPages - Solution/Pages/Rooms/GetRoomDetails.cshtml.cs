using EFCoreHotel_RazorPages.Models;
using EFCoreHotel_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreHotel_RazorPages_Solution.Pages.Rooms
{
    public class GetRoomDetailsModel : PageModel
    {
        IRoomService rService;

        public Room ? Room { get; set; }

        public GetRoomDetailsModel(IRoomService rServ)
        {
            rService = rServ;
        }

        public void OnGet(int ? rno, int ? hno)
        {
            if (rno != null && hno != null)
            {
                Room = rService.GetRoomByID(rno.Value, hno.Value);
            }
        }
    }
}
