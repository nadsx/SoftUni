using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] args = Console.ReadLine()
                    .Split()
                    .ToArray();

                Person person = new Person(args[0], args[1], int.Parse(args[2]), decimal.Parse(args[3]));

                persons.Add(person);
            }

            decimal percentage = decimal.Parse(Console.ReadLine());

            persons.ForEach(p => p.IncreaseSalary(percentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
