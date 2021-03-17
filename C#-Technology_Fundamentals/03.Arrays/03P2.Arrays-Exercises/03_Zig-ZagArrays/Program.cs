using System;
using System.Linq;

namespace _03_Zig_ZagArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int[] fromLeftDiagonal = new int[n];
			int[] fromRightDiagonal = new int[n];


			for (int i = 0; i < n; i++)
			{
				int[] currentArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

				if (i % 2 == 0)
				{
					fromLeftDiagonal[i] = currentArray[0];
					fromRightDiagonal[i] = currentArray[1];
				}
				else
				{
					fromLeftDiagonal[i] = currentArray[1];
					fromRightDiagonal[i] = currentArray[0];
				}
			}

			Console.WriteLine(string.Join(" ", fromLeftDiagonal));
			Console.WriteLine(string.Join(" ", fromRightDiagonal));
		}
	}	
}
