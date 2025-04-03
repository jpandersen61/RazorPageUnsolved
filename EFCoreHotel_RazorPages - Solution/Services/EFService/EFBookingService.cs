using EFCoreHotel_RazorPages.HotelDBContext;
using EFCoreHotel_RazorPages.Models;
using EFCoreHotel_RazorPages.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreHotel_RazorPages.Services.EFService
{
    public class EFBookingService:IBookingService
    {
        private HoteldbContext context;
        public EFBookingService(HoteldbContext service)
        {
            context = service;
        }

        public IEnumerable<Booking> GetBookings()
        {
            return context.Bookings;
        }

        public IEnumerable<Booking> GetBookings(DateTime? dateFrom, DateTime? dateTo)
        {
            IEnumerable<Booking> result = GetBookings();

            if (dateFrom != null)
            {
                result = result.Where(b => b.DateFrom >= dateFrom); 
            }

            if (dateTo != null)
            {
                result = result.Where(b => b.DateTo <= dateTo);
            }

            return result;
        }
    }
}
