using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_ArrayRotation
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int rotations = int.Parse(Console.ReadLine());

			for (int i = 0; i < rotations; i++)
			{
				int firstNumber = arr[0];

				for (int j = 0; j < arr.Length - 1; j++) 
				{
					arr[j] = arr[j + 1];

				}

				arr[arr.Length - 1] = firstNumber;
			}
			Console.WriteLine(string.Join(" ", arr));
		}
	}
}
