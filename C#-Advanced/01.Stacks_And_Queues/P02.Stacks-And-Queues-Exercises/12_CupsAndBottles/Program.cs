using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_CupsAndBottles
{
	class Program
	{
		static void Main(string[] args)
		{
			var firstLine = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
			var secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
			Stack<int> cups = new Stack<int>(firstLine);
			Stack<int> bottles = new Stack<int>(secondLine);
			int wastedWater = 0;

			while (cups.Count != 0 && bottles.Count != 0)
			{
				int currentCup = cups.Pop();
				int currentBottle = bottles.Pop();

				if (currentBottle >= currentCup)
				{
					wastedWater += currentBottle - currentCup;
				}
				else
				{
					currentCup -= currentBottle;
					cups.Push(currentCup);
				}
			}

			Console.WriteLine(cups.Count == 0 ?
				$"Bottles: {string.Join(" ", bottles)}" :
				$"Cups: {string.Join(" ", cups)}");

			Console.WriteLine($"Wasted litters of water: {wastedWater}");
		}
	}
}
