using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_FastFood
{
	class Program
	{
		static void Main(string[] args)
		{
			int foodQuantity = int.Parse(Console.ReadLine());
			int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
			Queue<int> queue = new Queue<int>(orders);

			Console.WriteLine(queue.Max());

			int n = queue.Count;

			for (int i = 0; i < n; i++)
			{
				if (foodQuantity - queue.Peek() >= 0)
				{
					foodQuantity -= queue.Dequeue();
				}
				else
				{
					break;
				}
			}

			if (queue.Count == 0)
			{
				Console.WriteLine("Orders complete");
			}
			else
			{
				Console.Write("Orders left: ");
				Console.WriteLine(string.Join(" ", queue));
			}
		}
	}
}
