using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_SoftUniExamResults
{
	class Program
	{
		static void Main(string[] args)
		{
			var studentsAndPoints = new SortedDictionary<string, int>();
			var submissions = new SortedDictionary<string, int>();

			string input = Console.ReadLine();

			while(input != "exam finished")
			{
				string[] tokens = input.Split("-");
				string name = tokens[0];

				if(tokens[1] == "banned")
				{
					studentsAndPoints.Remove(name);
				}
				else
				{
					string programmingLanguage = tokens[1];
					int points = int.Parse(tokens[2]);

					if (!studentsAndPoints.ContainsKey(name))
					{
						studentsAndPoints[name] = points;
					}
					else if (points > studentsAndPoints[name])
					{
						studentsAndPoints[name] = points;
					}

					if (!submissions.ContainsKey(programmingLanguage))
					{
						submissions[programmingLanguage] = 0;
					}

					submissions[programmingLanguage]++;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine("Results:");

			foreach(var kvp in studentsAndPoints.OrderByDescending(x => x.Value))
			{
				Console.WriteLine($"{kvp.Key} | {kvp.Value}");
			}

			Console.WriteLine("Submissions:");

			foreach(var kvp in submissions.OrderByDescending(x => x.Value))
			{
				Console.WriteLine($"{kvp.Key} - {kvp.Value}");
			}
		}
	}
}
