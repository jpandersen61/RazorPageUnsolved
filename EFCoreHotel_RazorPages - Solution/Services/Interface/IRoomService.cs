using EFCoreHotel_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreHotel_RazorPages.Services.Interface
{
  public  interface IRoomService
    {
        public IEnumerable<Room> GetRooms();
        public IEnumerable<Room> GetRooms(double ? PriceLowFilter, double ? PriceHighFilter, string ? TypeFilter);

        public Room ? GetRoomByID(int RoomNo, int HotelNo);
    }
}
