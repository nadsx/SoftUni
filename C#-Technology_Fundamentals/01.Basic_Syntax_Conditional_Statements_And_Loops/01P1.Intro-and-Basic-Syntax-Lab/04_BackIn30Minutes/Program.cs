using System;

namespace _04_BackIn30Minutes
{
	class Program
	{
		static void Main(string[] args)
		{
			int hours = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());

			minutes += 30;

			if(minutes > 59)
			{
				hours++;
				minutes -= 60;

				if(hours > 23)
				{
					hours -= 24;
				}
			}

			Console.WriteLine($"{hours}:{minutes:D2}");

		}
	}
}
