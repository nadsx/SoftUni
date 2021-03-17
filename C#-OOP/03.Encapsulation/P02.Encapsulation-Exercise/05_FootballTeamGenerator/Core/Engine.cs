namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private readonly Dictionary<string, Team> teams;

        public Engine()
        {
            teams = new Dictionary<string, Team>();
        }

        public void Run()
        {
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (input[0] == "END")
                {
                    break;
                }

                string command = input[0];
                string teamName = input[1];

                if (command != "Team" && !teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist.");
                    continue;
                }

                try
                {
                    switch (command)
                    {
                        case "Team":
                            Team team = new Team(teamName);

                            teams.Add(teamName, team);
                            break;
                        case "Add":
                            string playerName = input[2];
                            int endurance = int.Parse(input[3]);
                            int sprint = int.Parse(input[4]);
                            int dribble = int.Parse(input[5]);
                            int passing = int.Parse(input[6]);
                            int shooting = int.Parse(input[7]);

                            Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                            teams[teamName].AddPlayer(player);
                            break;
                        case "Remove":
                            string playerToRemove = input[2];

                            teams[teamName].RemovePlayer(playerToRemove);
                            break;
                        case "Rating":
                            double rating = teams[teamName].Players.Sum(p => p.GetSkillLevel());

                            Console.WriteLine($"{teamName} - {Math.Round(rating)}");
                            break;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
