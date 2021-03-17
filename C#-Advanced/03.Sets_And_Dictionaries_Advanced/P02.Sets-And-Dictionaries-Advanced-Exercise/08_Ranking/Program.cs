using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Ranking
{
	class Program
	{
		static void Main(string[] args)
		{
			var contests = new Dictionary<string, string>();
			var submissions = new Dictionary<string, Dictionary<string, int>>();

			string input = Console.ReadLine();

			while (input != "end of contests")
			{
				string[] contestInfo = input.Split(':').ToArray();
				string contestName = contestInfo[0];
				string password = contestInfo[1];

				contests.Add(contestName, password);

				input = Console.ReadLine();
			}

			input = Console.ReadLine();

			while (input != "end of submissions")
			{
				string[] submissionInfo = input.Split("=>").ToArray();
				string contestName = submissionInfo[0];
				string contestPass = submissionInfo[1];
				string username = submissionInfo[2];
				int points = int.Parse(submissionInfo[3]);

				if (!contests.ContainsKey(contestName) || contests[contestName] != contestPass)
				{
					input = Console.ReadLine();
					continue;
				}

				if (!submissions.ContainsKey(username))
				{
					submissions.Add(username, new Dictionary<string, int>());
				}

				if (!submissions[username].ContainsKey(contestName))
				{
					submissions[username].Add(contestName, 0);
				}

				if (submissions[username][contestName] < points)
				{
					submissions[username][contestName] = points;
				}

				input = Console.ReadLine();
			}

			KeyValuePair<string, Dictionary<string, int>> bestCandidate = submissions
				.OrderByDescending(v => v.Value.Values.Sum(x => x))
				.FirstOrDefault();

			string bestCandidateName = bestCandidate.Key;
			int topPoints = bestCandidate.Value.Values.Sum(x => x);

			Console.WriteLine($"Best candidate is {bestCandidateName} with total {topPoints} points.");
			Console.WriteLine("Ranking: ");

			foreach (var (key, value) in submissions.OrderBy(x => x.Key))
			{
				Console.WriteLine(key);

				foreach (var (contestName, points) in value.OrderByDescending(x => x.Value))
				{
					Console.WriteLine($"#  {contestName} -> {points}");
				}
			}
		}
	}
}
