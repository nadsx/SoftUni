using System;
using System.Linq;

namespace _04_ReverseArray0fStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arrOfStrings = Console.ReadLine().Split().ToArray();

			for (int i = arrOfStrings.Length - 1; i >= 0; i--)
			{
				Console.Write(arrOfStrings[i] + " ");
			}

			Console.WriteLine();
		}
	}
}
