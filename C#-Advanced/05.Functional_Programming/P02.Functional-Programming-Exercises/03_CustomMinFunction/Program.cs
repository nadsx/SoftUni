using System;
using System.Linq;

namespace _03_CustomMinFunction
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<int> printNumber = x => Console.WriteLine(x);

			Func<int[], int> minFunction =
				numbers =>
				{
					int minValue = int.MaxValue;

					foreach(var number in numbers)
					{
						if(number < minValue)
						{
							minValue = number;
						}
					}

					return minValue;
				};

			int[] inputNumbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			int minNumber = minFunction(inputNumbers);

			printNumber(minNumber);
		}
	}
}
