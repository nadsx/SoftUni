using System;
using System.Linq;

namespace _01_ActionPoint
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<string[]> printNames = 
				x => Console.WriteLine(string.Join(Environment.NewLine, x));

			string[] inputNames = Console.ReadLine()
			   .Split()
			   .ToArray();

			printNames(inputNames);
		}
	}
}
