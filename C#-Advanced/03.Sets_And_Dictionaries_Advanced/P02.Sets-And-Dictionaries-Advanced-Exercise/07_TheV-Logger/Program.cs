using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_TheV_Logger
{
	class Program
	{
		static void Main(string[] args)
		{
			var vloggersCollection = new Dictionary<string, Dictionary<string, HashSet<string>>>();

			string input = Console.ReadLine();

			while (input != "Statistics")
			{
				if (input.Contains("joined"))
				{
					string username = input.Split()[0];

					if (!vloggersCollection.ContainsKey(username))
					{
						vloggersCollection.Add(username, new Dictionary<string, HashSet<string>>());
						vloggersCollection[username].Add("followers", new HashSet<string>());
						vloggersCollection[username].Add("following", new HashSet<string>());
					}
				}
				else if (input.Contains("followed"))
				{
					string[] usernames = input.Split().ToArray();
					string firstVlogger = usernames[0];
					string secondVlogger = usernames[2];

					if (!vloggersCollection.ContainsKey(firstVlogger) ||
						!vloggersCollection.ContainsKey(secondVlogger) ||
						firstVlogger == secondVlogger)
					{
						input = Console.ReadLine();
						continue;
					}

					vloggersCollection[firstVlogger]["following"].Add(secondVlogger);
					vloggersCollection[secondVlogger]["followers"].Add(firstVlogger);
				}

				input = Console.ReadLine();
			}

			Console.WriteLine($"The V-Logger has a total of {vloggersCollection.Count} vloggers in its logs.");

			int count = 1;

			var sortedVloggers = vloggersCollection
				.OrderByDescending(x => x.Value["followers"].Count)
				.ThenBy(x => x.Value["following"].Count)
				.ToDictionary(k => k.Key, v => v.Value);

			foreach (var vloger in sortedVloggers)
			{
				int followersCount = sortedVloggers[vloger.Key]["followers"].Count;
				int followingCount = sortedVloggers[vloger.Key]["following"].Count;

				Console.WriteLine($"{count}. {vloger.Key} : {followersCount} followers, {followingCount} following");

				if (count == 1)
				{
					List<string> followersCollection = vloger.Value["followers"].OrderBy(x => x).ToList();

					foreach (var follower in followersCollection)
					{
						Console.WriteLine($"*  {follower}");
					}
				}

				count++;
			}
		}
	}
}
