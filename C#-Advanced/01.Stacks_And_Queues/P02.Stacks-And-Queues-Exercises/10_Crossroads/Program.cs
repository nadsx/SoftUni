using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_Crossroads
{
	class Program
	{
		static void Main(string[] args)
		{
			int greenLight = int.Parse(Console.ReadLine());
			int yellowLight = int.Parse(Console.ReadLine());
			Queue<string> queue = new Queue<string>();
			int passedCars = 0;

			string input = Console.ReadLine();

			while (input != "END")
			{
				if (input != "green")
				{
					queue.Enqueue(input);
				}
				else
				{
					int remainingSeconds = greenLight;

					while (remainingSeconds > 0 && queue.Count > 0)
					{
						string currentCar = queue.Peek();

						if (currentCar.Length <= remainingSeconds)
						{
							remainingSeconds -= queue.Dequeue().Length;
						}
						else if (currentCar.Length <= remainingSeconds + yellowLight)
						{
							queue.Dequeue();
							remainingSeconds = 0;
						}
						else
						{
							string crashedCar = queue.Dequeue();
							char hitChar = crashedCar[remainingSeconds + yellowLight];

							Console.WriteLine("A crash happened!");
							Console.WriteLine($"{crashedCar} was hit at {hitChar}.");
							return;
						}

						passedCars++;
					}
				}

				input = Console.ReadLine();
			}

			Console.WriteLine("Everyone is safe.");
			Console.WriteLine($"{passedCars} total cars passed the crossroads.");
		}
	}
}
