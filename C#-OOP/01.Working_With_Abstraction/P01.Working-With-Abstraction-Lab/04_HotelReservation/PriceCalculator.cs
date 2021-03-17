using System;

namespace _04_HotelReservation
{
    public static class PriceCalculator
    {
        public static decimal GetTotalPrice(decimal pricePerDay, int numberOfDays, DiscountType discount, Season season)
        {
            decimal price = numberOfDays * pricePerDay * (int)season;
            price -= price * ((decimal)discount / 100);

            return price;
        }
    }
}
