using EFCoreHotel_RazorPages.HotelDBContext;
using EFCoreHotel_RazorPages.Models;
using EFCoreHotel_RazorPages.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreHotel_RazorPages.Services.EFService
{
    public class EFRoomService : IRoomService
    {
        private HoteldbContext context;
        public EFRoomService(HoteldbContext service)
        {
            context = service;
        }

        public Room ? GetRoomByID(int id)
        {
            return context.Rooms
                  .Include(r => r.HotelNoNavigation)
                  .Include(r => r.Bookings)
                  .ThenInclude(b => b.GuestNoNavigation)
                  .FirstOrDefault(r => r.RoomNo == id);
        }

        public Room ? GetRoomByID(int RoomNo, int HotelNo)
        {
            return context.Rooms
                  .Include(r => r.HotelNoNavigation)
                  .Include(r => r.Bookings)
                  .ThenInclude(b => b.GuestNoNavigation)
                  .FirstOrDefault(r => (r.RoomNo == RoomNo) && (r.HotelNo == HotelNo));
        }

        public IEnumerable<Room> GetRooms()
        {
            return context.Rooms.Include(r => r.Bookings).AsNoTracking();
        }

        public IEnumerable<Room> GetRooms(double? priceLowFilter, double? priceHighFilter, string? typeFilter)
        {
            IEnumerable <Room> result = GetRooms() ;

            if (priceLowFilter != null)
            {
                result = result.Where(r => r.Price >= priceLowFilter);
            }

            if (priceHighFilter != null)
            {
                result = result.Where(r => r.Price <= priceHighFilter);
            }

            if (typeFilter != null)
            {
                result = result.Where(r => r.Types.ToLower() == typeFilter.ToLower());
            }

            return result;
        }
    }
}
