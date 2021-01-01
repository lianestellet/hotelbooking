using FluentAssertions;
using HotelBooking;
using System;
using System.Collections.Generic;
using Xunit;

namespace HotelBookingTest
{
    public class HotelBookingServiceTest
    {
        [Fact]
        public void ParqueDasFloresWhenRegularWeekdaysMonTuesWed()
        {
            var regularCustomerType = CustomerType.REGULAR;
            List<DateTime> bookingDates = new List<DateTime>
            {
                new DateTime(2020, 03, 16),
                new DateTime(2020, 03, 17),
                new DateTime(2020, 03, 18)
            };

            var hotelBooking = new HotelBookingService(regularCustomerType, bookingDates);

            var hotelName = hotelBooking.GetCheapestHotelName();
            hotelName.Should().Be("Parque das flores");
        }
    }
}
