using System;
using System.Linq;

namespace _04_HotelReservation
{
    public class StartUp
    {
        public static void Main()
        {
            string[] reservationInfo = Console.ReadLine()
             .Split()
             .ToArray();

            decimal pricePerDay = decimal.Parse(reservationInfo[0]);
            int numberOfDays = int.Parse(reservationInfo[1]);
            Season season = (Season)Enum.Parse(typeof(Season), reservationInfo[2]);
            DiscountType discount = DiscountType.None;

            if (reservationInfo.Length == 4)
            {
                discount = Enum.Parse<DiscountType>(reservationInfo[3]);
            }

            Console.WriteLine($"{PriceCalculator.GetTotalPrice(pricePerDay, numberOfDays, discount, season):F2}");
        }
    }
}
