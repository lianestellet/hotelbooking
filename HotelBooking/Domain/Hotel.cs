using System;

namespace HotelBooking
{
    public class Hotel
    {
        public Hotel(string name, int rating, decimal regularWeekday, decimal rewardsWeekday, decimal regularWeekend, decimal rewardsWeekend)
        {
            Name = name;
            Rating = rating;
            RegularWeekdayCost = regularWeekday;
            RewardsWeekdayCost = rewardsWeekday;
            RegularWeekendCost = regularWeekend;
            RewardsWeekendCost = rewardsWeekend;
        }

        public string Name { get; }
        public int Rating { get; }
        public decimal RegularWeekdayCost { get; }
        public decimal RewardsWeekdayCost { get; }
        public decimal RegularWeekendCost { get; }
        public decimal RewardsWeekendCost { get; }

        public decimal getCost(CustomerType regularCustomerType, DateTime date)
        {
            // TODO refactor this (sugg: decouple costs from customer types)
            if (IsWeekend(date))
            {
                if (regularCustomerType == CustomerType.Regular)
                    return RegularWeekendCost;
                else
                    return RewardsWeekendCost;
            }
            else
            {
                if (regularCustomerType == CustomerType.Regular)
                    return RegularWeekdayCost;
                else
                    return RewardsWeekdayCost;
            }                
        }





        private static bool IsWeekend(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}