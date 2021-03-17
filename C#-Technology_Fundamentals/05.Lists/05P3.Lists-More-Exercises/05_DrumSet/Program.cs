using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_DrumSet
{
	class Program
	{
		static void Main(string[] args)
		{
			double savings = double.Parse(Console.ReadLine());
			List<int> drumsList = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> copyDrumsList = drumsList.GetRange(0, drumsList.Count);

			string input = Console.ReadLine();

			while (input != "Hit it again, Gabsy!")
			{
				int hitPower = int.Parse(input);

				for (int i = 0; i < drumsList.Count; i++)
				{
					drumsList[i] -= hitPower;
				}

				if (drumsList.Exists(x => x <= 0))
				{
					for (int i = 0; i < drumsList.Count; i++)
					{
						if (drumsList[i] <= 0)
						{
							int price = copyDrumsList[i] * 3;

							if (price > savings)
							{
								drumsList.RemoveAt(i);
								copyDrumsList.RemoveAt(i);
							}
							else
							{
								savings -= price;
								drumsList[i] = copyDrumsList[i];
							}
						}
					}
				}

				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", drumsList));
			Console.WriteLine($"Gabsy has {savings:f2}lv.");
		}
	}
}
