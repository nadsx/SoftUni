using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_CompanyUsers
{
	class Program
	{
		static void Main(string[] args)
		{
			var companies = new Dictionary<string, List<string>>();

			while (true)
			{
				string[] tokens = Console.ReadLine().Split(" -> ").ToArray();

				if (tokens[0] == "End")
					break;

				string currentCompany = tokens[0];
				string currentEmployee = tokens[1];

				if (!companies.ContainsKey(currentCompany))
				{
					companies[currentCompany] = new List<string>();
				}

				if (!companies[currentCompany].Contains(currentEmployee))
				{
					companies[currentCompany].Add(currentEmployee);
				}
			}

			companies = companies
				.OrderBy(x => x.Key)
				.ToDictionary(k => k.Key, v => v.Value);

			foreach(var kvp in companies)
			{
				Console.WriteLine(kvp.Key);

				Console.WriteLine(string.Join("\n", kvp.Value.Select(x => $"-- {x}")));
			}
		}
	}
}
