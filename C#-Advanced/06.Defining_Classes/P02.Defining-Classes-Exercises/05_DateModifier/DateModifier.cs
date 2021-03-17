using System;

namespace _05_DateModifier
{
    public static class DateModifier
    {    
        public static double DateDifferenceInDays(string firstDate, string secondDate)
        {
            DateTime DTFirstDate = DateTime.Parse(firstDate);
            DateTime DTSecondDate = DateTime.Parse(secondDate);

            double difference = Math.Abs((DTFirstDate - DTSecondDate).TotalDays);

            return difference;
        }
    }
}
