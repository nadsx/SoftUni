using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_BasicQueueOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			Queue<int> queue = new Queue<int>(numbers);

			//for (int i = 0; i < commands[0]; i++)
			//	queue.Enqueue(numbers[i]);

			int countOfNumbersToDequeueS = commands[1];
			int searchedNumberX = commands[2];

			for (int i = 0; i < countOfNumbersToDequeueS; i++)
			{
				queue.Dequeue();
			}

			if (queue.Contains(searchedNumberX))
			{
				Console.WriteLine("true");
			}
			else if(queue.Count == 0)
			{
				Console.WriteLine(0);
			}
			else
			{
				Console.WriteLine(queue.Min());
			}
		}
	}
}
