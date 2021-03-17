using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Ranking
{
	class Program
	{
		static void Main(string[] args)
		{
			var contestsAndPasswords = new Dictionary<string, string>();

			string input = Console.ReadLine();

			while (input != "end of contests")
			{
				var contestInfo = input.Split(":").ToList();
				string contestName = contestInfo[0];
				string contestPassword = contestInfo[1];

				contestsAndPasswords[contestName] = contestPassword;

				input = Console.ReadLine();
			}

			var students = new Dictionary<string, Dictionary<string, int>>();

			input = Console.ReadLine();

			while (input != "end of submissions")
			{
				var submission = input.Split("=>").ToList();
				string contest = submission[0];
				string password = submission[1];
				string candidate = submission[2];
				int points = int.Parse(submission[3]);

				if (contestsAndPasswords.ContainsKey(contest) &&
					contestsAndPasswords[contest] == password)
				{
					if (!students.ContainsKey(candidate))
					{
						students[candidate] = new Dictionary<string, int>();
						students[candidate].Add(contest, points);
					}
					else
					{
						if (!students[candidate].ContainsKey(contest))
						{
							students[candidate].Add(contest, points);
						}
						else if (students[candidate][contest] < points)
						{
							students[candidate][contest] = points;
						}
					}
				}

				input = Console.ReadLine();
			}

			KeyValuePair<string, Dictionary<string, int>> bestCandidate = students.OrderByDescending(x => x.Value.Values.Sum()).First();

			Console.WriteLine($"Best candidate is {bestCandidate.Key} with total " +
				$"{bestCandidate.Value.Values.Sum()} points.");

			Console.WriteLine("Ranking:");

			var sortedStudents = students.OrderBy(x => x.Key);

			foreach (KeyValuePair<string, Dictionary<string, int>> student in sortedStudents)
			{
				Console.WriteLine(student.Key);

				var valuePair = student.Value.OrderByDescending(x => x.Value);

				foreach (var contest in valuePair)
				{
					Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
				}
			}
		}
	}
}
