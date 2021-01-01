using System;
using System.Collections.Generic;

namespace HotelBooking
{
    public class HotelBookingService
    {
        private CustomerType regularCustomerType;
        private List<DateTime> dates;

        public HotelBookingService(CustomerType regularCustomerType, List<DateTime> dates)
        {
            this.regularCustomerType = regularCustomerType;
            this.dates = dates;
        }

        public object GetCheapestHotelName()
        {
            return "Parque das flores";
        }
    }
}