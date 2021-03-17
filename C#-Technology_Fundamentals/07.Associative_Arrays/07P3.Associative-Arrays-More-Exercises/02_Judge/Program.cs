using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Judge
{
	class Program
	{
		static void Main(string[] args)
		{
			var contests = new Dictionary<string, Dictionary<string, int>>();
			var participants = new Dictionary<string, Dictionary<string, int>>();

			while (true)
			{
				var participantInfo = Console.ReadLine().Split(" -> ").ToList();

				if (participantInfo[0] == "no more time")
					break;

				string username = participantInfo[0];
				string contest = participantInfo[1];
				int points = int.Parse(participantInfo[2]);

				if (!contests.ContainsKey(contest))
				{
					contests[contest] = new Dictionary<string, int>();
					contests[contest].Add(username, points);
				}
				else if (!contests[contest].ContainsKey(username))
				{
					contests[contest].Add(username, points);
				}
				else if (contests[contest][username] < points)
				{
					contests[contest][username] = points;
				}

				if (!participants.ContainsKey(username))
				{
					participants[username] = new Dictionary<string, int>();
					participants[username].Add(contest, points);
				}
				else if (!participants[username].ContainsKey(contest))
				{
					participants[username].Add(contest, points);
				}
				else if (participants[username][contest] < points)
				{
					participants[username][contest] = points;
				}
			}

			foreach (var contest in contests)
			{
				Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

				int counter = 0;

				foreach (var participant in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
				{
					counter++;
					Console.WriteLine($"{counter}. {participant.Key} <::> {participant.Value}");
				}
			}

			Console.WriteLine("Individual standings:");

			int rank = 0;

			foreach (var participant in participants.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
			{
				rank++;
				Console.WriteLine($"{rank}. {participant.Key} -> {participant.Value.Values.Sum()}");
			}
		}
	}
}
