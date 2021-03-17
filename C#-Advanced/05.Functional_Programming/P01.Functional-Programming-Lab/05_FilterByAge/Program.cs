using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_FilterByAge
{
	class Program
	{
		static void Main(string[] args)
		{
			int totalPeople = int.Parse(Console.ReadLine());

			List<Person> people = new List<Person>();

			for (int i = 0; i < totalPeople; i++)
			{
				string[] personInfo = Console.ReadLine()
					.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				Person person = new Person
				{
					Name = personInfo[0],
					Age = int.Parse(personInfo[1])
				};

				people.Add(person);
			}

			string condition = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			// Func<Person(input), bool(output)>
			Func<Person, bool> filterPredicate;

			if (condition == "older")
			{
				filterPredicate = p => p.Age >= age;
			}
			else
			{
				filterPredicate = p => p.Age < age;
			}

			string format = Console.ReadLine();

			Func<Person, string> selectFunc;

			if (format == "name")
			{
				selectFunc = p => $"{p.Name}";
			}
			else if (format == "age")
			{
				selectFunc = p => $"{p.Age}";
			}
			else
			{
				selectFunc = p => $"{p.Name} - {p.Age}";
			}

			people
				.Where(filterPredicate)
				.Select(selectFunc)
				.ToList()
				.ForEach(Console.WriteLine);
		}
	}

	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}
}
	

