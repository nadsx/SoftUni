using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class Engine
    {
        private List<Person> people;

        public Engine()
        {
            this.people = new List<Person>();
        }

        public void Run()
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] args = Console.ReadLine()
                    .Split()
                    .ToArray();

                try
                {
                    Person person = new Person(args[0], args[1], int.Parse(args[2]), decimal.Parse(args[3]));
                    people.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Team team = new Team("SoftUni");

            foreach (Person person in people)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
