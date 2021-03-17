using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MOBAChallenger
{
	class Program
	{
		static void Main(string[] args)
		{
			var players = new Dictionary<string, Dictionary<string, int>>();

			while (true)
			{
				string input = Console.ReadLine();

				if (input == "Season end")
					break;

				if (input.Contains("->"))
				{
					var playerInfo = input.Split(" -> ").ToList();
					string player = playerInfo[0];
					string position = playerInfo[1];
					int skill = int.Parse(playerInfo[2]);

					if (!players.ContainsKey(player))
					{
						players[player] = new Dictionary<string, int>();
					}

					if (!players[player].ContainsKey(position))
					{
						players[player].Add(position, skill);
					}
					else if (players[player][position] < skill)
					{
						players[player][position] = skill;
					}
				}
				else
				{
					var playersList = input.Split(" vs ").ToList();
					string player1 = playersList[0];
					string player2 = playersList[1];

					if (!players.ContainsKey(player1) || !players.ContainsKey(player2))
						continue;

					bool isCommonPosition = false;

					foreach (var position in players[player1].Keys)
					{
						if (players[player2].ContainsKey(position))
						{
							isCommonPosition = true;
						}
					}

					if (isCommonPosition)
					{
						int totalSkills1Player = players[player1].Values.Sum();
						int totalSkills2Player = players[player2].Values.Sum();

						if (totalSkills1Player > totalSkills2Player)
						{
							players.Remove(player2);
						}
						else if (totalSkills2Player > totalSkills1Player)
						{
							players.Remove(player1);
						}
					}
				}
			}

			foreach (var player in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
			{
				Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

				foreach (var valuePair in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
				{
					Console.WriteLine($"- {valuePair.Key} <::> {valuePair.Value}");
				}
			}
		}
	}
}
