using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace _01_DayOfWeek
{
	class Program
	{
		static void Main(string[] args)
		{
			string dateAsText = Console.ReadLine();

			DateTime date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);

			Console.WriteLine(date.DayOfWeek);
		}
	}
}
	

	



