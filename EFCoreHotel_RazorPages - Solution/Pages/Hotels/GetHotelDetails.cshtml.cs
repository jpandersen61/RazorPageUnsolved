using EFCoreHotel_RazorPages.Models;
using EFCoreHotel_RazorPages.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreHotel_RazorPages_Solution.Pages.Hotels
{
    public class GetHotelDetailsModel : PageModel
    {
        IHotelService hService;

        public GetHotelDetailsModel(IHotelService hServ) 
        { 
             hService = hServ;
        }
        public Hotel ? Hotel { get; set; }
        public void OnGet(int ? hno)
        {
            if (hno != null)
            {
                Hotel = hService.GetHotelById(hno.Value);
            }
        }
    }
}
