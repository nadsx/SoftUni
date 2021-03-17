using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_TeamworkProjects
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfTheTeams = int.Parse(Console.ReadLine());
			List<Team> teams = new List<Team>();

			for (int i = 0; i < countOfTheTeams; i++)
			{
				string[] tokens = Console.ReadLine().Split('-');
				string currentCreatorName = tokens[0];
				string currentTeamName = tokens[1];

				if (teams.Any(t => t.TeamName == currentTeamName))
				{
					Console.WriteLine($"Team {currentTeamName} was already created!");
					continue;
				}

				if (teams.Any(t => t.CreatorName == currentCreatorName))
				{
					Console.WriteLine($"{currentCreatorName} cannot create another team!");
					continue;
				}

				Team team = new Team(currentTeamName, currentCreatorName);
				teams.Add(team);

				Console.WriteLine($"Team {currentTeamName} has been created by {currentCreatorName}!");
			}

			while (true)
			{
				string input = Console.ReadLine();

				if (input == "end of assignment")
				{
					break;
				}

				string[] tokens = input.Split("->");
				string memberName = tokens[0];
				string teamToJoin = tokens[1];

				if (!teams.Any(t => t.TeamName == teamToJoin))
				{
					Console.WriteLine($"Team {teamToJoin} does not exist!");
					continue;
				}

				if (teams.Any(t => t.TeamMembers.Contains(memberName)) ||
					teams.Any(t => t.CreatorName == memberName))
				{
					Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
					continue;
				}

				Team team = teams.First(t => t.TeamName == teamToJoin);
				team.TeamMembers.Add(memberName);
			}

			List<Team> orderedTeams = teams
				.Where(t => t.TeamMembers.Count > 0)
				.OrderByDescending(t => t.TeamMembers.Count)
				.ThenBy(t => t.TeamName)
				.ToList();

			foreach (var team in orderedTeams)
			{
				Console.WriteLine(team.TeamName);
				Console.WriteLine($"- {team.CreatorName}");

				foreach (var member in team.TeamMembers.OrderBy(m => m))
				{
					Console.WriteLine($"-- {member}");
				}
			}

			List<Team> teamsToDisband = teams
			.Where(t => t.TeamMembers.Count == 0)
			.ToList();

			Console.WriteLine("Teams to disband:");

			foreach (var team in teamsToDisband.OrderBy(t => t.TeamName))
			{
				Console.WriteLine(team.TeamName);
			}
		}
	}
	class Team
	{
		public string TeamName { get; set; }
		public string CreatorName { get; set; }
		public List<string> TeamMembers { get; set; }

		public Team(string teamName, string creatorName)
		{
			TeamName = teamName;
			CreatorName = creatorName;
			TeamMembers = new List<string>();
		}
	}
}
	

