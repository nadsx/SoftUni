using System;
using System.Linq;

namespace _02_KnightsOfHonor
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<string[]> printNames =
				x => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", x));

			string[] inputNames = Console.ReadLine()
			   .Split()
			   .ToArray();

			printNames(inputNames);
		}
	}
}
