using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_HornetAssault
{
	class Program
	{
		static void Main(string[] args)
		{
			var beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
			var hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

			for (int i = 0; i < beehives.Length; i++)
			{
				if (hornets.Count == 0)
				{
					break;
				}

				long beehiveCount = beehives[i];
				long hornetPower = SumHornetsPower(hornets); 

				beehives[i] -= hornetPower;
		
				if (beehiveCount >= hornetPower)
				{
					hornets.RemoveAt(0);
				}
			}

			PrintWinningSide(beehives, hornets);
		}

		private static long SumHornetsPower(List<long> hornets)
		{
			long sum = 0L;

			foreach (var hornet in hornets)
			{
				sum += hornet;
			}

			return sum;
		}

		private static void PrintWinningSide(long[] beehives, List<long> hornets)
		{
			var aliveBeehives = new List<long>();

			foreach (var beehive in beehives)
			{
				if (beehive > 0)
				{
					aliveBeehives.Add(beehive);
				}
			}

			if (aliveBeehives.Count > 0)
			{
				Console.WriteLine(string.Join(" ", aliveBeehives));
			}
			else
			{
				Console.WriteLine(string.Join(" ", hornets));
			}
		}
	}
}
