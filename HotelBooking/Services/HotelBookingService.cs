using System;
using System.Collections.Generic;

namespace HotelBooking
{
    public class HotelBookingService
    {
        private readonly List<Hotel> hotels;

        public HotelBookingService()
        {
            this.hotels = new List<Hotel>
            {
                new Hotel("Parque das flores", 3, 110, 80, 90, 80),
                new Hotel("Jardim Botânico", 4, 160, 110, 60, 50),
                new Hotel("Mar Atlântico", 5, 220, 100, 150, 40)
            };
        }

        public object GetCheapestHotelName(CustomerType customerType, List<DateTime> bookingDates)
        {
            decimal cheapestHotelCost = 0;
            Hotel cheapestHotel = null;

            foreach (var hotel in hotels)
            {
                decimal hotelCost = 0;
                foreach (var date in bookingDates)
                {
                    hotelCost += hotel.getCost(customerType, date);
                }

                if((cheapestHotel == null || hotelCost < cheapestHotelCost))
                {
                    cheapestHotel = hotel;
                    cheapestHotelCost = hotelCost;

                } else if (hotelCost == cheapestHotelCost && hotel.Rating > cheapestHotel.Rating)
                {
                    cheapestHotel = hotel;
                    cheapestHotelCost = hotelCost;
                }
            }

            return cheapestHotel.Name;
        }
    }
}