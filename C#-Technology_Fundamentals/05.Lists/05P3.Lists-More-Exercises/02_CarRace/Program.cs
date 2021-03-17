using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_CarRace
{
	class Program
	{
		static void Main(string[] args)
		{
			List<double> minutes = Console.ReadLine().Split().Select(double.Parse).ToList();
			double leftCarTime = 0;
			double rightCarTime = 0;

			for (int i = 0; i < minutes.Count / 2; i++)
			{
				if (minutes[i] == 0)
				{
					leftCarTime *= 0.8;
				}

				leftCarTime += minutes[i];
			}

			for (int i = minutes.Count - 1; i > minutes.Count / 2; i--)
			{
				if (minutes[i] == 0)
				{
					rightCarTime *= 0.8;
				}

				rightCarTime += minutes[i];
			}

			if (leftCarTime < rightCarTime)
			{
				Console.WriteLine($"The winner is left with total time: {leftCarTime}");
			}
			else
			{
				Console.WriteLine($"The winner is right with total time: {rightCarTime}");
			}
		}
	}
}
