using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_DragonArmy
{
	class Program
	{
		static void Main(string[] args)
		{
			var dragonsTypeNameStats = new Dictionary<string, SortedDictionary<string, List<int>>>();

			GetDragonsInfo(dragonsTypeNameStats);
			PrintDragonInfo(dragonsTypeNameStats);
		}

		private static void PrintDragonInfo(Dictionary<string, SortedDictionary<string, List<int>>> dragonsTypeNameStats)
		{
			foreach (var dragonType in dragonsTypeNameStats)
			{
				Console.WriteLine($"{dragonType.Key}::({GetDragonTypeAverageStats(dragonType.Value)})");

				Console.WriteLine(string.Join("\n", dragonType.Value
					.Select(x => $"-{x.Key} -> damage: {x.Value[0]}, health: {x.Value[1]}, armor: {x.Value[2]}")));
			}
		}

		private static object GetDragonTypeAverageStats(SortedDictionary<string, List<int>> dragonNames)
		{
			var damageList = new List<int>();
			var healthList = new List<int>();
			var armorList = new List<int>();

			foreach (var name in dragonNames)
			{
				damageList.Add(name.Value[0]);
				healthList.Add(name.Value[1]);
				armorList.Add(name.Value[2]);
			}

			return $"{damageList.Average():f2}/{healthList.Average():f2}/{armorList.Average():f2}";
		}

		private static void GetDragonsInfo(Dictionary<string, SortedDictionary<string, List<int>>> dragonsTypeNameStats)
		{
			var dragonsCount = int.Parse(Console.ReadLine());

			for (int i = 0; i < dragonsCount; i++)
			{
				var dragonInfo = Console.ReadLine().Split().ToList();
				string dragonType = dragonInfo[0];
				string name = dragonInfo[1];
				int damage = int.TryParse(dragonInfo[2], out damage) ? damage : 45;
				int health = int.TryParse(dragonInfo[3], out health) ? health : 250;
				int armor = int.TryParse(dragonInfo[4], out armor) ? armor : 10;

				if (!dragonsTypeNameStats.ContainsKey(dragonType))
				{
					dragonsTypeNameStats[dragonType] = new SortedDictionary<string, List<int>>();
				}

				if (!dragonsTypeNameStats[dragonType].ContainsKey(name))
				{
					dragonsTypeNameStats[dragonType][name] = new List<int>();
				}
				else
				{
					dragonsTypeNameStats[dragonType][name].Clear();
				}

				dragonsTypeNameStats[dragonType][name].Add(damage);
				dragonsTypeNameStats[dragonType][name].Add(health);
				dragonsTypeNameStats[dragonType][name].Add(armor);
			}
		}
	}
}
