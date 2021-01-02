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
        public void ShoulBeParqueDasFloresWhenRegularCustomerOnMonTuesWed()
        {            
            List<DateTime> bookingDates = new List<DateTime>
            {
                new DateTime(2020, 03, 16),
                new DateTime(2020, 03, 17),
                new DateTime(2020, 03, 18)
            };

            var hotelBooking = new HotelBookingService();
            var hotelName = hotelBooking.GetCheapestHotelName(CustomerType.Regular, bookingDates);

            hotelName.Should().Be("Parque das flores");
        }

        [Fact]
        public void ShoulBeJardimBotanicoWhenRegularCustomerOnFriSatSun()
        {
            List<DateTime> bookingDates = new List<DateTime>
            {
                new DateTime(2020, 03, 20),
                new DateTime(2020, 03, 21),
                new DateTime(2020, 03, 22)
            };

            var hotelBooking = new HotelBookingService();
            var hotelName = hotelBooking.GetCheapestHotelName(CustomerType.Regular, bookingDates);
            
            hotelName.Should().Be("Jardim Botânico");
            
        }



        [Fact]
        public static void ShoulBeMarAtlanticoWhenRewardsOnThurFriSat()
        {
            List<DateTime> bookingDates = new List<DateTime>
            {
                new DateTime(2020, 03, 26),
                new DateTime(2020, 03, 27),
                new DateTime(2020, 03, 28)
            };

            var hotelBooking = new HotelBookingService();
            var hotelName = hotelBooking.GetCheapestHotelName(CustomerType.Rewards, bookingDates);

            hotelName.Should().Be("Mar Atlântico");
        }
    }
}
