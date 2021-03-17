using System;

namespace _05_DateModifier
{
    public class StartUp
	{
		public static void Main()
		{
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            double differenceInDays = DateModifier.DateDifferenceInDays(firstDate, secondDate);

            Console.WriteLine(differenceInDays);
        }
	}
}
